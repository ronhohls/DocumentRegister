using Blazored.LocalStorage;
using Blazored.Toast;
using DocumentRegister.WebAssembly.UI;
using DocumentRegister.WebAssembly.UI.Contracts;
using DocumentRegister.WebAssembly.UI.Handlers;
using DocumentRegister.WebAssembly.UI.Providers;
using DocumentRegister.WebAssembly.UI.Services;
using DocumentRegister.WebAssembly.UI.Services.Authentication;
using DocumentRegister.WebAssembly.UI.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Reflection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient<JwtAuthorizationMessageHandler>();

builder.Services.AddHttpClient<IClient, Client>(client => client.BaseAddress = new Uri("https://localhost:7186"))
	.AddHttpMessageHandler<JwtAuthorizationMessageHandler>(); ;
//alt
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7186") });

builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<ApiAuthenticationStateProvider>();
//builder.Services.AddScoped<AuthenticationStateProvider>(p =>
//    p.GetRequiredService<ApiAuthenticationStateProvider>());
builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();

builder.Services.AddAuthorizationCore();

//alt
//builder.Services.AddScoped<IClient, Client>();

builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IDataTypeService, DataTypeService>();
builder.Services.AddScoped<IStatusService, StatusService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

await builder.Build().RunAsync();
