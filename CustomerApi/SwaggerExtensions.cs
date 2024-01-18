using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace CustomerApi
{
    public static class SwaggerExtensions
    {
        public static SwaggerGenOptions AddCustomerSwaggerGen(this SwaggerGenOptions options)
        {
            options.SwaggerDoc("customers", new OpenApiInfo { Title = "customers" });

            options.CustomSchemaIds(type => type.FullName);

            return options;
        }

        public static SwaggerUIOptions UseCustomerSwaggerEndpoints(this SwaggerUIOptions uiOptions)
        {
            uiOptions.SwaggerEndpoint("/swagger/customers/swagger.json", "customers");

            return uiOptions;
        }
    }
}
