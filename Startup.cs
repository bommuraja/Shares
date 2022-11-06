using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shares.Startup))]
namespace Shares
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
