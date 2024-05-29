using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabProjectRAiso.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader CreateTransactionHeader(int UserID, DateTime TransactionDate)
        {
            TransactionHeader transactionHeader = new TransactionHeader()
            {
                UserID = UserID,
                TransactionDate = TransactionDate
            };
            return transactionHeader;
        }
    }
}