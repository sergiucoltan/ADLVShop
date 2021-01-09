using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ADLVShop.Startup))]
namespace ADLVShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
