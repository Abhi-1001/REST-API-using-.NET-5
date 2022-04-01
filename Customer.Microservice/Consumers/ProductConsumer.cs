using MassTransit;
using Customer.Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Microservice.Consumer
{
    public class ProductConsumer : IConsumer<QueueObject>
    {
        public async Task Consume(ConsumeContext<QueueObject> context)
        {

            await Task.Run(() => {
                var obj = context.Message; 
                Console.WriteLine(obj.driverName);
            });
        }
    }
}
