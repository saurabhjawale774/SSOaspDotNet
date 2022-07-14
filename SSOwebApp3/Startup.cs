using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SSOwebApp3.Startup))]
namespace SSOwebApp3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
