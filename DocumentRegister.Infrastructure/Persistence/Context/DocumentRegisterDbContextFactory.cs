using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace DocumentRegister.Infrastructure.Persistence.Context
{
	public class DocumentRegisterDbContextFactory : IDesignTimeDbContextFactory<DocumentRegisterDbContext>
	{
		public DocumentRegisterDbContext CreateDbContext(string[] args)
		{
			var basePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "DocumentRegister.Api"));
			// Use the configuration system to read the connection string
			var config = new ConfigurationBuilder()
				.SetBasePath(basePath)
				.AddJsonFile("appsettings.json")
				.Build();

			var optionsBuilder = new DbContextOptionsBuilder<DocumentRegisterDbContext>();
			var connectionString = config.GetConnectionString("DocumentRegisterAppConnection");

			optionsBuilder.UseSqlServer(connectionString);

			// Return the context with just DbContextOptions (since IUserService isn't available at design time)
			return new DocumentRegisterDbContext(optionsBuilder.Options, null);
		}
	}
}
