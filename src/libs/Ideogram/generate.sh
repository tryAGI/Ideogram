#!/usr/bin/env bash
set -euo pipefail
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error https://api.ideogram.ai/openapi.json | jq . > openapi.json
autosdk generate openapi.json \
  --namespace Ideogram \
  --clientClassName IdeogramClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://api.ideogram.ai \
  --security-scheme Http:Header:Bearer
