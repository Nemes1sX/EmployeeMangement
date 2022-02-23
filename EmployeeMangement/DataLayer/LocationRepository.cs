using EmployeeMangement.DataContext;
using EmployeeMangement.Infrastructure;
using EmployeeMangement.Models.Dtos;
using EmployeeMangement.Models.Entities;
using EmployeeMangement.Models.FormRequest;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeMangement.DataLayer
{
    public class LocationRepository : ILocationRepository
    {
        private readonly EmployeeContext _db;
        private readonly Mapping _mapper;

        public LocationRepository(EmployeeContext db, Mapping mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<LocationDto> AddLocation(LocationRequest request)
        {
            var location = new Location();
            location = SaveLocation(location, request);

            _db.Locations.Add(location);
            await _db.SaveChangesAsync();

            return _mapper.MapLocation().Map<LocationDto>(location);
        }

        public async Task<int> DeleteLocation(int id)
        {
            var location = await _db.Locations.FindAsync(id);

            if (location == null)
                return 0;

            _db.Locations.Remove(location);
            await _db.SaveChangesAsync();

            return id;
        }

        public async Task<List<LocationDto>> GetLocations()
        {
            var locations = await _db.Locations.ToListAsync();

            return _mapper.MapLocation().Map<List<LocationDto>>(locations);
        }

        public async Task<LocationDto> ShowLocation(int id)
        {
            var location = await _db.Locations.FindAsync(id);

            if (location == null)
                return null;
       
            return _mapper.MapLocation().Map<LocationDto>(location);
        }

        public async Task<LocationDto> UpdateLocation(int id, LocationRequest request)
        {
            var location = await _db.Locations.FindAsync(id);

            if (location == null)
                return null;

            location = SaveLocation(location, request);
            await _db.SaveChangesAsync();

            return _mapper.MapLocation().Map<LocationDto>(location);
        }

        private Location SaveLocation(Location location, LocationRequest request)
        {
            location.Name = request.Name;
            location.Address = request.Address;
            location.MaxAllocation = request.MaxAllocation; 

            return location;
        }
    }
}
