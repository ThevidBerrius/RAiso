using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

        public static List<TransactionDetail> GetDetail(int transactionID)
        {
            return (from x in db.TransactionDetails
                    where x.TransactionID == transactionID
                    select x).ToList();
        }

        public static void InsertTransactionHeader(TransactionHeader header)
        {
            db.TransactionHeaders.Add(header);
            db.SaveChanges();
        }

        public static void InsertTransactionDetail(TransactionDetail detail)
        {
            db.TransactionDetails.Add(detail);
            db.SaveChanges();
        }

        public static List<TransactionDetail> GetDetailByStationeryID(int stationeryID)
        {
            return (from x in db.TransactionDetails
                    where x.StationeryID == stationeryID
                    select x).ToList();
        }

        public static void DeleteHeader(int TransactionID)
        {
            TransactionHeader header = db.TransactionHeaders.Find(TransactionID);
            db.TransactionHeaders.Remove(header);
            db.SaveChanges();
        }


        public static void DeleteDetail(TransactionDetail detail)
        {
            db.TransactionDetails.Remove(detail);
            DeleteHeader(detail.TransactionID);
            db.SaveChanges();
        }

        public static List<TransactionHeader> GetAllTransactions()
        {
            var allTransactions = db.TransactionHeaders
                .Include("TransactionDetails")
                .Include("MsStationery")
                .ToList();

            return allTransactions;
        }
    }
}