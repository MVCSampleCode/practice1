using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(practice1.Startup))]
namespace practice1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
