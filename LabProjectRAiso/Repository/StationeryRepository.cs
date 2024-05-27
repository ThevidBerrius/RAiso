using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Repository
{
    public class StationeryRepository
    {
        static LocalDatabaseEntities db = DatabaseSingleton.GetInstance();
        public static void InsertStationery(MsStationery stationery)
        {
            db.MsStationeries.Add(stationery);
            db.SaveChanges();
        }

        public static List<MsStationery> GetAllStationery()
        {
            return (db.MsStationeries).ToList();
        }
    }
}