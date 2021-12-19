using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pelo.Common.Database.DataAccess;
using Pelo.Common.Database.Interfaces;

namespace Pelo.Common.Database.Implements;

public class BaseWriteRepository<T>:IBaseWriteRepository<T> where T:class
{
    public DbWriteContext _context { get; set; }

    public BaseWriteRepository(DbWriteContext context)
    {
        _context = context;
    }
    
    public async Task<EntityEntry<T>> Create(T record)
    {
        var dbSet = _context.Set<T>();
        return await dbSet.AddAsync(record);
    }

    public async Task Create(IEnumerable<T> records)
    {
        var dbSet = _context.Set<T>();
        await dbSet.AddRangeAsync(records);
    }

    public EntityEntry<T> Update(T record)
    {
        var dbSet = _context.Set<T>();
        return dbSet.Update(record);
    }

    public void Update(IEnumerable<T> records)
    {
        var dbSet = _context.Set<T>();
        dbSet.UpdateRange(records);
    }

    public async Task<bool> Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(IEnumerable<Guid> ids)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Save()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}