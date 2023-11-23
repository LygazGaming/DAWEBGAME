using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DAGAME.Startup))]
namespace DAGAME
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
