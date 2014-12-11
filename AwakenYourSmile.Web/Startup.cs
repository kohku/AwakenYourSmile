using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AwakenYourSmile.Web.Startup))]
namespace AwakenYourSmile.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
