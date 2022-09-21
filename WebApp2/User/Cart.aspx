<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="WebApp2.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <title>Shopping Cart</title>
    <link href="Styles/StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
 
    <form id="form1" runat="server">
        <div class="container">
            <h1>Shopping Cart</h1>
            <a href="ProductList.aspx">< Back to Products</a>
 
            <br /><br />
            <asp:GridView ID="GridView1" runat="server" EmptyDataText="Nothing" AutoGenerateColumns="false">
                 <Columns>
                    <asp:BoundField DataField="Key" HeaderText="Item" ReadOnly="True" SortExpression="Key" />
                    <asp:BoundField DataField="Value" HeaderText="Amount" ReadOnly="True" SortExpression="Value" />
                </Columns>
            </asp:GridView>
 
           
           
            <br />
            <asp:Label ID="lblTotal" runat="server"></asp:Label>
            <br />
 
           
           
        </div>
    </form>
</body>
</asp:Content>
