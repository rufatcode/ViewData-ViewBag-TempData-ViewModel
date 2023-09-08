var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    //endpoints.MapGet("/hello", () => "hello");
    //endpoints.MapControllerRoute(
    //    name: "default",
    //    pattern: "{controller=home}/{action=index}/{id?}");
});
app.MapDefaultControllerRoute();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

