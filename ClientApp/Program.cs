using Application;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Infrastructure.Modules;
using Infrastructure.Resources;
using Microsoft.AspNetCore.Localization;
using Persistence;
using System.Globalization;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);

builder.Services.AddSingleton<ISharedLocalizer, SharedLocalizer>();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(containerBuilder =>
    {
        containerBuilder.RegisterModule(new InfrastructureModule());
    });

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services
    .AddMvc()
    .AddDataAnnotationsLocalization(
        options =>
        {
            options.DataAnnotationLocalizerProvider =
                (type, factory) =>
                {
                    var assemblyName =
                        new AssemblyName(
                            typeof(SharedResource)
                                    .GetTypeInfo()
                                    .Assembly.FullName!);
                    return factory.Create("SharedResource", assemblyName.Name!);
                };
        });


CultureInfo[] supportedCultures =
[
    new CultureInfo("az"),
    new CultureInfo("en"),
    //new CultureInfo("ru")
];

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("az");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
    options.RequestCultureProviders =
    [
        new QueryStringRequestCultureProvider(),
        new CookieRequestCultureProvider()
    ];
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.ApplyApplicationConfigure();

app.UseStaticFiles();

app.UseRequestLocalization();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
