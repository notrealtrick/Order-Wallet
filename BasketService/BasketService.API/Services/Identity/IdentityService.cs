﻿namespace BasketService.API.Services.Identity
{
    public class IdentityService : IIdentityService
    {
        private IHttpContextAccessor _context;

        public IdentityService(IHttpContextAccessor context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public string GetUserIdentity()
        {
            //return _context.HttpContext.User.FindFirst("sub").Value;
            return "admin";
        }

        public string GetUserName()
        {
            //return _context.HttpContext.User.Identity.Name;
            return "admin";
        }

        public string GetUserRoomName()
        {
            //return _context.HttpContext.User.Identity.Name;
            return "300";
        }
    }
}
