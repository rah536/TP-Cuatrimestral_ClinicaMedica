<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTACalendarioTurnos.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RECEPCIONISTACalendarioTurnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:Calendar ID="calCalendario" runat="server" SelectedDate="2022-07-14" ></asp:Calendar>
        </div>
        <div>
            <asp:DropDownList ID="ddlHorarios" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="btnCargarObservaciones" runat="server" Text="Cargar Observaciones" OnClick="btnCargarObservaciones_Click" />

        </div>
    
    </form>
</body>
</html>
