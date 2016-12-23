using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Iconic.Startup))]
namespace Iconic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
