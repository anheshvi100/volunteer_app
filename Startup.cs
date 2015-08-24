using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(volunteer_app.Startup))]
namespace volunteer_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
