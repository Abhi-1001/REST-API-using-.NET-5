using System.Threading.Tasks;
using System.Collections.Generic;
using Catalog.Entities;
using System;

namespace Catalog.Repositories
{
    public interface DDriverRepo
    {
        Task <Driver> GetDriver(Guid Id);
        Task <IEnumerable<Driver>> GetDrivers();
        Task CreateDriver(Driver item);
        Task UpdateDriver(Driver item);
        Task DeleteDriver(Guid Id);
    }
}