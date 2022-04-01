using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record UpdateDriverDto
    {
        [Required]
        public String Name {get; set;}
        
        [Required]
        public String Number {get; set;}
    }
}