using DocumentRegister.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentRegister.Infrastructure.Persistence.Configurations
{
    public class DeptDocNumStructConfiguration : IEntityTypeConfiguration<DeptDocNumStruct>
    {
        public void Configure(EntityTypeBuilder<DeptDocNumStruct> builder)
        {
            builder.HasData(
                new DeptDocNumStruct
                {
                    DeptDocNumStructId = 1,
                    Seperator = "-----",
                    Description = "Electronic Department",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                });

            builder.HasMany(d => d.SegmentCategories)
                .WithMany(s => s.DeptDocNumStructs)
                .UsingEntity(j => j.HasData(
                    new { DeptDocNumStructsDeptDocNumStructId = 1, SegmentCategoriesSegmentCategoryId = 1 },
                    new { DeptDocNumStructsDeptDocNumStructId = 1, SegmentCategoriesSegmentCategoryId = 2 },
                    new { DeptDocNumStructsDeptDocNumStructId = 1, SegmentCategoriesSegmentCategoryId = 3 },
                    new { DeptDocNumStructsDeptDocNumStructId = 1, SegmentCategoriesSegmentCategoryId = 4 }
            ));
        }
    }
}
