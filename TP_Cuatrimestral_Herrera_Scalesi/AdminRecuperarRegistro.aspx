<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminRecuperarRegistro.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.AdminRecuperarRegistro" %>

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
                <h2>Administrador: Recuperar Registros</h2>
                <div>
                    <img src="img/adminrr.png" cssclass="img-fluid" width="70" alt="admin2" />
                </div>
            </div>

            <div class="card-body m-auto">
                <asp:Label ID="lblFiltro" runat="server" Text="Filtro"></asp:Label>
                <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
                <asp:Button ID="btnFiltro" runat="server" Text="Buscar" OnClick="btnFiltro_Click" />
                <br />
                <br />
                <asp:GridView ID="dgvListadoBajas" OnSelectedIndexChanged="dgvListadoBajas_SelectedIndexChanged" AutoGenerateColumns="false" CssClass="table table-hover d-sm-table-cell alig-middle text-center" runat="server">
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="Id"/>
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido"/>
                        <asp:BoundField HeaderText="DNI" DataField="Dni"/>
                        <asp:BoundField HeaderText="Cuit" DataField="Cuit" />
                        <asp:BoundField HeaderText="Email" DataField="Email" />
                        <asp:BoundField HeaderText="Telefono" DataField="Telefono"/>
                        <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" ControlStyle-CssClass="btn btn-info" HeaderText="Alta de Registro" />
                    </Columns>
                </asp:GridView>
            </div>

            <div class="card-footer">
                <div class="text-center p-2">
                    <asp:Button ID="btnVolver" CssClass="btn btn-danger" runat="server" Text="Volver" OnClick="btnVolver_Click" />
                </div>
            </div>
       </div>
    </form>
</body>
</html>
