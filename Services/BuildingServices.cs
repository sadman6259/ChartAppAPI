using BuildingAppSample.DTO;
using BuildingAppSample.Interfaces;
using BuildingAppSample.Models;
using BuildingAppSample.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildingAppSample.Services
{
    public class BuildingServices : IBuildingServices
    {
        private readonly BuildingRepository repo = null;
        private readonly DbContext context;
        public BuildingServices(IConfiguration Config)
        {
            this.context = new BuildingContext(Config);
            this.repo = new BuildingRepository(this.context);
        
        }
        public async Task<List<BuildingDTO>> getBuildings(int BuildingId,int ObjectId,int DataFieldId, DateTime Fromdate,DateTime ToDate)
        {
            return await repo.getBuildings(BuildingId, ObjectId, DataFieldId, Fromdate, ToDate);
        }
        public async Task<List<Building>> getBuildingsforDropdown()
        {
            return await repo.getBuildingsforDropdown();
        }
        public async Task<List<BuildingAppSample.Models.Object>> getObjectsforDropdown()
        {
            return await repo.getObjectsforDropdown();
        }
        public async Task<List<DataField>> getDataFieldforDropdown()
        {
            return await repo.getDataFieldforDropdown();
        }
    }
}
