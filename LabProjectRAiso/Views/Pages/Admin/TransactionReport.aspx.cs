using LabProjectRAiso.Controller;
using LabProjectRAiso.Dataset;
using LabProjectRAiso.Model;
using LabProjectRAiso.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabProjectRAiso.Views.Pages.Admin
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var report = new CrystalReport();
            var datasets = new ReportDataset();
            var header = datasets.Transactions;
            var detail = datasets.TransactionDetail;

            var transactions = TransactionController.GetAllTransaction();
            foreach ( var transaction in transactions )
            {
                var newHeader = header.NewRow();
                newHeader["TransactionID"] = transaction.TransactionID;
                newHeader["TransactionDate"] = transaction.TransactionDate;
                newHeader["UserID"] = transaction.UserID;
                newHeader["GrandTotalValue"] = transaction.
            }
        }
    }
}