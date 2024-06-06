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
    public partial class TransactionHistory : System.Web.UI.Page
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
            }
        }

        private void GVBind()
        {
            List<TransactionHeader> headers = TransactionController.GetAllHeader(Convert.ToInt32(Session["user"]));
            List<dynamic> data = new List<dynamic>();
            foreach (var header in headers)
            {
                MsUser user = UserController.GetUserByID((Session["user"]).ToString());
                data.Add(new
                {
                    TransactionID = header.TransactionID,
                    TransactionDate = header.TransactionDate.ToShortDateString(),
                    UserName = user.UserName,
                });
            }
            GV_History.DataSource = data;
            GV_History.DataBind();
        }

        protected void Btn_Detail_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            GridViewRow detailRow = (GridViewRow)button.NamingContainer;
            string transactionID = detailRow.Cells[0].Text;

            Response.Redirect("~/Views/Pages/Customer/TransactionDetails.aspx?id=" + transactionID);

        }
    }
}