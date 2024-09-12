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
	public class MediaTypeConfiguration : IEntityTypeConfiguration<MediaType>
	{
		public void Configure(EntityTypeBuilder<MediaType> builder)
		{
			builder.HasData(
				new MediaType
				{
					MediaTypeId = 1,
					Description = "TestValue",
					DateCreated = DateTime.Now,
					DateModified = DateTime.Now
				}
			);
		}
	}
}
