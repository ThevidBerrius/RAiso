using LabProjectRAiso.Factory;
using LabProjectRAiso.Model;
using LabProjectRAiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Handler
{
    public class StationeryHandler
    {
        public static void InsertHandler(String name, int price)
        {
            MsStationery msStationery = MsStationeryFactory.CreateMsStationery(name, price);
            StationeryRepository.InsertStationery(msStationery);
        }

        public static List<MsStationery> GetStationeriesData()
        {
            return StationeryRepository.GetAllStationery();
        }
    }
}