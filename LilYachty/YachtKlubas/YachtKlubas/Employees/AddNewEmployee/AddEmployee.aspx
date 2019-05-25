<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="YachtKlubas.Employees.AddNewEmployee.AddEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Add New Employee</h1>
            <div>
                <asp:Label ID="EmployeeSelect" runat="server" Text="Select:"></asp:Label>
                <select id="Select1">
                    <option>Vartotojas</option>
                </select>
                <asp:Button ID="SubmitEmployee" runat="server" Text="Submit" />
            </div>
        </div>
    </form>
</body>
</html>
