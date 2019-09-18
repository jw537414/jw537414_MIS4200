using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jw537414_MIS4200.Startup))]
namespace jw537414_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
