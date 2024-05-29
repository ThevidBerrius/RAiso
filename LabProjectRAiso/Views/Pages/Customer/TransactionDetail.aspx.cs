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
            if(!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    String role = UserController.GetUserRole(Session["user"].ToString());
                    if (!role.Equals("Customer")) Response.Redirect("~/Views/Pages/Home.aspx");
                    else
                    {
                        if (Request["id"] == null) Response.Redirect("~/Views/Pages/Home.aspx");
                        else
                        {
                            int userID = Convert.ToInt32(Session["user"]);
                            int transactionID = Convert.ToInt32(Request["id"]);
                            TransactionHeader header = TransactionController.GetHeader(userID, transactionID);

                            if (header == null)
                            {
                                Response.Redirect("~/Views/Pages/Home.aspx");
                            }

                        }
                    }
                }
                else Response.Redirect("~/Views/Pages/Home.aspx");
            }
        }
    }
}