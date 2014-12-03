using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace OnlineExchange
{
    public class OESUser
    {
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string AddressLine1;
        public string AddressLine2;
        public string UserID;
        public string img_path;
        public string Password;
        DBConnector db = new DBConnector();
        public OESUser(string FirstName,string LastName,string Phone,string AddressLine1,string AddressLine2,string UserId,string Password,string img_path)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = Phone;
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.UserID = UserId;
            this.img_path = img_path;
            this.Password = Password;
        }


        public OESUser()
        {
        }
        public OESUser(string UserId, string Password)
        {
            this.UserID = UserId;
            this.Password = Password;
        }
        public void AddOESUser()
        {
            
            db.InsertUserDetails(this);
            
        }
        public string CheckuserYN(){
          string res=  db.CheckLogin(this);
          return res;
           }

        public SqlDataReader ViewProduct(int P_id)
        {

            DBConnector db=new DBConnector();
            SqlDataReader rd = db.GetprodDetails(P_id);
            return rd;
        }

        public SqlDataReader ViewWishListItem(int Item_ID)
        {
             DBConnector db=new DBConnector();
             SqlDataReader rd = db.GetWishListItem(Item_ID);
            return rd;
        
        }

    }
}