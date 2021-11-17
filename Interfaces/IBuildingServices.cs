using BuildingAppSample.DTO;
using BuildingAppSample.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingAppSample.Interfaces
{
    public interface IBuildingServices
    {
        Task<List<BuildingDTO>> getBuildings(int BuildingId, int ObjectId, int DataFieldId, DateTime Fromdate, DateTime ToDate);
        Task<List<Building>> getBuildingsforDropdown();
        Task<List<BuildingAppSample.Models.Object>> getObjectsforDropdown();
        Task<List<DataField>> getDataFieldforDropdown();
    }
}
