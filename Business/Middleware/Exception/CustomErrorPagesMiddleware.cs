using Microsoft.AspNetCore.Http;
using Core.Common;
using System;
using System.Threading.Tasks;

namespace Business.Middleware.Exception
{
    public class CustomErrorPagesMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomErrorPagesMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (TimeoutException ex)
            {
                var response = context.Response;
                // response.Clear();
                // response.StatusCode = StatusCodes.Status400BadRequest;
                // response.ContentType = "application/json; charset=utf-8";
                await response.WriteAsync($"İstek zaman aşımına uğradı");
            }
            catch (System.Exception ex)
            {
                var response = context.Response;
                // response.Clear();
                // response.StatusCode = StatusCodes.Status400BadRequest;
                // response.ContentType = "application/json; charset=utf-8";
                await response.WriteAsync($"Beklenmedik bir hata olustu! {ex.Message}");
            }

        }
    }
}
