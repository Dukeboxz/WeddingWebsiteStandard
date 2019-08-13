using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeddingWebsiteStandard.Startup))]
namespace WeddingWebsiteStandard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
