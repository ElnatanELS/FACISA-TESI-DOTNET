using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(br.edu.cesed.Web.Startup))]
namespace br.edu.cesed.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
