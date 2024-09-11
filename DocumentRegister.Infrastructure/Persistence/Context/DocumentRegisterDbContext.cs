using DocumentRegister.Application.Contracts.Identity;
using DocumentRegister.Core.Entities;
using DocumentRegister.Core.Entities.Common;
using Microsoft.EntityFrameworkCore;


namespace DocumentRegister.Infrastructure.Persistence.Context
{
    public class DocumentRegisterDbContext : DbContext
    {
        private readonly IUserService _userService;
        public DocumentRegisterDbContext(DbContextOptions<DocumentRegisterDbContext> options, IUserService userService) : base(options)
        {
            _userService = userService;
        }
        public DbSet<DataType> DataTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }
        //public DbSet<SegmentData> SegmentData { get; set; }
        //public DbSet<DeptDocNumStructure> DeptDocNumStructures { get; set; }
        //public DbSet<Document> Documents { get; set; }

        //public DbSet<MediaType> MediaTypes { get; set; }
        //public DbSet<DocumentSegment> DocumentSegments { get; set; }
        //public DbSet<SegmentCategory> SegmentCategories { get; set; }


        //apply configurations for entities
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DocumentRegisterDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        //adds meta for all entities
		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
				.Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
			{
				entry.Entity.DateModified = DateTime.Now;
				entry.Entity.ModifiedBy = _userService.UserId;
				if (entry.State == EntityState.Added)
				{
					entry.Entity.DateCreated = DateTime.Now;
					entry.Entity.CreatedBy = _userService.UserId;
				}
			}

			return base.SaveChangesAsync(cancellationToken);
		}


	}
}
