using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioVotante
    {
        public List<Votante> listaVotantes { get; set; }
        private AccesoDatos datos = new AccesoDatos();

        public List<Votante> listar()
        {

            try
            {
                datos.setearConsulta("select p.Id idPersona, p.nombre nombre, p.apellido apellido, p.dni dni, p.fechaDeNacimiento fechaDeNacimiento, p.Nacionalidad nacionalidad,d.Id idDireccion, d.calle calle, d.numero numero, d.localidad localidad, d.provincia, v.Id idVotante, v.fechaInscripcion fechaInscripcion, s.id idSedeVoto,s.Nombre nombreSede, s.cantidadVotantes cantidadVotantes from votante v, Persona p, Direccion d, sede s where p.idDireccion = d.Id and v.idPersona=p.id and v.idSedeVoto= s.id;");
                datos.EjecutarLectura();

                cargarDatos();

                return listaVotantes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void cargarDatos()
        {
            listaVotantes = null;
            listaVotantes = new List<Votante>();

            while (datos.Lector.Read())
            {
                Votante v = new Votante();
                v.SedeVoto = new Sede();

                v.IdVotante = (int)datos.Lector["id"];
                v.FechaInscripcion = (DateTime)datos.Lector["fechaInscripcion"];
                v.Id = (int)datos.Lector["idPersona"];
                v.Nombre = (String)datos.Lector["nombre"];
                v.Apellido = (String)datos.Lector["Apellido"];
                v.Dni = (long)datos.Lector["dni"];
                v.fechaDeNacimiento = (DateTime)datos.Lector["FechaDeNacimiento"];
                v.Nacionalidad = (String)datos.Lector["Nacionalidad"];
                v.Direccion.Id = (int)datos.Lector["idDireccion"];
                v.Direccion.Calle = (String)datos.Lector["Calle"];
                v.Direccion.Numero = (int)datos.Lector["numero"];
                v.Direccion.Localidad = (String)datos.Lector["Localidad"];
                v.Direccion.Provincia = (String)datos.Lector["Provincia"];
                v.SedeVoto.Id = (int)datos.Lector["idSedeVoto"];
                v.SedeVoto.CantidadVotantes = (int)datos.Lector["CantidadVotantes"];
                v.SedeVoto.Nombre = (String)datos.Lector["NombreSede"];

                listaVotantes.Add(v);
            }
        }
    }
}
