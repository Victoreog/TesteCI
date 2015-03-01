using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteCI.Startup))]
namespace TesteCI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
