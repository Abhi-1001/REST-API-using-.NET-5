using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog
{
    public static class NewBaseType
    {
        public static DriverDto AsDto(this Driver item)
        {
            return new DriverDto
            {
                Id = item.Id,
                Name = item.Name,
                Number = item.Number,
            };
        }

        public static CarDto AsDto(this Car item)
        {
            return new CarDto
            {
                Id = item.Id,
                Cord = item.Cord,
                Speed = item.Speed,
            };
        }

        public static TripDto AsDto(this Trip item)
        {
            return new TripDto
            {
                Id = item.Id,
                Car_Id = item.Car_Id,
                Driver_Id = item.Driver_Id,
                Dest = item.Dest,
            };
        }
    }
}