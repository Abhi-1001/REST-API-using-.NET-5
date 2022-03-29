using Microsoft.EntityFrameworkCore;
using Catalog.Entities;
 
namespace Catalog.Data
{
    public class DriverContext: DbContext, IDriverContext
    {
        public DriverContext(DbContextOptions<DriverContext> options) : base(options)
        {
             
        }
 
        public DbSet<Driver> Drivers { get; init; }
    }
}