using System;
using System.ComponentModel.DataAnnotations;

namespace USTerritoryAPI.Models
{
	public class UsTerritoryDtoToCreate
    {
            public string Name { get; set; } = string.Empty;
            public double TerritoryPopulation { get; set; }
            public int YearAquired { get; set; }

        }
    }

