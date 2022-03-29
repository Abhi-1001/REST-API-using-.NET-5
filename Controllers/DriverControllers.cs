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
    [Route("drivers")]
    public class DriverContoller : ControllerBase
    {
        private readonly DDriverRepo _driverRepository;
        public DriverContoller(DDriverRepo driverRepository)
        {
            _driverRepository = driverRepository;
        }

        // GET /drivers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DriverDto>>> GetDrivers()
        {
            var drivers = await _driverRepository.GetDrivers();
            return Ok(drivers);
        }

        // GET /drivers/{id}
        [HttpGet("{Id}")]
        public async Task<ActionResult<DriverDto>> GetDriver(Guid Id)
        {
            var item = await _driverRepository.GetDriver(Id);

            if (item is null)
            {
                return NotFound();
            }
            
            return item.AsDto();
        }

        // POST /drivers
        [HttpPost]
        public async Task<ActionResult> CreateDriver(CreateDriverDto driverDto)
        {
            Driver item = new()
            {
                Id = Guid.NewGuid(),
                Name = driverDto.Name,
                Number = driverDto.Number
            };

            await _driverRepository.CreateDriver(item);

            return Ok();
        }

        // PUT /items/{id}
        [HttpPut("{Id}")]
        public async Task<ActionResult> UpdateDriver(Guid Id, UpdateDriverDto driverDto)
        {
            var existingDriver = _driverRepository.GetDriver(Id);

            if (existingDriver is null)
            {
                return NotFound();
            }

            Driver updatedDriver = new()
            {
                Name = driverDto.Name,
                Number = driverDto.Number
            };

            await _driverRepository.UpdateDriver(updatedDriver);

            return Ok();
        }

        // DELETE /drivers/{id}
        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteDriver(Guid Id)
        {
            var existingDriver= _driverRepository.GetDriver(Id);

            if (existingDriver is null)
            {
                return NotFound();
            }

            await _driverRepository.DeleteDriver(Id);

            return Ok();
        }
    }
}