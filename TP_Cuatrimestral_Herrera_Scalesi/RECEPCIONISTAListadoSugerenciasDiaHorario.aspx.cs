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
    public partial class RECEPCIONISTAListadoSugerenciasDiaHorario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //RECIBO INFO DESDE LA URL (idMedico,idEspecialidad,nombre, apellido)

            int idPersona = int.Parse(Request.QueryString["idPersona"].ToString());
            int idEspecialidad = int.Parse(Request.QueryString["idEspecialidad"].ToString());
            string nombre = Request.QueryString["nombre"].ToString();
            string apellido = Request.QueryString["apellido"].ToString();

            //BUSCO idMedico DE ESA PERSONA

            MedicoNegocio medicoNegocio = new MedicoNegocio();
            Medico medico = new Medico();
            medico = medicoNegocio.buscarMedicoIdPersona(idPersona);

            //ME TRAIGO LA LISTA DE AGENDAS PARA ESE MEDICO

            AgendaNegocio agendaNegocio = new AgendaNegocio();
            
            grvAgenda.DataSource = agendaNegocio.listarIdMedicoIdEspecialidad(idEspecialidad, medico.Id);
            grvAgenda.DataBind();

        }
    }
}