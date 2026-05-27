using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi;

namespace Assignment.Api.OpenApi;

public sealed class OpenApiDocumentTransformer : IOpenApiDocumentTransformer
{
    public Task TransformAsync(OpenApiDocument document, OpenApiDocumentTransformerContext context, CancellationToken cancellationToken)
    {
        document.Components ??= new OpenApiComponents();

        document.Info.Description = """
        ## Introduction

        The Assignment API provides endpoints for handling various assignments.

        """;

        return Task.CompletedTask;
    }
}
