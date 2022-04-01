using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Microservice.Models;
using Catalog.Repositories;
using Catalog.Dtos;
using Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerProduct : ControllerBase
    {
        private readonly IBus _busService;
        private readonly TTripRepo _tripRepository;
        private readonly CCarRepo _carRepository;
        private readonly DDriverRepo _driverRepository;
        public CustomerProduct(IBus busService, TTripRepo tripRepository, CCarRepo carRepository, DDriverRepo driverRepository)
        {
            _busService = busService;
            _carRepository = carRepository;
            _tripRepository = tripRepository;
            _driverRepository = driverRepository;
        }
        [HttpPost]
        public async Task<string> CreateProduct(CreateQueueObjectDto queueObject)
        {
            // var checkCar = await _carRepository.GetCar(trip.Car_Id);
            // var checkDriver = await _driverRepository.GetDriver(trip.Driver_Id);

            // if (checkDriver != null && checkCar != null)
            // {
            //     QueueObject item = new()
            //     {
            //         Id = Guid.NewGuid(),
            //         driverName = checkDriver.Name,
            //         Car_Id = checkCar.Id,
            //         Car_Speed = checkCar.Speed,
            //         Car_Cord = checkCar.Cord
            //     };
            QueueObject item = new()
            {
                Id = Guid.NewGuid(),
                driverName = queueObject.driverName,
                Car_Id = queueObject.Car_Id,
                Car_Speed = queueObject.Car_Speed,
                Car_Cord = queueObject.Car_Cord
            };
            Uri uri = new Uri("rabbitmq://localhost/productQueue");
            var endPoint = await _busService.GetSendEndpoint(uri);
            await endPoint.Send(item);
            return "true";
        }
    }
}
