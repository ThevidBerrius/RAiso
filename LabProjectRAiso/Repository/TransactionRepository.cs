using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Repository
{
    public class TransactionRepository
    {
        static LocalDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<TransactionHeader> GetAllHeader(int userID)
        {
            return (from x in db.TransactionHeaders
                    where x.UserID == userID
                    select x).ToList();
        }

        public static TransactionHeader GetHeader(int userID, int transactionID)
        {
            return (from x in db.TransactionHeaders
                    where x.UserID == userID
                    && x.TransactionID == transactionID
                    select x).FirstOrDefault();
        }

        public static TransactionDetail GetDetail(int transactionID)
        {
            return (from x in db.TransactionDetails
                    where x.TransactionID == transactionID
                    select x).FirstOrDefault();
        }
    }
}