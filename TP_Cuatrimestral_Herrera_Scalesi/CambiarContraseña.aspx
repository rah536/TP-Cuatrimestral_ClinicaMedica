<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarContraseña.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.CambiarContraseña" %>

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
                <h2>Usuario: Cambiar Contraseña</h2>
                <div>
                    <img src="img/cambiarcontraseña.png" cssclass="img-fluid" width="70" alt="admin2" />
                </div>
            </div>

            <div class="card-body m-auto">
                <div class="row mb-2">
                    <div class="col">
                        <asp:Label ID="lblIngresarUsuario" runat="server" Text="Ingrese Usuario: "></asp:Label>
                    </div>
                    <div class="col">
                        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    </div>
                </div>  
                <div class="row">
                    <div class="col">
                        <asp:Label ID="lblIngresarCont" runat="server" Text="Nueva Contraseña: "></asp:Label>
                    </div>
                    <div class="col " style="color:red;">
                       <asp:TextBox ID="txtCont" runat="server"></asp:TextBox>
                        <br />
                       <asp:Label ID="lblUsuarioContInvalido" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                    <div class="m-4 text-center">
                        <asp:Button ID="btnModificar" CssClass="btn btn-success" runat="server" Text="Aceptar" OnClick="btnModificar_Click" />
                    </div>
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
