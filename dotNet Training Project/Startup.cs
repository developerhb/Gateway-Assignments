using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotNet_Training_Project.Startup))]
namespace dotNet_Training_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
