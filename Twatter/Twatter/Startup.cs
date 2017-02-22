using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Twatter.Startup))]
namespace Twatter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
