using System;
using System.ComponentModel.DataAnnotations;
namespace USTerritoryAPI.Models
{
	public class USTerritoryDto
	{
		[Required]
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public double TerritoryPopulation { get; set; }
		public int YearAquired { get; set; }

	}
}

