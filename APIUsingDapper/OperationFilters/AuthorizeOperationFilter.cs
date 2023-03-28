﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace APIUsingDapper.OperationFilters
{
    public class AuthorizeOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (context.MethodInfo.GetCustomAttributes().OfType<AuthorizeAttribute>().Any() || context.MethodInfo.DeclaringType != null && context.MethodInfo.DeclaringType.GetCustomAttributes().OfType<AuthorizeAttribute>().Any())
            {
                operation.Responses.Add(StatusCodes.Status401Unauthorized.ToString(), new OpenApiResponse { Description = "Unauthorize" });
                operation.Responses.Add(StatusCodes.Status403Forbidden.ToString(), new OpenApiResponse { Description = "Forbidden" });
                operation.Security = new List<OpenApiSecurityRequirement>
                {
                    new OpenApiSecurityRequirement
                    {
                        {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id="auth2"
                            }
                        },
                        new List<string>
                        {
                            "api"
                        }
                        }
                    }
                };
            }
        }
    }
}
