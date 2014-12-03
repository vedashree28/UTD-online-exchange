<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WishListForm.aspx.cs" Inherits="OnlineExchange.WishList1.WishListForm" MasterPageFile="~/Site.Master" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        #customers {
            font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
            width: 40%;
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
    <br />
    <br />
    <br />
    <table style="margin-left: 60px">
        <tr>
            <td>
                <asp:Button ID="btn1" runat="server" Text=" ADD TO WISHLIST" OnClientClick="window.open('AddWishList.aspx','','width=800, height=800');return false;" />
            </td>
        </tr>
    </table>

    <br />
    <br />

    <br />

    <asp:Panel ID="pnlshowdata" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Bold="true" Style="font-size: 1.1em; text-align: left; padding-top: 5px; font-family: Trebuchet MS, Arial, Helvetica, sans-serif; margin-left: 40px;">YOUR WISHLIST:</asp:Label><br />


        <asp:Repeater ID="rptShowdata" runat="server" OnItemCommand="rptShowdata_ItemCommand">
            <HeaderTemplate>
                <table id="customers">
                    <tr>
                        <th>
                            <b>Product Name</b>
                        </th>
                        <th>
                            <b>Product Category</b>
                        </th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Item_ID") %>'></asp:Label>


                        <a href="javascript:window.open('ViewWishlistItem.aspx?Pid=<%# Eval("Item_ID") %>','','width=500, height=500')"><%#DataBinder.Eval(Container.DataItem, "Item_Name")%>
                    </td>

                    <td>
                        <%#GetStatus(Eval("ItemCategory_ID").ToString())   %>
                    </td>
                </tr>

            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>

        </asp:Repeater>
    </asp:Panel>

    <br />
    <br />
    <br />


    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="Label2" runat="server" Font-Bold="true" Style="font-size: 1.1em; text-align: left; padding-top: 5px; font-family: Trebuchet MS, Arial, Helvetica, sans-serif; margin-left: 40px;">YOUR WISHLIST PRODUCTS THAT ARE NOW AVALIABLE:</asp:Label><br />
        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="rptShowdata_ItemCommand">
            <HeaderTemplate>
                <table id="customers">
                    <tr>
                        <th>
                            <b>Product Name</b>
                        </th>
                        <th>
                            <b>Product Category</b>
                        </th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "P_ID") %>'></asp:Label>
                        <a href="javascript:window.open('../Products/ViewPage.aspx?P_ID=<%# Eval("P_ID") %>','','width=500, height=500')"><%#DataBinder.Eval(Container.DataItem, "Item_Name")%></a>
                    </td>

                    <td>
                        <%#GetStatus(Eval("ItemCategory_ID").ToString())   %>
                    </td>
                </tr>

            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>

        </asp:Repeater>
    </asp:Panel>

</asp:Content>
