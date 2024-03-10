using ETrade.Domain.Entities;
using System.Linq.Expressions;

namespace ETrade.Application.Repositories;

public interface IReadRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    IQueryable<TEntity> GetAll(bool tracking = true);
    IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> filter, bool tracking = true);
    Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter, bool tracking = true);
    Task<TEntity> GetByIdAsync(string id, bool tracking = true);

}
