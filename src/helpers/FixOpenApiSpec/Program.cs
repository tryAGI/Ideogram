using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

yamlOrJson = yamlOrJson
        .Replace("  v1beta", "  ")
        .Replace("#/definitions/v1beta", "#/definitions/")
        .Replace("MgmtPublicService_", string.Empty)
        .Replace("mgmtv1beta", string.Empty)
        .Replace("  v1alpha", "  ")
        .Replace("#/definitions/v1alpha", "#/definitions/")
        .Replace("  ArtifactPublicService", "  ")
        .Replace("#/definitions/ArtifactPublicService", "#/definitions/")
        .Replace("ArtifactPublicService_", string.Empty)
        .Replace("artifactv1alpha", string.Empty)

        // Fixing the Task schema because it conflicts with the Task class in C#
        .Replace("#/definitions/Task", "#/definitions/AITask")
        .Replace("  Task:", "  AITask:")

        // Fixing the Object schema because it conflicts with the Object class in C#
        .Replace("'#/definitions/Object'", "'#/definitions/AIObject'")
        .Replace("  Object:", "  AIObject:")
    ;

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);

var schemas = openApiDocument.Components?.Schemas;
var securitySchemes = openApiDocument.Components?.SecuritySchemes;

if (securitySchemes?.ContainsKey("Bearer") == true)
{
    ((OpenApiSecurityScheme)securitySchemes["Bearer"]!).Type = SecuritySchemeType.Http;
    ((OpenApiSecurityScheme)securitySchemes["Bearer"]!).Scheme = "bearer";
}

if (schemas?.ContainsKey("CreateCatalogResponse") == true)
    ((OpenApiSchema)schemas["CreateCatalogResponse"]!).Required!.Add("catalog");

if (schemas?.ContainsKey("UploadCatalogFileResponse") == true)
    ((OpenApiSchema)schemas["UploadCatalogFileResponse"]!).Required!.Add("file");

if (schemas?.ContainsKey("File") == true)
    ((OpenApiSchema)schemas["File"]!).Required!.Add("fileUid");

if (schemas?.ContainsKey("ProcessCatalogFilesResponse") == true)
    ((OpenApiSchema)schemas["ProcessCatalogFilesResponse"]!).Required!.Add("files");

if (schemas?.ContainsKey("ListCatalogFilesResponse") == true)
    ((OpenApiSchema)schemas["ListCatalogFilesResponse"]!).Required!.Add("files");

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
