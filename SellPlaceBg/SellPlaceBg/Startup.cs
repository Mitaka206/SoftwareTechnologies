using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SellPlaceBg.Startup))]
namespace SellPlaceBg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
