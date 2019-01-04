using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTrackerServices.Models
{
    public class OrderStatus
    {
        public int StatusCode { get; set; }
        public string Status { get; set; }
        public bool IsAvailable { get; set; }
    }
}
