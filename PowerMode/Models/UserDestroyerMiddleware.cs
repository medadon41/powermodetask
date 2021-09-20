using PowerMode.Areas.Identity.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerMode.Models
{
    public class UserDestroyerMiddleware
    {
        private readonly RequestDelegate _next;

        public UserDestroyerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext,
            UserManager<PowerUser> userManager,
            SignInManager<PowerUser> signInManager)
        {

            if (!string.IsNullOrEmpty(httpContext.User.Identity.Name))
            {
                var user = await userManager.FindByNameAsync(httpContext.User.Identity.Name);
                if (user == null)
                {
                    await signInManager.SignOutAsync();
                    httpContext.Response.Redirect("/");
                }
                else
                {
                    if (user.isBlocked && user.Id != null)
                    {
                        //Log the user out and redirect back to homepage
                        await signInManager.SignOutAsync();
                        httpContext.Response.Redirect("/");
                    }
                }
            }
            await _next(httpContext);
        }
    }

    public static class UserDestroyerMiddlewareExtensions
    {
        public static IApplicationBuilder UseUserDestroyer(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UserDestroyerMiddleware>();
        }
    }
}
