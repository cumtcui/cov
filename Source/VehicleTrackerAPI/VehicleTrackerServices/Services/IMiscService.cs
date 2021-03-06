﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTrackerServices.Models;

namespace VehicleTrackerServices.Services
{
    public interface IMiscService
    {
        List<OrderStatus> GetOrderStatusList();
        List<LocationInfo> GetVehicleLocations(string id);
    }
}
