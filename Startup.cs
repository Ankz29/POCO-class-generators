using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(POCO.Startup))]
namespace POCO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
