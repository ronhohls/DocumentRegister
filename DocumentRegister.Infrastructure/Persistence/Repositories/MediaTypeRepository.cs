using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.Entities;
using DocumentRegister.Infrastructure.Persistence.Context;

namespace DocumentRegister.Infrastructure.Persistence.Repositories
{
	public class MediaTypeRepository : GenericRepository<MediaType>, IMediaTypeRepository
	{
		public MediaTypeRepository(DocumentRegisterDbContext dbContext) : base(dbContext)
		{ 

		}
	}
}
