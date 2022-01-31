using Business.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserSessionManager : IUserSessionService
    {
        private readonly string UserId = "UserId";
        private readonly HttpContext _httpContext;
        public UserSessionManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContext = httpContextAccessor.HttpContext;
        }
        public string GetUserId()
        {
            var headerUserId = _httpContext.Request.Headers["UserId"].ToString();

            var userId = "8603398b-68d7-4001-9c22-3613bc04f177";
    
            if(!headerUserId.IsNullOrEmpty())
            userId = headerUserId;

            if (!UserId.CheckGuid())
                return userId;

            return userId;
        }
    }
}
