using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicWebCalculator.Startup))]
namespace BasicWebCalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
