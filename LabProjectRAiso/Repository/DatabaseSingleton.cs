using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Repository
{
    public class DatabaseSingleton
    {
        private static LocalDatabaseEntities db  = null;

        public static LocalDatabaseEntities GetInstance()
        {
            if (db == null)
            {
                db = new LocalDatabaseEntities();
            }
            return db;
        }
    }
}