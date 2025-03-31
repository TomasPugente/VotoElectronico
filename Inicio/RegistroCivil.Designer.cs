namespace Inicio
{
    partial class frmRegistroCivil
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnVerMas = new System.Windows.Forms.Button();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtFechaDeNacimiento = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.pnlVerMas = new System.Windows.Forms.Panel();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.pnlVerMas.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(12, 54);
            this.dgvPersonas.MultiSelect = false;
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowHeadersWidth = 51;
            this.dgvPersonas.RowTemplate.Height = 24;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(471, 237);
            this.dgvPersonas.TabIndex = 0;
            this.dgvPersonas.SelectionChanged += new System.EventHandler(this.dgvPersonas_SelectionChanged);
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(5, 46);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(91, 16);
            this.lblNacionalidad.TabIndex = 1;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(5, 81);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(140, 16);
            this.lblFechaDeNacimiento.TabIndex = 2;
            this.lblFechaDeNacimiento.Text = "Fecha De Nacimiento:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(5, 106);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(73, 16);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion";
            // 
            // btnVerMas
            // 
            this.btnVerMas.Location = new System.Drawing.Point(506, 54);
            this.btnVerMas.Name = "btnVerMas";
            this.btnVerMas.Size = new System.Drawing.Size(75, 23);
            this.btnVerMas.TabIndex = 4;
            this.btnVerMas.Text = "Ver mas";
            this.btnVerMas.UseVisualStyleBackColor = true;
            this.btnVerMas.Click += new System.EventHandler(this.btnVerMas_Click);
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(102, 43);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(100, 22);
            this.txtNacionalidad.TabIndex = 5;
            // 
            // txtFechaDeNacimiento
            // 
            this.txtFechaDeNacimiento.Location = new System.Drawing.Point(151, 78);
            this.txtFechaDeNacimiento.Name = "txtFechaDeNacimiento";
            this.txtFechaDeNacimiento.Size = new System.Drawing.Size(100, 22);
            this.txtFechaDeNacimiento.TabIndex = 6;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(74, 145);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 22);
            this.txtCalle.TabIndex = 7;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(4, 148);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(41, 16);
            this.lblCalle.TabIndex = 8;
            this.lblCalle.Text = "Calle:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(195, 190);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(66, 16);
            this.lblProvincia.TabIndex = 10;
            this.lblProvincia.Text = "Provincia:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(271, 145);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(100, 22);
            this.txtLocalidad.TabIndex = 9;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(195, 148);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(70, 16);
            this.lblLocalidad.TabIndex = 12;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(74, 187);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 11;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(4, 190);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 16);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "Numero:";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(271, 187);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(100, 22);
            this.txtProvincia.TabIndex = 13;
            // 
            // pnlVerMas
            // 
            this.pnlVerMas.Controls.Add(this.btnReestablecer);
            this.pnlVerMas.Controls.Add(this.btnGuardarCambios);
            this.pnlVerMas.Controls.Add(this.btnOcultar);
            this.pnlVerMas.Controls.Add(this.lblNumero);
            this.pnlVerMas.Controls.Add(this.lblNacionalidad);
            this.pnlVerMas.Controls.Add(this.txtProvincia);
            this.pnlVerMas.Controls.Add(this.lblFechaDeNacimiento);
            this.pnlVerMas.Controls.Add(this.lblLocalidad);
            this.pnlVerMas.Controls.Add(this.lblDireccion);
            this.pnlVerMas.Controls.Add(this.txtNumero);
            this.pnlVerMas.Controls.Add(this.txtNacionalidad);
            this.pnlVerMas.Controls.Add(this.lblProvincia);
            this.pnlVerMas.Controls.Add(this.txtFechaDeNacimiento);
            this.pnlVerMas.Controls.Add(this.txtLocalidad);
            this.pnlVerMas.Controls.Add(this.txtCalle);
            this.pnlVerMas.Controls.Add(this.lblCalle);
            this.pnlVerMas.Location = new System.Drawing.Point(598, 54);
            this.pnlVerMas.Name = "pnlVerMas";
            this.pnlVerMas.Size = new System.Drawing.Size(375, 247);
            this.pnlVerMas.TabIndex = 15;
            this.pnlVerMas.Visible = false;
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Location = new System.Drawing.Point(212, 224);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(101, 23);
            this.btnReestablecer.TabIndex = 17;
            this.btnReestablecer.Text = "Reestablecer";
            this.btnReestablecer.UseVisualStyleBackColor = true;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(47, 224);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(127, 23);
            this.btnGuardarCambios.TabIndex = 16;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(3, 3);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(75, 23);
            this.btnOcultar.TabIndex = 15;
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 26);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(39, 16);
            this.lblFiltro.TabIndex = 16;
            this.lblFiltro.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(58, 26);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 22);
            this.txtFiltro.TabIndex = 17;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(506, 95);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar...";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRegistroCivil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 340);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnVerMas);
            this.Controls.Add(this.pnlVerMas);
            this.Controls.Add(this.dgvPersonas);
            this.Name = "frmRegistroCivil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Civil";
            this.Load += new System.EventHandler(this.frmRegistroCivil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.pnlVerMas.ResumeLayout(false);
            this.pnlVerMas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnVerMas;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtFechaDeNacimiento;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Panel pnlVerMas;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnAgregar;
    }
}