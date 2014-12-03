using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace OnlineExchange.PostAds
{
    public partial class PostAd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindRepeater();
            }
        }

        

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
        protected void bindRepeater()
        {
            DBConnector db = new DBConnector();
            SqlConnection conn = db.OpenConnection();


            string cmdText = "SELECT * FROM AD inner join Product on AD.P_ID=PRODUCT.P_ID where AD.User_ID='" + Session["User_Name"].ToString ()+"'";
            SqlCommand cmd = new SqlCommand(cmdText, conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable t = new DataTable();
            adp.Fill(t);
        
            rptShowdata.DataSource = t;

            rptShowdata.DataBind();
            conn.Close();
         
        }
        protected string GetStatus(string status_id)
        {

            if (status_id == "O")
                return "Open";
            else
                return "Closed";
        }

        protected void btnSave_Click1(object sender, EventArgs e)
        {
            

            Response.Redirect(Request.Url.PathAndQuery, true);
            bindRepeater();

        }

         protected void rptShowdata_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "close")
            {

                AD a = new AD();
                a.CloseAD( Convert.ToInt32( e.CommandArgument));




            }
            bindRepeater();
        }
    }
}