using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyDatabaseFirstProject.Site.Startup))]
namespace MyDatabaseFirstProject.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
