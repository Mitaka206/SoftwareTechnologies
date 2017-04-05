using Microsoft.Owin;
using myMag.Migrations;
using myMag.Models;
using Owin;
using System.Data.Entity;

[assembly: OwinStartupAttribute(typeof(myMag.Startup))]
namespace myMag
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());

            ConfigureAuth(app);
        }
    }
}
