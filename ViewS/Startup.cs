using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewS.Startup))]
namespace ViewS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
