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
    public partial class AgendaListadoMedicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombre"] == null || Session["apellido"] == null || (int)Session["id"] == 2)
            {
                Response.Redirect("Error.aspx", false);
            }

            if (Session["listaMedicos"] == null)
            {
                MedicoNegocio medicoNegocio = new MedicoNegocio();
                Session.Add("listaMedicos", medicoNegocio.listar());
            }
            if (!IsPostBack)
            {

                dgvListadoMedicos.DataSource = Session["listaMedicos"];
                dgvListadoMedicos.DataBind();
            }
        }

        protected void dgvListadoMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvListadoMedicos.SelectedRow.Cells[0].Text;
            Response.Redirect("Agenda.aspx?id=" + id);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("RECEPCIONISTAFormularioPrincipal.aspx", false);

        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            List<Medico> listaFiltrada = (List<Medico>)Session["listaMedicos"];
            if (txtFiltro.Text != "")
            {
                //faltaria agregar un filtro por especialidad
                listaFiltrada = listaFiltrada.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || x.Apellido.ToUpper().Contains(txtFiltro.Text.ToUpper()));
            }

            dgvListadoMedicos.DataSource = null;
            dgvListadoMedicos.DataSource = listaFiltrada;
            dgvListadoMedicos.DataBind();
        }
    }
}