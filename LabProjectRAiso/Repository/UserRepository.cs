using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Repository
{
    public class UserRepository
    {
        private static LocalDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static MsUser GetUser(string username, string password)
        {
            return (from x in db.MsUsers
                    where x.UserName == username
                    && x.UserPassword == password
                    select x).FirstOrDefault();
        }
    }
}