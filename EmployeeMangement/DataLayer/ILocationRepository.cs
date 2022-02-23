using EmployeeMangement.Models.Dtos;
using EmployeeMangement.Models.FormRequest;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeMangement.DataLayer
{
    public interface ILocationRepository
    {
        Task<List<LocationDto>> GetLocations();
        Task<LocationDto> ShowLocation(int id);
        Task<LocationDto> AddLocation(LocationRequest request);
        Task<LocationDto> UpdateLocation(int id, LocationRequest request);
        Task<int> DeleteLocation(int id);
    }
}
