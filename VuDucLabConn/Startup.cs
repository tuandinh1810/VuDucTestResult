using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VuDucLabConn.Startup))]
namespace VuDucLabConn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
