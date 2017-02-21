using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APlayerAndWebApi.Startup))]
namespace APlayerAndWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
