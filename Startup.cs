using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wx092414_SD1.Startup))]
namespace wx092414_SD1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
