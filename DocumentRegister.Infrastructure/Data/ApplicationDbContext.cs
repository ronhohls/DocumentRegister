using DocumentRegister.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<SegmentCategory> SegmentCategories { get; set; }
        public DbSet<DataType> DataTypes { get; set; }
        public DbSet<SegmentData> SegmentData { get; set; }
        public DbSet<DeptDocNumStructure> DeptDocNumStructures { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }
        public DbSet<DocumentSegment> DocumentSegments { get; set; }
        

    }
}
