dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.ideogram.ai/openapi.json
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
 echo "Failed, exiting..."
 exit 1
fi
autosdk generate openapi.yaml \
  --namespace Ideogram \
  --clientClassName IdeogramApi \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations