<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Storage.aspx.cs" Inherits="YachtKlubas.Storage.Storage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Meniu DAr reikia pagrindini pridet</h1>
            <h1>Storage page</h1>
            <p>
                <asp:CheckBox ID="CheckBox1" runat="server" />
                <asp:Label ID="PrekesPavadinimas" runat="server" Text="Prekes Pav"></asp:Label>
                <asp:Button ID="Edit" runat="server" Text="Edit" OnClick="Edit_Click1" />
            </p>
        </div>
    </form>
</body>
</html>
