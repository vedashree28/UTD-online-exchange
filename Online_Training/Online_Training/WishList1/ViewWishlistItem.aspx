<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewWishlistItem.aspx.cs" Inherits="OnlineExchange.WishList1.ViewWishlistItem" MasterPageFile="~/PopUp.Master" %>

<asp:Content ContentPlaceHolderId="MainContent" runat="server">
<style type="text/css">
        #customers {
            font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
            width: 70%;
            border-collapse: collapse;
            margin-left: 40px;
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

        table {
            table-layout: fixed;
        }

        #customers tr.alt td {
            color: #000000;
            background-color: dimgray;
            word-wrap: break-word;
        }
    </style>
   <table id="customers">
       <tr>
           <th colspan="2">
               WISH LIST ITEM:
           </th>
       </tr>
       <tr>
           <td>
                <asp:Label ID="Iemnamekey" runat="server" Text="Item Name :" Font-Bold="true"></asp:Label>
           </td>
           <td>
               <asp:Label ID="Item_Name" runat="server" ></asp:Label>
           </td>
       </tr>

       <tr>
           <td>
                <asp:Label ID="ItemSpecification1" runat="server" Text="Item Specification : "  Font-Bold="true"></asp:Label>
           </td>

           <td>
               <asp:Label ID="Item_Specification" runat="server"  ></asp:Label>
           </td>
       </tr>

       <tr>
           <td>
               <asp:Label ID="ItemCategory1" runat="server"  Text="Item Category :" Font-Bold="true"></asp:Label>
           </td>
           <td>
 <asp:Label ID="category_name" runat="server" ></asp:Label>
           </td>
       </tr>

       <tr>
           <td>
               <asp:Label ID="ItemSubCategory1" runat="server" Text="Item Sub Category : "  Font-Bold="true"></asp:Label>
           </td>
           <td>
<asp:Label ID="subcategory_name" runat="server" ></asp:Label>
           </td>
       </tr>
   </table>
       
</asp:Content>