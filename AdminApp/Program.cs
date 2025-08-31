using Application;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Infrastructure.Modules;
using Microsoft.AspNetCore.Identity;
using Persistence;
using Persistence.Contexts;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddNewtonsoftJson(x =>
 x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddRazorPages();

builder.Services.AddAutoMapper(cfg => { }, Assembly.GetExecutingAssembly());

builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(containerBuilder =>
    {
        containerBuilder.RegisterModule(new InfrastructureModule());
    });

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
.AddEntityFrameworkStores<IdentityContext>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.ApplyPersistenceConfigure();
app.ApplyApplicationConfigure();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    "areas",
    "area",
    "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.Run();