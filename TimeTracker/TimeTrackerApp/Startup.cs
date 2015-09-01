using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeTrackerApp.Startup))]
namespace TimeTrackerApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
