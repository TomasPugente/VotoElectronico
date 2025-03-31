using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioPersona
    {
        public List<Persona> listaPersonas { get; set; }
        private AccesoDatos datos = new AccesoDatos();

        public List<Persona> listar()
        {

            try
            {
                datos.setearConsulta("select p.Id id, p.nombre nombre, p.apellido apellido, p.dni dni, p.fechaDeNacimiento fechaDeNacimiento, p.Nacionalidad nacionalidad,d.Id idDireccion, d.calle calle, d.numero numero, d.localidad localidad, d.provincia from Persona p, Direccion d where p.idDireccion = d.Id;");
                datos.EjecutarLectura();

                listaPersonas = null;
                listaPersonas = new List<Persona>();

                cargarDatos();

                return listaPersonas;
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

        public  void cargarDatos()
        {
            try
            {
                while (datos.Lector.Read())
                {
                    Persona aux = new Persona();
                    aux.Direccion = new Direccion();

                    aux.Id = (int)datos.Lector["id"];
                    aux.Nombre = (String)datos.Lector["nombre"];
                    aux.Apellido = (String)datos.Lector["apellido"];
                    aux.Dni = (long)datos.Lector["dni"];
                    aux.fechaDeNacimiento = (DateTime)datos.Lector["FechaDeNacimiento"];
                    aux.Nacionalidad = (String)datos.Lector["nacionalidad"];
                    aux.Direccion.Id = (int)datos.Lector["idDireccion"];
                    aux.Direccion.Calle = (String)datos.Lector["calle"];
                    aux.Direccion.Numero = (int)datos.Lector["numero"];
                    aux.Direccion.Localidad = (String)datos.Lector["Localidad"];
                    aux.Direccion.Provincia = (String)datos.Lector["Provincia"];

                    listaPersonas.Add(aux);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void editar(Persona p)
        {
            try
            {
                datos.setearConsulta("update Persona set FechaDeNacimiento= @fechaDeNacimiento,Nacionalidad= @nacionalidad where id= @id; update Direccion set Calle= @calle, numero= @numero, Localidad= @localidad, Provincia= @provincia where id=@idDireccion;");
                datos.setearParametros("@fechaDeNacimiento",p.fechaDeNacimiento );
                datos.setearParametros("@nacionalidad",p.Nacionalidad );
                datos.setearParametros("@id",p.Id );
                datos.setearParametros("@calle",p.Direccion.Calle );
                datos.setearParametros("@numero",p.Direccion.Numero );
                datos.setearParametros("@localidad",p.Direccion.Localidad );
                datos.setearParametros("@provincia",p.Direccion.Provincia );
                datos.setearParametros("@idDireccion",p.Direccion.Id );
                datos.EjecutarAccion();

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

        public void agregar(Persona p)
        {
            try
            {
                datos.setearConsulta("insert into Direccion values (@calle,@numero,@localidad,@provincia)");
                datos.setearParametros("@calle", p.Direccion.Calle);
                datos.setearParametros("@numero", p.Direccion.Numero);
                datos.setearParametros("@localidad", p.Direccion.Localidad);
                datos.setearParametros("@provincia", p.Direccion.Provincia);
                datos.EjecutarAccion();
                datos.setearConsulta("select max(id) id from Direccion");
                datos.EjecutarLectura();
                int idDireccion = (int)datos.Lector["id"];
                datos.setearConsulta("insert into Persona values (@nombre,@apellido,@dni,@fechaDeNacimiento,@nacionalidad,@idDireccion)");
                datos.setearParametros("@nombre", p.Nombre);
                datos.setearParametros("@apellido", p.Apellido);
                datos.setearParametros("@dni", p.Dni);
                datos.setearParametros("@fechaDeNacimiento", p.fechaDeNacimiento);
                datos.setearParametros("@nacionalidad", p.Nacionalidad);
                datos.setearParametros("@idDireccion", idDireccion);
                datos.EjecutarAccion();
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
