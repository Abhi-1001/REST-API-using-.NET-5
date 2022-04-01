using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Microservice.Models
{
    public class QueueObject
    {
        public Guid Id { get; set; }
        public string driverName { get; set; }
        public Guid Car_Id { get; set; }
        public decimal Car_Speed { get; set; }
        public string Car_Cord { get; set; }
    }
}
