using EmployeeMangement.DataContext;
using EmployeeMangement.DataLayer;
using EmployeeMangement.Models.Dtos;
using EmployeeMangement.Models.FormRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationRepository _locationRepository;
        private readonly EmployeeContext _db;

        public LocationController(ILocationRepository locationRepository, EmployeeContext db)
        {
            _locationRepository = locationRepository;
            _db = db;
        }

        [HttpGet]
        [Route("index")]
        public async Task<ActionResult<List<LocationDto>>> GetLocations()
        {
            var locations = await _locationRepository.GetLocations(); ;

            if (locations.Count() == 0 || locations == null)
            {
                return NotFound();
            }

            return locations;
        }

        [HttpPost]
        [Route("add")]
        public async Task<LocationDto> AddLocation(LocationRequest request)
        {
            return await _locationRepository.AddLocation(request);
        }

        [HttpGet]
        [Route("show")]
        public async Task<ActionResult<LocationDto>> ShowLocation(int id)
        {
            var locations = await _locationRepository.ShowLocation(id);

            if (locations == null)
                return NotFound();

            return locations;
        }

        [HttpPut]
        [Route("update")]
        public async Task<ActionResult<LocationDto>> UpdateLocation(int id, LocationRequest request)
        {
            var location = await _locationRepository.UpdateLocation(id, request);

            if (location == null)
                return NotFound();

            return location;
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<ActionResult<int>> DeleteLocation(int id)
        {
            var result = await _locationRepository.DeleteLocation(id);

            if (result == 0)
                return NotFound();

            return id;
        }

        [HttpGet]
        [Route("id")]
        public async Task<List<int>> GetId()
        {
            var idList = await _db.Locations.Select(x => x.Id).ToListAsync();

            return idList;
        }

    }
}
