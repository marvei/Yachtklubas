<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Items.aspx.cs" Inherits="YachtKlubas.Items.Items" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Item page</h1>
            <div>
                
                <asp:Button ID="AddNewItem" runat="server" Text="Add New" OnClick="AddNewItem_Click" />
                <asp:Button ID="CreateNewPackage" runat="server" Text="Create New Package" OnClick="CreateNewPackage_Click" />
                <br />
                <br />
                <asp:CheckBox ID="CheckBox1" runat="server" />
                <asp:Label ID="PrekesPav" runat="server" Text="PrekesPavadinimas"></asp:Label>
                <asp:Button ID="ChangePrice" runat="server" Text="Change Price" OnClick="ChangePrice_Click" Width="153px" />

                <asp:Button ID="AddFavorite" runat="server" Text="Add To Favorite" OnClick="AddFavorite_Click" />
                <asp:Button ID="AddToCart" runat="server" Text="Add To Cart" OnClick="AddToCart_Click" />
                <asp:Button ID="DeleteItem" runat="server" Text="Delete Item" OnClick="DeleteItem_Click" />
            </div>
        </div>
    </form>
</body>
</html>
