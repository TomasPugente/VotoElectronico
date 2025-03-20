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
        public frmServicioElecciones()
        {
            InitializeComponent();
        }

        private void btnIniciarSesionAdmin_Click(object sender, EventArgs e)
        {

        }

        private void frmServicioElecciones_Load(object sender, EventArgs e)
        {
            pbxBandera.Load("https://i.pinimg.com/736x/a5/37/05/a53705b9a77b24e5b04b99e06b737a60.jpg");
        }

        private void btnSeccionSedes_Click(object sender, EventArgs e)
        {

        }
    }
}
