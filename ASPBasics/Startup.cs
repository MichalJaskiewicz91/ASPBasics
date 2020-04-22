using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPBasics.Startup))]
namespace ASPBasics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
