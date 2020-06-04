using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoGithub.Startup))]
namespace DemoGithub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
