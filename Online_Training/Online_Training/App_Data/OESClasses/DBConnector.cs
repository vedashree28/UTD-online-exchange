using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace OnlineExchange
{
    public class DBConnector
    {
        string cs = ConfigurationManager.ConnectionStrings["Connection1"].ConnectionString;
        SqlConnection myconnection = new SqlConnection();

        public SqlConnection OpenConnection()
        {

            myconnection.ConnectionString = cs;
            try
            {
                myconnection.Open();
                return myconnection;
            }

            catch
            {
                return myconnection;
            }
        }
        public void closeConnection()
        {
            if (myconnection != null)
            {
                myconnection.Close();
            }
        }

        public void InsertUserDetails(OESUser usr)
        {

            SqlConnection conn = this.OpenConnection();
            SqlCommand cmd = new SqlCommand("dbo.insertUser", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.Add("@FIRST_NAME", System.Data.SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Second_Name", System.Data.SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@User_ID", System.Data.SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Phone_number", System.Data.SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Address_line1", System.Data.SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Address_line2", System.Data.SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@img_path", System.Data.SqlDbType.VarChar, 100);


            cmd.Parameters["@FIRST_NAME"].Value = usr.FirstName;
            cmd.Parameters["@Second_Name"].Value = usr.LastName;
            cmd.Parameters["@User_ID"].Value = usr.UserID;
            cmd.Parameters["@Password"].Value = usr.Password;
            cmd.Parameters["@Phone_number"].Value = usr.PhoneNumber;
            cmd.Parameters["@Address_line1"].Value = usr.AddressLine1;
            cmd.Parameters["@Address_line2"].Value = usr.AddressLine2;
            cmd.Parameters["@img_path"].Value = usr.img_path;

            cmd.ExecuteNonQuery();
            conn.Close();


        }
        public string CheckLogin(OESUser usr)
        {

            SqlConnection conn = this.OpenConnection();
            SqlCommand cmd = new SqlCommand("dbo.ChkLogin", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@validYN", SqlDbType.Char, 1));


            cmd.Parameters["@validYN"].Direction = ParameterDirection.Output;
            cmd.Parameters["@UserName"].Value = usr.UserID;
            cmd.Parameters["@Password"].Value = usr.Password;
            cmd.ExecuteNonQuery();
            string validYN = cmd.Parameters["@validYN"].Value.ToString();
            conn.Close();
            return validYN;

        }

        public int SaveProductDetails(Product p)
        {
            SqlConnection conn = this.OpenConnection();
            SqlCommand cmd = new SqlCommand("dbo.InsertProduct", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Prod_name", SqlDbType.VarChar, 250));
            cmd.Parameters.Add(new SqlParameter("@Prod_desc", SqlDbType.Text));
            cmd.Parameters.Add(new SqlParameter("@Prod_cost", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@prod_path", SqlDbType.VarChar, 255));
            cmd.Parameters.Add(new SqlParameter("@prod_catID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@prod_subCatID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@prod_specification", SqlDbType.Text));
            cmd.Parameters.Add(new SqlParameter("@prod_isAvailable", SqlDbType.VarChar, 1));
            cmd.Parameters.Add(new SqlParameter("@Prod_ID", SqlDbType.Int));



            cmd.Parameters["@Prod_ID"].Direction = ParameterDirection.Output;
            cmd.Parameters["@Prod_name"].Value = p.Product_name;
            cmd.Parameters["@Prod_desc"].Value = p.Product_desc;
            cmd.Parameters["@Prod_cost"].Value = p.Product_cost;
            cmd.Parameters["@prod_path"].Value = p.Produc_path;
            cmd.Parameters["@prod_catID"].Value = p.CatID;
            cmd.Parameters["@prod_subCatID"].Value = p.subCatID;
            cmd.Parameters["@prod_specification"].Value = p.Product_specification;
            cmd.Parameters["@prod_isAvailable"].Value = p.Product_isAvaliable;

            cmd.ExecuteNonQuery();
            int P_id = Convert.ToInt32(cmd.Parameters["@Prod_ID"].Value);
            conn.Close();
            return P_id;


        }

        public int SaveAdDetails(AD A)
        {
            SqlConnection conn = this.OpenConnection();
            SqlCommand cmd = new SqlCommand("dbo.InsertAD", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@User_ID", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@P_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@AD_ID", SqlDbType.Int));


            cmd.Parameters["@AD_ID"].Direction = ParameterDirection.Output;
            cmd.Parameters["@User_ID"].Value = A.User_ID;
            cmd.Parameters["@P_ID"].Value = A.P_ID;
            cmd.ExecuteNonQuery();
            int AD_ID = Convert.ToInt32(cmd.Parameters["@AD_ID"].Value);
            conn.Close();
            return AD_ID;

        }

        public void CloseAD(int A_ID)
        {

            SqlConnection conn = this.OpenConnection();
            SqlCommand cmd = new SqlCommand("dbo.CloseAD", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@A_ID", SqlDbType.Int));
            cmd.Parameters["@A_ID"].Value = A_ID;
            cmd.ExecuteNonQuery();
            conn.Close();

        }



        public DataTable SearchProduct(string QueryText, int Cat)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = this.OpenConnection();
            SqlCommand cmd = new SqlCommand("dbo.searchProduct", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@searchString", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@category", SqlDbType.VarChar, 50));
            cmd.Parameters["@searchString"].Value = QueryText;
            cmd.Parameters["@category"].Value = Cat;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }

        //call from Observer Class
        public Product getProductDetails(int Product_Id)
        {
            Product pobj = new Product();
            SqlConnection conn = this.OpenConnection();

            SqlCommand cmd = new SqlCommand("dbo.viewProduct", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@p_id", SqlDbType.Int));
            cmd.Parameters["@p_id"].Value = Product_Id;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pobj.Product_name = dr[4].ToString();
                pobj.Product_specification = dr[7].ToString();
                // pobj.Product_cost = Convert.ToInt32(dr[4].ToString());
                pobj.CatID = Convert.ToInt32(dr[0].ToString());
                pobj.subCatID = Convert.ToInt32(dr[1].ToString())
 ;
            }
            dr.Close();
            conn.Close();

            return pobj;
        }

        public List<Tuple<int, string>> getUsersFromWishlistDB(string Name, int category, int subcategory, string specification)
        {


            var user_items = new List<Tuple<int, string>>();
            SqlConnection conn = this.OpenConnection();

            SqlCommand cmd = new SqlCommand("dbo.getUsersFromWishlist", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@p_name", System.Data.SqlDbType.VarChar, 250));
            cmd.Parameters.Add(new SqlParameter("@p_specification", System.Data.SqlDbType.VarChar, 1000));
            cmd.Parameters.Add(new SqlParameter("@p_categoryID", System.Data.SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@p_subCategoryID", System.Data.SqlDbType.Int));





            cmd.Parameters["@p_name"].Value = Name;
            cmd.Parameters["@p_categoryID"].Value = category;
            cmd.Parameters["@p_subCategoryID"].Value = subcategory;
            cmd.Parameters["@p_specification"].Value = specification;
            SqlDataReader dr;
            int x;
            string y;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                x = Convert.ToInt32(dr[0].ToString());

                y = dr[1].ToString();
                user_items.Add(new Tuple<int, string>(x, y));
            }

            dr.Close();
            conn.Close();

            return user_items;
        }

        public void Update(int id, List<Tuple<int, string>> items_and_users)
        {
            SqlConnection conn = this.OpenConnection();


            for (int count = 0; count < items_and_users.Count; count++)
            {

                SqlCommand cmd = new SqlCommand("dbo.updateWishlist", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@p_id", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@item_id", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@user_id", System.Data.SqlDbType.VarChar, 50));


                cmd.Parameters["@p_id"].Value = id;
                cmd.Parameters["@item_id"].Value = items_and_users[count].Item1;
                cmd.Parameters["@user_id"].Value = items_and_users[count].Item2;
                cmd.ExecuteReader();

            }

            conn.Close();

        }

        public int InsertToWishList(WishList w)
        {
            SqlConnection conn = this.OpenConnection();

            SqlCommand cmd = new SqlCommand("dbo.insertWishlistItem", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@user_ID", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Item_Name", System.Data.SqlDbType.VarChar, 255));
            cmd.Parameters.Add(new SqlParameter("@ItemCategory_ID", System.Data.SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@ItemSubCategory_ID", System.Data.SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Item_Specification", System.Data.SqlDbType.Text));
            cmd.Parameters.Add(new SqlParameter("@is_fulfilled", System.Data.SqlDbType.VarChar, 1));
            cmd.Parameters.Add(new SqlParameter("@Item_ID", System.Data.SqlDbType.Int));


            cmd.Parameters["@Item_ID"].Direction = ParameterDirection.Output;
            cmd.Parameters["@user_ID"].Value = HttpContext.Current.Session["User_Name"];
            cmd.Parameters["@Item_Name"].Value = w.Item_Name;
            cmd.Parameters["@ItemCategory_ID"].Value = w.Item_CatID;
            cmd.Parameters["@ItemSubCategory_ID"].Value = w.item_SubCatID;
            cmd.Parameters["@Item_Specification"].Value = w.item_specification;
            cmd.Parameters["@is_fulfilled"].Value = "N";
            cmd.ExecuteNonQuery();
            int id = Convert.ToInt32(cmd.Parameters["@Item_ID"].Value.ToString());
            conn.Close();
            return id;


        }


        public DataTable GetCompareDetails(int Pid1, int Pid2, ref string ValidYN)
        {
           
            Int32 row_counter;
            
       
            DataTable dt = new DataTable();
            SqlConnection conn = this.OpenConnection();
            SqlCommand cmd = new SqlCommand("dbo.compareProduct", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pid1", SqlDbType.Int)).Value = Pid1;
            cmd.Parameters.Add(new SqlParameter("@pid2", SqlDbType.Int)).Value = Pid2;
            cmd.Parameters.Add(new SqlParameter("@validYN", SqlDbType.Char, 1));
            cmd.Parameters.Add(new SqlParameter("@row_counter", SqlDbType.Int, 1));
            cmd.Parameters["@validYN"].Direction = ParameterDirection.Output;
            cmd.Parameters["@row_counter"].Direction = ParameterDirection.Output;
            SqlDataReader row_read;
            row_read = cmd.ExecuteReader();
            row_read.Close();
            ValidYN = cmd.Parameters["@validYN"].Value.ToString();
            row_counter = Convert.ToInt32(cmd.Parameters["@row_counter"].Value);

            if (ValidYN == "Y" && row_counter > 0)
            {
                row_read = cmd.ExecuteReader();
               


                dt.Load(row_read);
            }
            row_read.Close();
            return dt;

        }
        public SqlDataReader GetprodDetails(int p_id)
        {
            DBConnector db = new DBConnector();
            SqlConnection conn = db.OpenConnection();
            SqlCommand cmd = new SqlCommand("dbo.viewProduct1", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_id", p_id);
            //cmd.Parameters[""].Direction = ParameterDirection.Output;
            SqlDataReader row_read;
            row_read = cmd.ExecuteReader();
            return row_read;
        }


        public SqlDataReader GetWishListItem(int item_id)
        {
        
         
            SqlConnection conn = this.OpenConnection();
            SqlCommand cmd = new SqlCommand("dbo.viewWishlistItems", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@item_id", item_id);
            SqlDataReader row_read;
            row_read = cmd.ExecuteReader();

            return row_read;
        }
    }
}