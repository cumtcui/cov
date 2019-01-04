using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTrackerServices.Models;

namespace VehicleTrackerServices.Services
{
    public interface IVehicleService
    {
        List<OrderInfo> GetVehicleListByUser(UserInfo userInfo);
        List<OrderInfo> GetVehicleListById(string id);
        OrderInfo GetVehicleDetailById(string id);
        List<OrderInfo> GetAllVehicles();
        List<VehicleStatusUpdatedInfo> GetVehicleUpdatedInformationByOrderId(string omOrderId);
    }
}
