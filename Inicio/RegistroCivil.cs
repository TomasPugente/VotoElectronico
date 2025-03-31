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
    public partial class frmRegistroCivil : Form
    {
        private NegocioPersona negocioPersona= new NegocioPersona();
        private Persona persona;
        private List<Persona> listaPersonas;
        public frmRegistroCivil()
        {
            InitializeComponent();
        }
                
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistroCivil_Load(object sender, EventArgs e)
        {
            try
            {
                Width = 500;
                Height = 300;
                listaPersonas=negocioPersona.listar();
                dgvPersonas.DataSource = listaPersonas;
                ocultarColumnas();
                cargarFormularioPersona();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()) ;
            }

            
        
        }

        private void ocultarColumnas()
        {
            dgvPersonas.Columns["Id"].Visible = false;
            dgvPersonas.Columns["Nacionalidad"].Visible = false;
            dgvPersonas.Columns["fechaDeNacimiento"].Visible = false;
            dgvPersonas.Columns["Direccion"].Visible = false;
        }


        private void btnVerMas_Click(object sender, EventArgs e)
        {
            try
            {
                Width = 750;
                Height = 300;
                pnlVerMas.Visible = true;
                btnVerMas.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            try
            {
                Width = 500;
                Height = 300;
                pnlVerMas.Visible = false;
                btnVerMas.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvPersonas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                cargarFormularioPersona();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            try
            {
                cargarFormularioPersona();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); ;
            }
        }

        private void cargarFormularioPersona()
        {
            try
            {
                if (dgvPersonas.CurrentRow != null)
                {

                persona = (Persona)dgvPersonas.CurrentRow.DataBoundItem;
                txtNacionalidad.Text = persona.Nacionalidad;
                txtFechaDeNacimiento.Text = persona.fechaDeNacimiento.ToShortDateString();
                txtCalle.Text = persona.Direccion.Calle;
                txtNumero.Text = persona.Direccion.Numero.ToString();
                txtLocalidad.Text = persona.Direccion.Localidad;
                txtProvincia.Text = persona.Direccion.Provincia;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                Persona p = new Persona();
                p.Direccion = new Direccion();
                p.Id = persona.Id;
                p.Nacionalidad = txtNacionalidad.Text;
                p.fechaDeNacimiento = DateTime.Parse(txtFechaDeNacimiento.Text);
                p.Direccion.Id = persona.Direccion.Id;
                p.Direccion.Calle = txtCalle.Text;
                p.Direccion.Numero= int.Parse(txtNumero.Text);
                p.Direccion.Localidad = txtLocalidad.Text;
                p.Direccion.Provincia = txtProvincia.Text;
                negocioPersona.editar(p);
                dgvPersonas.DataSource = null;
                dgvPersonas.DataSource = negocioPersona.listar();
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()) ;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Persona> listaFiltro;
                if (txtFiltro.Text.Length > 1)
                {
                    listaFiltro=(listaPersonas.FindAll(x => x.Nombre.ToLower().Contains(txtFiltro.Text.ToLower()) || x.Apellido.ToLower().Contains(txtFiltro.Text.ToLower()) || x.Dni.ToString().Contains(txtFiltro.Text)));

                }
                else
                {
                    listaFiltro = listaPersonas;
                }
                dgvPersonas.DataSource = null;
                dgvPersonas.DataSource = listaFiltro;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgregarPersona frm = new frmAgregarPersona();
            frm.ShowDialog();
        }
    }
}
