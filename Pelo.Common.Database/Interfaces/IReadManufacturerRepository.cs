using Pelo.Common.Database.DbObjects;

namespace Pelo.Common.Database.Interfaces;

public interface IReadManufacturerRepository
{
    Task<List<Manufacturer>> GetAll();
}