<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOGIN.aspx.cs" Inherits="TP_Cuatrimestral_Herrera_Scalesi.LOGIN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous"/>
    <link rel="stylesheet" href="estilos/estilos.css"/>
</head>
<body class="estiloBody">
    <form id="form1" runat="server">
        
      <div class="card" id="estiloCardLogin">
            <div class="card-header">
               <h2>LOGIN</h2>
                <div>
                <img src="img/login.png" cssclass="img-fluid" width="70" alt="img login" />
                </div>
            </div>
    
          <div class="card-body">

               <div>
                  <h6>Usuario</h6>
                  <asp:TextBox ID="txtUsuario" type="email" CssClass="text-center" runat="server"></asp:TextBox>
               </div>

               <div style="padding-top:20px;">
                  <h6>Contraseña</h6>
                  <asp:TextBox ID="txtContraseña" type="password" CssClass="text-center" runat="server"></asp:TextBox>
               </div>

              <div style="color:red;">
                   <asp:Label ID="lblUsuarioContInvalido" runat="server" Text=""></asp:Label>
              </div>

          </div> 
    
          <div class="card-footer" style="padding-top:20px;">
              <div>
                  <asp:Button ID="btnIngresar" cssclass="btn" runat="server" Text="INGRESAR" style="background-color: lightgreen;" OnClick="btnIngresar_Click" />
              </div>
              <div>
                  <br />
                  <asp:Button ID="btnRecPassword" cssclass="btn btn-outline-dark" runat="server" Text="Modificar Contraseña" OnClick="btnRecPassword_Click" />
              </div>
         </div>
     </div>
    
    
    
    </form>
</body>
</html>
