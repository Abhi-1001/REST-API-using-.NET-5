using Microsoft.EntityFrameworkCore;
using Catalog.Entities;
 
namespace Catalog.Data
{
    public class CarContext: DbContext, ICarContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
             
        }
 
        public DbSet<Car> Cars { get; init; }
    }
}