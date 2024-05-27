﻿using LabProjectRAiso.Controller;
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
                    GVBind();
                }
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
    }
}