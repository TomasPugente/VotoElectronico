using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioCandidato
    {
        public List<Candidato> listaCandidatos { get; set; }
        private AccesoDatos datos = new AccesoDatos();

        public List<Candidato> listar()
        {

            try
            {
                datos.setearConsulta("select p.Id idPersona, p.nombre nombre, p.apellido apellido, p.dni dni, p.fechaDeNacimiento fechaDeNacimiento, p.Nacionalidad nacionalidad,d.Id idDireccion, d.calle calle, d.numero numero, d.localidad localidad, d.provincia, c.Id idCandidato, c.FechaPostulacion FechaPostulacion, c.ImagenCandidato imagenCandidato from Candidato c, Persona p, Direccion d, sede s where p.idDireccion = d.Id and c.idPersona=p.id ;");
                datos.EjecutarLectura();

                cargarDatos();

                return listaCandidatos;
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
            listaCandidatos = null;
            listaCandidatos = new List<Candidato>();

            while (datos.Lector.Read())
            {
                Candidato c = new Candidato();

                c.IdCandidato = (int)datos.Lector["id"];
                c.FechaPostulacion = (DateTime)datos.Lector["fechaPostulacion"];
                c.ImagenCandidato = (String)datos.Lector["ImagenCandidato"];
                c.Id = (int)datos.Lector["idPersona"];
                c.Nombre = (String)datos.Lector["nombre"];
                c.Apellido = (String)datos.Lector["Apellido"];
                c.Dni = (long)datos.Lector["dni"];
                c.fechaDeNacimiento = (DateTime)datos.Lector["FechaDeNacimiento"];
                c.Nacionalidad = (String)datos.Lector["Nacionalidad"];
                c.Direccion.Id = (int)datos.Lector["idDireccion"];
                c.Direccion.Calle = (String)datos.Lector["Calle"];
                c.Direccion.Numero = (int)datos.Lector["numero"];
                c.Direccion.Localidad = (String)datos.Lector["Localidad"];
                c.Direccion.Provincia = (String)datos.Lector["Provincia"];


                listaCandidatos.Add(c);
            }
        }
    }
}
