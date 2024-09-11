using DocumentRegister.Application.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Infrastructure.Persistence.Context;

namespace DocumentRegister.Infrastructure
{
    public static class DatabaseDependencyInjection
	{
		public static IServiceCollection AddDatabaseServices(this IServiceCollection services, IConfiguration configuration)
		{

			services.AddDbContext<DocumentRegisterDbContext>(options =>
			{
				options.UseSqlServer(configuration.GetConnectionString("DocumentRegisterAppConnection"));
			});

			services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			services.AddScoped<IDataTypeRepository, DataTypeRepository>();

			return services;
		}
	}
}
