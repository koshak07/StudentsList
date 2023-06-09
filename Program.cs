using StudentCrudV1.Models;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);


// Add controller
builder.Services.AddControllersWithViews();


//DI for DbContext
builder.Services.AddDbContext<StudentDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

var app = builder.Build();

// configure the http request pipeline.
if (!app.environment.isdevelopment())
{
    app.useexceptionhandler("/home/error");
}



app.UseRouting();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Index}/{id?}"); 

app.Run();
