using LabProjectRAiso.Factory;
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

        public static List<TransactionDetail> GetDetail(int transactionID)
        {
            return TransactionRepository.GetDetail(transactionID);
        }

        public static void CheckoutItem(List<Cart> carts)
        {
            foreach (Cart cart in carts)
            {
                TransactionHeader header = CheckoutHeaderHandler(cart.UserID);
                TransactionDetail detail = CheckoutDetailHandler(header.TransactionID, cart.StationeryID, cart.Quantity);
                TransactionRepository.InsertTransaction(header, detail);
            }
        }

        public static TransactionHeader CheckoutHeaderHandler(int userID)
        {
            TransactionHeader header = TransactionHeaderFactory.CreateTransactionHeader(userID, DateTime.Now);
            return header;
        }

        public static TransactionDetail CheckoutDetailHandler(int transactionID, int stationeryID, int quantity)
        {
            TransactionDetail detail = TransactionDetailFactory.CreateTransactionDetail(transactionID, stationeryID, quantity);
            return detail;
        }

        public static List<TransactionHeader> GetAllTransactions()
        {
            return TransactionRepository.GetAllTransactions();
        }

    }
}