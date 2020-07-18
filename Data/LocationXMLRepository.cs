using GoogleMappApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GoogleMappApp.Data
{
    public class LocationXMLRepository : ILocationRepository
    {
        public async Task<List<Location>> GetLocations()
        {
            WebClient wclient = new WebClient();
            string locationData = wclient.DownloadString("wwwroot//Locations.xml");

            XDocument xml = XDocument.Parse(locationData);

            var locations = (from x in xml.Descendants("Location")
                             select new Location
                             {
                                 Latitude = ((string)x.Attribute("Latitude")),
                                 Longitude = ((string)x.Attribute("Longitude")),
                                 Name = ((string)x.Attribute("Name"))
                             }).ToList();

            return await Task.FromResult(locations);
        }
    }
}
