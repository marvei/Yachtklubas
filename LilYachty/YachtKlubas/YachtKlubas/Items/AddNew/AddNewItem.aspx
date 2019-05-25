<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewItem.aspx.cs" Inherits="YachtKlubas.Items.AddNew.AddNewItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Add New Item</h1>
            <div>
                <asp:Label ID="AddItemsName" runat="server" Text="Name: "></asp:Label>
                <asp:TextBox ID="AddItemsNameBox" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="AddItemsImageLink" runat="server" Text="Image Link: "></asp:Label>
                <asp:TextBox ID="AddItemsImageLinkBox" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="AddItemsInfo" runat="server" Text="Description: "></asp:Label>
                <asp:TextBox ID="AddItemsInfoBox" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="AddItemsQuantity" runat="server" Text="Quantity: "></asp:Label>
                <asp:TextBox ID="AddItemsQuantityBox" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="AddItemsPrice" runat="server" Text="Price: "></asp:Label>
                <asp:TextBox ID="AddItemsPriceBox" runat="server"></asp:TextBox>
                <br />

                <asp:Button ID="AddNewItemSubmit" runat="server" Text="Submit" />
            </div>
        </div>
    </form>
</body>
</html>
