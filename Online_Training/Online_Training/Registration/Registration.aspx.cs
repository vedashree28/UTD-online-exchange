using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace OnlineExchange.Registration

{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OESUser usr = new OESUser(Fname.Text, Lname.Text, Phnumber.Text, txtaddress.Text, txtaddress2.Text, txtEmail.Text, txtPassword.Text, "blank_img.jpg");
            usr.AddOESUser();
        


            p1.Visible = false;
            p2.Visible = true;

        }
    }
}