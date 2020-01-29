using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using PRAXYS.Client.Auth;
using PRAXYS.Client.Services;

namespace PRAXYS.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IService, ApiServices>();
            services.AddBlazorContextMenu();
            services.AddAuthorizationCore();

            services.AddScoped<AuthenticationJWTProvider>();

            services.AddScoped<AuthenticationStateProvider, AuthenticationJWTProvider>(
                provider => provider.GetRequiredService<AuthenticationJWTProvider>());
            
            services.AddScoped<ILoginService, AuthenticationJWTProvider>(
                provider => provider.GetRequiredService<AuthenticationJWTProvider>());
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
