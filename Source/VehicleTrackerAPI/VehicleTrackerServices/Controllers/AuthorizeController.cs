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
    public class AuthorizeController : ControllerBase
    {

        private IAuthorizeService _service;
        private IVehicleService _vehicleService;

        public AuthorizeController(IVehicleService vehicleService, IAuthorizeService service)
        {
            _vehicleService = vehicleService;
            _service = service;
        }

        [HttpPost]
        [Route("GetListByUserId")]
        public ActionResult<IEnumerable<OrderInfo>> GetListByUserId([FromBody]UserInfo userInfo)
        {
            var vehicleList = _vehicleService.GetVehicleListByUser(userInfo);
            
            if(vehicleList == null)
            {
                return NotFound();
            }

            return vehicleList;
        }

        [HttpPost]
        public ActionResult<string> GetAuthentication([FromBody]LoginInfo login)
        {
            return _service.GetUserInfoByLogin(login);
        }

    }
}