using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
   
    public partial class frmIniciarSesion : Form
    {
        private String Usuario = "Admin";
        private String Contraseña="contraseña";

        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Length > 0 && txtUsuario.Text.Length > 0)
                btnIniciarSesion.Enabled = true;
            else
                btnIniciarSesion.Enabled = false;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Length > 0 && txtUsuario.Text.Length > 0)
                btnIniciarSesion.Enabled = true;
            else
                btnIniciarSesion.Enabled = false;


        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text==Usuario && txtContraseña.Text==Contraseña)
            {
                MessageBox.Show("Credenciales correctas fueron ingresadas", "Inicio sesion correctamente");
                DialogResult = DialogResult.OK;
                Close();
                
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas fueron ingresadas", "No se pudo iniciar sesion");
                lblInicioIncorrecto.Visible = true;
                btnIniciarSesion.Enabled = false;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {     

        }
    }
}
