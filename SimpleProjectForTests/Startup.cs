using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleProjectForTests.Startup))]
namespace SimpleProjectForTests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
