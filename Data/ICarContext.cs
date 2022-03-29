using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Catalog.Entities;
 
namespace Catalog.Data
{
    public interface ICarContext
    {
        DbSet<Car> Cars { get; init; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}