using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(CvSystem.Web.Startup))]

namespace CvSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
