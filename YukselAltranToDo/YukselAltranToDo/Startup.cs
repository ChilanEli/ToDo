using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YukselAltranToDo.Startup))]
namespace YukselAltranToDo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
