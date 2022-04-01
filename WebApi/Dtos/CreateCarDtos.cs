using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record CreateCarDto
    {
        [Required]
        public String Cord {get; set;}

        [Required]
        public Decimal Speed {get; set;}
    }
}