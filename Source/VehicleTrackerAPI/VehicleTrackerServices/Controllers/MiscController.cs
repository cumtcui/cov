using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleTrackerServices.Models;
using VehicleTrackerServices.Services;

namespace VehicleTrackerServices.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class MiscController : ControllerBase
    {
        private IMiscService _service;

        public MiscController(IMiscService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetOrderStatusList")]
        public ActionResult<IEnumerable<OrderStatus>> GetOrderStatusList()
        {
            var orderStatusList = _service.GetOrderStatusList();

            if (orderStatusList is null)
            {
                return NotFound();
            }

            return orderStatusList;
        }

        [HttpPost]
        [Route("GetVechicleLocation/{id}")]
        public ActionResult<IEnumerable<LocationInfo>> GetVechicleLocation(string id)
        {
            var locations = _service.GetVehicleLocations(id);
            if(locations == null)
            {
                return NotFound();
            }

            return locations;

        }
    }
}