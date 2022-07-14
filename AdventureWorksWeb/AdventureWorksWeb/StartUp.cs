using AdventureWorksNS.Data;

namespace AdventureWorksWeb
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AdventureWorksDBContext();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsDevelopment())
            {
                app.UseHsts();
            }
            app.UseRouting();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapGet("/hello", () => "Hello World");
            });
        }
    }
}
