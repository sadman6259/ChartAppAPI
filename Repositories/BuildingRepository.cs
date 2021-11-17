using BuildingAppSample.DTO;
using BuildingAppSample.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingAppSample.Repositories
{
    public class BuildingRepository
    {
        private DbContext context = null;
        public BuildingRepository(DbContext context)
        {
            this.context = context;
            this.context.Database.SetCommandTimeout(240);

        }
        public async Task<List<BuildingDTO>> getBuildings(int BuildingId, int ObjectId, int DataFieldId, DateTime Fromdate, DateTime ToDate)
        {
            var result = await this.context.Set<BuildingDTO>().FromSqlRaw("exec getBuildingsforChart @BuildingId,@ObjectId,@DataFieldId,@Fromdate,@ToDate",
                new SqlParameter("@BuildingId", BuildingId), new SqlParameter("@ObjectId", ObjectId)
                , new SqlParameter("@DataFieldId", DataFieldId), new SqlParameter("@Fromdate", Fromdate)
                , new SqlParameter("@ToDate", ToDate)).ToListAsync();
            return result;
        }
        public async Task<List<Building>> getBuildingsforDropdown()
        {
            IQueryable<Building> queryable = this.context.Set<Building>().Select(x => x);

            var res = await Task.FromResult(queryable.ToList());
            return res;

        }
        public async Task<List<BuildingAppSample.Models.Object>> getObjectsforDropdown()
        {
            IQueryable<BuildingAppSample.Models.Object> queryable = this.context.Set<BuildingAppSample.Models.Object>().Select(x => x);

            var res = await Task.FromResult(queryable.ToList());
            return res;

        }
        public async Task<List<DataField>> getDataFieldforDropdown()
        {
            IQueryable<DataField> queryable = this.context.Set<DataField>().Select(x => x);

            var res = await Task.FromResult(queryable.ToList());
            return res;

        }
    }
}
