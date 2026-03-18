# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Ideogram](https://ideogram.ai/) AI image generation platform, auto-generated from the Ideogram OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Ideogram.slnx

# Build for release (also produces NuGet package)
dotnet build Ideogram.slnx -c Release

# Run integration tests (requires IDEOGRAM_API_KEY env var)
dotnet test src/tests/IntegrationTests/Ideogram.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Ideogram && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** — do not manually edit files in `src/libs/Ideogram/Generated/`.

1. `src/libs/Ideogram/openapi.yaml` — the Ideogram OpenAPI spec (fetched from `https://api.ideogram.ai/openapi.json`)
2. `src/helpers/FixOpenApiSpec/` — converts OpenAPI 3.1 → 3.0 format for compatibility
3. `src/libs/Ideogram/generate.sh` — orchestrates: download spec → fix spec → run AutoSDK CLI → output to `Generated/`
4. CI auto-updates the spec every 3 hours and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Ideogram/` | Main SDK library (`IdeogramClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Ideogram API |
| `src/helpers/FixOpenApiSpec/` | OpenAPI spec fixer tool |
| `src/helpers/GenerateDocs/` | Documentation generator from integration tests |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# 13 preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
