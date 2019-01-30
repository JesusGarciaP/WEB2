<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MusicoForm.aspx.cs" Inherits="ejercicio01.MusicoForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        ID<br />
        <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
        <br />
        <br />
        Nombre:<br />
        <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        Instrumento<br />
        <asp:TextBox ID="txtInstrumento" runat="server"></asp:TextBox>
        <br />
        Lugar de nacimiento:<br />
        <asp:TextBox ID="txtLugarNacimiento" runat="server"></asp:TextBox>
        <br />
        Fecha de nacimiento:<asp:Calendar ID="clnFechaNacimiento" runat="server"></asp:Calendar>
        <br />
        Fecha de muerte:<br />
        <asp:Calendar ID="clnFechaMuerte" runat="server"></asp:Calendar>
        <asp:Button ID="btnAgregar" runat="server" OnClick="Button1_Click" Text="Agregar" />
        <asp:Button ID="btnCancelar" runat="server" style="margin-left: 62px" Text="Cancelar" />
        <br />
    
    </div>
    </form>
</body>
</html>
