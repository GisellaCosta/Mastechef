var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=MBrasil}/{action=Index}");

//app.MapControllerRoute(
//    name: "Republica",
//    pattern: "123",
//    defaults: new { controller = "home", action = "Republica" });

//app.MapControllerRoute(
//    name: "Despesas",
//    pattern: "Despesas",
//    defaults: new { controller = "Expensive", action = "Despesas" });

//app.MapControllerRoute(
//    name: "Pessoas",
//    pattern: "Pessoas",
//    defaults: new { controller = "Home", action = "Pessoas" });

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();

app.Run();
