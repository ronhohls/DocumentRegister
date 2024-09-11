using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Infrastructure.Persistence.Context;
using DocumentRegister.Core.Entities;
using DocumentRegister.Infrastructure.Persistence.Repositories;



namespace DocumentRegister.Application.Persistence.Repositories
{
    public class DataTypeRepository : GenericRepository<DataType>, IDataTypeRepository
	{
		public DataTypeRepository(DocumentRegisterDbContext dbContext) : base(dbContext)
		{
		}
	}
}
