using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameServer.Startup))]
namespace GameServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
