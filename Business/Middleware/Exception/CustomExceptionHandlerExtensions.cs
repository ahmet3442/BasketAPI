using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Middleware.Exception
{
    public static class CustomExceptionHandlerExtensions
    {
        public static IApplicationBuilder UseCustomException(this IApplicationBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentException(nameof(app));
            }
            return app.UseMiddleware<CustomErrorPagesMiddleware>();
        }
    }
}
