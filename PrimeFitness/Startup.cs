using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrimeFitness.Startup))]
namespace PrimeFitness
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
