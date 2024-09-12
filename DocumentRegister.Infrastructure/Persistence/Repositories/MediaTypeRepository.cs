using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.Entities;
using DocumentRegister.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Infrastructure.Persistence.Repositories
{
	public class MediaTypeRepository : GenericRepository<MediaType>, IMediaTypeRepository
	{
		public MediaTypeRepository(DocumentRegisterDbContext dbContext) : base(dbContext)
		{ }
	}
}
