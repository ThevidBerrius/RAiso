using LabProjectRAiso.Controller;
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
            if (Request.Cookies["userCookie"] != null)
            {
                Session["user"] = Request.Cookies["userCookie"].Value;
            }
            if (Session["user"] != null)
            {
                String role = UserController.GetUserRole(Session["user"].ToString());
                Btn_Login.Visible = false;
                Btn_Register.Visible = false;
                Btn_Profile.Visible = true;
                Btn_Logout.Visible = true;

                if (role.Equals("Admin"))
                {
                    Btn_Report.Visible = true;
                }

                else if (role.Equals("Customer"))
                {
                    Btn_Transaction.Visible = true;
                    Btn_Cart.Visible = true;
                }
            }
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
            // Not Created Yet Transaction Report Page
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
            Session.Clear();
            Session.Abandon();
            if (Request.Cookies["userCookie"] != null)
            {
                var cookie = new HttpCookie("userCookie");
                cookie.Expires = DateTime.Now.AddHours(-1);
                Response.Cookies.Add(cookie);
            }
            Response.Redirect("~/Views/Pages/Home.aspx");
        }
    }
}