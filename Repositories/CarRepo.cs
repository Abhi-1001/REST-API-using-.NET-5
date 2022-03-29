using System;
using System.Collections.Generic;
using Catalog.Entities;
using System.Threading.Tasks;

namespace Catalog.Repositories
{
    public interface CCarRepo
    {
        Task <Car> GetCar(Guid Car_Id);
        Task <IEnumerable<Car>> GetCars();
        Task CreateCar(Car item);
        Task UpdateCar(Car item);
        Task DeleteCar(Guid Car_Id);
    }
}