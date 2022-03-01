//using Blazored.LocalStorage;
using coreNXTProtoV1.Client;
using coreNXTProtoV1.Client.Services;
using coreNXTProtoV1.Client.Services.IServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration.GetValue<string>("App:ApiUrl")) });
builder.Services.AddScoped<ICategoryService, CategoryService>();
//
//builder.Services.AddHttpClient<ICategoryService, CategoryService>(client =>
//{
//    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
//});
//builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
