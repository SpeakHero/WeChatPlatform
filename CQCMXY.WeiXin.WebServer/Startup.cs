using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CQCMXY.WeiXin.WebServer.Startup))]
namespace CQCMXY.WeiXin.WebServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
