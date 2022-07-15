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
    public partial class RECEPBrindarTurnosListadoMedicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //obtengo la especialidad que me llega desde el form anterior
                //y busco su id
                EspecialidadNegocio especialidadNegocio = new EspecialidadNegocio();
                string especialidad = Request.QueryString["especialidad"].ToString();
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


                /*MedicoNegocio medicoNegocio = new MedicoNegocio();
                List<Medico> medicos = medicoNegocio.listar();
                
                medicos = medicos.FindAll(x => x.Especialidad.Id == idEspecialidad);

                dgvListadoMedicos.DataSource = medicos;
                dgvListadoMedicos.DataBind();*/

                //traigo los medicos de esa especialidad
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

                dgvListadoMedicos.DataSource = personas;
                dgvListadoMedicos.DataBind();
            }
        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            //
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            int idPaciente = int.Parse(Request.QueryString["id"].ToString());
            string especialidad = Request.QueryString["especialidad"].ToString();
            Response.Redirect("RECEPCIONISTAListadoSugerencias.aspx?id=" + idPaciente + "&especialidad=" + especialidad, false);
        }
    }
}