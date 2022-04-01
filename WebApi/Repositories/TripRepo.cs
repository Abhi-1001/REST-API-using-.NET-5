using System;
using System.Collections.Generic;
using Catalog.Entities;
using System.Threading.Tasks;

namespace Catalog.Repositories
{
    public interface TTripRepo
    {
        Task <Trip> GetTrip(Guid Trip_Id);
        Task <IEnumerable<Trip>> GetTrips();
        Task CreateTrip(Trip item);
        Task UpdateTrip(Trip item);
        Task DeleteTrip(Guid Trip_Id);
    }
}