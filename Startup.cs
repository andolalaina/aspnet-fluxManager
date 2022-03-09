using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FluxManager.Startup))]
namespace FluxManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
