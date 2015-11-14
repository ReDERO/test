using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(System5M.Startup))]
namespace System5M
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
