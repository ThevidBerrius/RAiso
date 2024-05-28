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

        public static int GetStationeryIDByName(String name)
        {
            MsStationery stationery = StationeryRepository.GetStationery(name);
            return stationery.StationeryID;
        }

        public static void DeleteHandler(int id)
        {
            MsStationery stationery = StationeryRepository.FindStationery(id);
            StationeryRepository.DeleteStationery(stationery);
        }

        public static MsStationery GetStationeryByID(int id)
        {
            return StationeryRepository.FindStationery(id);
        }
    }
}