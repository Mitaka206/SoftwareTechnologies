using Microsoft.Owin;
using myBlog.Migrations;
using Owin;
using System.Data.Entity;
using myBlog.Models;

[assembly: OwinStartupAttribute(typeof(myBlog.Startup))]
namespace myBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
            ConfigureAuth(app);
        }
    }
}
