using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpaceKanjiAdmin.Startup))]
namespace SpaceKanjiAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
