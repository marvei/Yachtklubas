<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="YachtKlubas.Employees.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <h1>EMployees page</h1>
            <p>atspausdinti Darbuotojus</p>
           
            <div>
                 <select id="Select1" runat="server" name="D1">
                 </select>
                <asp:Button ID="AddNewEmployee" runat="server" Text="Add New" OnClick="AddNewEmployee_Click" />
            </div>
        </div>
    </form>
</body>
</html>
