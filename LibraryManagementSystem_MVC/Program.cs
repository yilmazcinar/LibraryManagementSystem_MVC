var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();



var app = builder.Build();

//use to static files.
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
