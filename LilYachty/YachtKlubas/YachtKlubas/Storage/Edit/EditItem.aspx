<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditItem.aspx.cs" Inherits="YachtKlubas.Storage.Edit.EditItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Pagrindinis meniu turi but idetas</p>
            <h1>Edit items Page</h1>
            <asp:Label ID="ItemsName" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="NameBox" runat="server">Pavadinimas</asp:TextBox>
            <br />
            <asp:Label ID="ImageLink" runat="server" Text="Image:"></asp:Label>
            <asp:TextBox ID="ImageLinkBox" runat="server">ImageLink</asp:TextBox>
            <br />
            <asp:Label ID="Quantity" runat="server" Text="Quantity:"></asp:Label>
            <asp:TextBox ID="QuantityBox" runat="server">Kiekis</asp:TextBox>
            <br />
            <asp:Button ID="Submit" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
