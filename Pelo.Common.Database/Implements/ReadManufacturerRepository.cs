using Microsoft.EntityFrameworkCore;
using Pelo.Common.Database.DataAccess;
using Pelo.Common.Database.DbObjects;
using Pelo.Common.Database.Interfaces;

namespace Pelo.Common.Database.Implements;

public class ReadManufacturerRepository : IReadManufacturerRepository
{
    private readonly DbReadContext _context;

    public ReadManufacturerRepository(DbReadContext context)
    {
        _context = context;
    }

    public async Task<List<Manufacturer>> GetAll()
    {
        return await _context.Manufacturers.Where(c => c.IsDeleted == false).Select(c => new Manufacturer
        {
            Id = c.Id,
            Name = c.Name
        }).ToListAsync();
    }
}