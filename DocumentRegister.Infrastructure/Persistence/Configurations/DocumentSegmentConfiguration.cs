using DocumentRegister.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentRegister.Infrastructure.Persistence.Configurations
{
    public class DocumentSegmentConfiguration : IEntityTypeConfiguration<DocumentSegment>
    {
        public void Configure(EntityTypeBuilder<DocumentSegment> builder)
        {
            builder.HasData(
                new DocumentSegment
                {
                    DocumentSegmentId = 1,
                    CategoryName = "Project Code",
                    CategoryDescription = "Codes that define what project the document is part of",
                    Value = "A554",
                    ValueDescription = "Oxygen sensor retrofitting",
                    DocumentId = 1,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new DocumentSegment
                {
                    DocumentSegmentId = 2,
                    CategoryName = "Document Type",
                    CategoryDescription = "Specifies the type of document",
                    Value = "ELEC",
                    ValueDescription = "Electronic schematic",
                    DocumentId = 1,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new DocumentSegment
                {
                    DocumentSegmentId = 3,
                    CategoryName = "Customer code",
                    CategoryDescription = "Codes that define the customer they are related to",
                    Value = "ANG",
                    ValueDescription = "Anglo Gold Ashanti",
                    DocumentId = 1,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new DocumentSegment
                {
                    DocumentSegmentId = 4,
                    CategoryName = "Sequence Number",
                    CategoryDescription = "Unique serial number for identifying individual documents",
                    Value = "566",
                    ValueDescription = "Some info about seq number",
                    DocumentId = 1,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                }
                );
        }
    }
}
