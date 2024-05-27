using LabProjectRAiso.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabProjectRAiso.Views.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    String UserRole = UserController.GetUserRole(Session["user"].ToString());
                    if (UserRole.Equals("Admin"))
                    {
                        Btn_Insert.Visible = true;
                    }
                }
            }
        }

        protected void Btn_Insert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Pages/Admin/InsertStationery.aspx");
        }
    }
}