using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TasksList.Startup))]
namespace TasksList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
