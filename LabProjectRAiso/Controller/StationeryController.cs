using LabProjectRAiso.Handler;
using LabProjectRAiso.Model;
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

        public static void InsertStationery(String name, int price)
        {
            StationeryHandler.InsertHandler(name, price);
        }

        public static List<MsStationery> GetStationeryList()
        {
            return StationeryHandler.GetStationeriesData();
        }

        public static int GetIDByStationeryName(String name)
        {
            return StationeryHandler.GetStationeryIDByName(name);
        }

        public static void DeleteStationery(int id)
        {
            StationeryHandler.DeleteHandler(id);
        }

        public static MsStationery GetStationery(int id)
        {
            return StationeryHandler.GetStationeryByID(id);
        }
    }
}