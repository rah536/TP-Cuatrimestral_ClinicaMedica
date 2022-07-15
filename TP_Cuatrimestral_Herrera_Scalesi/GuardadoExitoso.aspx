<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuardadoExitoso.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.GuardadoExitoso" %>

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
        <div class="card text-center m-auto mt-5" style="width: 25rem;" >
            <div class="card-header">
                <img src="img/guardadoexitoso.png" margin="5" width="70" alt="guardadoExitoso" />
            </div>
            <div class="card-body">
                <div>
                    <asp:Label ID="lblGuardadoExitoso" runat="server" Text="El registro se guardo/modifico exitosamente"></asp:Label>
                </div>
            </div>
            <div class="card-footer">
                <div>
                    <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-primary" Text="Menu principal" OnClick="btnVolver_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
