using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedicalBlog.Startup))]
namespace MedicalBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
