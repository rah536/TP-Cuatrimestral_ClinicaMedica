<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTAListadoSugerencias.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RECEPCIONISTAListadoSugerencias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous"/>
    <link rel="stylesheet" href="estilos/estilos.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            
            <div class="card-header" style="text-align:center">
                <h2>Brindar Turno: Listado Medico Sugerido</h2>
                <div>
                    <asp:Label ID="lblSugerencias" runat="server" Text="Algunos medicos disponibles son:"></asp:Label>
                </div>
            </div>

            <div class="card-body m-auto">
                <asp:GridView ID="grvSugerencias" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="grvSugerencias_SelectedIndexChanged">

                    <columns>
                            <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
                            <asp:BoundField HeaderText="Apellido" DataField="Apellido"/>
                            <asp:BoundField HeaderText="IdPersona" DataField="Id"/>
                        
                            <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" ControlStyle-CssClass="btn btn-info" /> 
                    </columns>
                </asp:GridView>
            </div>

            <div class="card-footer">
                <div class="text-center p-2">
                    <asp:Button ID="btnListadoMedicos" CssClass="btn btn-success" runat="server" Text="Todos los Medicos" OnClick="btnListadoMedicos_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
