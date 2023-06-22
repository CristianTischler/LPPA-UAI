<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Clientes.aspx.cs" Inherits="_Default" OnUnload="Page_Unload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 481px">
    <form id="form1" runat="server" method="post">
        <div>
        </div>
        <asp:Label ID="LabelTitulo" runat="server" Text="Clientes"></asp:Label>
        <br />
        <asp:Label ID="LabelCodigo" runat="server" Text="Codigo Cliente:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxCodigo" runat="server"></asp:TextBox>
        &nbsp;&nbsp; Cliente:<asp:Label ID="LabelNombre" runat="server" Text="??????"></asp:Label>
        <br />
        <asp:Button ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Buscar" />
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Width="102px">
            <asp:ListItem>Cookie</asp:ListItem>
            <asp:ListItem>Session</asp:ListItem>
            <asp:ListItem>Request</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Button ID="ButtonSiguiente" runat="server" Text="Siguiente" OnClick="ButtonSiguiente_Click" />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
