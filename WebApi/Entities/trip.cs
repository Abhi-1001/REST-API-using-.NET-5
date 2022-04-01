using System;

namespace Catalog.Entities
{
    public record Trip
    {
        public Guid Id {get; set;}
        public Guid Car_Id {get; set;}
        public Guid Driver_Id {get; set;}
        public String Dest {get; set;}
    }
}