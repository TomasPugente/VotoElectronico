using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sede
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public Direccion Direccion { get; set; }
        public int CantidadVotantes { get; set; }

    }
}
