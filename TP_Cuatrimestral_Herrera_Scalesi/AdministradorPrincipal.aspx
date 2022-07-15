<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdministradorPrincipal.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.AdministradorPrincipal" %>

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
        
          <div class="card card text-center m-auto" id="estiloCardAdmin" style="width: contain; background: linear-gradient(#e9e9e9, #a9a9a9);">
                
                <div>
                    <img src="img/gestiondeturnos.png" alt="gestion turno"/>
                    <h2 style="padding:40px;">
                        <asp:Label ID="lblHolaRecepcionista" runat="server" Text=""></asp:Label>
                    </h2>
                </div>
              <div class="card-header">
                  <img src="img/admin.png" width="70" alt="logo" />
                  <h4 class="card-title">Vista Administrador</h4>
              </div>
                
              <div class="card-body">
                 <div class="container">
                     <div class="row">
                         <div class="col" style="padding-top:10px;">
                             <asp:Button ID="btnListaRecepcionistas" CssClass="btn btn-success" runat="server" Text="Ver Recepcionistas" />
                             <br />
                             <br />
                             <asp:Button ID="btnAltaRecepcionista" CssClass="btn btn-success" runat="server" Text="Alta Recepcionista" />
                         </div>
                 
                          <div class="col" style="padding-top:10px;">
                              <asp:Button ID="btnListaTurnos" CssClass="btn" runat="server" Text="Lista de Turnos" style="background-color: lightblue;" />
                              <br />
                              <br />
                              <asp:Button ID="btnBrindarTurnos" CssClass="btn" runat="server" Text="Brindar Turnos" style="background-color: lightblue;" OnClick="btnBrindarTurnos_Click"/>
                          </div>
                      
                         <div class="col" style="padding-top:10px;">
                                <asp:Button ID="btnListaPacientes" CssClass="btn" runat="server" Text="Lista pacientes" style="background-color:lightgreen;" OnClick="btnListaPacientes_Click" />
                                <br />
                                <br />
                                <asp:Button ID="btnNuevoPaciente" CssClass="btn" runat="server" Text="Nuevo Paciente" style="background-color:lightgreen;" OnClick="btnNuevoPaciente_Click"/>
                         </div>

                         <div class="col" style="padding-top:10px;">
                             <asp:Button ID="btnListaMedicos" CssClass="btn" runat="server" Text="Lista Medicos" style="background-color:dodgerblue;" OnClick="btnListaMedicos_Click" />
                             <br />
                             <br />
                             <asp:Button ID="btnNuevoMedico" CssClass="btn" runat="server" Text="Nuevo Medico" style="background-color:dodgerblue;" OnClick="btnNuevoMedico_Click"/>
                         </div>

                         <div class="col" style="padding-top:10px;">
                             <asp:Button ID="btnAgenda" CssClass="btn btn-secondary" runat="server" Text="Agenda Medica" style="background-color:indianred;" OnClick="btnAgenda_Click" />
                             <br />
                             <br />
                             <asp:Button ID="btnRecuperarRegistro" CssClass="btn btn-dark" runat="server" Text="Recuperar Registro" OnClick="btnRecuperarRegistro_Click" />
                         </div>
                     </div>
                       
                 </div>
               </div>
            
             <div class="card-footer" style="padding-top:20px;">
                    <asp:Button ID="btnSalir" CssClass="btn btn-danger" runat="server" Text="Salir" OnClick="btnSalir_Click"/>
             </div>
        
        
        
        </div>
    
    
    </form>
    
    
</body>
</html>
