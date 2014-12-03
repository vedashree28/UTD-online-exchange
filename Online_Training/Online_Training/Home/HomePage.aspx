<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="OnlineExchange.Home.HomePage" MasterPageFile="~/Site.Master" %>


    <%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>


   
   <asp:Content ContentPlaceHolderID="FeaturedContent"  runat="server" > 
    <style type="text/css">
        .style1
        {
            height: 19px;
        }
        .style2
        {
            height: 19px;
            width: 203px;
        }
        .style3
        {
            width: 203px;
        }
        .style5
        {
            width: 48%;
            height: 154px;
            z-index: 1;
            left: 556px;
            top: 179px;
            position: absolute;
            bottom: 166px;
        }
        .style6
        {
            position: absolute;
            left: 273px;
            top: 159px;
            width: 21%;
            height: 250px;
        }
    .style7
    {
        width: 203px;
        height: 21px;
    }
    .style8
    {
        height: 21px;
    }
    </style>
    </asp:Content> 
    <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
     
          <table border="0" cellpadding="0" cellspacing="0" style="padding-left: 50em">
      
            <br />
            <br />
         
        <tr>
            <td>
                &nbsp;</td>
            <td>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Image ID="profile_image" runat="server" Height="130px" Width="150px" 
                    BorderStyle="Solid" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Edit Photo" OnClick="Button2_Click" />
                <cc1:PopupControlExtender ID="Button2_PopupControlExtender" runat="server"  PopupControlID="Panel1"
                    DynamicServicePath="" Enabled="True" ExtenderControlID=""  TargetControlID="Button2">
                </cc1:PopupControlExtender>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Panel ID="Panel1" runat="server" Visible="false">
                    <asp:FileUpload ID="FileUpload1" runat="server" Height="31px" Width="219px" />
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Upload"  OnClick="Button1_Click"
                         />
                </asp:Panel>
            </td>
        </tr>
        </table>
           
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <table class="style5">
                <tr>
                    <td class="style2">
                        <asp:Label ID="Fname" runat="server" Font-Bold="true" CssClass="bold" Text="Name"></asp:Label>
                    </td>
                    <td class="style1">
                        <asp:Label ID="Name_value" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <asp:Label ID="emailaddress" Font-Bold="true" runat="server" CssClass="bold" Text="Email Address"></asp:Label>
                    </td>
                    <td class="style1">
                        <asp:Label ID="Emailaddress_value" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        <asp:Label ID="Address1" Font-Bold="true" runat="server" CssClass="bold" Text="Address Line1"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Address1_value" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        <asp:Label ID="Address2" runat="server" Font-Bold="true" CssClass="bold" Text="Address Line2"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Address2_value" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        <asp:Label ID="Phnumber" runat="server" Font-Bold="true" CssClass="bold" Text="Phone-Number"></asp:Label>
                    </td>
                    <td class="style8">
                       <asp:Label ID="Phnumber_value" runat="server"></asp:Label>
                    </td>
                </tr>
                
              
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:Content> 




