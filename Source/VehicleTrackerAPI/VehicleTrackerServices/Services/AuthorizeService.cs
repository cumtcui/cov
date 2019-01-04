using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTrackerServices.Models;

namespace VehicleTrackerServices.Services
{
    public class AuthorizeService : IAuthorizeService
    {
        private readonly List<UserInfo> userInfoList = new List<UserInfo>() {
            new UserInfo{ CDBPartyId="1880350525", EmailAddress="kandlhaulage@outlook.com", CompanyName="K&L Haulage Pty Ltd", Mobile="0419626312", Pin="123"},
            new UserInfo{ CDBPartyId="3791291612", EmailAddress="danny@matictransport.com.au", CompanyName="Matic Transport", Mobile="0419249407", Pin="123"},
            new UserInfo{ CDBPartyId="5369026847", EmailAddress="jason_rigby@lowespetrol.com.au", CompanyName="Lowes Petroleum", Mobile="0409891737", Pin="123"},
            new UserInfo{ CDBPartyId="1812764332", EmailAddress="johnkellysons@westnet.com.au", CompanyName="John Kelly & Sons", Mobile="0418754382", Pin="123"},
            new UserInfo{ CDBPartyId="18175217", EmailAddress="lynne@halkitis.com.au", CompanyName="HB Concrete", Mobile="0418893050", Pin="123"}
        };

        public string GetUserInfoByLogin(LoginInfo login)
        {
            if (login == null)
            {
                return null;
            }

            return userInfoList.FirstOrDefault(u => (u.EmailAddress == login.LoginId || u.Mobile == login.LoginId) && u.Pin == login.Pin).CDBPartyId;
        }
    }
}
