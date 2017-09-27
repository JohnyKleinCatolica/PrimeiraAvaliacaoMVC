using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrimeiraAvaliacao.Startup))]
namespace PrimeiraAvaliacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
