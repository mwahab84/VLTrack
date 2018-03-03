using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VLTrack.Startup))]
namespace VLTrack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
