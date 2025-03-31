using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioAntecedentesPenales
    {
        public List<AntecedentesPenales> listaAntecedentesPenales { get; set; }
        private AccesoDatos datos = new AccesoDatos();

        public List<AntecedentesPenales> listar()
        {
            try
            {
                datos.setearConsulta("select a.id id,  a.fechaDelitoCometido fechaDelitoCometido, a.descripcion descripcion, d.id idDelito, d.nombre nombreDelito, d.Ley ley, p.id idPersona, p.Nombre nombrePersona, p.Apellido apellido, p.Dni dni, p.FechaDeNacimiento fechaDeNacimiento, p.Nacionalidad nacionalidad from delito d, persona p, AntecedentesPenales a where a.idPersona=p.Id and  a.idDelito= d.id;");
                datos.EjecutarLectura();

                cargarDatos();
                return listaAntecedentesPenales;
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
            try
            {
                listaAntecedentesPenales = null;
                listaAntecedentesPenales = new List<AntecedentesPenales>();

                while (datos.Lector.Read())
                {
                    AntecedentesPenales aux = new AntecedentesPenales();
                    aux.Persona = new Persona();
                    aux.Delito = new Delito();

                    aux.Id = (int)datos.Lector["id"];
                    aux.FechaDelitoCometido = (DateTime)datos.Lector["fechaDelitoCometido"];
                    aux.Descripcion = (String)datos.Lector["descripcion"];
                    aux.Delito.Id = (int)datos.Lector["idDelito"];
                    aux.Delito.Nombre = (String)datos.Lector["nombreDelito"];
                    aux.Delito.Ley = (String)datos.Lector["ley"];
                    aux.Persona.Id = (int)datos.Lector["idPersona"];
                    aux.Persona.Nombre = (String)datos.Lector["nombrePersona"];
                    aux.Persona.Apellido = (String)datos.Lector["Apellido"];
                    aux.Persona.Dni = (long)datos.Lector["dni"];
                    aux.Persona.Nacionalidad = (String)datos.Lector["Nacionalidad"];

                    listaAntecedentesPenales.Add(aux);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<AntecedentesPenales> listarPorPersona(Persona persona)
        {
            try
            {
                datos.setearConsulta("select a.id id,  a.fechaDelitoCometido fechaDelitoCometido, a.descripcion descripcion, d.id idDelito, d.nombre nombreDelito, d.Ley ley, p.id idPersona, p.Nombre nombrePersona, p.Apellido apellido, p.Dni dni, p.FechaDeNacimiento fechaDeNacimiento, p.Nacionalidad nacionalidad from delito d, persona p, AntecedentesPenales a where a.idPersona=p.Id and  a.idDelito= d.id and a.idPersona= @idPersona;");
                datos.setearParametros("@idPersona", persona.Id);
                datos.EjecutarLectura();
                cargarDatos();
                return listaAntecedentesPenales;
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

    }
}
