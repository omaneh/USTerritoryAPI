using USTerritoryAPI.Models;
using System.ComponentModel.DataAnnotations;


namespace USTerritoryAPI
{
	public class USTerritoryDataStore
	{
		public List<USTerritoryDto> Territory { get; set; }

		public static USTerritoryDataStore Current { get; set; } = new USTerritoryDataStore();


		public USTerritoryDataStore()
		{
            Territory = new List<USTerritoryDto>()
            {
                new USTerritoryDto()
                {
                    Id = 1,
                    Name = "Puerto Rico",
                    TerritoryPopulation = 3_252_407,
                    YearAquired = 1898

                },
                new USTerritoryDto()
                {
                    Id = 2,
                    Name = "American Samoa",
                    TerritoryPopulation = 44_273,
                    YearAquired = 1900

                },
                new USTerritoryDto()
                {
                    Id = 3,
                    Name = "Northern Mariana Islands",
                    TerritoryPopulation = 49_551,
                    YearAquired = 1947

                },
                new USTerritoryDto()
                {
                    Id = 4,
                    Name = "Guam",
                    TerritoryPopulation = 171_774,
                    YearAquired = 1898

                },
                new USTerritoryDto()
                {
                    Id = 5,
                    Name = "US Virgin Islands",
                    TerritoryPopulation = 105_870,
                    YearAquired = 1917

                },
                new USTerritoryDto()
                {
                    Id = 6,
                    Name = "Baker Island",
                    TerritoryPopulation = 0,
                    YearAquired = 1857

                },
                new USTerritoryDto()
                {
                    Id = 7,
                    Name = "Howland Island",
                    TerritoryPopulation = 0,
                    YearAquired = 1867

                },
                new USTerritoryDto()
                {
                    Id = 8,
                    Name = "Palmyra Atoll",
                    TerritoryPopulation = 0,
                    YearAquired = 2000

                },
                new USTerritoryDto()
                {
                    Id = 9,
                    Name = "Jarvis Island",
                    TerritoryPopulation = 0,
                    YearAquired = 1858

                },
                new USTerritoryDto()
                {
                    Id = 10,
                    Name = "Johnston Atoll",
                    TerritoryPopulation = 0,
                    YearAquired = 1858

                },
                new USTerritoryDto()
                {
                    Id = 11,
                    Name = "Kingman Reef",
                    TerritoryPopulation = 0,
                    YearAquired = 1941

                },
                new USTerritoryDto()
                {
                    Id = 12,
                    Name = "Midway Atoll",
                    TerritoryPopulation = 40,
                    YearAquired = 1867

                },
                new USTerritoryDto()
                {
                    Id = 13,
                    Name = "Navassa Island",
                    TerritoryPopulation = 0,
                    YearAquired = 1856

                },
                new USTerritoryDto()
                {
                    Id = 14,
                    Name = "Wake Island",
                    TerritoryPopulation = 150,
                    YearAquired = 1899

                }
            };
		}

    }
}

