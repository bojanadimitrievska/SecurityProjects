using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ezdrastvoProject.Startup))]
namespace ezdrastvoProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
