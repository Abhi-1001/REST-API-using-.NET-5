using Microsoft.EntityFrameworkCore;
using Catalog.Entities;
 
namespace Catalog.Data
{
    public class TripContext: DbContext, ITripContext
    {
        public TripContext(DbContextOptions<TripContext> options) : base(options)
        {
             
        }
 
        public DbSet<Trip> Trips { get; init; }
    }
}