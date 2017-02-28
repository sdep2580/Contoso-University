using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvcmovie.Startup))]
namespace Mvcmovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
