<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CrudTarea.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="ButtonSubirInformacion" runat="server" OnClick="ButtonSubirInformacion_Click" Text="Cargar info csv SQL" Width="172px" />
        <asp:Button ID="Button_CargarInformacionMySQL" runat="server" OnClick="Button_CargarInformacionMySQL_Click" Text="Cargar infor csv MySQL" />
    </form>
</body>
</html>
