using BuildingAppSample.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace BuildingAppSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IBuildingServices service;

        public BuildingController(IBuildingServices service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("~/api/get/buildings/{buildingid}/{objectid}/{datafieldid}/{fromdate}/{todate}")]
        public async Task<ActionResult> getBuildings(int BuildingId, int ObjectId, int DataFieldId, DateTime Fromdate, DateTime ToDate)
        {
            try
            {
                var data = await service.getBuildings(BuildingId, ObjectId, DataFieldId, Fromdate, ToDate);
                return Ok(data);
            }
            catch(Exception e)
            {
                throw e;
            }
          

        }

        [HttpGet]
        [Route("~/api/get/buildings/dropdownlist")]
        public async Task<ActionResult> getBuildingsforDropdown()
        {
            try
            {
                var data = await service.getBuildingsforDropdown();
                return Ok(data);
            }
            catch (Exception e)
            {
                throw e;
            }


        }
        [HttpGet]
        [Route("~/api/get/objects/dropdownlist")]
        public async Task<ActionResult> getObjectsforDropdown()
        {
            try
            {
                var data = await service.getObjectsforDropdown();
                return Ok(data);
            }
            catch (Exception e)
            {
                throw e;
            }


        }
        [HttpGet]
        [Route("~/api/get/datafields/dropdownlist")]
        public async Task<ActionResult> getDataFieldforDropdown()
        {
            try
            {
                var data = await service.getDataFieldforDropdown();
                return Ok(data);
            }
            catch (Exception e)
            {
                throw e;
            }


        }
    }
}
