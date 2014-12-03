using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace OnlineExchange
{
    public class Observer
    {


       public int Product_Id = 0;



        public void notify(int id)
        {
            Product_Id = id;
            var item_user_tuple = new List<Tuple<int, string>>();

            DBConnector db = new DBConnector();
            WishList wlc = new WishList();

            Product P_obj = new Product();

          

            P_obj = db.getProductDetails(Product_Id);

            item_user_tuple = wlc.getUsersFromWishlist(P_obj);

          
           
            


            


            db.Update(Product_Id, item_user_tuple);

           




        }
    }
}