<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MusicosGruposForm.aspx.cs" Inherits="ejercicio01.MusicosGruposForm" %>

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
        IdMusico<br />
        <asp:TextBox ID="txtIdMusico" runat="server"></asp:TextBox>
        <br />
        Instrumento<br />
        <asp:TextBox ID="txtInstrumento" runat="server"></asp:TextBox>
        <br />
        <br />
        fechaInicio<asp:Calendar ID="clnFechaInicio" runat="server"></asp:Calendar>
        <br />
        fechaFin<asp:Calendar ID="clnFechaFin" runat="server"></asp:Calendar>
        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" Width="60px" />
        <asp:Button ID="btnCancelar" runat="server" style="margin-left: 66px" Text="Cancelar" />
        <br />
    
    </div>
    </form>
</body>
</html>
