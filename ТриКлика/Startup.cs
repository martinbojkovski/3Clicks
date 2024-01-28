using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ТриКлика.Startup))]
namespace ТриКлика
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
