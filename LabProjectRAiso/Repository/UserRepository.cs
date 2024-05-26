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

        public static MsUser GetUser(String name, String password)
        {
            return (from x in db.MsUsers 
                    where x.UserName == name 
                    && x.UserPassword == password 
                    select x).FirstOrDefault();
        }

        public static MsUser GetUserByUsername(string username)
        {
            return (from x in db.MsUsers
                    where x.UserName == username
                    select x).FirstOrDefault();
        }

        public static void InsertUser(MsUser user)
        {
            db.MsUsers.Add(user);
            db.SaveChanges();
        }

        public static MsUser GetUserByUserName(String username)
        {
            return (from x in db.MsUsers
                    where x.UserName == username
                    select x).FirstOrDefault();
        }

        public static MsUser GetUserByUserId(String userID)
        {
            int ID = Convert.ToInt32(userID);
            return (from x in db.MsUsers
                    where x.UserID == ID
                    select x).FirstOrDefault();
        }
    }
}