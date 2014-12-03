<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="OnlineExchange.Registration.Registration" MasterPageFile="~/main.Master" %>


      <asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
          <asp:Panel ID="p1" runat="server">
    <table border="0" cellpadding="0" cellspacing="0" style="padding-left: 50em;margin-left:40px;">
        <tr>
            <th colspan="3">Registration
            </th>
        </tr>
        <tr>
            <td>
                First Name
            </td>
                <td>
                <asp:TextBox ID="Fname" runat="server" />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ErrorMessage="Required" ForeColor="Red" ControlToValidate="Fname"
                    runat="server" />
            </td>
           
        </tr>
         <tr>
            <td>
               Last Name
            </td>
                <td>
                <asp:TextBox ID="Lname" runat="server" />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ErrorMessage="Required" ForeColor="Red" ControlToValidate="Lname"
                    runat="server" />
            </td>
           
        </tr>


        <tr>
            <td>Email
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ErrorMessage="Required" Display="Dynamic" ForeColor="Red"
                    ControlToValidate="txtEmail" runat="server" />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ControlToValidate="txtEmail" ForeColor="Red" ErrorMessage="Invalid email address." />
            </td>
        </tr>
        <tr>
            <td>Password
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtPassword"
                    runat="server" />
            </td>
        </tr>
        <tr>
            <td>Confirm Password
            </td>
            <td>
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" />
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" ErrorMessage="Passwords do not match." ForeColor="Red" ControlToCompare="txtPassword"
                    ControlToValidate="txtConfirmPassword" runat="server" />
            </td>
        </tr>
       
        <tr>

            <td>Address Line1
            </td>
            <td>
                <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
                </td>
            <td>
                <asp:RequiredFieldValidator ID="ReqAddress" runat="server" ForeColor="Red" ErrorMessage="Required" ControlToValidate="txtaddress"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>

            <td>Address Line2
            </td>
            <td>
                <asp:TextBox ID="txtaddress2" runat="server"></asp:TextBox>
              
            </td>
        </tr>
        <tr>

            <td>Phone Number
            </td>
            <td>
                <asp:TextBox ID="Phnumber" runat="server"></asp:TextBox>
                </td>
            <td>
                <asp:RequiredFieldValidator ID="ReqPhnumber" runat="server" ForeColor="Red" ErrorMessage="Required" ControlToValidate="Phnumber"></asp:RequiredFieldValidator>
                
            </td>
        </tr>

        <tr>
            <td></td>
            <td>
                <asp:Button ID="Button1" Text="Submit" runat="server" OnClick="Button1_Click" />
            </td>
            <td></td>
        </tr>
    </table>
              </asp:Panel>

          <asp:Panel ID="p2" runat="server" Visible="false">

              <asp:Label ID="l1" runat="server" >You registered successfully!!!</asp:Label>
          </asp:Panel>
</asp:Content>
