using Microsoft.EntityFrameworkCore;
using Pelo.Common.Database.DbObjects;

namespace Pelo.Common.Database.DataAccess;

public class DbWriteContext : DbContext
{
    public DbWriteContext(DbContextOptions<DbReadContext> options):base(options)
    {
        
    }

    public DbSet<Manufacturer> Manufacturers { get; set; }
}