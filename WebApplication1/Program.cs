var builder = WebApplication.CreateBuilder(args);

//Adding Services to the Project
builder.Services.AddControllersWithViews();
#if DEBUG
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
#endif

var app = builder.Build();

//Adding HTTP Pipeline to The File
if(!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();

app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();
