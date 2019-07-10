using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SameSystemDiffrentWeather.Startup))]
namespace SameSystemDiffrentWeather
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
