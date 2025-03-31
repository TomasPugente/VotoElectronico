using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class frmAgregarPersona : Form
    {
        NegocioPersona negocioPersona = new NegocioPersona();
        public frmAgregarPersona()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
            Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona persona = new Persona();
                persona.Direccion = new Direccion();
                persona.Nombre = txtNombre.Text;
                persona.Apellido= txtApellido.Text;
                persona.Dni = int.Parse(txtDni.Text);
                persona.Nacionalidad = txtNacionalidad.Text;
                persona.fechaDeNacimiento= DateTime.Parse(mcFechaDeNacimiento.SelectionStart.ToShortDateString());
                persona.Direccion.Calle = txtCalle.Text;
                persona.Direccion.Numero = int.Parse(txtNumero.Text);
                persona.Direccion.Localidad = txtLocalidad.Text;
                persona.Direccion.Provincia = txtProvincia.Text;
                negocioPersona.

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }
    }
}
