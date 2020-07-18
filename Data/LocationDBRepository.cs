using GoogleMappApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoogleMappApp.Data
{
    public class LocationDBRepository : ILocationRepository
    {
        private readonly DataContext _context;
        public LocationDBRepository(DataContext context)
        {
            this._context = context;
        }

        public async Task<List<Location>> GetLocations()
        {
            var locations = await _context.Locations.ToListAsync();
            return locations;
        }
    }
}
