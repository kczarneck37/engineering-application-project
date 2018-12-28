using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BakeryShop.Startup))]
namespace BakeryShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
