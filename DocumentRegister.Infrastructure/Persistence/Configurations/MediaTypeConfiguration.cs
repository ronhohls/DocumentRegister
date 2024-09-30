using DocumentRegister.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
					Description = "Hard copy",
					DateCreated = DateTime.Now,
					DateModified = DateTime.Now
				},
                new MediaType
                {
                    MediaTypeId = 2,
                    Description = "Digital - local",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new MediaType
                {
                    MediaTypeId = 3,
                    Description = "Digital - cloud",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                }
            );
		}
	}
}
