using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OEE_Test.Startup))]
namespace OEE_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
