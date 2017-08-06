using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParkVac.Startup))]
namespace ParkVac
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
