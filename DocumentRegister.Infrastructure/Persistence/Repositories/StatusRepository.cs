using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.Entities;
using DocumentRegister.Infrastructure.Persistence.Context;


namespace DocumentRegister.Infrastructure.Persistence.Repositories
{
    public class StatusRepository : GenericRepository<Status>, IStatusRepository
    {
        public StatusRepository(DocumentRegisterDbContext dbContext) : base(dbContext)
        {
        }
    }
}
