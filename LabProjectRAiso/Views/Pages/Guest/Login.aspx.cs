using LabProjectRAiso.Controller;
using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabProjectRAiso.Views.Pages.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null || Request.Cookies["userCookie"] != null)
            {
                Response.Redirect("~/Views/Pages/Home.aspx");
            }
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            string name = TBox_Name.Text;
            string password = TBox_Password.Text;
            Boolean isRemember = CBox_Remember.Checked;

            Lbl_Status.Text = UserController.LoginValidate(name, password);
            if(Lbl_Status.Text.Equals("Success"))
            {
                MsUser User = UserController.GetUserByUserName(name);
                Session["user"] = User.UserID;
                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("userCookie");
                    cookie.Value = User.UserID.ToString();
                    cookie.Expires = DateTime.Now.AddHours(1);

                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("~/Views/Pages/Home.aspx");
            }
        }
    }
}