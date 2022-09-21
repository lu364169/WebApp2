<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="WebApp2.ProductList" ViewStateMode="Enabled"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            Fruit:
            <asp:Label ID="FruitLabel" runat="server" Text='<%# Eval("Fruit") %>' />
            <br />
            Price:
            <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
            <br />
            <br />
            <asp:TextBox ID="TextId" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                runat="server" ErrorMessage="Cannot be blank" 
                ControlToValidate="TextId" 
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            
            
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Fruit], [Price] FROM [ProductList]"></asp:SqlDataSource>
    <asp:Button ID="ButtonId" Text="Add" runat="server" OnClick="Button1_Click"/>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
</form>
        
</asp:Content>
