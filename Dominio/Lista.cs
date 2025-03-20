using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Lista
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public Candidato CandidatoPresidente { get; set; }
        public Candidato CandidatoVice { get; set; }
        public Candidato CandidatoDiputado { get; set; }
        public Candidato CandidatoSenador { get; set; }

    }
}
