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
    public partial class RECEPCIONISTABrindarTurnos : System.Web.UI.Page
    {
        private List<Paciente> listaPacientes;

        private List<Paciente> listaFiltrada;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombre"] == null || Session["apellido"] == null || (int)Session["id"] == 2)
            {
                Response.Redirect("Error.aspx", false);
            }

            PacienteNegocio pacienteNegocio = new PacienteNegocio();
            dgvListarPacientes.DataSource = pacienteNegocio.listar();
            dgvListarPacientes.DataBind();
            listaPacientes = pacienteNegocio.listar();

        }

        protected void btnNuevoTurno_Click(object sender, EventArgs e)
        {

        }

        protected void VolverAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("RECEPCIONISTAFormularioPrincipal.aspx", false);
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            listaFiltrada = null;
            string filtro = txtFiltro.Text;
            if (filtro != "")
            {
                listaFiltrada = listaPacientes.FindAll(x => x.Nombre == filtro);
            }
            else
            {
                listaFiltrada = listaPacientes;
            }

            dgvListarPacientes.DataSource = null;
            dgvListarPacientes.DataSource = listaFiltrada;
        }

        protected void dgvListarPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvListarPacientes.SelectedRow.Cells[0].Text;
            Response.Redirect("RecepcionistaFormularioEspecialidades.aspx?id=" + id);
        }

        /*protected void VolverAtras_Click1(object sender, EventArgs e)
        {
            //Response.Redirect("RECEPCIONISTAFormularioPrincipal.aspx", false);
        }*/
    }
}