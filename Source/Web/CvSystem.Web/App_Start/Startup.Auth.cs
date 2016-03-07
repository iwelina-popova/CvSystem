namespace CvSystem.Web
{
    using CvSystem.Data;

    using Owin;

    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context
            app.CreatePerOwinContext(CvSystemDbContext.Create);
        }
    }
}
