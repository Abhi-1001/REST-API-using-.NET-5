using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record UpdateCarDto
    {
        [Required]
        public String Cord {get; set;}
        
        [Required]
        public Decimal Speed {get; init;}
    }
}