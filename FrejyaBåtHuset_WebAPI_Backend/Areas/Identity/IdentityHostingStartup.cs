using System;
using FrejyaBåtHuset_WebAPI_Backend.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FrejyaBåtHuset_WebAPI_Backend.Areas.Identity.IdentityHostingStartup))]
namespace FrejyaBåtHuset_WebAPI_Backend.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityRegistrationContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("IdentityRegistrationContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<IdentityRegistrationContext>();
            });
        }
    }
}