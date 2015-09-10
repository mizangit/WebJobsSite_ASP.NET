<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WEBJOBS.UI.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
         <div id="Lsidebar">
             <p>
                <h2>Bangladesh </h2> 
                Country in South Asia
                Bangladesh, east of India on the Bay of Bengal, is South Asian country of lush greenery and many waterways.
                  
             </p>
        </div>
    <div id="session">
        <div id="upload">

            <asp:Label ID="Label8" runat="server" Text="Category"></asp:Label><br />
            <asp:DropDownList ID="categoryDropDownList" runat="server"></asp:DropDownList><br />

            <asp:Label ID="Label1" runat="server" Text=" Position"></asp:Label><br />
            <asp:TextBox ID="positionTextBox" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label2" runat="server" Text="Company Name"></asp:Label><br />
            <asp:TextBox ID="companynameTextBox" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label3" runat="server" Text="Education"></asp:Label><br />

            <asp:TextBox ID="educationTextBox" runat="server" Height="45px" TextMode="MultiLine" Width="247px"></asp:TextBox>
            <br />

            <asp:Label ID="Label4" runat="server" Text="Experience"></asp:Label><br />
            <asp:TextBox ID="experienceTextBox" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label5" runat="server" Text="Salary"></asp:Label><br />
            <asp:TextBox ID="salaryTextBox" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label6" runat="server" Text="Vacancies"></asp:Label><br />
            <asp:TextBox ID="vacanciesTextBox" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label7" runat="server" Text="Job Description"></asp:Label><br />
            <asp:TextBox ID="descriptionTextBox" runat="server" Height="46px" TextMode="MultiLine" Width="258px"></asp:TextBox>
            <br />
            <br />

            <asp:Button ID="uploadButton" runat="server" Text="Upload" OnClick="uploadButton_Click" />
        </div>
        <div id="category">

            <asp:Label ID="Label9" runat="server" Text=" Category"></asp:Label><br />
            <asp:TextBox ID="categoryTextBox" runat="server"></asp:TextBox><br />
            <asp:Button ID="uploadcatagoryButton" runat="server" Text="Upload" OnClick="uploadcategoryButton_Click" />

        </div>



    </div>




    <div id="Rsidebar">
            <p>
               <h2>Badarganj Upazila </h2> 

Badarganj (Bengali: বদরগঞ্জ) is an Upazila of Rangpur District in the Division of Rangpur, Bangladesh.
            </p>
        </div>



</asp:Content>
