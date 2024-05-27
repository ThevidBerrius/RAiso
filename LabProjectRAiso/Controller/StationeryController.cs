using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Controller
{
    public class StationeryController
    {
        public static string CheckInputName(String name)
        {
            string message = "";
            if(name == "")
            {
                message = "Stationery Name must Be Filled";
            }
            else if (name.Length <  3 || name.Length > 50)
            {
                message = "Name must be at range 3-50";
            }
            return message;
        }

        public static string CheckInputPrice(String price)
        {
            string message = "";
            if (price == "")
            {
                message = "Price must be filled";
            }
            else if (Convert.ToInt32(price) < 2000)
            {
                message = "Minimum Price is 2000";
            }
            return message;
        }

        public static String InputValidate(String name, String price)
        {
            String message = CheckInputName(name);
            if(message == "")
            {
                message = CheckInputPrice(price);
            }
            if(message == "")
            {
                message = "Success";
            }
            return message;
        }
    }
}