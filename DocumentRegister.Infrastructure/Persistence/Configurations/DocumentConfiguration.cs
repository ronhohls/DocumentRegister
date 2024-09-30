using DocumentRegister.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentRegister.Infrastructure.Persistence.Configurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasData(
                new Document
                {
                    DocumentId = 1,
                    Description = "TestValue",
                    DdnsDescription = "Electronic Department",
                    Seperator = "-----",
                    DocumentNumber = "A554-ELEC-ANG-566",
                    StatusId = 1,
                    MediaTypeId = 1,
                    Revision = "45",
                    RequestedBy = "Ron",
                    Location = "Documents office, cabinet 3"
                }
                );
        }
    }
}
