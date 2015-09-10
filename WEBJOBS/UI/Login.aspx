<%@ Page Title="Login" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WEBJOBS.UI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       <ContentTemplate>
           
           <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
           <div id="msg" runat="server" clientidmode="Static"></div>
           <div id="login"  >
               
   <b>Log In Page </b> 

    <table id="table" align="center">
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Email: "></asp:Label> </td>
            <td><asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox></td>
            <%--<td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="emailTextBox" ErrorMessage="Enter Email " ForeColor="Red"></asp:RequiredFieldValidator>
                             <br />
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailTextBox" ErrorMessage="Enter Valid E-mail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>--%>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label></td>
            <td><asp:TextBox ID="passwodTextBox" runat="server" TextMode="Password"></asp:TextBox></td>
           <%-- <td>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="passwodTextBox" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>--%>
        </tr>
        <tr>
            <td><asp:Button ID="loginButton" runat="server" Text="Log In" OnClick="loginButton2" /></td>
            <td><asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/UI/Register.aspx"><b>Register</b></asp:LinkButton></td>
        </tr>
        
    </table>                    
        </div>
           
       </ContentTemplate>

   </asp:UpdatePanel>
    
</asp:Content>
