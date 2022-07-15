using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        public int Id { get; set; }

        public Medico Medico { get; set; }

        public Persona Persona { get; set; }

        public Estado Estado { get; set; }

        public Especialidad Especialidad { get; set; }

        public DateTime FechaTurno { get; set; }

        public int HoraTurno { get; set; }

        public string ObservacionesMedico { get; set; }

        public string ObservacionesPaciente { get; set; }

        //public string Diagnostico { get; set; }

        public bool Activo { get; set; }
    }
}
