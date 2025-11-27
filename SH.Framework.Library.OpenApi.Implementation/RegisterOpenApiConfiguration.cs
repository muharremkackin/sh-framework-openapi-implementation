using Microsoft.Extensions.DependencyInjection;

namespace SH.Framework.Library.OpenApi.Implementation;

public static class RegisterOpenApiConfiguration
{
    public static IServiceCollection AddOpenApiConfiguration(this IServiceCollection services) {
        services.AddOpenApi(options =>
        {
            options.CreateSchemaReferenceId = context =>
            {
                return OpenApiExtensions.CreateFriendlyId(context.Type);
            };
        });

        return services;
    }
}
