using DocumentRegister.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentRegister.Infrastructure.Persistence.Configurations
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasData(
                new Status
                {
                    StatusId = 1,
                    Description = "Pending Approval",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new Status
                {
                    StatusId = 2,
                    Description = "Approved",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new Status
                {
                    StatusId = 3,
                    Description = "Deprecated",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new Status
                {
                    StatusId = 4,
                    Description = "N/A",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                }
                );
        }
    }
}
