<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="YachtKlubas.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>

                <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" />

                <asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click" />

                <br />
                <div>

                    <asp:Button ID="ItemsButton" runat="server" Text="Items" OnClick="Items_Click" />
                    <asp:Button ID="EmployeesButton" runat="server" Text="Employees" OnClick="Employees_Click" />
                    <asp:Button ID="StorageButton" runat="server" Text="Storage" OnClick="Storage_Click" />
                    <asp:Button ID="PackagesButton" runat="server" Text="Packages" OnClick="Packages_Click" />
                    <asp:Button ID="CartButton" runat="server" Text="Cart" OnClick="Cart_Click" style="height: 29px" />
                    <asp:Button ID="FavoriteButton" runat="server" Text="Favorite" OnClick="Favorite_Click" />

                </div>
            </div>
        </div>
    </form>
</body>
</html>
