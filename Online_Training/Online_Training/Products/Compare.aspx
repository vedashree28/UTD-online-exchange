<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compare.aspx.cs" Inherits="OnlineExchange.Products.Compare" MasterPageFile="~/PopUp.Master" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">

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
    #icons{
        float:left;
    width: 64px; 
    height: 64px;
    margin:5px;
   }
    </style>
    <asp:Panel ID="Panelprod1" runat="server">
        <div>
            <table id="customers">
               <tr>
                   <th>
                       Attributes
                   </th>
                   <th>
                       Product 1
                   </th>
                   <th>
                       Product 2
                   </th>
               </tr>
                <tr>
                    <td>
                        <asp:Label ID="ProductName1" Font-Bold="true" runat="server"  Text="Product Catgory:"></asp:Label>
                    </td>

                    <td>
                        <asp:Label ID="prod1Catname" runat="server" ></asp:Label>
                    </td>
                     <td>
<asp:Label ID="prod2Catname" runat="server" ></asp:Label>
             </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="prod1SubCat1" Font-Bold="true" runat="server"  Text="Product Sub Category:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="prod1SubCat" runat="server" ></asp:Label>
                    </td>
                    <td>
   <asp:Label ID="prod2SubCatname" runat="server" > </asp:Label>
             </td>
        
                </tr>


                <tr>
                    <td>
                        <asp:Label ID="prod1Name1" Font-Bold="true" runat="server"  Text="Product Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="prod1Name" runat="server" ></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="prod2Name" runat="server" ></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="prod1Description1" Font-Bold="true" runat="server"  Text="Product Description:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="prod1Description" runat="server"></asp:Label>
                        <asp:Label ID="Label1" runat="server" Font-Size="Large"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="prod2Description" runat="server" ></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="prd1Cost1" Font-Bold="true" runat="server"  Text="Product Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="prod1Cost" runat="server" ></asp:Label>
                    </td>
                    <td>
                         <asp:Label ID="prod2Cost" runat="server" ></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label0prod1" Font-Bold="true" runat="server" ></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label0prod1values" runat="server" ></asp:Label>
                    </td>

                    <td>
                          <asp:Label ID="Label0prod2values" runat="server" ></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label1prod1" Font-Bold="true" runat="server" ></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label1prod1values" runat="server" ></asp:Label>
                    </td>
                    <td>

                    <asp:Label ID="Label1prod2values"  runat="server" ></asp:Label> </td>
                </tr>
            </table>
            <br />
            <br />
            
        </div>
    </asp:Panel>

    <table style="margin-left:40px;width:70%">
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <asp:Image ID="prod1ImagePath" runat="server" Width="150px"  /> 
            </td>
           
            <td>
                &nbsp;
            </td>
            <td>
                <asp:Image ID="prod2ImagePath" runat="server" Width="150px"  />
            </td>
        </tr>
    </table>
           
  

    <asp:Panel ID="nores" runat="server" Visible="false">
        <asp:Label ID="lbl1" runat="server" Style="font-size: 1.1em; text-align: left; padding-top: 5px; font-family: Trebuchet MS, Arial, Helvetica, sans-serif; margin-left: 40px;">PRODUCTS CANNOT BE COMPARED</asp:Label>
    </asp:Panel>
</asp:Content>
