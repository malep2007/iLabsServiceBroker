using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iLabsServiceBroker.Startup))]
namespace iLabsServiceBroker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
