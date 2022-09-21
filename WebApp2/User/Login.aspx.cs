using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2.User
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                if (Session["ShoppingUser"] != null)
                {
                    Session["ShoppingUser"] = null;
                    Response.Redirect("../DisplayPage.aspx");
                }

        }

        protected void Login_btn_Click(object sender, EventArgs e)
        {
            string LoginID = WebConfigurationManager.AppSettings["UserLoginID"];
            string LoginPassword = WebConfigurationManager.AppSettings["UserPassword"];


            if (IdTextBox.Text == LoginID && PasswrodTextBox.Text == LoginPassword)
            {

                Session["ShoppingUser"] = "ShoppingUser";
                Response.Redirect("/User/ProductList.aspx");
            }

            else
            {

                lblError.Text = "Incorrect Login/Password";
            }

        }
    }
}