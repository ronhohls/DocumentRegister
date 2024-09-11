using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.Entities;
using DocumentRegister.Infrastructure.Persistence.Context;


namespace DocumentRegister.Application.Repositories
{
    public class DataTypeRepository : GenericRepository<DataType>, IDataTypeRepository
	{
		public DataTypeRepository(DocumentRegisterDbContext dbContext) : base(dbContext)
		{
		}
	}
}
