<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerRoles.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.VerRoles" %>

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
        <div class="card" id="estiloRoles">
            <div class="card-header">
                 <div>
                     <h3>ROLES/PERFILES de Usuarios</h3>
                </div>
            </div>
            <div class="card-body">
                <div>
                      <asp:GridView ID="dgvRoles" cssclass="table table-bordered d-table-cell"  AutoGenerateColumns="false" runat="server">
                            <Columns>
                                <asp:BoundField HeaderText="ID ROL" DataField="id"/>
                                <asp:BoundField HeaderText="Nombre" DataField="nombre"/>
                            </Columns>
                      </asp:GridView>
                </div>
            </div>
            <div class="card-footer">
                <div>
                    <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click"/>
                </div>
            </div>
       </div>
    </form>
</body>
</html>
