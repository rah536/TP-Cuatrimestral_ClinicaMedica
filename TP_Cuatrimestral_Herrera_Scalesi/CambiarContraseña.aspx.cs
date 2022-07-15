using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP_Cuatrimestral_Herrera_Scalesi
{
    public partial class CambiarContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            PersonaNegocio persona = new PersonaNegocio();
            List<Persona> lista = persona.listar();
            string usuario = txtUsuario.Text;
            string cont = txtCont.Text;


            if (persona.validaUsuario(usuario, lista) != null)
            {
                if (persona.modificarContraseña(usuario, cont))
                {
                    Response.Redirect("GuardadoExitoso.aspx", false);
                    //response redirect Guardado Exitoso
                }
            }

            else
            {
                lblUsuarioContInvalido.Text = "El usuario no existe";
                //lblEl usuario no existe
                //F5
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("LOGIN.aspx", false);
        }
    }
}