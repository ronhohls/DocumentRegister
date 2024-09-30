using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DocumentRegister.Application
{
	public static class ApplicationDependencyInjection
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services )
		{
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
			return services;
		}
	}
}
