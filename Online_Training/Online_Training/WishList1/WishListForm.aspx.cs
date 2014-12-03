using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;




namespace OnlineExchange.WishList1
{
    public partial class WishListForm : System.Web.UI.Page
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


            string cmdText = "SELECT * FROM WishList_Items where user_ID='" + Session["User_Name"].ToString() + "' and isFulfilled='N' ";
            SqlCommand cmd = new SqlCommand(cmdText, conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable t = new DataTable();
           int count= adp.Fill(t);
           if (count > 0)
           {
               rptShowdata.DataSource = t;
               rptShowdata.DataBind();
           }
           else
               pnlshowdata.Visible = false;

            

            cmdText = "SELECT * FROM WishList_Items where user_ID='" + Session["User_Name"].ToString() + "' and isFulfilled='Y' ";
             cmd = new SqlCommand(cmdText, conn);

           adp = new SqlDataAdapter(cmd);
             t = new DataTable();
        count=    adp.Fill(t);
        if (count > 0)
        {
            Repeater1.DataSource = t;
            Repeater1.DataBind();
        }
        else
              Panel1.Visible = false;

           


            conn.Close();

        }
        protected string GetStatus(string status_id)
        {

            if (status_id == "1")
                return "Books";
            else if (status_id == "2")
                return "Electronic Appliances";
            else if (status_id == "3")
                return "Mobile";

            else
                return "";
        }

        

        protected void rptShowdata_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            }
    }
}