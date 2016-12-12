using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_codefirst.Startup))]
namespace Web_codefirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            // Initialize the product database.
           // System.Data.Entity.Database.SetInitializer(new Migrations.SampleData());
        }
    }
}
