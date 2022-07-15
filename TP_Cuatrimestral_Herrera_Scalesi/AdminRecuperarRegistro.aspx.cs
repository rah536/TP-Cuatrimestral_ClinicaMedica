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
    public partial class AdminRecuperarRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombre"] == null || Session["apellido"] == null || (int)Session["id"] != 3)
            {
                Response.Redirect("Error.aspx", false);
            }

            if (!IsPostBack)
            {
                //traigo todo el listado de personas, pero me quedo con los que
                //tienen estado 0
                PersonaNegocio persona = new PersonaNegocio();
                List<Persona> listaBajas = persona.listar();
                listaBajas = listaBajas.FindAll(x => x.Estado == false);

                //dgvListadoBajas.DataSource = null;
                dgvListadoBajas.DataSource = listaBajas;
                dgvListadoBajas.DataBind();
            }
        }

        protected void dgvListadoBajas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvListadoBajas.SelectedRow.Cells[0].Text;

            PersonaNegocio persona = new PersonaNegocio();
            if (persona.recuperarRegistroEliminado(id))
            {
                List<Persona> listaBajas = persona.listar();
                listaBajas = listaBajas.FindAll(x => x.Estado == false);
                dgvListadoBajas.DataSource = listaBajas;
                dgvListadoBajas.DataBind();
            }
        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdministradorPrincipal.aspx", false);
        }
    }
}