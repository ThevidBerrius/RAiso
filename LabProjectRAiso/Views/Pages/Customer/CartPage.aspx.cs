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
    public partial class CartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    String role = UserController.GetUserRole(Session["user"].ToString());
                    if (!role.Equals("Customer"))
                    {
                        Response.Redirect("~/Views/Pages/Home.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Views/Pages/Home.aspx");
                }
                GVBind();
                List<Cart> carts = CartController.GetCarts(Convert.ToInt32(Session["user"]));
                
                if (carts.Count == 0) Btn_Checkout.Visible = false;
            }
        }

        private void GVBind()
        {
            List<Cart> carts = CartController.GetCarts(Convert.ToInt32(Session["user"]));

            List<dynamic> cartData = new List<dynamic>();  
            foreach (var cart in carts)
            {
                MsStationery stationery = StationeryController.GetStationery(cart.StationeryID);
                cartData.Add(new
                {
                    StationeryName = stationery.StationeryName,
                    StationeryPrice = stationery.StationeryPrice,
                    Quantity = cart.Quantity,
                });
            }
            GV_Cart.DataSource = cartData;
            GV_Cart.DataBind();
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}