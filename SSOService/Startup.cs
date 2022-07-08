using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SSOService.Startup))]
namespace SSOService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
