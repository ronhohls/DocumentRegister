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
	.AddHttpMessageHandler<JwtAuthorizationMessageHandler>()
    .ConfigureHttpClient(client =>
    {
        var options = new System.Text.Json.JsonSerializerOptions
        {
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
            PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase
        };
        // Pass the options when needed or use globally
    });

builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<ApiAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();

builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IDataTypeService, DataTypeService>();
builder.Services.AddScoped<IStatusService, StatusService>();
builder.Services.AddScoped<IMediaTypeService, MediaTypeService>();
builder.Services.AddScoped<ISegmentCategoryService, SegmentCategoryService>();
builder.Services.AddScoped<ISegmentDataService, SegmentDataService>();
builder.Services.AddScoped<IDeptDocNumStructService, DeptDocNumStructService>();
//builder.Services.AddScoped<IDocumentSegmentService, DocumentSegmentService>();
builder.Services.AddScoped<IDocumentService, DocumentService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

await builder.Build().RunAsync();