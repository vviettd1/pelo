using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Pelo.Common.Database.Interfaces;

public interface IBaseWriteRepository<T> where T : class
{
    Task<EntityEntry<T>> Create(T record);
    Task Create(IEnumerable<T> records);
    EntityEntry<T> Update(T record);
    void Update(IEnumerable<T> records);
    Task<bool> Delete(Guid id);
    Task<bool> Delete(IEnumerable<Guid> ids);
    Task<bool> Save();
}