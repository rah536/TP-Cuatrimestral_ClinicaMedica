<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MEDICOListadoTurnos.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.MEDICOListadoTurnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous"/>
    <link rel="stylesheet" href="estilos/estilos.css"/>
    <title></title>
</head>
<body class="estiloBody">
    <form id="form1" runat="server">
        
         <div class="card">
  
            <div class="card-header">
                <div>
                   <asp:Label ID="lblHolaMedico" runat="server" Text="Hola "></asp:Label>
                </div>
            </div>
  
            <div class="card-body">
                 <div>
                    <asp:GridView ID="dgvListadoTurnos" runat="server"></asp:GridView>
                 </div>
    
                 <div>
                    <asp:Button ID="btnModAgrDiagnostico" runat="server" Text="Agregar/Modificar Diagnostico" style="background-color:lightgreen;" OnClick="btnModAgrDiagnostico_Click" />
                 </div>
            </div>
  
            <div class="card-footer">
                <asp:Button ID="btnSalir" runat="server" Text="Salir" style="background-color: lightcoral;" />
            </div>
       
        </div>
    
    </form>

     

</body>
</html>
