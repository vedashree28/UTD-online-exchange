using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Sql;

namespace OnlineExchange.Home
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DBConnector db = new DBConnector();
                SqlConnection conn = db.OpenConnection();
                
                //======= Select Query.
                string cmdText = "SELECT * FROM User_Details where User_ID='" + Session["User_Name"]+"'" ;

                //====== Providning information to SQL command object about which query to 
                //====== execute and from where to get database connection information.
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Name_value.Text = dr[0].ToString() + " " + dr[1].ToString();
                    Emailaddress_value.Text = dr[2].ToString();
                    Address1_value.Text = dr[5].ToString();
                    Address2_value.Text = dr[6].ToString();
                    Phnumber_value.Text = dr[4].ToString();
                    profile_image.ImageUrl = "~/Home/" + dr[7].ToString();
                }
                dr.Close();
                conn.Close();
               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string f = FileUpload1.FileName;
            FileUpload1.PostedFile.SaveAs(Server.MapPath(f));
            profile_image.ImageUrl = f;
            Panel1.Visible = false;
            DBConnector db = new DBConnector();
            SqlConnection conn = db.OpenConnection();
           // string uid = Session["User_Name"].ToString();
            SqlCommand abc = new SqlCommand("Update User_Details Set img_path=@ige Where User_ID='" + Session["User_Name"] + "'", conn);


            abc.Parameters.Add("@ige", System.Data.SqlDbType.VarChar, 50).Value = f;


            abc.ExecuteNonQuery();
            conn.Close();
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
           
        }
    }
}