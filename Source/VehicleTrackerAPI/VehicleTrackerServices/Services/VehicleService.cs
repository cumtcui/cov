using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTrackerServices.Models;

namespace VehicleTrackerServices.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly List<OrderInfo> vehicleList = new List<OrderInfo>() {
            new OrderInfo(){ OMOrderId="18184607",
                ChassisNumber ="UD0001",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            },
            new OrderInfo(){ OMOrderId="18184606",
                ChassisNumber ="UD0002",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            },
            new OrderInfo(){ OMOrderId="18184605",
                ChassisNumber ="UD0001",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            },
            new OrderInfo(){ OMOrderId="18184606",
                ChassisNumber ="UD0003",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            },
            new OrderInfo(){ OMOrderId="18184606",
                ChassisNumber ="UD0004",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            },
            new OrderInfo(){ OMOrderId="18184606",
                ChassisNumber ="UD0005",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            },
            new OrderInfo(){ OMOrderId="18184606",
                ChassisNumber ="UD0006",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            },
            new OrderInfo(){ OMOrderId="18184606",
                ChassisNumber ="UD0007",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            },
            new OrderInfo(){ OMOrderId="18184606",
                ChassisNumber ="UD0008",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            },
            new OrderInfo(){ OMOrderId="18184606",
                ChassisNumber ="UD0009",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            },
            new OrderInfo(){ OMOrderId="18184606",
                ChassisNumber ="UD0010",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            },
            new OrderInfo(){ OMOrderId="18184606",
                ChassisNumber ="UD0011",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            },
            new OrderInfo(){ OMOrderId="18184606",
                ChassisNumber ="UD0012",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            },
            new OrderInfo(){ OMOrderId="18184606",
                ChassisNumber ="UD0013",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            },
            new OrderInfo(){ OMOrderId="18184606",
                ChassisNumber ="UD0014",
                CDBPartyId ="1880350525",
                CompanyName ="K&L Haulage Pty Ltd",
                Brand ="UD",
                LastChangeDate =new DateTime(2018, 10, 1),
                LastCancellationDate =new DateTime(2018, 10, 1),
                RDD = new DateTime(2018, 10, 1),
                CDD =new DateTime(2018, 10, 1),
                PlannedBuildDate =new DateTime(2018, 10, 1),
                OrderStatus ="20",
                ChassisType ="2",
                Vin ="",
                PlannedFirmPlanDate =new DateTime(2018, 10, 1),
                DeliverToLocationCode ="",
                DeliveryAddress ="48 McKenzie Ave Pottsville  ",
                Customer = new UserInfo{ CDBPartyId=""}
            }
        };

        private readonly List<VehicleStatusUpdatedInfo> vehicleStatusUpdatedInfoList = new List<VehicleStatusUpdatedInfo>()
        {
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184607", UpdatedDate=new DateTime(2018, 9, 1), Description="invoiced" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184607", UpdatedDate=new DateTime(2018, 8, 1), Description="Finished order processed" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184607", UpdatedDate=new DateTime(2018, 7, 1), Description="Invoiced all levels" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184607", UpdatedDate=new DateTime(2018, 6, 1), Description="Invoiced first level" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184607", UpdatedDate=new DateTime(2018, 5, 1), Description="Ready for invoicing" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184607", UpdatedDate=new DateTime(2018, 4, 1), Description="Under Production" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184607", UpdatedDate=new DateTime(2018, 3, 1), Description="Firm Planned" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184607", UpdatedDate=new DateTime(2018, 2, 1), Description="Under firm planning" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184607", UpdatedDate=new DateTime(2018, 1, 1), Description="Confirmed" },

            new VehicleStatusUpdatedInfo(){ OmOrderId="18184606", UpdatedDate=new DateTime(2018, 9, 1), Description="invoiced" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184606", UpdatedDate=new DateTime(2018, 8, 1), Description="Finished order processed" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184606", UpdatedDate=new DateTime(2018, 7, 1), Description="Invoiced all levels" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184606", UpdatedDate=new DateTime(2018, 6, 1), Description="Invoiced first level" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184606", UpdatedDate=new DateTime(2018, 5, 1), Description="Ready for invoicing" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184606", UpdatedDate=new DateTime(2018, 4, 1), Description="Under Production" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184606", UpdatedDate=new DateTime(2018, 3, 1), Description="Firm Planned" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184606", UpdatedDate=new DateTime(2018, 2, 1), Description="Under firm planning" },
            new VehicleStatusUpdatedInfo(){ OmOrderId="18184606", UpdatedDate=new DateTime(2018, 1, 1), Description="Confirmed" }
        };

        public List<OrderInfo> GetVehicleListByUser(UserInfo userInfo)
        {
            if (userInfo == null)
            {
                return null;
            }
            var result = vehicleList.FindAll(o => o.CDBPartyId == userInfo.CDBPartyId).ToList();

            return result;
        }

        public List<OrderInfo> GetVehicleListById(string id)
        {
            return vehicleList.FindAll(v => v.ChassisNumber == id || v.OMOrderId == id).ToList();
        }

        public OrderInfo GetVehicleDetailById(string id)
        {
            return vehicleList.FirstOrDefault(v => v.ChassisNumber == id || v.OMOrderId == id);
        }

        public List<OrderInfo> GetAllVehicles()
        {
            return vehicleList;
        }

        public List<VehicleStatusUpdatedInfo> GetVehicleUpdatedInformationByOrderId(string orderId)
        {
            return vehicleStatusUpdatedInfoList.FindAll(s => s.OmOrderId == orderId).ToList();
        }
    }
}
