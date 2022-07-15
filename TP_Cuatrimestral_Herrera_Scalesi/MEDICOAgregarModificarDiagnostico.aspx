<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MEDICOAgregarModificarDiagnostico.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.MEDICOAgregarModificarDiagnostico" %>

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
        
       <div class="card" id="estiloModificarDiagnostico">
           
            <div class="card-header">
               <asp:Label ID="lblTituloDiagnostico" runat="server" Text="Ingrese aqui el diagnostico:"></asp:Label>
           </div>
           
            <div class="card-body">
               <div>
                   <asp:TextBox ID="txtDiagnostico" runat="server" TextMode="MultiLine"></asp:TextBox>
               </div>
    
               <div>
                   <asp:Button ID="btnGuardar" runat="server" Text="Guardar" style="background-color:lightgreen;"/>
               </div>
           </div>
           
           <div class="card-footer">
                  <asp:Button ID="btnVolverATurnos" runat="server" Text="Volver a Turnos" style="background-color:lightcoral;" OnClick="btnVolverATurnos_Click"/>
           </div>
        
       </div>
     
    </form>

</body>
</html>
