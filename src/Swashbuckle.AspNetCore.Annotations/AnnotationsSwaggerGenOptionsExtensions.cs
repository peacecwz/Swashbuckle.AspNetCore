﻿using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.Annotations;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AnnotationsSwaggerGenOptionsExtensions
    {
        public static void EnableAnnotations(this SwaggerGenOptions options)
        {
            options.SchemaFilter<SwaggerSchemaAttributeFilter>();
            options.OperationFilter<SwaggerResponseAttributeFilter>();
            options.OperationFilter<SwaggerOperationAttributeFilter>();
        }
    }
}