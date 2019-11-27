using System;
using lortframMSsidenderofteikkevirker.Areas.Identity.Data;
using lortframMSsidenderofteikkevirker.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(lortframMSsidenderofteikkevirker.Areas.Identity.IdentityHostingStartup))]
namespace lortframMSsidenderofteikkevirker.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<lortframMSsidenderofteikkevirkerContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("lortframMSsidenderofteikkevirkerContextConnection")));

                services.AddDefaultIdentity<lortframMSsidenderofteikkevirkerUser>()
                    .AddEntityFrameworkStores<lortframMSsidenderofteikkevirkerContext>();
            });
        }
    }
}