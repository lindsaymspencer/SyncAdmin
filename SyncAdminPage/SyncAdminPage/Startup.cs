using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SyncAdminPage.Startup))]
namespace SyncAdminPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
