using ETrade.Application.Repositories;
using ETrade.Domain.Entities;
using ETrade.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Persistence.Repositories;
public class ReadRepository<TEntity> : IReadRepository<TEntity> where TEntity : BaseEntity
{
    private readonly ETradeDbContext _context;

    public ReadRepository(ETradeDbContext context)
    {
        _context = context;
    }

    public DbSet<TEntity> Table => _context.Set<TEntity>();

    public IQueryable<TEntity> GetAll()
        => Table;

    public async Task<TEntity> GetByIdAsync(string id)
       => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
    

    public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter)
        => await Table.FirstOrDefaultAsync(filter);

        public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> filter)
        => Table.Where(filter);
}
