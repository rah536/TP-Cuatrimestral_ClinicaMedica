<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTABrindarTurnos.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RECEPCIONISTABrindarTurnos" %>

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
    <asp:ScriptManager id="ScriptManager1" runat="server"></asp:ScriptManager>

        <div class="card">

            <div class="card-header" style="text-align:center">
                <h2>Brindar Turno: Listado Pacientes</h2>
                <div>
                    <img src="img/turno.png" cssclass="img-fluid" margin="5" width="70" alt="img turno" />
                </div>
            </div>

            <div class="card-body m-auto">
                <div>
                    <!--<asp:UpdatePanel runat="server">
                        <ContentTemplate>-->
                    <asp:Label ID="lblFiltrar" runat="server" Text="Filtro: "></asp:Label>
                    <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
                    <asp:Button ID="btnFiltrar" runat="server" Text="Buscar" OnClick="btnFiltrar_Click"  />
                    <br />
                    <br />
                    <!--</ContentTemplate>
                    </asp:UpdatePanel>-->
                </div>
                <asp:GridView ID="dgvListarPacientes" CssClass="table table-hover d-sm-table-cell alig-middle text-center" AutoGenerateColumns="false" runat="server" OnSelectedIndexChanged="dgvListarPacientes_SelectedIndexChanged">
                    <columns>
                        <asp:BoundField HeaderText="ID" DataField="Id"/>
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido"/>
                        <asp:BoundField HeaderText="DNI" DataField="Dni"/>
                        <asp:BoundField HeaderText="CUIT" DataField="Cuit"/>
                        <asp:BoundField HeaderText="Telefono" DataField="Telefono"/>
                        
                        <asp:BoundField HeaderText="Email" DataField="Email"/>
                    
                        <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" ControlStyle-CssClass="btn btn-info" />
                    
                    </columns>
                </asp:GridView>
                <div class="text-center p-3 pb-0">
                     <asp:Button ID="btnNuevoTurno" Visible="false" CssClass="btn" runat="server" Text="Nuevo turno" style="background-color:lightgreen;" OnClick="btnNuevoTurno_Click"/>
                </div>
            </div>
            <div class="card-footer">
                <div class="text-center p-2">
                    <asp:Button ID="VolverAtras" CssClass="btn btn-danger" runat="server" Text="Volver" OnClick="VolverAtras_Click"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
