using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExchange.WishList1
{
    public partial class ViewWishlistItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            int item_id = Convert.ToInt32(Request.QueryString["Pid"].ToString());
            ViewWishListItem(item_id);
        }

        public  void ViewWishListItem(int p)
        {

            OESUser usr = new OESUser();
            SqlDataReader row_read = usr.ViewWishListItem(p);
            while (row_read.Read())
            {
                Item_Name.Text = row_read[0].ToString();
                Item_Specification.Text = row_read[1].ToString();
                category_name.Text = row_read[2].ToString();
                subcategory_name.Text = row_read[3].ToString();
                
            }
             }
    }
}