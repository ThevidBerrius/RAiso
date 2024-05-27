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

        public static MsStationery GetStationery(String name)
        {
            return (from x in db.MsStationeries
                    where x.StationeryName == name
                    select x).FirstOrDefault();
        }

        public static MsStationery FindStationery(int  id)
        {
            return db.MsStationeries.Find(id);
        }

        public static void DeleteStationery(MsStationery stationery)
        {
            db.MsStationeries.Remove(stationery);
            db.SaveChanges();
        }
    }
}