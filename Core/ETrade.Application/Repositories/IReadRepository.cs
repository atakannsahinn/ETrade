using ETrade.Domain.Entities;
using System.Linq.Expressions;

namespace ETrade.Application.Repositories;

public interface IReadRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    IQueryable<TEntity> GetAll();
    IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> filter);
    Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter);
    Task<TEntity> GetByIdAsync(string id);

}
