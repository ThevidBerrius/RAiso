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
                        GV_Stationery.Columns[1].Visible = true;
                        Btn_Insert.Visible = true;
                    }
                    GetStationeryData();
                }
            }
        }

        protected void Btn_Insert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Pages/Admin/InsertStationery.aspx");
        }

        private void GetStationeryData()
        {
            GV_Stationery.DataSource = StationeryController.GetStationeryList();
            GV_Stationery.DataBind();
        }
    }
}