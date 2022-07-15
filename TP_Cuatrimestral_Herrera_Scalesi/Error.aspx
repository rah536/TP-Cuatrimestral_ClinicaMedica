<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.Error" %>

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
        <div class="card text-center m-auto mt-5" style="width: 18rem;" >
            <div class="card-header">
                <div>
                    <img src="img/loginlock.png" margin="5" width="80" alt="log" />
                    <h5 class="card-title">Error de perfil</h5>
                </div>
            </div>
            <div class="card-body">
                <div>
                    <a><asp:Label ID="lblError" runat="server" Text=""></asp:Label></a>
                </div>
           </div>
            <div class="card-footer">
                <div>
                    <asp:Button ID="btnVolver" CssClass="btn btn-danger" runat="server" Text="Volver" OnClick="btnVolver_Click" />
                </div>
            </div>
       </div>
    </form>
</body>
</html>
