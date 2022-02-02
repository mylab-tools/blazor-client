using Demo.Client;
using Demo.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyLab.BlazorApp.Model;
using MyLab.BlazorApp.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services
    .AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) })
    .AddSingleton<IUserService, DemoUserService>();

builder.Services.Configure<BlazorApp>(app =>
{
    app.Title = "The Demo application";
    app.LogoUrl = "/img/logo.png";
    app.SectionsGroups = new AppSectionGroup[]
    {
        new()
        {
            Title = "",
            Sections = new AppSection[]
            {
                new() { Title = "Home", FaClass = "home", Url = "#"},
            }
        },
        new()
        {
            Title = "Admin",
            Sections = new AppSection[]
            {
                new() { Title = "Users", FaClass = "user", Url = "#"},
                new() { Title = "Admins", FaClass = "user-secret", Url = "#"},
                new() { Title = "Bills", FaClass = "money-bill-alt", Url = "#"},
            }
        },
        new()
        {
            Title = "Services",
            Sections = new AppSection[]
            {
                new() { Title = "Banking", FaClass = "university", Url = "#"},
                new() { Title = "Input documents", FaClass = "file", Url = "#"},
                new() { Title = "Validation", FaClass = "check", Url = "#"},
            }
        }
    };
});

await builder.Build().RunAsync();
