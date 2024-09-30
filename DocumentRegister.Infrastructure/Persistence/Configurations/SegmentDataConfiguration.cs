using DocumentRegister.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentRegister.Infrastructure.Persistence.Configurations
{
    public class SegmentDataConfiguration : IEntityTypeConfiguration<SegmentData>
    {
        public void Configure(EntityTypeBuilder<SegmentData> builder)
        {
            builder.HasData(
                new SegmentData
                {
                    SegmentDataId = 1,
                    Value = "A554",
                    Description = "Oxygen sensor retrofitting",
                    SegmentCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new SegmentData
                {
                    SegmentDataId = 2,
                    Value = "B336",
                    Description = "Calibration of systems",
                    SegmentCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new SegmentData
                {
                    SegmentDataId = 3,
                    Value = "C123",
                    Description = "Testing of new systems",
                    SegmentCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new SegmentData
                {
                    SegmentDataId = 4,
                    Value = "D789",
                    Description = "Testing of new systems",
                    SegmentCategoryId = 1,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new SegmentData
                {
                    SegmentDataId = 5,
                    Value = "ELEC",
                    Description = "Electronic schematic",
                    SegmentCategoryId = 2,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new SegmentData
                {
                    SegmentDataId = 6,
                    Value = "MECH",
                    Description = "Mechanical schematic",
                    SegmentCategoryId = 2,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new SegmentData
                {
                    SegmentDataId = 7,
                    Value = "FIN",
                    Description = "Financial documents",
                    SegmentCategoryId = 2,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new SegmentData
                {
                    SegmentDataId = 8,
                    Value = "ANG",
                    Description = "Anglo Gold Ashanti",
                    SegmentCategoryId = 3,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new SegmentData
                {
                    SegmentDataId = 9,
                    Value = "SIB",
                    Description = "Sibanye",
                    SegmentCategoryId = 3,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new SegmentData
                {
                    SegmentDataId = 10,
                    Value = "HAR",
                    Description = "Harmony Gold",
                    SegmentCategoryId = 3,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                }
                );
        }
    }
}
