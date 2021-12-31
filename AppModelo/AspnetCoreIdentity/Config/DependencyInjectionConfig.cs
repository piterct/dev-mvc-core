using AspnetCoreIdentity.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace AspnetCoreIdentity.Config
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IAuthorizationHandler, PermissaoNecessariaHandler>();

            return services;
        }
    }
}
