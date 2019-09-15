﻿using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace RMP_DataManager.App_Start
{
    public class AuthTokenOperation : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, IApiExplorer apiExplorer)
        {
            swaggerDoc.paths.Add("/token", new PathItem
            {
                post = new Operation
                {
                    tags = new List<string> { "Auth" },
                    consumes = new List<string>
                    {
                        "application/x-www-form-urlencoded"
                    },
                    parameters = new List<Parameter>
                    {
                        new Parameter
                        {
                            type     = "string",
                            name     = "grant_type",
                            @in      = "formData",
                            @default = "password",

                            required = true
                        },
                        new Parameter
                        {
                            type     = "string",
                            name     = "username",
                            @in      = "formData",

                            required = false
                        },
                        new Parameter
                        {
                            type     = "string",
                            name     = "password",
                            @in      = "formData",

                            required = false
                        }
                    }
                }
            });
        }
    }
}