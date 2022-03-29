using System;

namespace Catalog.Dtos
{
    public record TripDto
    {
        public Guid Id {get; init;}
        public Guid Car_Id {get; init;}
        public Guid Driver_Id {get; init;}
        public String Dest {get; init;}
    }
}