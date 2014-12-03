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
    public partial class Compare : System.Web.UI.Page
    {
        string[] prod1speclist;
        string[] prod2speclist;
        protected void Page_Load(object sender, EventArgs e)
        {

            int pid1 = Convert.ToInt32(Request.QueryString["Pid1"].ToString());
            int pid2 = Convert.ToInt32(Request.QueryString["Pid2"].ToString());
            CompareProducts(pid1, pid2);
        }
        public void CompareProducts(int prod1, int prod2)
        {

            Product p=new Product();
            String prod1spec, prod2spec, validYN = "";
            var list1=p.CompareProducts(prod1,prod2, ref validYN);
            if (validYN == "Y")
            {
                prod1Catname.Text = list1[0];
                prod1SubCat.Text = list1[1];
                prod1Name.Text = list1[2];
                prod1Description.Text = list1[3];
                prod1Cost.Text = list1[5];
                prod1ImagePath.ImageUrl =("~/Products/images/" + list1[6]).Trim();
                string prod1CatId = list1[7].ToString();
                prod2Catname.Text = list1[8];
                prod2SubCatname.Text = list1[9];
                prod2Name.Text = list1[10];
                nores.Visible = false;
                Panelprod1.Visible = true;
                //Panelprod2.Visible = true;


                prod2Description.Text = list1[11];
                prod2Cost.Text = list1[13];
                prod2ImagePath.ImageUrl = ("~/Products/images/" + list1[14]).Trim();

                prod1spec = list1[4];
                prod1speclist = prod1spec.Split('|');
                prod2spec = list1[12];
                prod2speclist = prod2spec.Split('|');

                switch (prod1CatId)
                {
                    case "1":
                        setvisiblility();
                        Label0prod1.Text = "Book Title : ";
                        Label1prod1.Text = "Book Author : ";
                   //     Label0prod2.Text = "Book Title : ";
                      //  Label1prod2.Text = "Book Author : ";
                        break;
                    case "2":
                        setvisiblility();
                        Label0prod1.Text = "Brand : ";
                        Label1prod1.Text = "No of Years : ";
                    //    Label0prod2.Text = "Brand : ";
                     //   Label1prod2.Text = "No of Years : ";
                        break;
                    case "3":
                        setvisiblility();
                        Label0prod1.Text = "Model : ";
                        Label1prod1.Text = "Operating System : ";
                      //  Label0prod2.Text = "Model : ";
                     //   Label1prod2.Text = "Operating System : ";
                        break;
                    case "4":
                        break;
                }
            }

            else
            {
                nores.Visible = true;

                Panelprod1.Visible = false;
                //Panelprod2.Visible = false;
            }
            
            }
         
        

        public void setvisiblility()
        {
            Label0prod1.Visible = true;
            Label1prod1.Visible = true;
           // Label0prod2.Visible = true;
           // Label1prod2.Visible = true;
            Label0prod1values.Visible = true;
            Label1prod1values.Visible = true;
            Label0prod2values.Visible = true;
            Label1prod2values.Visible = true;
            Label0prod1values.Text = prod1speclist[0];
            Label1prod1values.Text = prod1speclist[1];
            Label0prod2values.Text = prod2speclist[0];
            Label1prod2values.Text = prod2speclist[1];
        }
    }
}