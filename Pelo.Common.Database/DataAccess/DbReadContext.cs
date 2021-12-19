using Microsoft.EntityFrameworkCore;
using Pelo.Common.Database.DbObjects;

namespace Pelo.Common.Database.DataAccess;

public class DbReadContext : DbContext
{
    public DbReadContext(DbContextOptions<DbReadContext> options) : base(options)
    {
    }

    public DbSet<Manufacturer> Manufacturers { get; set; }
}