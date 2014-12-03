<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostAd.aspx.cs" Inherits="OnlineExchange.PostAds.PostAd" MasterPageFile="~/Site.Master" %>



<asp:Content ContentPlaceHolderID="MainContent" runat="server">
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
    <table style="margin-left:50px">
        <tr><td>
   

   </td></tr>
        <tr><td>
    <asp:Button ID="btn1" runat="server" Width="200px" Height="50px" Text="POST NEW ADD" OnClientClick="window.open('AddProduct.aspx','','width=800, height=800');return false;" />
    </td></tr>
   
        </table>
    <br />
    <br />
   <asp:Label ID="Label1" runat="server" Font-Bold="true" style="font-size: 1.1em;text-align: left;padding-top: 5px;font-family:Trebuchet MS, Arial, Helvetica, sans-serif; margin-left:40px;">YOUR AD'S:</asp:Label><br />

  <asp:Panel ID="pnlshowdata" runat="server" >
      <asp:Repeater ID="rptShowdata" runat="server" OnItemCommand="rptShowdata_ItemCommand">
          <HeaderTemplate>
              <table id="customers">
                  <tr>
                      <th>
                         <b>Product Name</b>
                      </th>
                      <th>
                          <b>Product Description</b>
                      </th>
                      <th>
                        <b> Posted Date</b>
                      </th>
                      <th>
                        <b>  Status</b>
                      </th>
                      <th>
                        <b> Action</b>
                      </th>
                  </tr>
                  </HeaderTemplate>
          <ItemTemplate>
              <tr>
                  <td>
                      <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "A_ID") %>'></asp:Label>
                       <a href="javascript:window.open('ViewPage.aspx?P_ID=<%# Eval("P_ID") %>','','width=500, height=500')"><%#DataBinder.Eval(Container.DataItem, "Product_Name")%>
                  </td>
                  <td>
 <asp:Label ID="Label2"  runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Product_Description") %>'></asp:Label>
                  </td>
                  <td>
                       <asp:Label ID="Label3"  runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Posted_date") %>'></asp:Label>
                  </td>
                  <td>
                  <%#GetStatus(Eval("Status").ToString())   %>
                  </td>
                  <td>
                         <asp:LinkButton ID="lnkEdit" runat="server" CommandName="close" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "A_ID") %>'>Close AD</asp:LinkButton>
   
                  </td>
              </tr>
               
          </ItemTemplate>
             <FooterTemplate>
                 </table>
             </FooterTemplate>
        
      </asp:Repeater>
  </asp:Panel>
</asp:Content>
