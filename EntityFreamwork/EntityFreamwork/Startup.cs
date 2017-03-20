using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityFreamwork.Startup))]
namespace EntityFreamwork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
