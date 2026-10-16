# Ideogram v2 migration

The package contains both API generations. The provider says that [v1 keeps working](https://developer.ideogram.ai/ideogram-api/api-overview); migration does not require removing the legacy client.

| Contract | Client | Specification | Operation layout |
| --- | --- | --- | --- |
| Existing v1 | `Ideogram.IdeogramClient` | `src/libs/Ideogram/openapi.json` | Existing tagged clients, unchanged |
| Current v2 | `Ideogram.V2.IdeogramV2Client` | `src/libs/Ideogram/openapi-v2.json` | Flat methods on the v2 client |

The v1 generated files remain byte-for-byte unchanged. The new namespace also separates request, response, enum and serializer context types. Existing constructors and `AuthorizeUsingBearer` calls remain source-compatible. A handwritten request hook translates the legacy bearer credential into the documented `Api-Key` header; an explicitly configured `Api-Key` takes precedence. The v2 client generates this header directly. See the [provider authentication documentation](https://developer.ideogram.ai/ideogram-api/api-overview).

## Updating callers

Use `using Ideogram.V2;` and construct `IdeogramV2Client(apiKey)`. Select the model-specific method, such as `CreateImageGenerateIdeogram45Async(prompt: "A sunset")`. V2 image operations send multipart form data. Supply binary upload bytes with a filename on the corresponding request type. The SDK derives the file media type from that filename.

V2 has model-specific paths under `/v2/{content}/{action}/{model}`. Request shapes are not interchangeable with v1: for example, v1 `text_prompt` becomes v2 `prompt` where applicable. Review the model-specific request rather than copying legacy JSON unchanged.

With `async: true`, retain `GenerationId` and poll `GetGenerationsByGenerationIdAsync`. Pending and failed generations may omit `Data`; inspect `Status` and `FailureReason` before accessing images. The client does not add an automatic polling loop or retry generation requests. Choose bounded polling and cancellation for your application. Generation and polling use the provider account; the repository's offline tests do not contact the provider.

The upstream specification describes `dry_run` but does not declare its price-quote response schema. Do not treat the ordinary typed generation response as a validated price quote. No live or paid-endpoint validation is claimed here.

## Reproducible generation

From `src/libs/Ideogram`, run `./generate.sh` to refresh v2 and regenerate both clients. V1 stays pinned. Removed v2 HTTP operations keep the checked-in v2 specification and produce a warning for review. Invalid inputs fail before deleting generated output.

Use `./generate.sh --pinned-spec --skip-tool-install` to reproduce from the checked-in specifications with the already-installed AutoSDK version. The v2 input is downloaded from the [official OpenAPI endpoint](https://api.ideogram.ai/openapi.json). Generation removes only operation tags from a temporary copy, giving v2 a flat client and a distinct serializer context without changing paths, schemas or wire fields. This avoids collisions between tag-specific serializer contexts from two API generations in one assembly.

The offline contract tests cover legacy credential replacement and explicit headers, v2 form fields, binary upload filename/media type, and pending/failed asynchronous responses. The generator fixture tests cover version preservation, operation-removal guards and invalid input safety.
