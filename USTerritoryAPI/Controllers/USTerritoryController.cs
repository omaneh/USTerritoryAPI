using System;
using USTerritoryAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace USTerritoryAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]

	public class USTerritoryController : ControllerBase
	{

		// 1. Client should be able to get a list of all resources avaliable.

		[HttpGet]
		public ActionResult<IEnumerable<USTerritoryDto>> GetAllUSTerritory()
		{
			var UsTerritoryAll = USTerritoryDataStore.Current.Territory;

			return Ok(UsTerritoryAll);

		}

		// 2. Client should be able to specify the resource to get.

		[HttpGet("{territoryId}", Name = "GetSpecifiedUsTerritory")]


		public ActionResult<USTerritoryDto> GetSpecifiedUsTerritory(int territoryId)
		{
			var UsTerritoryToBeReturned = USTerritoryDataStore.Current.Territory.FirstOrDefault(p => p.Id == territoryId);

			if (UsTerritoryToBeReturned == null)
			{
				return NotFound();
			}

			return Ok(UsTerritoryToBeReturned);
		}

		// 3. Client should be able to post a new resource.

		[HttpPost]

		public ActionResult<USTerritoryDto> PostNewTerritory(int territoryId, UsTerritoryDtoToCreate newTerritory)
		{
			var AllCurrentTerritories = USTerritoryDataStore.Current.Territory;

			var territoryReturned = AllCurrentTerritories.FirstOrDefault(p => p.Id == territoryId);

			if (territoryReturned == null)
			{
				return NotFound(); //code returns 404 Not Found. 
			}


			int HighestTerritoryIdValue = AllCurrentTerritories.Max(p => p.Id);

			var newTerritoryToBeReturned = new USTerritoryDto()
			{
				Id = HighestTerritoryIdValue + 1,
				Name = newTerritory.Name,
				TerritoryPopulation = newTerritory.TerritoryPopulation,
				YearAquired = newTerritory.YearAquired
			};

			AllCurrentTerritories.Add(newTerritoryToBeReturned);

			return CreatedAtRoute("GetSpecifiedUsTerritory",
				new
				{
					territoryId = territoryId
				}, newTerritoryToBeReturned);

		}

		//4. Client should be able to do a full update.
		[HttpPut("{territoryId}")]

		public ActionResult<USTerritoryDto> FullTerritoryUpdate(int territoryId, UsTerritoryDtoToUpdate updatedTerritory)
		{
			var territoryReturned = USTerritoryDataStore.Current.Territory.FirstOrDefault(p => p.Id == territoryId);

			if (territoryReturned == null)
			{
				return NotFound();
			}

			territoryReturned.Name = updatedTerritory.Name;
			territoryReturned.TerritoryPopulation = updatedTerritory.TerritoryPopulation;
			territoryReturned.YearAquired = updatedTerritory.YearAquired;

			return Ok(updatedTerritory);

        }

		//5. Client should be able to do a partial update.

		[HttpPatch("{territoryId}")]

		public ActionResult<USTerritoryDto> PartialUpdate(int territoryId, JsonPatchDocument<UsTerritoryDtoToUpdate> updatedTerritory)
		{
			var territoryReturned = USTerritoryDataStore.Current.Territory.FirstOrDefault(p => p.Id == territoryId);

			if (territoryReturned == null)
			{
				return NotFound();
			}

			var newTerritoryToPatch = new UsTerritoryDtoToUpdate()
			{
				Name = territoryReturned.Name,
				TerritoryPopulation = territoryReturned.TerritoryPopulation,
				YearAquired = territoryReturned.YearAquired
			};

			updatedTerritory.ApplyTo(newTerritoryToPatch, ModelState);

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (!TryValidateModel(ModelState))
			{
				return BadRequest(ModelState);
            }

			newTerritoryToPatch.Name = territoryReturned.Name;
			newTerritoryToPatch.TerritoryPopulation = territoryReturned.TerritoryPopulation;
			newTerritoryToPatch.YearAquired = territoryReturned.YearAquired;

			return Ok(territoryReturned);

        }

		//6. Client should be able to delete input





        }

    }

