using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SQLTreeView.Client;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mzg2MDQ2OEAzMjM5MmUzMDJlMzAzYjMyMzkzYk1HWVU3bmp5Z3hFdllFYmRVOC9SbzhvaGRoeDVNQVplSkplKy8xQXdYaHM9");

await builder.Build().RunAsync();
