using Catalog.Entities;
using Catalog.Data;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Repositories
{
    public class InMemDriverRepo : DDriverRepo
    {
        private readonly IDriverContext _context;

        public InMemDriverRepo(IDriverContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Driver>> GetDrivers()
        {
            return await _context.Drivers.ToListAsync();
        }

        public async Task<Driver> GetDriver(Guid Id)
        {
            return await _context.Drivers.FindAsync(Id);
        }

        public async Task CreateDriver(Driver item)
        {
            _context.Drivers.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateDriver(Driver item)
        {
            var itemToUpdate = await _context.Drivers.FindAsync(item.Id);

            if (itemToUpdate == null)
            {
                throw new NullReferenceException();
            }

            itemToUpdate.Name = item.Name;
            itemToUpdate.Number = item.Number;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteDriver(Guid Id)
        {
            var itemToDelete = await _context.Drivers.FindAsync(Id);
            
            if (itemToDelete == null)
            {
                throw new NullReferenceException();
            }

            _context.Drivers.Remove(itemToDelete);
            await _context.SaveChangesAsync();
        }
    }
}