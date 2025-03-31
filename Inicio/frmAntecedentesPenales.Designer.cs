namespace Inicio
{
    partial class frmAntecedentesPenales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAntecedentesPenales = new System.Windows.Forms.DataGridView();
            this.txtPorPersona = new System.Windows.Forms.Button();
            this.txtPorAntecedente = new System.Windows.Forms.Button();
            this.gbxInformacionPersona = new System.Windows.Forms.GroupBox();
            this.txtFechaDeNacimiento = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbxInformacionAntecedente = new System.Windows.Forms.GroupBox();
            this.cbxAntecedente = new System.Windows.Forms.ComboBox();
            this.lblAntecedente = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtDelito = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFechaDelito = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDelito = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntecedentesPenales)).BeginInit();
            this.gbxInformacionPersona.SuspendLayout();
            this.gbxInformacionAntecedente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAntecedentesPenales
            // 
            this.dgvAntecedentesPenales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAntecedentesPenales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAntecedentesPenales.Location = new System.Drawing.Point(47, 93);
            this.dgvAntecedentesPenales.MultiSelect = false;
            this.dgvAntecedentesPenales.Name = "dgvAntecedentesPenales";
            this.dgvAntecedentesPenales.ReadOnly = true;
            this.dgvAntecedentesPenales.RowHeadersWidth = 51;
            this.dgvAntecedentesPenales.RowTemplate.Height = 24;
            this.dgvAntecedentesPenales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAntecedentesPenales.Size = new System.Drawing.Size(450, 186);
            this.dgvAntecedentesPenales.TabIndex = 0;
            this.dgvAntecedentesPenales.SelectionChanged += new System.EventHandler(this.dgvAntecedentesPenales_SelectionChanged);
            // 
            // txtPorPersona
            // 
            this.txtPorPersona.Location = new System.Drawing.Point(301, 55);
            this.txtPorPersona.Name = "txtPorPersona";
            this.txtPorPersona.Size = new System.Drawing.Size(160, 32);
            this.txtPorPersona.TabIndex = 1;
            this.txtPorPersona.Text = "Por Persona";
            this.txtPorPersona.UseVisualStyleBackColor = true;
            this.txtPorPersona.Click += new System.EventHandler(this.txtPorPersona_Click);
            // 
            // txtPorAntecedente
            // 
            this.txtPorAntecedente.Location = new System.Drawing.Point(89, 55);
            this.txtPorAntecedente.Name = "txtPorAntecedente";
            this.txtPorAntecedente.Size = new System.Drawing.Size(160, 32);
            this.txtPorAntecedente.TabIndex = 2;
            this.txtPorAntecedente.Text = "Por Antecedente";
            this.txtPorAntecedente.UseVisualStyleBackColor = true;
            this.txtPorAntecedente.Click += new System.EventHandler(this.txtPorAntecedente_Click);
            // 
            // gbxInformacionPersona
            // 
            this.gbxInformacionPersona.Controls.Add(this.txtFechaDeNacimiento);
            this.gbxInformacionPersona.Controls.Add(this.txtNacionalidad);
            this.gbxInformacionPersona.Controls.Add(this.txtDni);
            this.gbxInformacionPersona.Controls.Add(this.txtApellido);
            this.gbxInformacionPersona.Controls.Add(this.txtNombre);
            this.gbxInformacionPersona.Controls.Add(this.lblFechaDeNacimiento);
            this.gbxInformacionPersona.Controls.Add(this.lblNacionalidad);
            this.gbxInformacionPersona.Controls.Add(this.lblDni);
            this.gbxInformacionPersona.Controls.Add(this.lblApellido);
            this.gbxInformacionPersona.Controls.Add(this.lblNombre);
            this.gbxInformacionPersona.Location = new System.Drawing.Point(546, 93);
            this.gbxInformacionPersona.Name = "gbxInformacionPersona";
            this.gbxInformacionPersona.Size = new System.Drawing.Size(259, 192);
            this.gbxInformacionPersona.TabIndex = 3;
            this.gbxInformacionPersona.TabStop = false;
            this.gbxInformacionPersona.Text = "INFORMACION";
            this.gbxInformacionPersona.Visible = false;
            // 
            // txtFechaDeNacimiento
            // 
            this.txtFechaDeNacimiento.Enabled = false;
            this.txtFechaDeNacimiento.Location = new System.Drawing.Point(153, 158);
            this.txtFechaDeNacimiento.Name = "txtFechaDeNacimiento";
            this.txtFechaDeNacimiento.Size = new System.Drawing.Size(100, 22);
            this.txtFechaDeNacimiento.TabIndex = 9;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Enabled = false;
            this.txtNacionalidad.Location = new System.Drawing.Point(153, 126);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(100, 22);
            this.txtNacionalidad.TabIndex = 8;
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(153, 92);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 22);
            this.txtDni.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(153, 64);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(153, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(9, 158);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(138, 16);
            this.lblFechaDeNacimiento.TabIndex = 4;
            this.lblFechaDeNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(56, 126);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(91, 16);
            this.lblNacionalidad.TabIndex = 4;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(114, 98);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 16);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(87, 67);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(88, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // gbxInformacionAntecedente
            // 
            this.gbxInformacionAntecedente.Controls.Add(this.cbxAntecedente);
            this.gbxInformacionAntecedente.Controls.Add(this.lblAntecedente);
            this.gbxInformacionAntecedente.Controls.Add(this.rtxtDescripcion);
            this.gbxInformacionAntecedente.Controls.Add(this.txtDelito);
            this.gbxInformacionAntecedente.Controls.Add(this.txtFecha);
            this.gbxInformacionAntecedente.Controls.Add(this.lblFechaDelito);
            this.gbxInformacionAntecedente.Controls.Add(this.lblDescripcion);
            this.gbxInformacionAntecedente.Controls.Add(this.lblDelito);
            this.gbxInformacionAntecedente.Location = new System.Drawing.Point(546, 291);
            this.gbxInformacionAntecedente.Name = "gbxInformacionAntecedente";
            this.gbxInformacionAntecedente.Size = new System.Drawing.Size(259, 231);
            this.gbxInformacionAntecedente.TabIndex = 4;
            this.gbxInformacionAntecedente.TabStop = false;
            this.gbxInformacionAntecedente.Text = "INFORMACION";
            this.gbxInformacionAntecedente.Visible = false;
            // 
            // cbxAntecedente
            // 
            this.cbxAntecedente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAntecedente.FormattingEnabled = true;
            this.cbxAntecedente.Location = new System.Drawing.Point(114, 27);
            this.cbxAntecedente.Name = "cbxAntecedente";
            this.cbxAntecedente.Size = new System.Drawing.Size(124, 24);
            this.cbxAntecedente.TabIndex = 11;
            this.cbxAntecedente.SelectedIndexChanged += new System.EventHandler(this.cbxAntecedente_SelectedIndexChanged);
            // 
            // lblAntecedente
            // 
            this.lblAntecedente.AutoSize = true;
            this.lblAntecedente.Location = new System.Drawing.Point(22, 27);
            this.lblAntecedente.Name = "lblAntecedente";
            this.lblAntecedente.Size = new System.Drawing.Size(86, 16);
            this.lblAntecedente.TabIndex = 10;
            this.lblAntecedente.Text = "Antecedente:";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(15, 129);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(223, 96);
            this.rtxtDescripcion.TabIndex = 9;
            this.rtxtDescripcion.Text = "";
            // 
            // txtDelito
            // 
            this.txtDelito.Enabled = false;
            this.txtDelito.Location = new System.Drawing.Point(114, 57);
            this.txtDelito.Name = "txtDelito";
            this.txtDelito.Size = new System.Drawing.Size(124, 22);
            this.txtDelito.TabIndex = 7;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(114, 92);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(124, 22);
            this.txtFecha.TabIndex = 8;
            // 
            // lblFechaDelito
            // 
            this.lblFechaDelito.AutoSize = true;
            this.lblFechaDelito.Location = new System.Drawing.Point(57, 92);
            this.lblFechaDelito.Name = "lblFechaDelito";
            this.lblFechaDelito.Size = new System.Drawing.Size(48, 16);
            this.lblFechaDelito.TabIndex = 7;
            this.lblFechaDelito.Text = "Fecha:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 110);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblDelito
            // 
            this.lblDelito.AutoSize = true;
            this.lblDelito.Location = new System.Drawing.Point(60, 60);
            this.lblDelito.Name = "lblDelito";
            this.lblDelito.Size = new System.Drawing.Size(45, 16);
            this.lblDelito.TabIndex = 5;
            this.lblDelito.Text = "Delito:";
            // 
            // frmAntecedentesPenales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 552);
            this.Controls.Add(this.gbxInformacionAntecedente);
            this.Controls.Add(this.gbxInformacionPersona);
            this.Controls.Add(this.txtPorAntecedente);
            this.Controls.Add(this.txtPorPersona);
            this.Controls.Add(this.dgvAntecedentesPenales);
            this.Name = "frmAntecedentesPenales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAntecedentesPenales";
            this.Load += new System.EventHandler(this.frmAntecedentesPenales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntecedentesPenales)).EndInit();
            this.gbxInformacionPersona.ResumeLayout(false);
            this.gbxInformacionPersona.PerformLayout();
            this.gbxInformacionAntecedente.ResumeLayout(false);
            this.gbxInformacionAntecedente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAntecedentesPenales;
        private System.Windows.Forms.Button txtPorPersona;
        private System.Windows.Forms.Button txtPorAntecedente;
        private System.Windows.Forms.GroupBox gbxInformacionPersona;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.GroupBox gbxInformacionAntecedente;
        private System.Windows.Forms.Label lblFechaDelito;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDelito;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFechaDeNacimiento;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.TextBox txtDelito;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblAntecedente;
        private System.Windows.Forms.ComboBox cbxAntecedente;
    }
}