using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabProjectRAiso.Views.MasterPage
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Pages/Home.aspx");
        }

        protected void Btn_Cart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Pages/Customer/CartPage.aspx");
        }

        protected void Btn_Transaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Pages/Customer/TransactionHistory.aspx");
        }

        protected void Btn_Report_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Pages/Admin/TransactionReport.aspx");
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Pages/Guest/Login.aspx");
        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Pages/Guest/Register.aspx");
        }

        protected void Btn_Profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Pages/UpdateProfile.aspx");
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Pages/Home.aspx");
        }
    }
}