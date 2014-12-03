using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace OnlineExchange
{
    public class Product
    {
        public string Product_name;
        public string Product_desc;
        public int Product_cost;
        public string Product_specification;
        public string Produc_path;
        public string Product_isAvaliable;
        public int CatID;
        public int subCatID;
        public int P_ID;
        public Product(string Pname, string Pdesc, int Pcost, string Pspecification, string Prod_path, string Isavaliable, int CatID, int subCatID)
        {
            this.Product_name = Pname;
            this.Product_desc = Pdesc;
            this.Product_cost = Pcost;
            this.Product_specification = Pspecification;
            this.Produc_path = Prod_path;
            this.CatID = CatID;
            this.subCatID = subCatID;
            this.Product_isAvaliable = Isavaliable;

           int A_ID= AddProduct(this);
           
        }
        public Product()
        {
        }
        public int AddProduct(Product p)
        {
            DBConnector Db=new DBConnector();

            int Product_ID = Db.SaveProductDetails(p);
            int AID = 0;
            if (Product_ID >= 0) 
            {
                p.P_ID = Product_ID;
                AD A = new AD(HttpContext.Current.Session["User_Name"].ToString(), Product_ID, ref AID);
                Observer o = new Observer();
                o.notify(Product_ID);
            }
           
           return AID;


        }

        public DataTable SearchPro(string QueryText, int cat)
        {
            DBConnector DB = new DBConnector();
          DataTable dt=  DB.SearchProduct(QueryText, cat);
          return dt;
        }

        public List<String> CompareProducts(int P_id1, int P_id2,ref string validYN)
        {

            var list1 = new List<String>();
            DBConnector db = new DBConnector();
            
            DataTable data = db.GetCompareDetails(P_id1, P_id2, ref validYN);

            
                foreach (DataRow row in data.Rows)
                {
                    foreach (DataColumn col in data.Columns)
                    {
                        String value = row[col].ToString();
                        list1.Add(value);
                    }
                }

                return list1;
            
        
        }
    }
}