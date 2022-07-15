<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTAFormularioNuevoPaciente.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.RECEPCIONISTAFORMULARIONUEVOPACIENTE" %>

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


        <div class="row">
            <div class="col-9">
                <div class="card" id="estiloRecepcionistaNuevoPaciente">
                    <div class="card-header">
                        <h2 style="text-align: center;">Alta de pacientes</h2>
                    </div>
                    <div class="card-body">
                        <div class="mb-3">
                            <asp:Label ID="lblId" Visible="false" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="mb-3">
                            <label for="txtNombre" class="form-label">Nombre</label>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="Ingrese nombre" ControlToValidate="txtNombre" style="color:darkred;"></asp:RequiredFieldValidator>
                        </div>
                        <div class="mb-3">
                            <label for="txtApellido" class="form-label">Apellido</label>
                            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ErrorMessage="Ingrese apellido" ControlToValidate="txtApellido" style="color:darkred;"></asp:RequiredFieldValidator>
                        </div>
                        <div class="mb-3">
                            <label for="txtDni" class="form-label">Dni</label>
                            <asp:TextBox ID="txtDni" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="revDni" runat="server" ErrorMessage="Ingresar solo numeros" ControlToValidate="txtDni" ValidationExpression="^\d+$" style="color:darkred;"></asp:RegularExpressionValidator>
                        </div>
                        <div class="mb-3">
                            <label for="txtCuit" class="form-label">Cuit</label>
                            <asp:TextBox ID="txtCuit" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label for="txtTelefono" class="form-label">Telefono</label>
                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label for="txtFechaNacimiento" class="form-label">Fecha de nacimiento</label>
                            <asp:TextBox ID="txtFechaNacimiento" TextMode="Date" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        
                        <div class="mb-3">
                            <label for="txtDireccion" class="form-label">Direccion</label>
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label for="txtEmail" class="form-label">Email</label>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="revMail" runat="server" ErrorMessage="Email invalido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" style="color:darkred;" ControlToValidate="txtEmail"></asp:RegularExpressionValidator>
                        </div>
                        <div class="mb-3">
                            <label for="txtClave" class="form-label">Clave</label>
                            <asp:TextBox ID="txtClave" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>


                    <div class="card-footer text-center">
                        <div>
                            <asp:Button ID="btnGuardar" CssClass="btn" runat="server" style="background-color:lightgreen;" Text="Guardar" OnClick="btnGuardar_Click" />
                            <asp:Label ID="lblGuardadoExitoso" runat="server" Text=""></asp:Label>
                        </div>
                        <div>
                            <br />
                            <asp:Button ID="btnFormularioPrincipal" CssClass="btn btn-danger border-secondary" runat="server" Text=" Volver " OnClick="btnFormularioPrincipal_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
