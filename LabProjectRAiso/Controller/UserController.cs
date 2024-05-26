using LabProjectRAiso.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public static String LoginValidate(string username, String password)
        {
            string message = UsernameValidate(username);
            if(message == "")
            {
                message = PasswordValidate(password);
            }
           else if(message == "")
            {
                UserHandler.LoginHandler(username, password);
            }
            return message;
        }
    }
}