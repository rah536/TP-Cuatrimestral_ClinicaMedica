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
    public partial class VerRoles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RolNegocio rol = new RolNegocio();
            dgvRoles.DataSource = rol.listar();
            dgvRoles.DataBind();


        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("LOGIN.aspx", false);
        }
    }
}