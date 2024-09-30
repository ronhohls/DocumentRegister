using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DocumentRegister.Core.Entities;

namespace DocumentRegister.Infrastructure.Persistence.Configurations
{
	public class SegmentCategoryConfiguration : IEntityTypeConfiguration<SegmentCategory>
	{
		public void Configure(EntityTypeBuilder<SegmentCategory> builder)
		{
            builder.HasData(
                new SegmentCategory
                {
                    SegmentCategoryId = 1,
                    Description = "Codes that define what project the document is part of",
                    Name = "Project Code",
                    DataTypeId = 1,
                    IsPredefined = true,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,

                },
                new SegmentCategory
                {
                    SegmentCategoryId = 2,
                    Description = "Specifies the type of document",
                    Name = "Document Type",
                    DataTypeId = 1,
                    IsPredefined = true,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                },
                new SegmentCategory
                {
                    SegmentCategoryId = 3,
                    Description = "Codes that define the customer they are related to",
                    Name = "Customer code",
                    DataTypeId = 1,
                    IsPredefined = true,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                },
                new SegmentCategory
                {
                    SegmentCategoryId = 4,
                    Description = "Unique serial number for identifying individual documents",
                    Name = "Sequence Number",
                    DataTypeId = 2,
                    IsPredefined = false,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                }
            );
        }
	}
}
