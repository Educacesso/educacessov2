using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Educacesso.MVC.Startup))]
namespace Educacesso.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}