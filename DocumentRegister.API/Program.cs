using DocumentRegister.Core.Entities;
using DocumentRegister.Infrastructure;
using DocumentRegister.Infrastructure.Identity;
using DocumentRegister.Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

//logging service with seq
builder.Host.UseSerilog((host, loggingConfig) =>
	loggingConfig.WriteTo.Console()
	.ReadFrom.Configuration(host.Configuration));

//var connectionString = builder.Configuration.GetConnectionString("DocumentRegisterAppConnection");

// Add services to the container.
builder.Services.AddApplicationServices();
builder.Services.AddDatabaseServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

builder.Services.AddControllers();

//Cors port restrictions
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowAll",
		b => b.AllowAnyMethod()
		.AllowAnyHeader()
		.AllowAnyOrigin());
});

builder.Services.AddHttpContextAccessor();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();
app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
