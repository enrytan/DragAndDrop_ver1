using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DragAndDrop_ver1.Startup))]
namespace DragAndDrop_ver1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
