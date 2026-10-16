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

# v1 stays pinned: the default upstream document now contains v2 only.
# See MIGRATION.md for the provider's explicit v1 compatibility guarantee.
pinned_spec=false
skip_tool_install=false
for arg in "$@"; do
  case "$arg" in
    --pinned-spec) pinned_spec=true ;;
    --skip-tool-install) skip_tool_install=true ;;
    *) printf 'Unknown argument: %s\n' "$arg" >&2; exit 1 ;;
  esac
done
if [[ "$skip_tool_install" == false ]]; then
  install_autosdk_cli
fi

temp_spec="$(mktemp)"
old_operations="$(mktemp)"
new_operations="$(mktemp)"
trap 'rm -f "$temp_spec" "$old_operations" "$new_operations"' EXIT
list_operations() {
  jq -r '.paths | to_entries[] | .key as $path | .value | keys[] |
    select(. == "get" or . == "post" or . == "put" or . == "patch" or
      . == "delete" or . == "head" or . == "options" or . == "trace") |
    "\(. | ascii_upcase) \($path)"' "$1" | LC_ALL=C sort
}

# Refresh only v2. Never replace the legacy contract with a version-filtered spec.
if [[ "$pinned_spec" == false ]]; then
  fetch_spec -L https://api.ideogram.ai/openapi.json | jq . > "$temp_spec"
  jq -e '.paths | type == "object" and length > 0' "$temp_spec" > /dev/null
  if [[ -f openapi-v2.json ]]; then
    list_operations openapi-v2.json > "$old_operations"
    list_operations "$temp_spec" > "$new_operations"
    removed_operations="$(comm -23 "$old_operations" "$new_operations")"
    if [[ -n "$removed_operations" ]]; then
      printf 'Warning: upstream Ideogram v2 spec removed operations; reusing checked-in v2 spec:\n%s\n' "$removed_operations" >&2
    else
      mv "$temp_spec" openapi-v2.json
    fi
  else
    mv "$temp_spec" openapi-v2.json
  fi
fi

# Validate both inputs before deleting any generated output.
jq -e '.paths | type == "object" and length > 0' openapi.json > /dev/null
jq -e '.paths | type == "object" and length > 0' openapi-v2.json > /dev/null
rm -rf Generated
autosdk generate openapi.json \
  --namespace Ideogram \
  --clientClassName IdeogramClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://api.ideogram.ai \
  --security-scheme Http:Header:Bearer

autosdk generate openapi-v2.json \
  --namespace Ideogram.V2 \
  --group-by-tags false \
  --json-serializer-context IdeogramV2SourceGenerationContext \
  --clientClassName IdeogramV2Client \
  --targetFramework net10.0 \
  --output Generated/V2 \
  --exclude-deprecated-operations \
  --base-url https://api.ideogram.ai \
  --methodNamingConvention MethodAndPath \
  --security-scheme ApiKey:Header:Api-Key
