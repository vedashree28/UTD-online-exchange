using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace OnlineExchange.Products
{
    public partial class ViewPage : System.Web.UI.Page
    {
        List<string> list1 = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {

            int pid= Convert.ToInt32(  Request.QueryString["P_ID"].ToString());
            Display(pid);
        }
        public void Display(int ID)
        {
          OESUser usr=new OESUser();

          SqlDataReader row_read = usr.ViewProduct(ID);

            while(row_read.Read())
            {
                String comp="O";
                CategoryIDvalue.Text = row_read[0].ToString();
                SubCategoryIdvalue.Text = row_read[1].ToString();
                
                ProductNamevalue.Text = row_read[2].ToString() ;
                ProductDescriptionvalue.Text = row_read[3].ToString();
                ProductCostvalue.Text = row_read[4].ToString();
                String ProductcatId=row_read[15].ToString();
                String spec=row_read[5].ToString();
                string[] words = spec.Split('|');
                
                foreach (string word in words)
                {
                    list1.Add(word);
                }
                switch(ProductcatId)
                {
                    case "1": 
                               setvisiblility();
                               Labelinit.Text = "Book Title : ";
                               Label1.Text = "Book Author : ";
                               break;
                    case "2": 
                               setvisiblility();
                               Labelinit.Text = "Brand : ";
                               Label1.Text = "No of Years : ";
                               break;
                    case "3": 
                               setvisiblility();
                               Labelinit.Text = "Model : ";
                               Label1.Text = "Operating System : ";
                               break;
                    case "4": 
                               
                               break;
                }
               
                First_Namevalue.Text=row_read[6].ToString();
                Second_namevalue.Text=row_read[7].ToString();
                Phone_numbervalue.Text=row_read[8].ToString();
                Address_line1value.Text=row_read[9].ToString();
                Address_line2value.Text=row_read[10].ToString();
                Posted_datevalue.Text=row_read[11].ToString();
                Closed_datevalue.Text=row_read[12].ToString();
                /*Statusvalue.Text = row_read[13].ToString();*/
                String val = row_read[13].ToString();
                int result=val.CompareTo(comp);
                if (result == 0)
                    Statusvalue.Text = "Open";
                else
                    Statusvalue.Text = "Closed";
                Productimage.ImageUrl = "~/Products/images/" + row_read[14].ToString(); 
            }
            row_read.Close();
           
        }
        public void setvisiblility()
        {
            Panel1.Visible = true;
            Labelinit.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label2.Text = list1[0];
            Label3.Text = list1[1];
        }

    }
}