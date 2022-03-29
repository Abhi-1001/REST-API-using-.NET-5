using System;   

namespace Catalog.Entities
{
    public record Driver
    {
        public Guid Id {get; set;}
        public String Name {get; set;}
        public String Number {get; set;}
    }
}