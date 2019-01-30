<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GrupoForm.aspx.cs" Inherits="ejercicio01.GrupoForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        IdGrupo:<br />
        <asp:TextBox ID="txtIdGrupo" runat="server"></asp:TextBox>
        <br />
        Nombre:<br />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        Formacion:<asp:Calendar ID="clnFormacion" runat="server"></asp:Calendar>
        <br />
        Desintegracion:<asp:Calendar ID="clnDesintegracion" runat="server"></asp:Calendar>
        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
        <asp:Button ID="btnCancelar" runat="server" style="margin-left: 45px" Text="Cancelar" />
        <br />
    
    </div>
    </form>
</body>
</html>
