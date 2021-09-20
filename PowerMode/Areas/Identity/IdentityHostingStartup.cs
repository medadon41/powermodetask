using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PowerMode.Areas.Identity.Data;
using PowerMode.Data;

[assembly: HostingStartup(typeof(PowerMode.Areas.Identity.IdentityHostingStartup))]
namespace PowerMode.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PowerModeContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PowerModeContextConnection")));

                services.AddDefaultIdentity<PowerUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<PowerModeContext>();
            });
        }
    }
}