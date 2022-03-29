using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Catalog.Entities;
 
namespace Catalog.Data
{
    public interface ITripContext
    {
        DbSet<Trip> Trips { get; init; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}