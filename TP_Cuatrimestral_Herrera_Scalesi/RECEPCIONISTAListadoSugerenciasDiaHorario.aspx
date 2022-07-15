<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTAListadoSugerenciasDiaHorario.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RECEPCIONISTAListadoSugerenciasDiaHorario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <asp:Label ID="lblDisponibilidad" runat="server" Text="Algunos dias y horarios sugeridos para "></asp:Label>
        </div>
        
        <div>

            <asp:GridView ID="grvAgenda" runat="server"></asp:GridView>

        </div>
        

    </form>
</body>
</html>
