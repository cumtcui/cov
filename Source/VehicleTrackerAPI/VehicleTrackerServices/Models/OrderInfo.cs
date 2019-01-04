using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTrackerServices.Models
{
    public class OrderInfo
    {
        public string OMOrderId { get; set; }
        public string ChassisNumber { get; set; }
        public string CDBPartyId { get; set; }
        public string CompanyName { get; set; }
        public string Brand { get; set; }
        public DateTime LastChangeDate { get; set; }
        public DateTime LastCancellationDate { get; set; }
        public DateTime RDD { get; set; }
        public DateTime CDD { get; set; }
        public DateTime PlannedBuildDate { get; set; }
        public string OrderStatus { get; set; }
        public string ChassisType { get; set; }
        public string Vin { get; set; }
        public DateTime PlannedFirmPlanDate { get; set; }
        public string DeliverToLocationCode { get; set; } //A4D system
        public string DeliveryAddress { get; set; } // CTDI
        public UserInfo Customer { get; set; }
    }
}
