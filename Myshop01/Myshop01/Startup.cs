using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Myshop01.Startup))]
namespace Myshop01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
