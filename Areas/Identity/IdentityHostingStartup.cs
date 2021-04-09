using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SOPRO.Areas.Identity.Data;
using SOPRO.Data;

[assembly: HostingStartup(typeof(SOPRO.Areas.Identity.IdentityHostingStartup))]
namespace SOPRO.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SOPRO.Data.DbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<SOPRO.Data.DbContext>();
            });
        }
    }
}