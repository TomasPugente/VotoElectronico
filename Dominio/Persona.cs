using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public long Dni { get; set; }
        public DateTime fechaDeNacimiento { get; set; }
        public Direccion Direccion { get; set; }
        public String Nacionalidad { get; set; }

        public override string ToString()
        {
            return Nombre+ ", " + Apellido + ", " + Dni +", "+ ", "+ fechaDeNacimiento + ", " + Nacionalidad;
        }
    }
}
