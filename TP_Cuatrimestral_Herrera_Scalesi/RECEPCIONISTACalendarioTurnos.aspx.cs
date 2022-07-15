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
    public partial class RECEPCIONISTACalendarioTurnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CARGAR EL ddl
            if (!IsPostBack)
            {

                ddlHorarios.Items.Add("10");
                ddlHorarios.Items.Add("11");
                ddlHorarios.Items.Add("12");
                ddlHorarios.Items.Add("13");
                ddlHorarios.Items.Add("14");
                ddlHorarios.Items.Add("15");
            }
        }

        protected void btnCargarObservaciones_Click(object sender, EventArgs e)
        {
            //RECUPERO idPersona,idMedico,idEspecialidad

            int idPaciente = int.Parse(Request.QueryString["idPaciente"].ToString());
            int idEspecialidad = int.Parse(Request.QueryString["idEspecialidad"].ToString());
            int idPersona = int.Parse(Request.QueryString["idPersona"].ToString());

            //BUSCO A QUE IDMEDICO CORRESPONDE ESE IDPERSONA

            MedicoNegocio medicoNegocio = new MedicoNegocio();
            int idMedico = medicoNegocio.buscaMedicoId(idPersona);

            //TOMO EL HORARIO SELECCIONADO EN EL ddl

            string horaSeleccionada = ddlHorarios.SelectedItem.ToString();
            int hora = int.Parse(horaSeleccionada);

            //TOMO LA FECHA SELECCIONADA EN EL CALENDARIO

            DateTime fechaSeleccionada = calCalendario.SelectedDate;

            //EXTRAIGO EL DIA DE ESA FECHA PARA PODER VER EN AGENDA SI 
            //ESE DIA TRABAJA ESE MEDICO

            DayOfWeek dia = fechaSeleccionada.DayOfWeek;

            //PASO ESE DIA A ENTERO YA QUE EN BD LOS TENGO COMO ENTEROS
            //A LOS DIAS

            int numdia = 0;

            if (dia == DayOfWeek.Monday) numdia = 1;
            if (dia == DayOfWeek.Tuesday) numdia = 2;
            if (dia == DayOfWeek.Wednesday) numdia = 3;
            if (dia == DayOfWeek.Thursday) numdia = 4;
            if (dia == DayOfWeek.Friday) numdia = 5;
            if (dia == DayOfWeek.Saturday) numdia = 6;

            //ME TRAIGO LA AGENDA PARA ESE MEDICO Y ESA ESPECIALIDAD
            AgendaNegocio agendaNegocio = new AgendaNegocio();
            List<Dominio.Agenda> listaAgendas = new List<Dominio.Agenda>();

            listaAgendas = agendaNegocio.listarIdMedicoIdEspecialidad(idEspecialidad, idMedico);

            //RECORRO LA AGENDA PARA VER SI TRABAJA ESE DIA Y ESE
            //HORARIO
            //SI TRABAJA BUSCO LOS TURNOS

            foreach (var item in listaAgendas)
            {
                //TRABAJA ESE DIA?
                if (item.DiaInicio == numdia)
                {
                    //TRABAJA ESE HORARIO?
                    if (item.HoraInicio == hora)
                    {
                        //ME TRAIGO EL LISTADO DE TURNOS

                        List<Turno> listadoTurnos = new List<Turno>();
                        TurnoNegocio turnoNegocio = new TurnoNegocio();

                        //listadoTurnos = turnoNegocio.listar();

                        //HAGO METODO PARA TRAERME MEDICO Y ESPECIALIDAD
                        //Y PARA ESA FECHA Y ESA HORA, SI VIENE REGISTRO
                        //ESTA TOMADO SI NO SE PUEDE DAR EL TURNO (bool)

                        bool encontroTurnoMedico = turnoNegocio.buscarTurnoMedico(idEspecialidad, idMedico, fechaSeleccionada, hora);

                        //BUSCO PACIENTE SI EN ESA FECHA Y HORA TIENE
                        //ALGO SIN IMPORTAR ESPECIALIDAD (bool)

                        PacienteNegocio pacienteNegocio = new PacienteNegocio();
                        bool encontroTurnoPaciente = turnoNegocio.buscarTurnoPaciente(fechaSeleccionada, hora,idPaciente);
                        
                        //SI NO ENCONTRO DE AMBOS SE PUEDE TOMAR EL TURNO
                        
                        if (!encontroTurnoMedico && !encontroTurnoPaciente)
                        {
                            //PUEDO TOMAR EL TURNO


                        }
                        
                        
                        
                       

                        //SI LOS DOS SON true O false RECIEN AHI PUEDE TOMAR 
                        //EL TURNO

                        //CAMBIAR
                        /*
                        foreach (var turno in listadoTurnos)
                        {
                            //EL TURNO DEPENDE DE SI EL MEDICO LO TOMO
                            if (turno.Medico.Id == idMedico)
                            {
                                //SI COINCIDEN FECHA HORA NO PODRA TOMAR EL TURNO

                                if (turno.FechaTurno == fechaSeleccionada && turno.HoraTurno == hora)
                                {
                                    //NO PUEDE TOMAR EL TURNO
                                }
                            }
                            else
                            {
                                //PUEDE TOMAR EL TURNO
                                //REDIRECCIONO AL FORMULARIO DE CARGAR OBSERVACIONES
                            }
                        }
                        */


                    }
                    else
                    {
                        //ESE HORARIO NO TRABAJA
                    }

                }
                else
                {
                    //ESE DIA NO TRABAJA
                }
            }




        }
    }
}