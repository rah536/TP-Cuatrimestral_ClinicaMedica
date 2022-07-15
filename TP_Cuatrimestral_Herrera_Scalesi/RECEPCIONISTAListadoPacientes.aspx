<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTAListadoPacientes.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RECEPCIONISTAListadoPacientes" %>

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
        
    <div class="card">

        <div class="card-header" style="text-align:center">
            <h2>Listado de pacientes</h2>
            <div>
                <img src="img/paciente.png" cssclass="img-fluid" width="70" alt="img paciente" />
            </div>
        </div>

        <div class="card-body m-auto">
            <div>
                <asp:Label ID="lblFiltro" runat="server" Text="Filtro"></asp:Label>
                <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
                <asp:Button ID="btbFiltro" runat="server" Text="Buscar" OnClick="btbFiltro_Click" />
                <br />
                <br />
                <asp:GridView ID="dgvListadoPacientes" OnSelectedIndexChanged="dgvListadoPacientes_SelectedIndexChanged" OnRowDeleting="dgvListadoPacientes_RowDeleting" AutoGenerateColumns="false" cssclass="table table-bordered d-sm-table-cell align-middle text-center align-center"  runat="server">
                    <columns>
                        <asp:BoundField HeaderText="ID" DataField="Id"/>
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido"/>
                        <asp:BoundField HeaderText="DNI" DataField="Dni"/>
                        <asp:BoundField HeaderText="CUIT" DataField="Cuit"/>
                        <asp:BoundField HeaderText="Telefono" DataField="Telefono"/>
                        <asp:BoundField HeaderText="Direccion" DataField="Direccion"/>
                        <asp:BoundField HeaderText="Email" DataField="Email"/>
                        
                        <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" ControlStyle-CssClass="btn btn-info" HeaderText="Modificar" />
                        <asp:CommandField ShowDeleteButton="true" ButtonType="Button" ControlStyle-CssClass="btn btn-danger" HeaderText="Eliminar" />
                    </columns>
                 </asp:GridView>
            </div>
            <div class="mt-5">
                <asp:Panel ID="Panel1" visible="false" BackColor="lightgray" cssclass="modal modal-content m-auto p-3 text-center fixed-bottom position-absolute border-5 border-dark" Height="220px" Width="350px" runat="server">
                    <h5><asp:Label ID="lblPanel"  runat="server" Text="Desea Eliminar El Registro?"></asp:Label></h5>
                    <asp:Button ID="btnPanelAceptar" CssClass="mt-5 mb-3 btn btn-success" runat="server" Text="Aceptar" OnClick="btnPanelAceptar_Click" />
                    <asp:Button ID="btnPanelCancelar" CssClass="btn btn-danger" runat="server" Text="Cancelar" OnClick="btnPanelCancelar_Click" />
                </asp:Panel>
            </div>
        </div>    

        
        <div class="card-footer">
            <div class="text-center p-2">
                <asp:Button ID="btnVolverAFormularioPrincipal" CssClass="btn btn-danger" runat="server" Text="Volver" OnClick="btnVolverAFormularioPrincipal_Click" />
            </div>
        </div>
    </div>
    </form>
   
</body>
</html>
