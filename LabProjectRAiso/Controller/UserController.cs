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
                message = "Username must not empty";
            }
            return message;
        }
    }
}