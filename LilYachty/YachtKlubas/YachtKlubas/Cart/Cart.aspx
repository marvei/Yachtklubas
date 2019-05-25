<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="YachtKlubas.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cart page</h1>
            <p>
                Parodyti susirinktas prekes ir butonas jog paconfirmintu ir sumoketu.
            </p>
            <asp:Button ID="Comfirm" runat="server" Text="Comfirm and Pay" />
        </div>
    </form>
</body>
</html>
