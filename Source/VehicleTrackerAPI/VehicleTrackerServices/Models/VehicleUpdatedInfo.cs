using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTrackerServices.Models
{
    public class VehicleStatusUpdatedInfo
    {
        public string OmOrderId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Description { get; set; }
    }
}
