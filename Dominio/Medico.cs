using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Medico : Persona
    {
        public int IdPersona { get; set; }

        public int IdMedico { get; set; }

        public int NumMatricula { get; set; }

        public Especialidad Especialidad { get; set; }

    }
}
