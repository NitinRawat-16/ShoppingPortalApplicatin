using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UI_Layer.Startup))]
namespace UI_Layer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
