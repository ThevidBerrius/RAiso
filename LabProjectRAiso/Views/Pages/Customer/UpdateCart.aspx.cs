using LabProjectRAiso.Controller;
using LabProjectRAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabProjectRAiso.Views.Pages.Customer
{
    public partial class UpdateCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    String role = UserController.GetUserRole(Session["user"].ToString());
                    if (!role.Equals("Customer")) Response.Redirect("~/Views/Pages/Home.aspx");
                }
                else Response.Redirect("~/Views/Pages/Home.aspx");

                if (Request["stationeryID"] == null) Response.Redirect("~/Views/Pages/Home.aspx");
                else
                {
                    int stationeryID = Convert.ToInt32(Request["stationeryID"]);
                    MsStationery stationery = StationeryController.GetStationery(stationeryID);
                    Cart cart = CartController.GetCart(Convert.ToInt32(Session["user"]), stationeryID);

                    if (cart == null) Response.Redirect("~/Views/Pages/Customer/CartPage.aspx");

                    TBox_Name.Text = stationery.StationeryName;
                    TBox_Price.Text = stationery.StationeryPrice.ToString();
                }
            }
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            Lbl_Error.Text = StationeryController.addToCartValidate(TBox_Quantity.Text);
            if(Lbl_Error.Text == "")
            {
                Cart cart = CartController.GetCart(Convert.ToInt32(Session["user"]), Convert.ToInt32(Request["stationeryID"]));
                CartController.UpdateCart(cart, Convert.ToInt32(TBox_Quantity.Text));
                Lbl_Error.Text = "Success Update Cart";
                TBox_Quantity.Text = "";
            }
        }
    }
}