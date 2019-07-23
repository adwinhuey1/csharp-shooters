using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using valkyrieID.Model;

[assembly: HostingStartup(typeof(valkyrieID.Areas.Identity.IdentityHostingStartup))]
namespace valkyrieID.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                
                var connectionString = "Data Source = Valkyrie.db";
                services.AddDbContext<ValkyrieIMSContext>(options => options.UseSqlite(connectionString));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<ValkyrieIMSContext>();
            });
        }
    }
}