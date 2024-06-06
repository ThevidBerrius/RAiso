using LabProjectRAiso.Factory;
using LabProjectRAiso.Model;
using LabProjectRAiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

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
            TransactionHeader header = CheckoutHeaderHandler(carts[0].UserID);
            TransactionRepository.InsertTransactionHeader(header);
            foreach (Cart cart in carts)
            {
                TransactionDetail detail = CheckoutDetailHandler(header.TransactionID, cart.StationeryID, cart.Quantity);
                TransactionRepository.InsertTransactionDetail(detail);
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

        public static List<TransactionHeader> GetDataReport()
        {
            return TransactionRepository.GetDataReport();
        }
        public static int GetGrandTotal(int transactionID)
        {
            int total = 0;
            int temp = 0;
            List<TransactionDetail> detail = TransactionRepository.GetDetail(transactionID);
            foreach(TransactionDetail details in detail)
            {
                MsStationery stationery = StationeryRepository.FindStationery(details.StationeryID);
                temp = stationery.StationeryPrice * details.Quantity;
                total += temp;
            }
            return total;
        }

        public static int GetSubTotal(int price, int quantity)
        {
            return price * quantity;
        }

    }
}