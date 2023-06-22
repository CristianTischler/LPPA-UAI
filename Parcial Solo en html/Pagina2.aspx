<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina2.aspx.cs" Inherits="Pagina2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Pagina 2</title>
    <link href="Pagina2.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="title">Datos:</h1>
            <div class="containerRow">
                <h1 class="label">Nombre:</h1>
                <input class="info" type="text" name="nombre" value="" readonly="readonly" id="txtNombre" runat="server"/>
            </div>
            <div class="containerRow">
                <h1 class="label">Apellido:</h1>
                <input class="info" type="text" name="apellido" value="" readonly="readonly" id="txtApellido" runat="server"/>
            </div>
            <div class="containerRow">
                <h1 class="label">Email:</h1>
                <input class="info" type="email" name="email" value="" readonly="readonly" id="txtEmail" runat="server"/>
            </div>
            <div class="containerRow">
                <h1 class="label">Temas de interes:</h1>
                <input class="info" type="text" name="temas" value="" readonly="readonly" id="txtTemas" runat="server"/>
            </div>
            <div class="containerRow">
                <h1 class="label">Pais</h1>
                <input class="info" type="text" name="pais" value="" readonly="readonly" id="txtPais" runat="server"/>
            </div>
            <div class="containerRow">
                <h1 class="label">Comentario</h1>
                <input class="info" type="text" name="comentario" value="" readonly="readonly" id="txtComentario" runat="server"/>
            </div>
        </div>
    </form>
</body>
</html>
