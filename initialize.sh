dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Ideogram \
  IdeogramClient \
  https://api.ideogram.ai/openapi.json \
  tryAGI \
  --output .
