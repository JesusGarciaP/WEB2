<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerosGrupoForm.aspx.cs" Inherits="ejercicio01.GenerosGrupoForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        IdGrupo<br />
        <asp:TextBox ID="txtIdGrupo" runat="server"></asp:TextBox>
        <br />
        IdGenero<br />
        <asp:TextBox ID="txtIdGenero" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
        <asp:Button ID="btnCancelar" runat="server" style="margin-left: 23px" Text="Cancelar" />
        <br />
    
    </div>
    </form>
</body>
</html>
