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
    public partial class frmServicioElecciones: Form
    {
        private bool sesionIniciada = false;
        public frmServicioElecciones()
        {
            InitializeComponent();
        }

        private void frmServicioElecciones_Load(object sender, EventArgs e)
        {
            NegocioAntecedentesPenales negocio = new NegocioAntecedentesPenales();
            List < AntecedentesPenales > ante= negocio.listar();
           pbxBandera.Load("https://i.pinimg.com/736x/a5/37/05/a53705b9a77b24e5b04b99e06b737a60.jpg");
        }
        private void btnIniciarSesionAdmin_Click(object sender, EventArgs e)
        {
            frmIniciarSesion frmIniciarSesion = new frmIniciarSesion();
            DialogResult resultado =frmIniciarSesion.ShowDialog();
            if (resultado == DialogResult.OK)
                sesionIniciada = true;
        }

        private void btnRegistroCivil_Click(object sender, EventArgs e)
        {
            if (sesionIniciada)
            {
                frmRegistroCivil frm = new frmRegistroCivil();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("DEBE INICIAR SESION ANTES");
        }

        private void btnAntecedentesPenales_Click(object sender, EventArgs e)
        {
            if (sesionIniciada)
            {
                frmAntecedentesPenales frm = new frmAntecedentesPenales();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("DEBE INICIAR SESION ANTES");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
