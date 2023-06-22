<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FacturasCliente.aspx.cs" Inherits="FacturasCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Facturas"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Cliente:"></asp:Label>
            <asp:Label ID="LabelNombre" runat="server" Text="?????????"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="ButtonVolver" runat="server" Text="Volver" />
        </div>
    </form>
</body>
</html>
