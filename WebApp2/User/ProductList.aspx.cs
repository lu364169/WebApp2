using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using WebApp2.Bussiness_Layer;
using WebApp2.Data_Layer;
using static System.Net.Mime.MediaTypeNames;

namespace WebApp2
{   

    public partial class ProductList : System.Web.UI.Page
    {
        public Dictionary<string, string> cartlist = new Dictionary<string, string>();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["ShoppingUser"] == null)
            {

                Response.Redirect("~/User/Login.aspx");
            }
            

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            
            foreach (DataListItem item in DataList1.Items)
            {
                string value = (item.FindControl("TextId") as TextBox).Text;
                string name = (item.FindControl("FruitLabel") as Label).Text;
                cartlist.Add(name, value);
                
            }

            CartList a = new CartList();
            a.AddToCart(cartlist);

            Response.Redirect("~/User/Cart.aspx");
        }
    }
}