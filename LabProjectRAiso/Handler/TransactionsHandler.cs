using LabProjectRAiso.Model;
using LabProjectRAiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Handler
{
    public class TransactionsHandler
    {
        public static List<TransactionHeader> GetAllHeader(int userID)
        {
            return TransactionRepository.GetAllHeader(userID);
        }

        public static TransactionHeader GetHeader(int userID, int transactionID)
        {
            return TransactionRepository.GetHeader(userID, transactionID);
        }

        public static TransactionDetail GetDetail(int transactionID)
        {
            return TransactionRepository.GetDetail(transactionID);
        }
    }
}