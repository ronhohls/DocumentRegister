using DocumentRegister.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentRegister.Infrastructure.Persistence.Configurations
{
	public class DataTypeConfiguration : IEntityTypeConfiguration<DataType>
	{
		public void Configure(EntityTypeBuilder<DataType> builder)
		{
			builder.HasData(
				new DataType
				{
					DataTypeId = 1,
					Name = "String",
					DateCreated = DateTime.Now,
					DateModified = DateTime.Now
				},
                new DataType
                {
                    DataTypeId = 2,
                    Name = "Number",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new DataType
                {
                    DataTypeId = 3,
                    Name = "Currency",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                }
            );
		}
	}
}
