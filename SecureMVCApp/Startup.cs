using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecureMVCApp.Startup))]
namespace SecureMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
