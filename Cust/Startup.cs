using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cust.Startup))]
namespace Cust
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
