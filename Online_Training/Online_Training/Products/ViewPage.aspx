<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPage.aspx.cs" Inherits="OnlineExchange.Products.ViewPage" MasterPageFile="~/PopUp.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderId="MainContent" runat="server">
    <style type="text/css">
#customers {
    font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
    width: 90%;
    border-collapse: collapse;
    margin-left:40px;
}

#customers td, #customers th {
    font-size: 1em;
    border: 1px solid dimgray;
    padding: 3px 7px 2px 7px;
}

#customers th {
    font-size: 1.1em;
    text-align: left;
    padding-top: 5px;
    padding-bottom: 4px;
    background-color: dimgray;
    color: #ffffff;
}
table{
    table-layout: fixed;
}

#customers tr.alt td {
    color: #000000;
    background-color: dimgray;
    word-wrap:break-word;
}
</style>

        <table id="customers">
        
             <tr>
                 <th colspan="2" style="text-align:center">
                <b>Product Details</b>
                 </th>
              </tr>
              <tr>
                  <td>
                  <asp:Label ID="CategoryID1" Font-Bold="true" runat="server" CssClass="bold" Text="Category"></asp:Label>
                  </td>
                  <td>
                  <asp:Label ID="CategoryIDvalue"  runat="server" ></asp:Label>
                  </td>
              </tr>
              
                <tr>
                  <td>
                  <asp:Label ID="SubcategoryID1" Font-Bold="true" runat="server" CssClass="bold"  Text="SubCategory"></asp:Label>
                  </td>
                  <td>
                  <asp:Label ID="SubCategoryIdvalue"  runat="server"  ></asp:Label>
                  </td>
              </tr>
              <tr >
                  <td>
                  <asp:Label ID="ProductNameLabel" Font-Bold="true" runat="server" CssClass="Bold" Text="Product Name"></asp:Label>
                  </td>
                  <td >
                  <asp:Label ID="ProductNamevalue"  runat="server"  ></asp:Label>
                  </td>
                  
                </tr>
             <tr >
                  <td>
                  <asp:Label ID="ProudDescriptionLabel" Font-Bold="true" runat="server" Text="Product Description" CssClass="Bold"></asp:Label>
                  </td>
                  <td>
                  <asp:Label ID="ProductDescriptionvalue"  runat="server" CssClass="bold" Text="----"></asp:Label>
                  </td>
              </tr>
              <tr>
                  <td>
                  <asp:Label ID="ProductCostLabel" Font-Bold="true" runat="server" CssClass="bold" Text="Product Cost"></asp:Label>
                  </td>
                  <td >
                  <asp:Label ID="ProductCostvalue"  runat="server" ></asp:Label>
                  </td>
              </tr>
             
             
              
            
        <asp:Panel ID="Panel1"  runat="server" Visible="false">
            
               
            
      <td>     <asp:Label ID="Labelinit" runat="server" Visible="false"   Font-Bold="true"  ></asp:Label></td> 
           
        <td>       <asp:Label ID="Label2" runat="server" Visible="false" ></asp:Label></td> 
          
     <tr><td><asp:Label ID="Label1" runat="server" Visible="false" Font-Bold="true"></asp:Label></td>
           
              <td>   <asp:Label ID="Label3" runat="server" Visible="false"  ></asp:Label></td></tr>
   </asp:Panel>   
        
    
              
                     <tr >
                    <th colspan="2" style="text-align:center">
                    <b>Seller Details</b>
                    </th>
                </tr>
                 <tr>
                  <td >
                  <asp:Label ID="First_NamevalueID" Font-Bold="true" runat="server" CssClass="bold" Text="First name"></asp:Label>
                  </td>
                  <td >
                  <asp:Label ID="First_Namevalue"  runat="server" ></asp:Label>
                  </td>
                </tr>
                <tr>
                  <td >
                  <asp:Label ID="Second_namevalueID"  runat="server" Font-Bold="true" CssClass="bold" Text="Last name"></asp:Label>
                  </td>
                  <td>
                  <asp:Label ID="Second_namevalue"  runat="server"  ></asp:Label>
                  </td>
                </tr>
                <tr >
                  <td >
                  <asp:Label ID="Phone_numberID" Font-Bold="true" runat="server" CssClass="bold" Text="Phonenumber"></asp:Label>
                  </td>
                  <td >
                  <asp:Label ID="Phone_numbervalue"  runat="server" ></asp:Label>
                  </td>
                </tr>
                <tr >
                  <td>
                  <asp:Label ID="Address_line1ID" Font-Bold="true" runat="server" CssClass="bold" Text="Address Line 1"></asp:Label>
                  </td>
                  <td >
                  <asp:Label ID="Address_line1value"   runat="server"  ></asp:Label>
                  </td>
                </tr>

                <tr >
                  <td >
                  <asp:Label ID="Address_line2ID" Font-Bold="true"  runat="server" CssClass="bold" Text="Address Line 2"></asp:Label>
                  </td>
                  <td >
                  <asp:Label ID="Address_line2value"  runat="server"  ></asp:Label>
                  </td>
                </tr>

                <tr >
                  <td >
                  <asp:Label ID="Posted_dateID" Font-Bold="true" runat="server" CssClass="bold" Text="AD Post Date"></asp:Label>
                  </td>
                  <td >
                  <asp:Label ID="Posted_datevalue"  runat="server"  ></asp:Label>
                  </td>
                </tr>
                <tr >
                  <td >
                  <asp:Label ID="Closed_dateID" Font-Bold="true" runat="server" CssClass="bold" Text="AD Close Date"></asp:Label>
                  </td>
                  <td>
                  <asp:Label ID="Closed_datevalue"  runat="server"></asp:Label>
                  </td>
                </tr>
                <tr >
                  <td >
                  <asp:Label ID="StatusID" Font-Bold="true" runat="server" CssClass="bold" Text="AD Status"></asp:Label>
                  </td>
                  <td >
                  <asp:Label ID="Statusvalue"  runat="server" ></asp:Label>
                  </td>
                </tr>
                
         
                  
        </table>
    <table style="margin-left:80px">
        <tr>
            <td>
                 <asp:Image id="Productimage" runat="server" AlternateText="Image text" ImageAlign="Middle" Height="200px" Width="200px"/>
            </td>
        </tr>
    </table>
       
    
</asp:Content>