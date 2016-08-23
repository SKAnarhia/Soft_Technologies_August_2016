using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WasteOfTimeTeamProject.Startup))]
namespace WasteOfTimeTeamProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
