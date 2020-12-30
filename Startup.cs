using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blue_Crystal.Startup))]
namespace Blue_Crystal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
