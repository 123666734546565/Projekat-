using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projekat_20_dec_v_2.Startup))]
namespace Projekat_20_dec_v_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
