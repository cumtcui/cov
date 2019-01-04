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
    public class VehicleController : ControllerBase
    {
        IVehicleService _service;

        public VehicleController(IVehicleService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public ActionResult<List<OrderInfo>> GetVehicleListById(string id)
        {
            return _service.GetVehicleListById(id);
        }

        [HttpGet]
        [Route("GetVehicleDetail")]
        public ActionResult<OrderInfo> GetVehicleDetailById([FromQuery]string omOrderId)
        {
            return _service.GetVehicleDetailById(omOrderId);
        }

        [HttpGet]
        public List<OrderInfo> GetAllVehicles()
        {
            return _service.GetAllVehicles();
        }

        [HttpGet]
        [Route("GetVehicleListByUser")]
        public List<OrderInfo> GetVehicleListByUser([FromQuery]UserInfo userInfo)
        {
            return _service.GetVehicleListByUser(userInfo);
        }

        [HttpGet]
        [Route("GetVehicleStatusUpdate")]
        public List<VehicleStatusUpdatedInfo> GetVehicleUpdatedInformationByOrderId([FromQuery]string omOrderId)
        {
            return _service.GetVehicleUpdatedInformationByOrderId(omOrderId);
        }
    }
}