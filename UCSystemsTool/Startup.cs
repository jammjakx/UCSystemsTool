using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UCSystemsTool.Startup))]
namespace UCSystemsTool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
