using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["ShoppingUser"] == null)
                {
                    UserSession.Text = "Login";
                }
                else {
                    UserSession.Text = "Logout";
                }
            }
            catch
            {
                throw;
            }
        }
    }
}