<%@ Page Title="Home" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WEBJOBS.UI.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="HomeLeft">

       <b>CATEGORY</b>
        <asp:Panel ID="categoryPanel" runat="server"></asp:Panel>
      

    </div>


    <div id="HomeRight">
          <label> <h2>Jobs List </h2> </label>
    <asp:Panel ID="descriptionPanel" runat="server"> </asp:Panel>
   
       <%-- <div style=" padding:5px;  clear:both; background-color:white" > </div>--%>

    </div>
   



</asp:Content>
