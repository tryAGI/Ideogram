dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Ideogram \
  IdeogramApi \
  https://api.ideogram.ai/openapi.json \
  tryAGI \
  --output .
