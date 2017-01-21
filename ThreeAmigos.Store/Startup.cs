using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThreeAmigos.Store.Startup))]
namespace ThreeAmigos.Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
