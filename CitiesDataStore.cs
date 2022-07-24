using CityInfo.Api.Models;

namespace CityInfo.Api
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Dunedin",
                    Description = "It's called sunny but it's not"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Christchurch",
                    Description = "A lot of earthquakes"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Wellington",
                    Description = "Windy as fuck"
                },
                new CityDto()
                {
                    Id = 4,
                    Name = "Auckland",
                    Description = "It's pretty much NZ really..."
                }
            };
        }
    }
}
