<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="OnlineExchange.Products.AddProduct" MasterPageFile="~/PopUp.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <table>

        <tr>
            <asp:Panel ID="PnlCom" runat="server">
                <td>Category:
                    <td>
                        <asp:DropDownList ID="dropCtegory" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dropCtegory_SelectedIndexChanged">
                            <asp:ListItem Text="Select Category" Value="none" />

                        </asp:DropDownList>

                        <asp:RequiredFieldValidator ID="reqFavoriteColor" Text="Required" InitialValue="none" ControlToValidate="dropCtegory" runat="server" />
                    </td>
                </td>

            </asp:Panel>
        </tr>
        <asp:Panel ID="GENERAL" runat="server" Visible="false">
            <tr>
                <td>Product Name:
                </td>
                <td>
                    <asp:TextBox ID="Product_Name" runat="server" />
                    <asp:RequiredFieldValidator ID="rq1" runat="server" ControlToValidate="Product_Name" Text="Required"></asp:RequiredFieldValidator>
                </td>
                <td></td>
            </tr>
            <tr>
                <td>Product Description:
                </td>
                <td>

                    <textarea id="Product_desc" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Product_desc" Text="Required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Product Cost:
                </td>
                <td>$<asp:TextBox ID="Product_cost" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Product_cost" Text="Required"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                        ControlToValidate="Product_cost"
                        ValidationExpression="\d+"
                        Display="Static"
                        EnableClientScript="true"
                        ErrorMessage="Please enter numbers only"
                        runat="server" />
                </td>
                <td></td>
            </tr>


        </asp:Panel>
    </table>

    <asp:Panel ID="book" runat="server" Visible="false">
        <table>
            <tr>
                <td>Book Title:
                </td>
                <td>
                    <asp:TextBox ID="txtbtitle" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtbtitle" Text="Required"></asp:RequiredFieldValidator>
                </td>
                

            </tr>
            <tr>
                <td>Book Author:
                </td>
                <td>
                    <asp:TextBox ID="txtAuthor" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtAuthor" Text="Required"></asp:RequiredFieldValidator>
                </td>
                
                <td></td>
            </tr>
            <tr>
                <td>Type:
                </td>
                <td>
                    <asp:DropDownList ID="ddlbooktype" runat="server">
                    </asp:DropDownList>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlbooktype" Text="Required" InitialValue="none"></asp:RequiredFieldValidator>
                </td>
               
            </tr>
        </table>

    </asp:Panel>
    <asp:Panel ID="HAppliances" runat="server" Visible="false">
        <table>
            <tr>
                <td>Brand :
                </td>
                <td>
                    <asp:TextBox ID="txtBrand" runat="server" />
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtBrand" Text="Required"></asp:RequiredFieldValidator>
                </td><td></td>
            </tr>
            <tr>
                <td>No of years since purchase
                </td>
                <td>
                    <asp:TextBox ID="txtyr" runat="server" />
                

                <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                    ControlToValidate="txtyr"
                    ValidationExpression="\d+"
                    Display="Static"
                    EnableClientScript="true"
                    ErrorMessage="Please enter numbers only"
                    runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtyr" Text="Required"></asp:RequiredFieldValidator>
               </td> <td></td>
            </tr>
            <tr>
                <td>Type:
                </td>
                <td>
                    <asp:DropDownList ID="ddlhtype" runat="server">
                    </asp:DropDownList>
               
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="ddlhtype" InitialValue="none" Text="Required"></asp:RequiredFieldValidator>
           </td> </tr>
        </table>

    </asp:Panel>
    <asp:Panel ID="pnlMobileTablets" runat="server" Visible="false">
        <table>
            <tr>
                <td>Model:
                </td>
                <td>
                    <asp:TextBox ID="txtmodel" runat="server" />
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtmodel" Text="Required"></asp:RequiredFieldValidator>
               </td> <td></td>
            </tr>
            <tr>
                <td>Operating System:
                </td>
                <td>
                    <asp:TextBox ID="txtOS" runat="server" />
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtOS" Text="Required"></asp:RequiredFieldValidator>
                </td><td></td>
            </tr>
            <tr>
                <td>Type:
                </td>
                <td>
                    <asp:DropDownList ID="ddlMtype" runat="server">
                    </asp:DropDownList>
               
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="ddlMtype" InitialValue="none" Text="Required"></asp:RequiredFieldValidator>
            </td></tr>


        </table>

    </asp:Panel>
    <asp:Panel ID="buttons_pnl" runat="server" Visible="false" >
        <table>
            <tr>
                <td>Upload your Image here:
                </td>
                <td>
                    <asp:FileUpload
                        ID="FileUpload1"
                        runat="server"
                        BackColor="Gray" />
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator90"
                        runat="server"
                        ControlToValidate="FileUpload1"
                        ErrorMessage="Choose a image to upload!" />
                </td>

            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button Text="Save" ID="btnSave" runat="server"  OnClick="btnSave_Click"></asp:Button>

                </td>
            </tr>
        </table>
    </asp:Panel>


</asp:Content>
