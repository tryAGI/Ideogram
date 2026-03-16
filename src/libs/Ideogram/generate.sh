dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.ideogram.ai/openapi.json
autosdk generate openapi.yaml \
  --namespace Ideogram \
  --clientClassName IdeogramClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://api.ideogram.ai \
  --security-scheme Http:Header:Bearer
