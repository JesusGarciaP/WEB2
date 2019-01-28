using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ejercicio01.Startup))]
namespace ejercicio01
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
