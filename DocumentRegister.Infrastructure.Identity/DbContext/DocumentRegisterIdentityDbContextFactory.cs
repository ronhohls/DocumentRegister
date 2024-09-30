using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DocumentRegister.Infrastructure.Identity.DbContext
{
    class DocumentRegisterIdentityDbContextFactory : IDesignTimeDbContextFactory<DocumentRegisterIdentityDbContext>
    {
        public DocumentRegisterIdentityDbContext CreateDbContext(string[] args)
        {
            var basePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "DocumentRegister.Api"));

            // Use the configuration system to read the connection string
            var config = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<DocumentRegisterIdentityDbContext>();
            var connectionString = config.GetConnectionString("DocumentRegisterAppConnection");

            optionsBuilder.UseSqlServer(connectionString);

            // Return the context with just DbContextOptions
            return new DocumentRegisterIdentityDbContext(optionsBuilder.Options);
        }
    }
}
