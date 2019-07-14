using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "1234";
            if (txtUsername.Text.ToString() != user || txtPassword.Text.ToString() != pass )
            {
                lblError.Text = "Username or password is incorrect!";
            }
            else
            {
                string returnUrl = Request.QueryString["ReturnUrl"];
                

               if (returnUrl == null) returnUrl = "~/home.aspx";
                Response.Redirect(returnUrl);
            }
           

        }
    }
}