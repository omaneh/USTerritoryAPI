using System;
namespace USTerritoryAPI.Models
{
	public class UsTerritoryDtoToUpdate
	{
			public string Name { get; set; } = string.Empty;
            public double TerritoryPopulation { get; set; }
            public int YearAquired { get; set; }
	}
}

