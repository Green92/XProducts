using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XProductsWeb.Startup))]
namespace XProductsWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
