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
    public partial class LOGIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            PersonaNegocio personaNegocio = new PersonaNegocio();
            List<Persona> lista = new List<Persona>();
            lista = personaNegocio.listar();

            //Metodo que valida con usuario y cont
            //y devuelve la persona
            string email = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            Persona persona = new Persona();
            persona = personaNegocio.validaUsuarioContraseña(email, contraseña, lista);

            if (persona != null)
            {
                switch (persona.Rol.Id)
                {
                    case 1:

                        //Recepcionista

                        //Debo llevar datos hacia otro Formulario (usaria
                        //una variable de tipo Session)

                        Session.Add("nombre", persona.Nombre);
                        Session.Add("apellido", persona.Apellido);
                        Session.Add("id", persona.Rol.Id);
                        Response.Redirect("RecepcionistaFormularioPrincipal.aspx", false);
                        break;


                    case 2:

                        Medico medico = new Medico();
                        MedicoNegocio medicoNegocio = new MedicoNegocio();

                        medico = medicoNegocio.buscarMedico(persona.Id);

                        Session.Add("nombre", persona.Nombre);
                        Session.Add("apellido", persona.Apellido);
                        Response.Redirect("MedicoListadoTurnos.aspx", false);
                        break;

                    case 3:

                        //ADMINISTRADOR
                        Session.Add("nombre", persona.Nombre);
                        Session.Add("apellido", persona.Apellido);
                        Session.Add("id", persona.Rol.Id);
                        Response.Redirect("AdministradorPrincipal.aspx", false);

                        break;

                }
            }
            else
            {
                lblUsuarioContInvalido.Text += "El usuario o contraseña son invalidos";
            }

        }

        protected void btnRecPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("CambiarContraseña.aspx", false);
        }
    }
}