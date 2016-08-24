using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Softuni_Blog.Startup))]
namespace Softuni_Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
