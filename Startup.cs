using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GaryRussell.Startup))]
namespace GaryRussell
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
