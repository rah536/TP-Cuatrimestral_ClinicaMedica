using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Cuatrimestral_Herrera_Scalesi
{
    public partial class MEDICOAgregarModificarDiagnostico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombre"] == null || Session["apellido"] == null || (int)Session["id"] == 1)
            {
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnVolverATurnos_Click(object sender, EventArgs e)
        {
            Response.Redirect("MEDICOListadoTurnos.aspx",false);
        }
    }
}