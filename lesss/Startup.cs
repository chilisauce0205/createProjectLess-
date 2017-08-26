using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lesss.Startup))]
namespace lesss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
