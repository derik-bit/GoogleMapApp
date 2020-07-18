using GoogleMappApp.Models;
using System.Linq;

namespace GoogleMappApp.Data
{
    public class Seed
    {
        private readonly DataContext _context;
        public Seed(DataContext context)
        {
            this._context = context;
        }

        public void SeedLocations()
        {
            if (!_context.Locations.Any())
            {
                _context.Locations.Add(new Location
                {
                    Latitude = "52.480372",
                    Longitude = "-1.897154",
                    Name = "Birmingham"
                });

                _context.Locations.Add(new Location
                {
                    Latitude = "54.5442828",
                    Longitude = "-1.3297485",
                    Name = "Stockton"
                });

                _context.Locations.Add(new Location
                {
                    Latitude = "51.490435",
                    Longitude = "-0.542273",
                    Name = "Langley - Head Office"
                });

                _context.Locations.Add(new Location
                {
                    Latitude = "53.780600",
                    Longitude = "-1.580270",
                    Name = "Leeds"
                });

                _context.Locations.Add(new Location
                {
                    Latitude = "53.479594",
                    Longitude = "-2.238558",
                    Name = "Manchester"
                });

                _context.SaveChanges();
            }
        }
    }
}
