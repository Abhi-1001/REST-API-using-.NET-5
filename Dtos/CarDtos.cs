using System;

namespace Catalog.Dtos
{
    public record CarDto
    {
        public Guid Id {get; set;}
        public String Cord {get; set;}
        public Decimal Speed {get; set;}
    }
}