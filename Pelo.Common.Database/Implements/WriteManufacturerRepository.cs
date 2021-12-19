using Pelo.Common.Database.DataAccess;
using Pelo.Common.Database.DbObjects;
using Pelo.Common.Database.Interfaces;

namespace Pelo.Common.Database.Implements;

public class WriteManufacturerRepository : BaseWriteRepository<Manufacturer>, IWriteManufacturerRepository
{
    public WriteManufacturerRepository(DbWriteContext context) : base(context)
    {
    }
}