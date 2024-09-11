using DocumentRegister.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Description = "TestValue",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                });
        }
    }
}
