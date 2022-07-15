using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Cuatrimestral_Herrera_Scalesi
{
    public partial class MEDICOListadoTurnos : System.Web.UI.Page
    {
        public string nombre { get; set; }
        public string apellido { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            nombre = Session["nombre"].ToString();
            apellido = Session["apellido"].ToString();

            lblHolaMedico.Text += nombre + " " + apellido;
            */
            if (Session["nombre"] == null || Session["apellido"] == null || (int)Session["id"] == 1)
            {
                Response.Redirect("Error.aspx", false);
            }
            else
            {
                nombre = Session["nombre"].ToString();
                apellido = Session["apellido"].ToString();
                lblHolaMedico.Text += nombre + " " + apellido;
            }
        }

        protected void btnModAgrDiagnostico_Click(object sender, EventArgs e)
        {
            Response.Redirect("MEDICOAgregarModificarDiagnostico.aspx", false);
        }
    }
}