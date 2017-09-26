using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prova1_MateusGadotti.Startup))]
namespace Prova1_MateusGadotti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
