using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CridacamoWebPage.Startup))]
namespace CridacamoWebPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
