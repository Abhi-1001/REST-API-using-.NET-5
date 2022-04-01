using System;

namespace Catalog.Dtos
{
    public record DriverDto
    {
        public Guid Id {get; set;}
        public String Name {get; set;}
        public String Number {get; set;}
    }
}