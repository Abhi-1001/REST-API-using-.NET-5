using Catalog.Entities;
using Catalog.Data;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Catalog.Repositories
{
    public class InMemTripRepo : TTripRepo
    {
        private readonly ITripContext _context;

        public InMemTripRepo(ITripContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Trip>> GetTrips()
        {
            return await _context.Trips.ToListAsync();
        }

        public async Task<Trip> GetTrip(Guid Id)
        {
            return await _context.Trips.FindAsync(Id);
        }

        public async Task CreateTrip(Trip item)
        {
            _context.Trips.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTrip(Trip item)
        {
            var itemToUpdate = await _context.Trips.FindAsync(item.Id);

            if (itemToUpdate == null)
            {
                throw new NullReferenceException();
            }

            itemToUpdate.Car_Id = item.Car_Id;
            itemToUpdate.Driver_Id = item.Driver_Id;
            itemToUpdate.Dest = item.Dest;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTrip(Guid Id)
        {
            var itemToDelete = await _context.Trips.FindAsync(Id);
            
            if (itemToDelete == null)
            {
                throw new NullReferenceException();
            }

            _context.Trips.Remove(itemToDelete);
            await _context.SaveChangesAsync();
        }
    }
}