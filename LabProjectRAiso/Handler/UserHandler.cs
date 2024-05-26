using LabProjectRAiso.Factory;
using LabProjectRAiso.Model;
using LabProjectRAiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Handler
{
    public class UserHandler
    {
        public static String LoginHandler(String username, String password)
        {
            MsUser user = UserRepository.GetUser(username, password);
            return user != null ? "Success" : "Incorrect username or password!";
        }

        public static String RegisterHandler(String username)
        {
            MsUser user = UserRepository.GetUserByUsername(username);
            return user != null ? "Success" : "Username already used";
        }

        public static void InsertHandler (String username, DateTime DOB, String gender, String address, String password, String phone)
        {
            MsUser user = MsUserFactory.CreateMsUser(username, gender, DOB, phone, address, password, "Customer");
            UserRepository.InsertUser(user);
        }
    }
}