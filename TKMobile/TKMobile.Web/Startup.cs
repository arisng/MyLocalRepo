using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TKMobile.Web.Startup))]
namespace TKMobile.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
