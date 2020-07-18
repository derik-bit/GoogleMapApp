using GoogleMappApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoogleMappApp.Data
{
    public interface ILocationRepository
    {
        Task<List<Location>> GetLocations();
    }
}
