using LabProjectRAiso.Controller;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
                        GV_Stationery.Columns[3].Visible = true;
                        Btn_Insert.Visible = true;
                    }
                }
                GVBind();
            }
        }

        protected void Btn_Insert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Pages/Admin/InsertStationery.aspx");
        }

        private void GVBind()
        {
            GV_Stationery.DataSource = StationeryController.GetStationeryList();
            GV_Stationery.DataBind();
        }

        protected void GV_Stationery_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow DeleteRow = GV_Stationery.Rows[e.RowIndex];
            string stationeryID = StationeryController.GetIDByStationeryName(DeleteRow.Cells[0].Text).ToString();

            StationeryController.DeleteStationery(Convert.ToInt32(stationeryID));
            GVBind();
        }

        protected void GV_Stationery_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow SelectRow = GV_Stationery.SelectedRow;
            string stationeryID = StationeryController.GetIDByStationeryName(SelectRow.Cells[0].Text).ToString();
            Response.Redirect("~/Views/Pages/StationeryDetail.aspx?id=" + stationeryID); ;
        }

        protected void GV_Stationery_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow editRow = GV_Stationery.Rows[e.NewEditIndex];
            string stationeryID = StationeryController.GetIDByStationeryName(editRow.Cells[0].Text).ToString();

            Response.Redirect("~/Views/Pages/Admin/UpdateStationery.aspx?id=" + stationeryID);
            GVBind();
        }
    }
}