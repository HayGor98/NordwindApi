using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NordwindApi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NordwindApi
{
    public static class MigrationManager
    {

        public static NordwindContext DbContext { get; private set; }

        public static Microsoft.AspNetCore.Hosting.IWebHost MigrateDatabase(this Microsoft.AspNetCore.Hosting.IWebHost webHost)
        {

            using (var scope = webHost.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var hostingEnvironment = services.GetRequiredService<IHostingEnvironment>();
                DbContext = services.GetRequiredService<NordwindContext>();

                DbContext.Database.Migrate();

                CheckStaticData();
            }

            return webHost;
        }


        private static void CheckStaticData()
        {
            // seed data here ...
        }
    }
}
