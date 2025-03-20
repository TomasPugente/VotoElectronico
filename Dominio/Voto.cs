using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Voto
    {
        public int Id { get; set; }
        public Lista ListaVotada { get; set; }
        public Sede SedeVoto { get; set; }

    }
}
