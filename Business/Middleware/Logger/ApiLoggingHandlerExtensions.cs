using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Middleware.Logger
{
    public static class ApiLoggingHandlerExtensions
    {

        public static IApplicationBuilder UseWebAPILogger(this IApplicationBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentException(nameof(app));
            }
            return app.UseMiddleware<ApiLoggingMiddleware>();
        }
    }
}
