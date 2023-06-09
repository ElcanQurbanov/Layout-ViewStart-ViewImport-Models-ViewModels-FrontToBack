var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseRouting();

app.MapControllerRoute(
	name: "default",
	pattern: "{Controller=Home}/{action=Index}/{id?}");


app.Run();
