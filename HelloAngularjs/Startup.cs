using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloAngularjs.Startup))]
namespace HelloAngularjs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
