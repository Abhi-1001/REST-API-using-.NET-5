using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record CreateQueueObjectDto
    {
        [Required]
        public string driverName { get; init; }
        [Required]
        public Guid Car_Id { get; init; }
        [Required]
        public decimal Car_Speed { get; init; }
        [Required]
        public string Car_Cord { get; init; }
    }
}