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
	public class DataTypeConfiguration : IEntityTypeConfiguration<DataType>
	{
		public void Configure(EntityTypeBuilder<DataType> builder)
		{
			builder.HasData(
				new DataType
				{
					DataTypeId = 1,
					Name = "TestValue",
					DateCreated = DateTime.Now,
					DateModified = DateTime.Now
				}
			);

		}
	}
}
