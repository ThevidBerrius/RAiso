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
    }
}