using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace OnlineExchange.Products
{
    public partial class Search_Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(! IsPostBack)
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
                cmp.Visible = true;
            }
            else
            {
                pnl1.Visible = false;
                nores.Visible = true;
                cmp.Visible = false;
            }
        }


        protected void SubmitSearch_Click(object sender, EventArgs e)
        {
            Product p = new Product();
           DataTable dt= p.SearchPro(querytext.Text, Convert.ToInt32(ddltype.SelectedValue));
           bindRepeater(dt);
        }

        protected void cmpbutton_Click(object sender, EventArgs e)
        {

            int count = 0;
         int   j=0;
            string[] stringArray = new string[2];
            foreach (RepeaterItem i in repEmployeeDetails.Items)
       {

           CheckBox cb = (CheckBox)i.FindControl("slctProduct");
          if (cb.Checked)
          {
              count = count + 1;
             
          }
       }

            if (count != 2)
            {
                System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Choose 2 products');", true);
            }
            else
            {

                foreach (RepeaterItem i in repEmployeeDetails.Items)
                {

                    CheckBox cb = (CheckBox)i.FindControl("slctProduct");
                    if (cb.Checked)
                    {
                        Label hiddenEmail = (Label)i.FindControl("lblID");
                        stringArray[j] = hiddenEmail.Text;
                        j = j + 1;
                    }
                }
            


                string url = "Compare.aspx?Pid1=" + stringArray[0] + "&Pid2=" + stringArray[1];
                string s = "window.open('" + url + "', 'popup_window', 'width=600,height=600,left=100,top=100,resizable=yes');";
                ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
            }

            }

        protected void OpenWindow()
        {
            
        }
    }
}