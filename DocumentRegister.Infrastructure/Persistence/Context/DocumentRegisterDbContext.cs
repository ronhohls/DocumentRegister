using DocumentRegister.Application.Contracts.Identity;
using DocumentRegister.Core.Entities;
using DocumentRegister.Core.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DocumentRegister.Infrastructure.Persistence.Context
{
    public class DocumentRegisterDbContext : DbContext
    {
        private readonly IUserService _userService;
		private readonly ILoggerFactory _loggerFactory;

        public DocumentRegisterDbContext(DbContextOptions<DocumentRegisterDbContext> options, IUserService userService, ILoggerFactory loggerFactory) 
            : base(options)
        {
            _userService = userService;
			_loggerFactory = loggerFactory;
        }

        public DocumentRegisterDbContext(DbContextOptions<DocumentRegisterDbContext> options, IUserService userService) 
            : base(options)
        {
            _userService = userService;
        }

        public DbSet<DataType> DataTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }
		public DbSet<MediaType> MediaTypes { get; set; }
		public DbSet<SegmentCategory> SegmentCategories { get; set; }
		public DbSet<SegmentData> SegmentDatum { get; set; }
		public DbSet<DeptDocNumStruct> DeptDocNumStructs { get; set; }
        public DbSet<DocumentSegment> DocumentSegments { get; set; }
        public DbSet<Document> Documents { get; set; }

        //logging
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(_loggerFactory);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        //apply configurations for entities
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DocumentRegisterDbContext).Assembly);

            //DeptDocNumStruct many-to-many relationship with SegmentCategory
            modelBuilder.Entity<DeptDocNumStruct>()
                .HasMany(d => d.SegmentCategories)
                .WithMany(sd => sd.DeptDocNumStructs);

            //SegmentCategory many-to-one relationship with SegmentDatum
            modelBuilder.Entity<SegmentCategory>()
                .HasMany(sc => sc.SegmentDatum)
                .WithOne(sd => sd.SegmentCategory)
                .HasForeignKey(sd => sd.SegmentCategoryId);

            //SegmentCategory many-to-one relationship with DataType
            modelBuilder.Entity<SegmentCategory>()
                .HasOne(sc => sc.DataType)
                .WithMany()
                .HasForeignKey(sc => sc.DataTypeId);

            //Document one-to-many relationship with DocumentSegment
            modelBuilder.Entity<Document>()
                .HasMany(d => d.DocumentSegments)
                .WithOne(ds => ds.Document)
                .HasForeignKey(ds => ds.DocumentId);

            //Document many-to-one relationship with Status
            modelBuilder.Entity<Document>()
                .HasOne(d => d.Status)
                .WithMany()
                .HasForeignKey(d => d.StatusId);

            //Document many-to-one relationship with MediaType
            modelBuilder.Entity<Document>()
                .HasOne(d => d.MediaType)
                .WithMany()
                .HasForeignKey(d => d.MediaTypeId);

            modelBuilder.Entity<DocumentSegment>()
                .HasOne(ds => ds.Document)
                .WithMany(d => d.DocumentSegments)
                .HasForeignKey(ds => ds.DocumentId)
                .OnDelete(DeleteBehavior.Cascade);

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
