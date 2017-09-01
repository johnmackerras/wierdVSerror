using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wierdVSerror.Startup))]
namespace wierdVSerror
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
