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
                UserHandler.LoginHandler(username, password);
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

        public static String RegisterDOBValidate(DateTime DOB)
        {
            string message = "";
            if(DOB == DateTime.MinValue)
            {
                message = "Date of Birth is required";
            }
            else
            {
                if (DOB == DateTime.Now)
                {
                    message = "Date of birth cannot be in the future :D";
                }
                else
                {
                    int age = DateTime.Now.Year - DOB.Year;
                    if (DOB > DateTime.Now.AddYears(-age)) age--;
                    if (age < 1)
                    {
                        message = "You must be at least 1 year old";
                    }
                }
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

        public static String RegisterValidation(string name, DateTime DOB, string gender, string address, string password, string phone)
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
    }


}