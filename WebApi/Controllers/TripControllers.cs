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
    [Route("trips")]
    public class TripContoller : ControllerBase
    {
        private readonly TTripRepo _tripRepository;
        private readonly CCarRepo _carRepo;
        private readonly DDriverRepo _driverRepo;
        public TripContoller(TTripRepo tripRepository, CCarRepo carRepository, DDriverRepo driverRepository)
        {
            _carRepo = carRepository;
            _tripRepository = tripRepository;
            _driverRepo = driverRepository;
        }

        // GET /drivers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TripDto>>> GetTrips()
        {
            var trips = await _tripRepository.GetTrips();
            return Ok(trips);
        }

        // GET /drivers/{id}
        [HttpGet("{Id}")]
        public async Task<ActionResult<TripDto>> GetTrip(Guid Id)
        {
            var item = await _tripRepository.GetTrip(Id);

            if (item is null)
            {
                return NotFound();
            }
            
            return item.AsDto();
        }

        // POST /drivers
        [HttpPost]
        public async Task<ActionResult> CreateTrip(CreateTripDto tripDto)
        {
            Trip item = new()
            {
                Id = Guid.NewGuid(),
                Car_Id = tripDto.Car_Id,
                Driver_Id = tripDto.Driver_Id,
                Dest = tripDto.Dest
            };

            var checkCar = await _carRepo.GetCar(item.Car_Id);
            var checkDriver = await _driverRepo.GetDriver(item.Driver_Id);

            if (checkCar != null && checkDriver != null)
            {
                await _tripRepository.CreateTrip(item);
                return Ok();
            }

            return Ok();
        }

        // PUT /items/{id}
        [HttpPut("{Id}")]
        public  async Task<ActionResult> UpdateTrip(Guid Trip_Id, UpdateTripDto TripDto)
        {
            var existingTrip = _tripRepository.GetTrip(Trip_Id);

            if (existingTrip is null)
            {
                return NotFound();
            }   

            Trip updatedTrip = new()
            {
                Car_Id = TripDto.Car_Id,
                Driver_Id = TripDto.Driver_Id,
                Dest = TripDto.Dest
            };

            var checkCar = _carRepo.GetCar(updatedTrip.Car_Id);
            var checkDriver = _driverRepo.GetDriver(updatedTrip.Driver_Id);

            if (checkCar != null && checkDriver != null)
            {
                await _tripRepository.UpdateTrip(updatedTrip);
                return Ok();
            }

            return NotFound();
        }

        // DELETE /drivers/{id}
        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteTrip(Guid Id)
        {
            var existingTrip = _tripRepository.GetTrip(Id);

            if (existingTrip is null)
            {
                return NotFound();
            }

            await _tripRepository.DeleteTrip(Id);

            return Ok();
        }
    }
}