using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTrackerServices.Models;

namespace VehicleTrackerServices.Services
{
    public class MiscService : IMiscService
    {
        public readonly List<OrderStatus> orderStatus = new List<OrderStatus>()
        {
            new OrderStatus { StatusCode =0, Status = "All", IsAvailable = true },
            new OrderStatus { StatusCode =-1, Status = "Tender Request Cancelled", IsAvailable = false },
            new OrderStatus { StatusCode =1, Status = "Created", IsAvailable = false  },
            new OrderStatus { StatusCode =2, Status = "Processing Started", IsAvailable = false  },
            new OrderStatus { StatusCode =5, Status = "Validated", IsAvailable = false  },
            new OrderStatus { StatusCode =10, Status = "Planned", IsAvailable = false  },
            new OrderStatus { StatusCode =15, Status = "Priced", IsAvailable = false  },
            new OrderStatus { StatusCode =20, Status = "Confirmed", IsAvailable = true  },
            new OrderStatus { StatusCode =26, Status = "To be firm planned next def run", IsAvailable = true },
            new OrderStatus { StatusCode =28, Status = "Under firm planning", IsAvailable = true },
            new OrderStatus { StatusCode =30, Status = "Firm Planned", IsAvailable = true },
            new OrderStatus { StatusCode =40, Status = "Ready off line", IsAvailable = true },
            new OrderStatus { StatusCode =45, Status = "Under Production", IsAvailable = true },
            new OrderStatus { StatusCode =50, Status = "Produced", IsAvailable = true },
            new OrderStatus { StatusCode =60, Status = "Ready for invoicing", IsAvailable = true },
            new OrderStatus { StatusCode =61, Status = "Cancelled not invoiced", IsAvailable = true },
            new OrderStatus { StatusCode =70, Status = "Invoiced first level", IsAvailable = true },
            new OrderStatus { StatusCode =80, Status = "Invoiced all levels", IsAvailable = true },
            new OrderStatus { StatusCode =90, Status = "Finished order processed", IsAvailable = true },
            new OrderStatus { StatusCode =91, Status = "Cancelled no invoice needed", IsAvailable = true },
            new OrderStatus { StatusCode =95, Status = "Moved to history", IsAvailable = true },
            new OrderStatus { StatusCode =98, Status = "Ready for deletion", IsAvailable = true }
        };

        public List<OrderStatus> GetOrderStatusList()
        {
            return orderStatus.FindAll(os => os.IsAvailable == true).ToList();
        }

        public List<LocationInfo> GetVehicleLocations(string id)
        {
            var locations = new List<LocationInfo>()
            {
                new LocationInfo{ ChassisNumber="1", OrderNumber="2", Longtitude=100.13m, Latitude=90.13m, Address="Tianjin"},
                new LocationInfo{ ChassisNumber="1", OrderNumber="2", Longtitude=100.13m, Latitude=90.13m, Address="Tianjin"},
                new LocationInfo{ ChassisNumber="1", OrderNumber="2", Longtitude=100.13m, Latitude=90.13m, Address="Tianjin"},
                new LocationInfo{ ChassisNumber="1", OrderNumber="2", Longtitude=100.13m, Latitude=90.13m, Address="Tianjin"},
                new LocationInfo{ ChassisNumber="1", OrderNumber="2", Longtitude=100.13m, Latitude=90.13m, Address="Tianjin"},
                new LocationInfo{ ChassisNumber="1", OrderNumber="2", Longtitude=100.13m, Latitude=90.13m, Address="Tianjin"},
                new LocationInfo{ ChassisNumber="1", OrderNumber="2", Longtitude=100.13m, Latitude=90.13m, Address="Tianjin"},
                new LocationInfo{ ChassisNumber="1", OrderNumber="2", Longtitude=100.13m, Latitude=90.13m, Address="Tianjin"},
                new LocationInfo{ ChassisNumber="1", OrderNumber="2", Longtitude=100.13m, Latitude=90.13m, Address="Tianjin"},
                new LocationInfo{ ChassisNumber="1", OrderNumber="2", Longtitude=100.13m, Latitude=90.13m, Address="Tianjin"},
                new LocationInfo{ ChassisNumber="1", OrderNumber="2", Longtitude=100.13m, Latitude=90.13m, Address="Tianjin"},
                new LocationInfo{ ChassisNumber="1", OrderNumber="2", Longtitude=100.13m, Latitude=90.13m, Address="Tianjin"}
            };

            return locations.FindAll(l => l.ChassisNumber == id || l.OrderNumber == id).ToList();
        }
    }
}
