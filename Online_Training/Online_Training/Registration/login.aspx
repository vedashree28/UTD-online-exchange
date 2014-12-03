<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="OnlineExchange.Registration.login" MasterPageFile="~/main.Master" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <table border="0" cellpadding="0" cellspacing="0" style="padding-left: 50em;margin-left:40px;">
        <tr>
            <th colspan="3">Sign In
            </th>
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
            
            <td>
                <asp:Button ID="Button1" Text="Login"  runat="server" OnClick="Button1_Click" />
            </td>
            <td></td>
        </tr>

</table>
    </asp:Content>