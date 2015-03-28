using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TBGitHubWebApp.Startup))]
namespace TBGitHubWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
