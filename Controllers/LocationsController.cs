using GoogleMappApp.Data;
using GoogleMappApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoogleMappApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationRepository _repo;
        public LocationsController(ILocationRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<Location>> GetLocations()
        {
            var locations = await _repo.GetLocations();
            return locations;
        }
    }
}
