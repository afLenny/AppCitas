﻿using AppCitas.Extensions;
using AppCitas.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AppCitas.Helpers
{
    public class LogUserActivity : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var resultContext = await next();

            if (!resultContext.HttpContext.User.Identity.IsAuthenticated) return;

            var username = resultContext.HttpContext.User.GetUsername();
            var repo = resultContext.HttpContext.RequestServices.GetService<IUserRepository>();
            var user = await repo.GetUserByUsernameAsync(username);
            user.LastActive = DateTime.Now;
            await repo.SaveAllAsync();
        }
    }
}
