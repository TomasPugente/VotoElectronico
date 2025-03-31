using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Inicio
{
    public partial class frmAntecedentesPenales : Form
    {
        private List<AntecedentesPenales> listaAntecedentes;
        private List<Persona> listaPersonas;
        private NegocioPersona negocioPersona = new NegocioPersona();
        private NegocioAntecedentesPenales negocioAntecedentesPenales = new NegocioAntecedentesPenales();
        public frmAntecedentesPenales()
        {
            InitializeComponent();
        }

        private void frmAntecedentesPenales_Load(object sender, EventArgs e)
        {
            try
            {
                cargarFormularioAntecedentes();
                gbxInformacionPersona.Visible = true;
                cargarGbxPersona();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarFormularioPersonas()
        {
            try
            {
            listaPersonas=negocioPersona.listar();   
            dgvAntecedentesPenales.DataSource = listaPersonas;
            ocultarColumnasPersonas();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarFormularioAntecedentes()
        {
            try
            {
            listaAntecedentes = negocioAntecedentesPenales.listar();
            dgvAntecedentesPenales.DataSource = listaAntecedentes;
            ocultarColumnasAntecedentes();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ocultarColumnasAntecedentes()
        {
            try
            {
            dgvAntecedentesPenales.Columns["Id"].Visible = false; 
            dgvAntecedentesPenales.Columns["Persona"].Visible = false;
            dgvAntecedentesPenales.Columns["descripcion"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void ocultarColumnasPersonas()
        {
            try
            {
            dgvAntecedentesPenales.Columns["Id"].Visible = false;
            dgvAntecedentesPenales.Columns["Direccion"].Visible = false;
            dgvAntecedentesPenales.Columns["FechaDeNacimiento"].Visible = false;
            dgvAntecedentesPenales.Columns["Nacionalidad"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void txtPorAntecedente_Click(object sender, EventArgs e)
        {
            try
            {
                cargarFormularioAntecedentes();
                gbxInformacionAntecedente.Visible = false;
                gbxInformacionPersona.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void txtPorPersona_Click(object sender, EventArgs e)
        {
            try
            {
                cargarFormularioPersonas();
                gbxInformacionPersona.Visible = false;
                gbxInformacionAntecedente.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void cargarGbxPersona()
        {
            try
            {
                Persona persona = ((AntecedentesPenales)dgvAntecedentesPenales.CurrentRow.DataBoundItem).Persona;

                if (persona != null)
                {

                    txtNombre.Text = persona.Nombre;
                    txtApellido.Text = persona.Apellido;
                    txtDni.Text = persona.Dni.ToString();
                    txtFechaDeNacimiento.Text = persona.fechaDeNacimiento.ToShortDateString();
                    txtNacionalidad.Text = persona.Nacionalidad;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void cargarGbxAntecedentesPenales()
        {
            try
            {
                Persona persona = ((AntecedentesPenales)dgvAntecedentesPenales.CurrentRow.DataBoundItem).Persona;
                if (dgvAntecedentesPenales.CurrentRow != null && listaAntecedentes.Find(x => x.Persona.Id == persona.Id) != null)
                {
                    cbxAntecedente.DataSource = negocioAntecedentesPenales.listarPorPersona(((AntecedentesPenales)dgvAntecedentesPenales.CurrentRow.DataBoundItem).Persona);
                    cbxAntecedente.DisplayMember = "Delito";
                    cbxAntecedente.ValueMember = "Id";
                    cargarInformacionAntecedente();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Close();
            }
        }
        private void dgvAntecedentesPenales_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gbxInformacionPersona.Visible == true)
                {
                    cargarGbxPersona();
                }
                else
                {
                    cargarGbxAntecedentesPenales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cbxAntecedente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (gbxInformacionAntecedente.Visible == true)
                {
                cargarInformacionAntecedente();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarInformacionAntecedente()
        {
            AntecedentesPenales aux=(AntecedentesPenales) cbxAntecedente.SelectedItem;
            txtDelito.Text = aux.Delito.Nombre;
            txtFecha.Text = aux.FechaDelitoCometido.ToShortDateString();
            rtxtDescripcion.Text = aux.Descripcion;
        }

    }
}
