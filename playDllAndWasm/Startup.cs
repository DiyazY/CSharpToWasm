using Microsoft.AspNetCore.Builder;

namespace playDllAndWasm
{
    public class Startup
    {
        public void ConfigureServices()
        {
        }

        public void Configure(IApplicationBuilder app)
        {
            // points to index.html as a start point.
            app.UseDefaultFiles(); 
            // for the wwwroot folder
            app.UseStaticFiles(new StaticFileOptions
            {
                // If the file is not a recognized content-type.
                ServeUnknownFileTypes = true 
            });
        }
    }
}
