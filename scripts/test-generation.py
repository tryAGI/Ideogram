#!/usr/bin/env python3
"""Offline generation contract tests; no provider or tool installation."""
import json
import os
from pathlib import Path
import shutil
import subprocess
import tempfile
import unittest

SCRIPT = Path(__file__).resolve().parents[1] / 'src/libs/Ideogram/generate.sh'


def spec(paths):
    return {'openapi': '3.0.0', 'paths': paths, 'components': {'schemas': {'Example': {'type': 'string'}}}}


class GenerationTests(unittest.TestCase):
    def run_fixture(self, upstream, pinned=False):
        with tempfile.TemporaryDirectory() as directory:
            root = Path(directory)
            shutil.copy(SCRIPT, root / 'generate.sh')
            legacy = spec({'/legacy': {'post': {'tags': ['Generate']}}})
            current = spec({'/v2/image': {'post': {'tags': ['Images']}, 'get': {'tags': ['Images']}}})
            for name, value in [('openapi.json', legacy), ('openapi-v2.json', current)]:
                (root / name).write_text(json.dumps(value))
            (root / 'incoming').write_text(json.dumps(upstream) if isinstance(upstream, dict) else upstream)
            (root / 'Generated').mkdir()
            (root / 'Generated/sentinel').write_text('preserve on failure')
            bin_dir = root / 'bin'
            bin_dir.mkdir()
            (bin_dir / 'curl').write_text('#!/bin/sh\ncat "$FIXTURE/incoming"\n')
            (bin_dir / 'autosdk').write_text('''#!/usr/bin/env python3
import json, os, pathlib, sys
root = pathlib.Path(os.environ['FIXTURE'])
with (root / 'calls.jsonl').open('a') as output:
    output.write(json.dumps({'args': sys.argv[1:], 'spec': json.loads(pathlib.Path(sys.argv[2]).read_text())}) + '\\n')
''')
            for file in bin_dir.iterdir():
                file.chmod(0o755)
            result = subprocess.run(['bash', 'generate.sh', '--skip-tool-install'] + (['--pinned-spec'] if pinned else []), cwd=root, env={**os.environ, 'PATH': str(bin_dir) + os.pathsep + os.environ['PATH'], 'FIXTURE': str(root)}, capture_output=True, text=True)
            calls = [json.loads(line) for line in (root / 'calls.jsonl').read_text().splitlines()] if (root / 'calls.jsonl').exists() else []
            return result, json.loads((root / 'openapi.json').read_text()), json.loads((root / 'openapi-v2.json').read_text()), calls, (root / 'Generated/sentinel').exists(), legacy, current

    def test_additive_v2_keeps_v1_and_only_normalizes_operation_tags(self):
        incoming = spec({'/v2/image': {'post': {'tags': ['Images']}, 'get': {'tags': ['Images']}}, '/v2/new': {'post': {'tags': ['Other'], 'summary': 'New'}}})
        result, legacy, current, calls, _, original, _ = self.run_fixture(incoming)
        self.assertEqual(result.returncode, 0, result.stderr)
        self.assertEqual(legacy, original)
        self.assertEqual(current, incoming)
        self.assertEqual(len(calls), 2)
        self.assertEqual(calls[0]['spec'], original)
        expected = json.loads(json.dumps(incoming))
        for path in expected['paths'].values():
            for operation in path.values():
                operation.pop('tags', None)
        self.assertEqual(calls[1]['spec'], expected)
        self.assertIn('Ideogram.V2', calls[1]['args'])
        self.assertIn('IdeogramV2SourceGenerationContext', calls[1]['args'])
        self.assertIn('ApiKey:Header:Api-Key', calls[1]['args'])

    def test_removed_method_keeps_pinned_v2(self):
        result, _, current, calls, _, _, original = self.run_fixture(spec({'/v2/image': {'post': {}}}))
        self.assertEqual(result.returncode, 0, result.stderr)
        self.assertIn('GET /v2/image', result.stderr)
        self.assertEqual(current, original)
        self.assertEqual(len(calls), 2)

    def test_invalid_download_preserves_generated_output(self):
        for incoming in ['not json', spec({})]:
            with self.subTest(incoming=incoming):
                result, _, _, calls, sentinel, _, _ = self.run_fixture(incoming)
                self.assertNotEqual(result.returncode, 0)
                self.assertTrue(sentinel)
                self.assertEqual(calls, [])

    def test_pinned_mode_does_not_fetch(self):
        result, _, current, calls, _, _, original = self.run_fixture('invalid download', pinned=True)
        self.assertEqual(result.returncode, 0, result.stderr)
        self.assertEqual(current, original)
        self.assertEqual(len(calls), 2)


if __name__ == '__main__':
    unittest.main()
