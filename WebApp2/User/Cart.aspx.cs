using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp2.Bussiness_Layer;
using WebApp2.Data_Layer;
using WebApp2.User;

namespace WebApp2
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ShoppingUser"] == null)
            {
                Response.Redirect("~/User/Login.aspx");
            }
            
            
            DetailBL objread = new DetailBL();

            if (objread != null)
            {
                Dictionary<string, string> b = new Dictionary<string, string>(objread.GetDetails());
                GridView1.DataSource = b;
                GridView1.DataBind();

                lblTotal.Text = "Total Amount:" + objread.Total().ToString();
            }
            else {
                lblTotal.Text = "Error Please re-enter the amount in product page";
            }
                
        }
    }
}