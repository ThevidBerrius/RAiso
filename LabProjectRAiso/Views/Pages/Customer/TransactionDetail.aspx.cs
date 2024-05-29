using LabProjectRAiso.Controller;
using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabProjectRAiso.Views.Pages.Customer
{
    public partial class TransactionDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    if (Session["user"] != null)
            //    {
            //        String role = UserController.GetUserRole(Session["user"].ToString());
            //        if (!role.Equals("Customer")) Response.Redirect("~/Views/Pages/Home.aspx");
            //        else
            //        {
            //            if (Request["ID"] == null) Response.Redirect("~/Views/Pages/Home.aspx");
            //            else
            //            {
            //                int UserID = Convert.ToInt32(Session["user"]);
            //                int TransactionID = Convert.ToInt32(Request["id"]);
            //                TransactionHeader header = TransactionController.GetHeader(UserID, TransactionID);
            //                if (header == null) Response.Redirect("~/Views/Pages/Home.aspx");

            //                TransactionDetail detail = TransactionController.GetDetail(TransactionID);
            //                TBox_Name.Text = detail.MsStationery.StationeryName;
            //                TBox_Price.Text = detail.MsStationery.StationeryPrice.ToString();
            //                TBox_Quantity.Text = detail.Quantity.ToString();
            //            }
            //        }
            //    }
            //    else Response.Redirect("~/Views/Pages/Home.aspx");
            //}
        }
    }
}