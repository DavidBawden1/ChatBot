using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class LocationModel
    {
        public LocationModel()
        {
            Locations.Add(new LocationModel
            {
                LocationId = 1,
                LocationCityName = "London"
            });

            Locations.Add(new LocationModel
            {
                LocationId = 2,
                LocationCityName = "Edinburgh"
            });

            Locations.Add(new LocationModel
            {
                LocationId = 3,
                LocationCityName = "Birmingham"
            });
        }

        public int LocationId { get; set; }
        public string LocationCityName { get; set; }
        public List<LocationModel> Locations { get; set; } = new List<LocationModel>();
    }
}
