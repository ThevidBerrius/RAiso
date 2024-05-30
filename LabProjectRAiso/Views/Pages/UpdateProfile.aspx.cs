using LabProjectRAiso.Controller;
using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabProjectRAiso.Views.Pages
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        static String nameBeforeUpdated;
        static int UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["userCookie"] == null)
            {
                Response.Redirect("~/Views/Pages/Home.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    string userID = Session["user"].ToString();
                    MsUser user = UserController.GetUserByID(userID);

                    TBox_Name.Text = user.UserName;
                    TBox_DOB.Text = user.UserDOB.ToString("yyyy-MM-dd");

                    if (user.UserGender.Equals("Male"))
                    {
                        Radio_Male.Checked = true;
                    }
                    else
                    {
                        Radio_Female.Checked = true;
                    }

                    TBox_Address.Text = user.UserAddress;
                    TBox_Password.Text = user.UserPassword;
                    TBox_Phone.Text = user.UserPhone;
                    nameBeforeUpdated = user.UserName;
                    UserID = user.UserID;
                }
            }
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            string name = TBox_Name.Text;
            string dob = TBox_DOB.Text;
            string gender = (Radio_Male.Checked) ? "Male" : (Radio_Female.Checked) ? "Female" : "";
            string address = TBox_Address.Text;
            string password = TBox_Password.Text;
            string phone = TBox_Phone.Text;
            
            Lbl_Error.Text = UserController.UpdateValidate(name, dob, gender, address, password, phone, nameBeforeUpdated);
            if(Lbl_Error.Text == "Success")
            {
                UserController.UpdateUser(name, DateTime.Parse(dob), gender, address, password, phone, UserID);
                Lbl_Error.Text = "Success Updated Profile";
            }
        }
    }
}