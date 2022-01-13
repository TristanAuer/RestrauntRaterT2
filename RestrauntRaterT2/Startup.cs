using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestrauntRaterT2.Startup))]
namespace RestrauntRaterT2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
