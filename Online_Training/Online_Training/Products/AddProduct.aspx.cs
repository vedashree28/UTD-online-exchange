using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;


namespace OnlineExchange.Products
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            FillCategory();

            
        }

        private void FillCategory()
        {

            DataTable subjects = new DataTable();
            DBConnector db = new DBConnector();
            using (SqlConnection con = db.OpenConnection())
            {

                try
                {
                    dropCtegory.Items.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from Product_Category", con);
                    adapter.Fill(subjects);

                    dropCtegory.DataSource = subjects;
                    dropCtegory.DataTextField = "Category_Name";
                    dropCtegory.DataValueField = "Category_Id";
                    dropCtegory.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle the error
                }

            }

           
            dropCtegory.Items.Insert(0, new ListItem("Please Select. . .", "none"));




        }

        public void FillSubCategory(string DDL)
        {
            DataTable subjects = new DataTable();
            DBConnector db = new DBConnector();
            ContentPlaceHolder MainContent = Page.Master.FindControl("MainContent") as ContentPlaceHolder;
            DropDownList myControl1 = (DropDownList)MainContent.FindControl(DDL);

            using (SqlConnection con = db.OpenConnection())
            {

                try
                {

                    myControl1.Items.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from Product_subcategory where Category_Id='" + dropCtegory.SelectedValue.ToString()+"'", con);
                    adapter.Fill(subjects);
                   
                    myControl1.DataSource = subjects;
                    myControl1.DataTextField = "SubCategory_Name";
                    myControl1.DataValueField = "SubCategory_Id";
                    myControl1.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle the error
                }

            }


            myControl1.Items.Insert(0, new ListItem("Please Select. . .", "none"));

        }

        protected void dropCtegory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropCtegory.SelectedValue == "1")
            {
                HAppliances.Visible = false;
                pnlMobileTablets.Visible = false;
                book.Visible = true;
                GENERAL.Visible = true;
                buttons_pnl.Visible = true;
                FillSubCategory("ddlbooktype");
            }
            else if (dropCtegory.SelectedValue == "2")
            {
                HAppliances.Visible = true;
                pnlMobileTablets.Visible = false;
                book.Visible = false;
                GENERAL.Visible = true;
                buttons_pnl.Visible = true;
                FillSubCategory("ddlhtype");
            }
            else if (dropCtegory.SelectedValue == "3")
            {
                pnlMobileTablets.Visible = true;
                HAppliances.Visible = false;
                book.Visible = false;
                GENERAL.Visible = true;
                buttons_pnl.Visible = true;
                FillSubCategory("ddlMtype");
            }
            else
            {
                pnlMobileTablets.Visible = false;
                HAppliances.Visible = false;
                book.Visible = false;
                GENERAL.Visible = true;
                buttons_pnl.Visible = true;
            }
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string product_specifications = "";
            Random rnd = new Random();
            int r = rnd.Next(1, 1000);

            string f = FileUpload1.FileName;
            string filename = Path.GetFileNameWithoutExtension(f);
            filename = filename + r.ToString();
            string ext = Path.GetExtension(f);
            string fullname = filename + ext;
            int scatid = 0;

            FileUpload1.PostedFile.SaveAs(Server.MapPath(@"~\Products\images\" + fullname));
 
            if (dropCtegory.SelectedValue == "1")
            {
                    product_specifications = txtbtitle.Text + "|" + txtAuthor.Text;
                    scatid = Convert.ToInt32(  ddlbooktype.SelectedValue);
 
            }
            else if (dropCtegory.SelectedValue == "2")
            {
                product_specifications = txtBrand.Text + "|" + txtyr.Text;
               scatid = Convert.ToInt32(ddlhtype.SelectedValue);
            }
            else if (dropCtegory.SelectedValue == "3")
            {
                product_specifications = txtmodel.Text + "|" + txtOS.Text;
                scatid = Convert.ToInt32(ddlMtype.SelectedValue);
            }

            Product p = new Product(Product_Name.Text, Product_desc.Value, Convert.ToInt32(Product_cost.Text), product_specifications,fullname, "Y", Convert.ToInt32(dropCtegory.SelectedValue), scatid);
            
            string closeAndRefreshScript = @"<script type='text/javascript'>                                    
             window.opener.location.reload();
             window.close();
             </script>";
            base.Response.Write(closeAndRefreshScript);
            //ScriptManager.RegisterStartupScript(this, typeof(string), "Error", "<script language=javascript>window.opener.location.reload(true);self.close();</script>;", true);
        }
    }
}