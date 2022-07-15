<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agenda.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.Agenda" %>

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
     <div class="card text-center m-auto">
            <div class="card-header">
                <img src="img/agenda.png" margin="5" width="70" alt="agenda" />
                <h2 class="card-title">Agenda</h2>
                <asp:Label ID="lblMedicoNombreApellido" runat="server" Text=""></asp:Label>
            </div>


        <div class="card-body">
            <table class="table table-info container-sm">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Lunes</th>
                        <th scope="col">Martes</th>
                        <th scope="col">Miercoles</th>
                        <th scope="col">Jueves</th>
                        <th scope="col">Viernes</th>
                        <th scope="col">Sabado</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope="row">10:00</th>
                        <td>
                           <asp:Label ID="lbl10Lunes" runat="server" Text=""></asp:Label >
                                   
                        </td>
                        <td>
                             
                         <asp:Label ID="lbl10Martes" runat="server" Text=""></asp:Label >
                                   
                        </td>
                        <td>
                            
                           <asp:Label ID="lbl10Miercoles" runat="server" Text="" style=""></asp:Label >

                        </td>
                        <td>
                            
                           <asp:Label ID="lbl10Jueves" runat="server" Text=""></asp:Label >
                                    
                         
                        </td>
                        <td>
                            
                           <asp:Label ID="lbl10Viernes" runat="server" Text=""></asp:Label >
                           
                        
                        
                        </td>
                        <td>
                             
                            <asp:Label ID="lbl10Sabado" runat="server" Text="" ></asp:Label >
                                    
                         
                        </td>

                    </tr>
                    <tr>
                        <th scope="row">11:00</th>
                        <td>
                             
                           <asp:Label ID="lbl11Lunes" runat="server" Text=""></asp:Label >
                             
                        </td>
                        <td>
                             
                             <asp:Label ID="lbl11Martes" runat="server" Text="" ></asp:Label >
                                    
                         
                        </td>
                        <td>
                             
                           <asp:Label ID="lbl11Miercoles" runat="server" Text=""></asp:Label >
                             
                        </td>
                        <td>
                             
                            <asp:Label ID="lbl11Jueves" runat="server" Text="" ></asp:Label >
                           
                        </td>
                        <td>
                             
                            <asp:Label ID="lbl11Viernes" runat="server" Text=""></asp:Label >
                          
                        </td>
                        <td>
                            
                          <asp:Label ID="lbl11Sabado" runat="server" Text=""></asp:Label >
                             
                        </td>

                    </tr>
                    <tr>
                        <th scope="row">12:00</th>
                        <td>
                             
                            <asp:Label ID="lbl12Lunes" runat="server" Text=""></asp:Label >
                             
                        </td>
                        <td>
                             
                           <asp:Label ID="lbl12Martes" runat="server" Text="" ></asp:Label >
                              
                        </td>
                        <td>
                            
                            <asp:Label ID="lbl12Miercoles" runat="server" Text=""></asp:Label >
                              
                        </td>
                        <td>
                            
                            <asp:Label ID="lbl12Jueves" runat="server" Text=""></asp:Label >
                              
                        </td>
                        <td>
                            
                              <asp:Label ID="lbl12Viernes" runat="server" Text=""></asp:Label >
                               
                        </td>
                        <td>
                            
                            <asp:Label ID="lbl12Sabado" runat="server" Text=""></asp:Label >
                              
                        </td>

                    </tr>
                    <tr>
                        <th scope="row">13:00</th>
                        <td>
                            
                            <asp:Label ID="lbl13Lunes" runat="server" Text=""></asp:Label >
                               
                        </td>
                        <td>
                            
                            <asp:Label ID="lbl13Martes" runat="server" Text=""></asp:Label >
                              
                        </td>
                        <td>
                           
                           <asp:Label ID="lbl13Miercoles" runat="server" Text="" ></asp:Label >
                                
                        </td>
                        <td>
                            
                            <asp:Label ID="lbl13Jueves" runat="server" Text="" ></asp:Label >
                                
                        </td>
                        <td>
                            
                           <asp:Label ID="lbl13Viernes" runat="server" Text="" ></asp:Label >
                               
                        </td>
                        <td>
                            
                            <asp:Label ID="lbl13Sabado" runat="server" Text="" ></asp:Label >
                               
                        </td>

                    </tr>
                    <tr>
                        <th scope="row">14:00</th>
                        <td>
                            
                            <asp:Label ID="lbl14Lunes" runat="server" Text="" ></asp:Label >
                               
                        </td>
                        <td>
                            
                            <asp:Label ID="lbl14Martes" runat="server" Text=""></asp:Label >
                              
                        </td>
                        <td>
                            
                            <asp:Label ID="lbl14Miercoles" runat="server" Text=""></asp:Label >
                             
                        </td>
                        <td>
                            
                           <asp:Label ID="lbl14Jueves" runat="server" Text=""></asp:Label >
                               
                        </td>
                        <td>
                            
                            <asp:Label ID="lbl14Viernes" runat="server" Text=""></asp:Label >
                               
                        </td>
                        <td>
                            
                            <asp:Label ID="lbl14Sabado" runat="server" Text=""></asp:Label >
                                
                        </td>


                    </tr>
                    <tr>
                        <th scope="row">15:00</th>
                        <td>
                            
                            <asp:Label ID="lbl15Lunes" runat="server" Text=""></asp:Label >
                              
                        </td>
                        <td>
                            
                            <asp:Label ID="lbl15Martes" runat="server" Text=""></asp:Label >
                                
                        </td>
                        <td>
                            
                           <asp:Label ID="lbl15Miercoles" runat="server" Text=""></asp:Label >
                               
                        </td>
                        <td>
                            
                            <asp:Label ID="lbl15Jueves" runat="server" Text=""></asp:Label >
                             
                        </td>
                        <td>
                            
                            <asp:Label ID="lbl15Viernes" runat="server" Text=""></asp:Label >
                                
                        </td>
                        <td>
                           
                          <asp:Label ID="lbl15Sabado" runat="server" Text=""></asp:Label >
                               
                        </td>

                    </tr>


                </tbody>
            </table>
        </div>
        <div class="card-footer mb-md-3 w-50 list-group-item-info m-auto">
            <div class="mb-3" style="margin-top: 50px;">
                <h4>Cargar horario</h4>
                <label for="ddlDiaInicio" class="form-label">Dia Inicio</label>
                <asp:DropDownList ID="ddlDiaInicio" CssClass="form-select" runat="server" AutoPostback ="true" OnSelectedIndexChanged="ddlDiaInicio_SelectedIndexChanged">
                </asp:DropDownList>
            
                <label for="ddlHoraInicio" class="form-label">Hora Inicio</label>
                <asp:DropDownList ID="ddlHoraInicio" CssClass="form-select" runat="server" OnSelectedIndexChanged="ddlHoraInicio_SelectedIndexChanged">
                </asp:DropDownList>
            
                <label for="ddlHoraFin" class="form-label">Hora Fin</label>
                <asp:DropDownList ID="ddlHoraFin" CssClass="form-select" runat="server">
                </asp:DropDownList>
            
                <label for="ddlEspecialidades" class="form-label">Especialidades</label>
                <asp:DropDownList ID="ddlEspecialidades" CssClass="form-select" runat="server">
                </asp:DropDownList>
            
            </div>
            <div style="padding:10px">
                <asp:Button ID="btnVolver" CssClass=" btn btn-danger" runat="server" Text="Volver" OnClick="btnVolver_Click" />
            </div>
        </div>
    
    </div>
    </form>
</body>
</html>
