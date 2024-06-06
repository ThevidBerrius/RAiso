using LabProjectRAiso.Handler;
using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Controller
{
    public class TransactionController
    {
        public static List<TransactionHeader> GetAllHeader(int userID)
        {
            return TransactionsHandler.GetAllHeader(userID);
        }

        public static TransactionHeader GetHeader(int userID, int transactionID)
        {
            return TransactionsHandler.GetHeader(userID, transactionID);
        }

        public static TransactionDetail GetDetail(int transactionID)
        {
            return TransactionsHandler.GetDetail(transactionID);
        }

        public static List<TransactionHeader> GetAllTransaction()
        {
            return TransactionsHandler.GetAllTransactions();
        }
    }
}