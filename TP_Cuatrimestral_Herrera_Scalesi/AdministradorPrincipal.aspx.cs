using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Cuatrimestral_Herrera_Scalesi
{
    public partial class AdministradorPrincipal : System.Web.UI.Page
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombre"] == null || Session["apellido"] == null || (int)Session["id"] != 3)
            {
                Response.Redirect("Error.aspx", false);
            }
            else
            {
                nombre = Session["nombre"].ToString();
                apellido = Session["apellido"].ToString();
                lblHolaRecepcionista.Text = "Hola " + nombre + " " + apellido;
            }
        }

        protected void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecepcionistaFormularioNuevoPaciente.aspx", false);

        }

        protected void btnBrindarTurnos_Click(object sender, EventArgs e)
        {
            Response.Redirect("RECEPCIONISTABrindarTurnos.aspx", false);

        }

        protected void btnNuevoMedico_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaMedico.aspx", false);
        }

        protected void btnListaPacientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("RECEPCIONISTAListadoPacientes.aspx", false);

        }

        protected void btnListaMedicos_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecepcionistaListadoMedicos.aspx", false);

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx", false);

        }

        protected void btnAgenda_Click(object sender, EventArgs e)
        {
            Response.Redirect("Agenda.aspx", false);
        }

        protected void btnRecuperarRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminRecuperarRegistro.aspx", false);
        }
    }
}