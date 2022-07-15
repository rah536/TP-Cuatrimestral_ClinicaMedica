using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class EspecialidadNegocio
    {

        public List<Especialidad> listar()
        {
            List<Especialidad> lista = new List<Especialidad>();
            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                datos.setearConsulta("select id,nombre from especialidades");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Especialidad aux = new Especialidad();

                    aux.Id = (int)datos.Lector["id"];
                    aux.Nombre = (string)datos.Lector["nombre"];

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

        public List<string> listarPorId(int id)
        {
            List<string> lista = new List<string>();
            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                datos.setearConsulta("select e.nombre from especialidades as e inner join medicos_x_especialidad as me on e.id = me.id_especialidad where me.id_medico = " + id);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    string nombre;

                    nombre = (string)datos.Lector["nombre"];

                    lista.Add(nombre);

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
    }
}
