
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Globalization;

namespace Business.CustomExtensions
{
    public static class BusinessExtensions
    {

        public static void AddBusinessModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new List<CultureInfo> {
                new CultureInfo ("tr-TR"),
                new CultureInfo ("en-US")
                };
                options.DefaultRequestCulture = new RequestCulture("tr-TR");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });

            services.Scan(x => x.FromCallingAssembly()
                        .AddClasses(s => s.Where(t => t.Name.EndsWith("Manager")))
                        .AsImplementedInterfaces());
        }
    }
}
