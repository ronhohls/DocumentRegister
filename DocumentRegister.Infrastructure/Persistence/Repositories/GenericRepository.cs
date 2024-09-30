using DocumentRegister.Application.Contracts.Persistence;
using DocumentRegister.Core.Entities.Common;
using DocumentRegister.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DocumentRegister.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
	{
		protected readonly DocumentRegisterDbContext _dbContext;

        public GenericRepository(DocumentRegisterDbContext dbContext)
        {
			_dbContext = dbContext;
		}
        public async Task CreateAsync(TEntity entity)
		{
			await _dbContext.AddAsync(entity);
			await _dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(TEntity entity)
		{
			_dbContext.Remove(entity);
			await _dbContext.SaveChangesAsync();
		}

		public async Task<IEnumerable<TEntity>> GetAllAsync()
		{
			return await _dbContext.Set<TEntity>().AsNoTracking().ToListAsync();
		}

		//cannot make getbyid 
		public async Task<TEntity> GetByIdAsync(int id)
		{
			//TODO: handle null exceptions
			var keyProperty = _dbContext.Model
								  .FindEntityType(typeof(TEntity))
								  .FindPrimaryKey()
								  .Properties
								  .FirstOrDefault();

			if (keyProperty == null)
			{
				throw new InvalidOperationException($"No primary key defined for {typeof(TEntity).Name}");
			}

			// Get the primary key property name
			var keyName = keyProperty.Name;

			// Build a lambda expression dynamically for `entity => entity.{PrimaryKey} == id`
			var parameter = Expression.Parameter(typeof(TEntity), "entity");
			var property = Expression.Property(parameter, keyName);
			var equal = Expression.Equal(property, Expression.Constant(id));
			var lambda = Expression.Lambda<Func<TEntity, bool>>(equal, parameter);

			// Use the lambda expression to query the DbSet
			return await _dbContext.Set<TEntity>().SingleOrDefaultAsync(lambda);
		}

		public async Task UpdateAsync(TEntity entity)
		{
			_dbContext.Update(entity);
			_dbContext.Entry(entity).State = EntityState.Modified;
			await _dbContext.SaveChangesAsync();
		}
	}
}
