<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search_Product.aspx.cs" Inherits="OnlineExchange.Products.Search_Product" MasterPageFile="~/Site.Master" %>

 <asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent"  runat="server" > 
     <style type="text/css">
#customers {
    font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
    width: 60%;
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
     <table style="margin-left:40px;">
         <tr>
             <td>
              <asp:TextBox ID="querytext" runat="server">

    </asp:TextBox>
                 </td>
             <td>
     <asp:DropDownList ID="ddltype" runat="server"  />
                 </td>
             <td>
                 <asp:Button ID="SubmitSearch" runat="server" Text="SUBMIT" OnClick="SubmitSearch_Click" />
             </td>
         </tr>
         </table>
   <asp:Panel ID="nores" runat ="server" Visible="false">
      
       <label id="dis" runat="server" style="font-size: 1.1em;text-align: left;padding-top: 5px;font-family:Trebuchet MS, Arial, Helvetica, sans-serif; margin-left:40px;" >NO RESULTS FOUND</label>
   </asp:Panel>
     <asp:Panel ID="pnl1" runat="server" Visible="false" >
     
      <asp:Repeater ID="repEmployeeDetails" runat="server" >
       <HeaderTemplate>
            <table border="1"width="20%" id="customers">
               <label id="dis" runat="server" style="font-size: 1.1em;text-align: left;padding-top: 5px;font-family:Trebuchet MS, Arial, Helvetica, sans-serif; margin-left:80px;" >RESULTS:</label>
                <tr>
                    <th>Product Name</th>
                    <th>Product Description</th>
                    <th>Product Cost</th>
                </tr>
        </HeaderTemplate>

        <ItemTemplate>
            <tr>
                
                <td>
                    <asp:CheckBox id="slctProduct" runat="server"></asp:checkbox>
                    <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "P_ID") %>'></asp:Label>
                 <a href="javascript:window.open('ViewPage.aspx?P_ID=<%# Eval("P_ID") %>','','width=500, height=500')"><%#DataBinder.Eval(Container.DataItem, "Product_Name")%>
        </a> 
                
         </td>
                
                <td> <asp:Label Text ='<%#DataBinder .Eval  (Container.DataItem,"Product_Description")%>' ID ="lbldesc" runat ="server" ></asp:Label>
                    
                </td>
                
                <td> <asp:Label Text ='<%#DataBinder .Eval  (Container.DataItem,"Product_Cost")%>' ID ="Label1" runat ="server" ></asp:Label>
                    
                </td>
               </tr>
        </ItemTemplate>

        <FooterTemplate>
            </table>
        </FooterTemplate>

    </asp:Repeater>
     </asp:panel>
     <br />
     <br />

     <asp:Panel ID="cmp" runat="server" Visible="false">

         <table style="margin-left:370px"><tr><td>
              <asp:Button ID="cmpbutton" runat="server" Text="Compare"  ToolTip="Click here to compare between two products" OnClick="cmpbutton_Click" />
                                             </td></tr></table>
        
     </asp:Panel>
     </asp:content>
