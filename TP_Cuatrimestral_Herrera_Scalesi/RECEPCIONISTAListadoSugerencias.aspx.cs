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
    public partial class RECEPCIONISTAListadoSugerencias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //RECIBO INFO DESDE LA URL

            int idPaciente = int.Parse(Request.QueryString["id"].ToString());
            string especialidad = Request.QueryString["especialidad"].ToString();

            //BUSCO ID ESPECIALIDAD

            EspecialidadNegocio especialidadNegocio = new EspecialidadNegocio();
            List<Especialidad> especialidades = new List<Especialidad>();
            especialidades = especialidadNegocio.listar();

            int idEspecialidad = 0;

            foreach (var item in especialidades)
            {
                if (item.Nombre == especialidad)
                {
                    idEspecialidad = item.Id;
                }
            }

            //OBTENGO LOS MEDICOS CON ESA ESPECIALIDAD (de medicos_x_especialidad)
            MedicoNegocio medicoNegocio = new MedicoNegocio();

            List<int> idMedicos = new List<int>();

            idMedicos = medicoNegocio.buscaIdMedicosEspecialidad(idEspecialidad);

            Medico medico = new Medico();

            List<Medico> medicos = new List<Medico>();
            //HAGO UN for CON LA CANT DE ID QUE HAYA

            for (int i = 0; i < idMedicos.Count; i++)
            {
                int idMedico = idMedicos[i];
                medico = medicoNegocio.buscarMedico(idMedico);

                medicos.Add(medico);
            }

            PersonaNegocio personaNegocio = new PersonaNegocio();
            List<Persona> personas = new List<Persona>();
            
            for (int i = 0; i < medicos.Count; i++)
            {
                Persona persona = new Persona();
                int idPersona = medicos[i].IdPersona;
                persona = personaNegocio.buscaPersonaId(idPersona);
                personas.Add(persona);
                
            }

            grvSugerencias.DataSource = personas;
            grvSugerencias.DataBind();
        }

        protected void grvSugerencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = grvSugerencias.SelectedRow.Cells[0].Text;
            string apellido = grvSugerencias.SelectedRow.Cells[1].Text;
            int idPersona = int.Parse(grvSugerencias.SelectedRow.Cells[2].Text);
            string especialidad = Request.QueryString["especialidad"].ToString();

            //BUSCO ID ESPECIALIDAD

            EspecialidadNegocio especialidadNegocio = new EspecialidadNegocio();
            List<Especialidad> especialidades = new List<Especialidad>();
            especialidades = especialidadNegocio.listar();

            int idEspecialidad = 0;

            foreach (var item in especialidades)
            {
                if (item.Nombre == especialidad)
                {
                    idEspecialidad = item.Id;
                }
            }

            Response.Redirect("RECEPCIONISTAListadoSugerenciasDiaHorario.aspx?nombre=" + nombre + "&apellido=" + apellido + "&idPersona=" + idPersona + "&idEspecialidad=" + idEspecialidad, false);

        }

        protected void btnListadoMedicos_Click(object sender, EventArgs e)
        {
            int idPaciente = int.Parse(Request.QueryString["id"].ToString());
            string especialidad = Request.QueryString["especialidad"].ToString();
            Response.Redirect("RECEPBrindarTurnosListadoMedicos.aspx?id="+ idPaciente +"&especialidad=" + especialidad, false);
        }
    }
}