using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAP456.Startup))]
namespace LAP456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
