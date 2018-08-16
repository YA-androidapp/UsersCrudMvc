using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UsersCrudMvc.Startup))]
namespace UsersCrudMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
