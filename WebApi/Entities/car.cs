using System;

namespace Catalog.Entities
{
    public record Car
    {
        public Guid Id {get; set;}
        public String Cord {get; set;}
        public Decimal Speed {get; set;}
    }
}