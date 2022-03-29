using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record UpdateTripDto
    {
        [Required]
        public Guid Car_Id {get; init;}

        [Required]
        public Guid Driver_Id {get; init;}
        
        [Required]
        public String Dest {get; init;}
    }
}