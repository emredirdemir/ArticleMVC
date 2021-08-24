using System;
using EmreDemir.UI.Areas.Identity.Data;
using EmreDemir.UI.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EmreDemir.UI.Areas.Identity.IdentityHostingStartup))]
namespace EmreDemir.UI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EmreDemirUIContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EmreDemirUIContextConnection")));

                services.AddDefaultIdentity<EmreDemirUIUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<EmreDemirUIContext>();


            });
        }
    }
}