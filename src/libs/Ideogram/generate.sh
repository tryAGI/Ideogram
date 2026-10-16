#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://api.ideogram.ai/openapi.json
install_autosdk_cli
temp_spec="$(mktemp)"
old_operations="$(mktemp)"
new_operations="$(mktemp)"
trap 'rm -f "$temp_spec" "$old_operations" "$new_operations"' EXIT
fetch_spec --fail --silent --show-error -L https://api.ideogram.ai/openapi.json | jq . > "$temp_spec"
# Reject malformed downloads before touching either the pinned spec or generated SDK.
jq -e '.paths | type == "object" and length > 0' "$temp_spec" > /dev/null

list_operations() {
  jq -r '.paths | to_entries[] | .key as $path | .value | keys[] |
    select(. == "get" or . == "post" or . == "put" or . == "patch" or
      . == "delete" or . == "head" or . == "options" or . == "trace") |
    "\(. | ascii_upcase) \($path)"' "$1" | LC_ALL=C sort
}

# The upstream v2 document omits legacy public image APIs. Keep the last complete
# contract until those removals have been reviewed as an intentional SDK migration.
if [[ -f openapi.json ]]; then
  list_operations openapi.json > "$old_operations"
  list_operations "$temp_spec" > "$new_operations"
  removed_operations="$(comm -23 "$old_operations" "$new_operations")"
  if [[ -n "$removed_operations" ]]; then
    printf 'Warning: upstream Ideogram spec removed operations; reusing checked-in spec:\n%s\n' "$removed_operations" >&2
  else
    mv "$temp_spec" openapi.json
  fi
else
  mv "$temp_spec" openapi.json
fi
rm -rf Generated
autosdk generate openapi.json \
  --namespace Ideogram \
  --clientClassName IdeogramClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://api.ideogram.ai \
  --security-scheme Http:Header:Bearer
