using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace OnlineExchange.Registration
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string validYN;
            OESUser usr = new OESUser(txtEmail.Text, txtPassword.Text);
         validYN =   usr.CheckuserYN();
                        if (validYN == "Y")
                        {
                            Session["User_Name"] = txtEmail.Text.ToString();
                            Response.Redirect("~/Home/HomePage.aspx");

                        }
                        else

                        {
                            Response.Redirect("login.aspx");
                        }
        }
    }
}