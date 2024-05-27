using LabProjectRAiso.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabProjectRAiso.Views.Pages.Admin
{
    public partial class InsertStationery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Insert_Click(object sender, EventArgs e)
        {
            string name = TBox_Name.Text;
            string price  = TBox_Price.Text;

            Lbl_Error.Text =  StationeryController.InputValidate(name, price);
        }
    }
}