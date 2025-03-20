using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Direccion
    {
        public int Id { get; set; }
        public String Calle { get; set; }
        public int Numero { get; set; }
        public String Localidad { get; set; }
        public String Provincia { get; set; }

    }
}
