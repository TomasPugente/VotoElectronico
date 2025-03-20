using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Votante : Persona
    {
        public int IdVotante { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public Sede SedeVoto { get; set; }
    }
}
