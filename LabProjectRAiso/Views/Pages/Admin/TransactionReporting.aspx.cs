using LabProjectRAiso.Controller;
using LabProjectRAiso.Dataset;
using LabProjectRAiso.Model;
using LabProjectRAiso.Reports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Web;
using System;
using System.Linq;
using System.Web.UI;
using System.Collections.Generic;
using System.Data;

namespace LabProjectRAiso.Views.Pages.Admin
{
    public partial class TransactionReporting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    String role = UserController.GetUserRole(Session["user"].ToString());
                    if (!role.Equals("Admin"))
                    {
                        Response.Redirect("~/Views/Pages/Home.aspx");
                    }
                    else
                    {
                        Reporting();
                    }
                }
                else
                {
                    Response.Redirect("~/Views/Pages/Home.aspx");
                }
            }
            else
            {
                Reporting();
            }
        }

        private void Reporting()
        {
            var report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            var data = SetData(TransactionController.GetDataReport());
            report.SetDataSource(data);
        }

        private ReportDataset SetData(List<TransactionHeader> header)
        {
            var dataset = new ReportDataset();
            var headers = dataset.Transactions;
            var detail = dataset.TransactionDetail;

            foreach(TransactionHeader head in header)
            {
                var newHeader = headers.NewRow();
                newHeader["TransactionID"] = head.TransactionID;
                newHeader["UserID"] = head.UserID;
                newHeader["TransactionDate"] = head.TransactionDate;
                newHeader["GrandTotalValue"] = TransactionController.GetGrandTotal(head.TransactionID);
                headers.Rows.Add(newHeader);

                foreach (TransactionDetail det in head.TransactionDetails)
                {
                    var newDetail = detail.NewRow();
                    MsStationery stationery = StationeryController.GetStationery(det.StationeryID);

                    newDetail["TransactionID"] = det.TransactionID;
                    newDetail["StationeryName"] = stationery.StationeryName;
                    newDetail["Quantity"] = det.Quantity;
                    newDetail["StationeryPrice"] = stationery.StationeryPrice;
                    newDetail["SubTotalValue"] = TransactionController.GetSubTotal(stationery.StationeryPrice, det.Quantity);

                    detail.Rows.Add(newDetail);
                }
            }
            return dataset;
        }
    } 
}
