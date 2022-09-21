<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp2.User.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <style>
  div {
      border-radius: 5px;
      background-color: #f2f2f2;
      padding: 20px;
}
</style>
    <div>
        <form id="form1" runat="server">
        <h2>Please Login Before Accessing Product</h2>
        <p>User ID</p>
        <asp:TextBox ID="IdTextBox" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
            runat="server" ErrorMessage="Id cannot be blank" 
            ControlToValidate="IdTextBox" 
            ForeColor="Red">
        </asp:RequiredFieldValidator>
       
        <p>Password</p>
        <asp:TextBox ID="PasswrodTextBox" runat="server"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
            runat="server" ErrorMessage="Password cannot be blank" 
            ControlToValidate="IdTextBox" 
            ForeColor="Red">
        </asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="Loginbtn" runat="server" Text="Login" OnClick="Login_btn_Click"/>
            <br />
            <asp:Label ID="lblError" runat="server" Font-Names="Aharoni" ForeColor="Red"></asp:Label>
    </form>

    </div>
    
    


</asp:Content>
