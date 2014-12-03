using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace OnlineExchange.Registration
{
    public partial class Search_Product_guest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
                FillDropdown();


        }

        public void FillDropdown()
        {

            DBConnector DB = new DBConnector();
            SqlConnection SqlCnn = DB.OpenConnection();
            SqlCommand SqlCmd = new SqlCommand("select * from Product_category ", SqlCnn);
            SqlDataAdapter SqlAd1 = new SqlDataAdapter(SqlCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            SqlAd1.Fill(dt);
            ddltype.DataTextField = "Category_Name";
            ddltype.DataValueField = "Category_Id";
            ddltype.DataSource = dt;
            ddltype.DataBind();
            DB.closeConnection();
        }

        protected void bindRepeater(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                repEmployeeDetails.DataSource = dt;
                repEmployeeDetails.DataBind();
                pnl1.Visible = true;
                nores.Visible = false;
               
            }
            else
            {
                pnl1.Visible = false;
                nores.Visible = true;
               
            }
        }


        protected void SubmitSearch_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            DataTable dt = p.SearchPro(querytext.Text, Convert.ToInt32(ddltype.SelectedValue));
            bindRepeater(dt);
        }

       
    }
}