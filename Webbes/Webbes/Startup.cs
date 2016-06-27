using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webbes.Startup))]
namespace Webbes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
