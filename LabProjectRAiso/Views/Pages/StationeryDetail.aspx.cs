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
    public partial class StationeryDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    String role = UserController.GetUserRole(Session["user"].ToString());
                    if (role.Equals("Admin"))
                    {
                        TBox_Quantity.Visible = false;
                        Btn_Add.Visible = false;
                    }
                }
                else
                {
                    TBox_Quantity.Visible = false;
                    Btn_Add.Visible = false;
                }
                if (Request["id"] == null)
                {
                    Response.Redirect("~/Views/Pages/Home.aspx");
                }
                int id = Convert.ToInt32(Request["id"]);
                MsStationery stationery = StationeryController.GetStationery(id);

                TBox_Name.Text = stationery.StationeryName;
                TBox_Price.Text = stationery.StationeryPrice.ToString();
            }
        }

        protected void Btn_Add_Click(object sender, EventArgs e)
        {

        }
    }
}