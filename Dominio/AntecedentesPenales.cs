using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AntecedentesPenales
    {
        public int Id { get; set; }
        public Delito Delito { get; set; }
        public Persona Persona { get; set; }
        public DateTime FechaDelitoCometido { get; set; }
        public String Descripcion { get; set; }

    }
}
