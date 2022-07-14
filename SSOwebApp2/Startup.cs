using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SSOwebApp2.Startup))]
namespace SSOwebApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
