<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTAFormularioEspecialidades.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RECEPCIONISTAFormularioEspecialidades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous"/>
    <link rel="stylesheet" href="estilos/estilos.css"/>
    <title></title>
</head>
<body class="estiloBody">
    <form id="form1" runat="server">
     <div class="card" id="estiloCardRecepcionistaEsp">

        <div class="card-header" style="text-align:center">
            <h2>Brindar Turno: Especialidades</h2>
        </div>
        <div class="card-body m-auto">
            <div>
                <asp:Label ID="lblEspecialidad" runat="server" Text="Especialidad"></asp:Label> 
            </div>
            <div>
                <asp:DropDownList ID="ddlEspecialidades" runat="server" AutoPostBack="true" ></asp:DropDownList>
            </div>
        </div>
        <div class="card-footer">
            <div class="text-center p-2">
                <asp:Button ID="btnContinuarAHorariosMedicos" runat="server" Text="Continuar" OnClick="btnContinuarAHorariosMedicos_Click" />
            </div>
        </div>

    </div>
    </form>
</body>
</html>
