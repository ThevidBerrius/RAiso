using LabProjectRAiso.Controller;
using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabProjectRAiso.Views.Pages.Admin
{
    public partial class UpdateStationery : System.Web.UI.Page
    {
        static string nameBeforeUpdated;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    String role = UserController.GetUserRole(Session["user"].ToString());
                    if (!role.Equals("Admin"))
                    {
                        Response.Redirect("~/Views/Pages/Home.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Views/Pages/Home.aspx");
                }
                if (Request["id"] == null)
                {
                    Response.Redirect("~/Views/Pages/Home.aspx");
                }

                int id = Convert.ToInt32(Request["id"]);
                MsStationery stationery = StationeryController.GetStationery(id);

                nameBeforeUpdated = stationery.StationeryName;
                TBox_Name.Text = stationery.StationeryName;
                TBox_Price.Text = stationery.StationeryPrice.ToString();
                
            }
        }

        protected void Btn_Insert_Click(object sender, EventArgs e)
        {
            string name = TBox_Name.Text;
            string price = TBox_Price.Text;

            Lbl_Error.Text = StationeryController.InputValidate(name, price);
            if (Lbl_Error.Text.Equals("Success"))
            {
                StationeryController.UpdateStationery(name, Convert.ToInt32(price), nameBeforeUpdated);
                Response.Redirect("~/Views/Pages/Home.aspx");
            }
        }
    }
}