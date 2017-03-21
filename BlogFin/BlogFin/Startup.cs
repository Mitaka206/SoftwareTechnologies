using Microsoft.Owin;
using BlogFin.Migrations;
using BlogFin.Models;
using System.Data.Entity;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogFin.Startup))]
namespace BlogFin
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
