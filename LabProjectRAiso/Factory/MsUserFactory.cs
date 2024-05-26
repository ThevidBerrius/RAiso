using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Factory
{
    public class MsUserFactory
    {
        public static MsUser CreateMsUser(string UserName, string UserGender, DateTime UserDOB, string UserPhone, string UserAddress, string UserPassword, string UserRole)
        {
            MsUser MsUser = new MsUser()
            {
                UserName = UserName,
                UserGender = UserGender,
                UserDOB = UserDOB,
                UserPhone = UserPhone,
                UserAddress = UserAddress,
                UserPassword = UserPassword,
                UserRole = UserRole
            };
            return MsUser;
        }
    }
}