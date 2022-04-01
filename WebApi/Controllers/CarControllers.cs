using System;
using System.Collections.Generic;
using Catalog.Entities;
using Catalog.Dtos;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("cars")]
    public class CarContoller : ControllerBase
    {
        private readonly CCarRepo _carRepository;
        public CarContoller(CCarRepo carRepository)
        {
            _carRepository = carRepository;
        }

        // GET /cars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarDto>>> GetCars()
        {
            var cars = await _carRepository.GetCars();
            return Ok(cars);
        }

        // GET /cars/{id}
        [HttpGet("{Id}")]
        public async Task<ActionResult<CarDto>> Getcar(Guid Id)
        {
            var item = await _carRepository.GetCar(Id);

            if (item is null)
            {
                return NotFound();
            }
            
            return item.AsDto();
        }

        // POST /cars
        [HttpPost]
        public async Task<ActionResult> Createcar(CreateCarDto carDto)
        {
            Car item = new()
            {
                Id = Guid.NewGuid(),
                Cord = carDto.Cord,
                Speed = carDto.Speed
            };

            await _carRepository.CreateCar(item);

            return Ok();
        }

        // PUT /items/{id}
        [HttpPut("{Id}")]
        public async Task<ActionResult> Updatecar(Guid Id, UpdateCarDto carDto)
        {
            var existingcar = await _carRepository.GetCar(Id);

            if (existingcar == null)
            {
                return NotFound();
            }

            Car updatedcar = new()
            {
                Cord = carDto.Cord,
                Speed = carDto.Speed
            };

            await _carRepository.UpdateCar(updatedcar);

            return Ok();
        }

        // DELETE /cars/{id}
        [HttpDelete("{Id}")]
        public async Task<ActionResult> Deletecar(Guid Id)
        {
            var existingcar= _carRepository.GetCar(Id);

            if (existingcar is null)
            {
                return NotFound();
            }

            await _carRepository.DeleteCar(Id);

            return Ok();
        }
    }
}