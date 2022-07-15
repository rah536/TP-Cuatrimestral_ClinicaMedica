using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class TurnoNegocio
    {
        public List<Turno> listar()
        {
            List<Turno> lista = new List<Turno>();
            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                datos.setearConsulta("select id,id_medico,id_especialidad,fecha_turno,id_estado,observaciones_medico,observaciones_paciente,hora_turno,id_paciente from turnos");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Turno aux = new Turno();

                    //aux.HoraInicio = (int)datos.Lector["hora_inicio"];
                    aux.Id = (int)datos.Lector["id"];
                    aux.Medico = new Medico();
                    aux.Medico.Id = (int)datos.Lector["id_medico"];
                    aux.Especialidad = new Especialidad();
                    aux.Especialidad.Id = (int)datos.Lector["id_especialidad"];
                    aux.FechaTurno = (DateTime)datos.Lector["fecha_turno"];
                    aux.Estado = new Estado();
                    //aux.Estado.Id = (int)datos.Lector["id_estado"];
                    //aux.ObservacionesMedico = (string)datos.Lector["observaciones_medico"];
                    //aux.ObservacionesPaciente = (string)datos.Lector["observaciones_paciente"];
                    aux.HoraTurno = (int)datos.Lector["hora_turno"];
                    aux.Persona = new Persona();
                    //aux.Persona.Id = (int)datos.Lector["id_paciente"];
                    

                    lista.Add(aux);

                }

                return lista;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }

        }

        public bool buscarTurnoMedico(int idEspecialidad,int idMedico,DateTime fecha, int hora)
        {

            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                datos.setearConsulta("select * from Turnos where id_especialidad= " + idEspecialidad + " and id_medico= " + idMedico + " and fecha_turno= " + fecha + " and hora_turno =" + hora );
                datos.ejecutarLectura();

                if(datos.Lector.Read())
                {

                    return true;

                }
                else
                {
                    return false;
                }
                
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }

            
        }

        public bool buscarTurnoPaciente(DateTime fecha, int hora,int idPaciente)
        {

            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                datos.setearConsulta("select * from Turnos where fecha_turno =" + fecha + "and hora_turno =" + hora + " and id_paciente =" + idPaciente);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {

                    return true;

                }
                else
                {
                    return false;
                }

            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }

        }
    }
}

