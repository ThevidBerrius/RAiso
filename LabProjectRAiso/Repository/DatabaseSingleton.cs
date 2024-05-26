using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Repository
{
    public class DatabaseSingleton
    {
        private static LocalDatabaseEntities instance;

        public static LocalDatabaseEntities GetInstance()
        {
            if (instance == null)
            {
                instance = new LocalDatabaseEntities();
            }
            return instance;
        }
    }
}