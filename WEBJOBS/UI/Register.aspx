<%@ Page Title="Register" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WEBJOBS.UI.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <b> Register page</b>

    <div>
        <table>
            <tr>
                <td>Full Name: </td>
                <td><asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
               <%-- <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Full Name" ControlToValidate="nameTextBox" ForeColor="#FF3300">*</asp:RequiredFieldValidator></td>--%>
            </tr>
            <tr>
                <td>Email</td>
                <td><asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox></td>
                <%--<td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Valid Email" ControlToValidate="emailTextBox" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter valid Email !!" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>--%>
            </tr>
             <tr>
                <td>Password</td>
                <td><asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password"></asp:TextBox></td>
                 <%--<td> <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter Password" ControlToValidate="passwordTextBox" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                     </td>--%>
            </tr>
             <tr>
                <td>Confirm Password</td>
                <td><asp:TextBox ID="confirmPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox></td>
                 <%--<td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Confirm Password" ControlToValidate="confirmPasswordTextBox" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                     <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passwordTextBox" ControlToValidate="confirmPasswordTextBox" ErrorMessage="Password not Match" ForeColor="#FF3300"></asp:CompareValidator>
                 </td>--%>
            </tr>
      

        </table>
        <asp:Button ID="registerButton" runat="server" Text="Register" OnClick="registerButton_Click" />

        <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>

    </div>


</asp:Content>
