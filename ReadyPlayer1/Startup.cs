using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReadyPlayer1.Startup))]
namespace ReadyPlayer1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
