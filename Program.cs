using la_mia_pizzeria_static.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//per connettersi al db:
string sConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PizzaContext>(options =>
 options.UseSqlServer(sConnectionString));
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();
//end per connettersi al db

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pizzas}/{action=Index}/{id?}");



// crea il db in locale tramite il context
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<PizzaContext>();
    context.Database.EnsureCreated(); //crea il Db
    //DbInitializer.Initialize(context); //popola il Db creato da context
}

app.Run();
