using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExchange
{
    public class AD
    {
        public string User_ID;
        public int A_ID;
        public int P_ID;
        public string Status;

        public AD(string U_ID, int P_ID,ref int AID)
        {
            this.User_ID = U_ID;
            this.P_ID = P_ID;
            AID = InsertAD(this);
        }

        public AD()
        {
        }
        public int InsertAD(AD a)
        {
            DBConnector DB = new DBConnector();
            int A_ID = DB.SaveAdDetails(a);
            return A_ID;
        }

        public void  CloseAD(int A_ID)

        {
            DBConnector DB = new DBConnector();
            DB.CloseAD(A_ID);

        }
    }
}