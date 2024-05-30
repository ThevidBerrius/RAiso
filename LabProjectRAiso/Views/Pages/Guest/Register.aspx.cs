using LabProjectRAiso.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabProjectRAiso.Views.Pages.Guest
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null || Request.Cookies["userCookie"] != null)
            {
                Response.Redirect("~/Views/Pages/Home.aspx");
            }
        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            string name = TBox_Name.Text;
            string DOB = TBox_DOB.Text;
            string gender = Radio_Male.Checked ? "Male" : Radio_Female.Checked ? "Female" : "";
            string address = TBox_Address.Text;
            string password = TBox_Password.Text;
            string phone = TBox_Phone.Text;

            Lbl_Status.Text  = UserController.RegisterValidation(name, DOB, gender, address, password, phone);
            if (Lbl_Status.Text.Equals("Success"))
            {
                UserController.InsertUser(name, DateTime.Parse(DOB), gender, address, password, phone);
                Response.Redirect("~/Views/Pages/Home.aspx");
            }

        }
    }
}