using System.Globalization;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer;

namespace EMT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Set culture to en-US
            var cultureInfo = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            var builder = WebApplication.CreateBuilder(args);

            // Add Razor Pages and session support
            builder.Services.AddRazorPages();
            builder.Services.AddSession();
            builder.Services.AddHttpContextAccessor();

            // Register the DbContext with SQLite
            builder.Services.AddDbContext<EMTDbContext>(options =>
                options.UseSqlite("Data Source=EMTDb.db"));

            // Register custom repositories
            builder.Services.AddScoped<IMinigameRepository, MinigameRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            // Ensure the database exists and is seeded
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<EMTDbContext>();
                context.Database.EnsureCreated();
                EMTDbInitializer.Initialize(context);
            }

            // Middleware setup
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthorization();
            app.UseSession();

            // Razor Pages route mapping
            app.MapRazorPages();
            app.MapFallbackToPage("/HomePage");


            app.Run();
        }
    }
}
