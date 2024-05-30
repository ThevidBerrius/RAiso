using LabProjectRAiso.Handler;
using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace LabProjectRAiso.Controller
{
    public class UserController
    {
        public static String UsernameValidate(String username)
        {
            string message = "";
            if (username == "")
            {
                message = "Username must not be empty";
            }
            return message;
        }

        public static String PasswordValidate(String password)
        {
            string message = "";
            if(password == "")
            {
                message = "Password must not be empty";
            }
            return message;
        }

        public static String LoginValidate(String username, String password)
        {
            string message = UsernameValidate(username);
            if(message == "")
            {
                message = PasswordValidate(password);
            }
            if(message == "")
            {
                message = UserHandler.LoginHandler(username, password);
            }
            return message;
        }

        public static String RegisterUsernameValidate(string username)
        {
            string message = "";
            if(username == "")
            {
                message = "Username must not be empty";
            }
            else if (username.Length < 5 || username.Length > 50)
            {
                message = "Username must at range 5-50 characters";
            }
            return message;
        }

        public static String RegisterDOBValidate(String DOB)
        {
            string message = "";
            if(DOB == "")
            {
                message = "Date Of Birth Must Be Filled";
            }
            else if ((DateTime.Now - DateTime.Parse(DOB)).TotalDays < 365)
            {
                message = "User must be at least 1 year";
            }
            return message;
        }

        public static String RegisterGenderValidate(string gender)
        {
            string message = "";
            if(gender == "")
            {
                message = "Gender must be selected";
            }
            return message;
        }

        public static String RegisterAddressValidate(string address)
        {
            string message = "";
            if(address == "")
            {
                message = "Address must not be empty";
            }
            return message;
        }

        public static String RegisterPasswordValidate (string password)
        {
            string message = "";
            if(password == "")
            {
                message = "Password must not be empty";
            }
            else if(!Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*[0-9])[a-zA-Z0-9]+$"))
            {
                message = "Password must be alphanumeric and contain at least one letter and one number";
            }
            return message;
        }

        public static String RegisterPhoneValidate (string phone)
        {
            string message = "";
            if(phone == "")
            {
                message = "Phone number must be filled";
            }
            return message;
        }

        public static String RegisterValidation(string name, String DOB, string gender, string address, string password, string phone)
        {
           string message = RegisterUsernameValidate(name);
            if(message == "")
            {
                message = RegisterDOBValidate(DOB);
            }
            if(message == "")
            {
                message = RegisterGenderValidate(gender);
            }
            if (message == "")
            {
                message = RegisterAddressValidate(address);
            }
            if (message == "")
            {
                message = RegisterPasswordValidate(password);
            }
            if (message == "")
            {
                message = RegisterPhoneValidate(phone);
            }
            if (message == "")
            {
                message = UserHandler.RegisterHandler(name);
            }
            return message;
        }

        public static void InsertUser(string username, DateTime DOB, string gender, string address, string password, string phone)
        {
            UserHandler.InsertHandler(username, DOB, gender, address, password, phone);
        }

        public static MsUser GetUserByUserName(String UserName)
        {
            return UserHandler.GetUserByUserName(UserName);
        }

        public static String GetUserRole(String userID)
        {
            return UserHandler.GetUserRole(userID);
        }

        public static MsUser GetUserByID(String UserID)
        {
            return UserHandler.GetUserByID(UserID);
        }

        public static String UpdateValidate(String UserName, String DOB, String gender, String address, String password, String phone, String nameBeforeUpdate)
        {
            string message = RegisterUsernameValidate(UserName);

            if(message == "")
            {
                message = RegisterDOBValidate(DOB);
            }
            if(message == "")
            {
                message = RegisterGenderValidate(gender);
            }
            if(message == "")
            {
                message = RegisterAddressValidate(address);
            }
            if(message == "")
            {
                message = RegisterPasswordValidate(password);
            }
            if (message == "")
            {
                message = RegisterPhoneValidate(phone);
            }
            if (message == "")
            {
                message = UserHandler.UpdateHandler(UserName, nameBeforeUpdate);
            }
            return message;
        }

        public static void UpdateUser(String UserName, DateTime DOB, String gender, String address, String password, String phone, int UserID)
        {
            UserHandler.UpdateUser(UserName, DOB, gender, address, password, phone, UserID);
        }
    }


}