using Catalog.Entities;
using Catalog.Data;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Repositories
{
    public class InMemCarRepo : CCarRepo
    {
        private readonly ICarContext _context;

        public InMemCarRepo(ICarContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Car>> GetCars()
        {
            return await _context.Cars.ToListAsync();
        }

        public async Task<Car> GetCar(Guid Id)
        {
            return await _context.Cars.FindAsync(Id);
        }

        public async Task CreateCar(Car item)
        {
            _context.Cars.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCar(Car item)
        {
            var itemToUpdate = await _context.Cars.FindAsync(item.Id);

            if (itemToUpdate == null)
            {
                throw new NullReferenceException();
            }

            itemToUpdate.Cord = item.Cord;
            itemToUpdate.Speed = item.Speed;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCar(Guid Id)
        {
            var itemToDelete = await _context.Cars.FindAsync(Id);
            
            if (itemToDelete == null)
            {
                throw new NullReferenceException();
            }

            _context.Cars.Remove(itemToDelete);
            await _context.SaveChangesAsync();
        }
    }
}