using LabProjectRAiso.Handler;
using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Controller
{
    public class TransactionController
    {
        public static List<TransactionHeader> GetAllHeader(int userID)
        {
            return Handler.TransactionHandler.GetAllHeader(userID);
        }

        public static TransactionHeader GetHeader(int userID, int transactionID)
        {
            return Handler.TransactionHandler.GetHeader(userID, transactionID);
        }

        public static TransactionDetail GetDetail(int transactionID)
        {
            return Handler.TransactionHandler.GetDetail(transactionID);
        }
    }
}