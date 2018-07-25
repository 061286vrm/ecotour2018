using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ecotour2018.Startup))]
namespace ecotour2018
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
