using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace UserApi
{
    public static class SwaggerExtensions
    {
        public static SwaggerGenOptions AddUserSwaggerGen(this SwaggerGenOptions options)
        {
            options.SwaggerDoc("users", new OpenApiInfo { Title = "users" });
            options.CustomSchemaIds(type => type.FullName);

            return options;
        }
        public static SwaggerUIOptions UseUserSwaggerEndpoints(this SwaggerUIOptions uiOptions)
        {
            uiOptions.SwaggerEndpoint("/swagger/users/swagger.json", "users");
            return uiOptions;
        }
    }
}
