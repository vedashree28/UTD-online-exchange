using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExchange
{
    public class WishList
    {
       public int Item_id;
       public int p_id;
       public string Item_Name;
       public int Item_CatID;
       public int item_SubCatID;
       public string item_specification;
       public string isfulfilled;
       public string User_id;

        public WishList(string Item_Name, int Item_CatID, int subcatId, string item_specification, string isfulfilled, string user_id)
        {

            DBConnector DB = new DBConnector();
            this.Item_Name = Item_Name;
            this.Item_CatID = Item_CatID;
            this.item_SubCatID = subcatId;
            this.item_specification = item_specification;
            this.isfulfilled = isfulfilled;
            this.User_id = user_id;

         int Item_ID=   DB.InsertToWishList(this);
        }
        public WishList()
        {
        }
        public List<Tuple<int, string>> getUsersFromWishlist(Product Pobj)
        {
          
            DBConnector db = new DBConnector();
           
            var item_user_list = new List<Tuple<int, string>>();


            item_user_list = db.getUsersFromWishlistDB(Pobj.Product_name, Pobj.CatID, Pobj.subCatID, Pobj.Product_specification);
           

            return item_user_list;
        }

    }
}