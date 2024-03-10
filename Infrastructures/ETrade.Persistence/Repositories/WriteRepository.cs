using ETrade.Application.Repositories;
using ETrade.Domain.Entities;
using ETrade.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Persistence.Repositories;
public class WriteRepository<TEntity> : IWriteRepository<TEntity> where TEntity : BaseEntity
{
    private readonly ETradeDbContext _context;

    public WriteRepository(ETradeDbContext context)
    {
        _context = context;
    }

    public DbSet<TEntity> Table => _context.Set<TEntity>();

    public async Task<bool> AddAsync(TEntity entity)
    {
        EntityEntry<TEntity> entityEntry = await Table.AddAsync(entity);
        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(List<TEntity> entities)
    {
        await Table.AddRangeAsync(entities);
        return true;
    }

    public bool Remove(TEntity entity)
    {
        EntityEntry<TEntity> entityEntry =  Table.Remove(entity);
        return entityEntry.State == EntityState.Deleted;
    }
    
    public bool RemoveRange(List<TEntity> entities)
    {
        Table.RemoveRange(entities);
        return true;
    }

    public async Task<bool> RemoveAsync(string id)
    {
        TEntity entity = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        return Remove(entity);
    }

    public bool Update(TEntity entity)
    {
        EntityEntry<TEntity> entityEntry = Table.Update(entity);
        return entityEntry.State == EntityState.Modified;
    }

    public async Task<int> SaveAsync()
        => await _context.SaveChangesAsync();
}
