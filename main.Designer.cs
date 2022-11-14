
namespace pryMarconiejerciciopararesolver3
{
    partial class main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtRepuesto = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.mrcConsulta = new System.Windows.Forms.GroupBox();
            this.lstDatosderepuestos = new System.Windows.Forms.ListBox();
            this.mrcOrigenconsulta = new System.Windows.Forms.GroupBox();
            this.optNacionalconsulta = new System.Windows.Forms.RadioButton();
            this.optImportadoconsulta = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblDatosderespuestos = new System.Windows.Forms.Label();
            this.cmbMarca2 = new System.Windows.Forms.ComboBox();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.mrcRegistro.SuspendLayout();
            this.mrcOrigen.SuspendLayout();
            this.mrcConsulta.SuspendLayout();
            this.mrcOrigenconsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.txtDescripcion);
            this.mrcRegistro.Controls.Add(this.mrcOrigen);
            this.mrcRegistro.Controls.Add(this.cmbMarca);
            this.mrcRegistro.Controls.Add(this.txtPrecio);
            this.mrcRegistro.Controls.Add(this.txtRepuesto);
            this.mrcRegistro.Controls.Add(this.btnRegistrar);
            this.mrcRegistro.Controls.Add(this.lblPrecio);
            this.mrcRegistro.Controls.Add(this.lblDescripcion);
            this.mrcRegistro.Controls.Add(this.lblRepuesto);
            this.mrcRegistro.Controls.Add(this.lblMarca);
            this.mrcRegistro.Location = new System.Drawing.Point(28, 17);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(263, 417);
            this.mrcRegistro.TabIndex = 1;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Repuesto - Registro";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(30, 178);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(206, 86);
            this.txtDescripcion.TabIndex = 13;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.optNacional);
            this.mrcOrigen.Controls.Add(this.optImportado);
            this.mrcOrigen.Location = new System.Drawing.Point(24, 52);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Size = new System.Drawing.Size(212, 59);
            this.mrcOrigen.TabIndex = 12;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Checked = true;
            this.optNacional.Location = new System.Drawing.Point(6, 19);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(67, 17);
            this.optNacional.TabIndex = 2;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(111, 19);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 3;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Peugeot",
            "Fiat",
            "Renault"});
            this.cmbMarca.Location = new System.Drawing.Point(115, 25);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 11;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(115, 283);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtRepuesto
            // 
            this.txtRepuesto.Location = new System.Drawing.Point(115, 124);
            this.txtRepuesto.Name = "txtRepuesto";
            this.txtRepuesto.Size = new System.Drawing.Size(121, 20);
            this.txtRepuesto.TabIndex = 7;
            this.txtRepuesto.TextChanged += new System.EventHandler(this.txtRepuesto_TextChanged);
            this.txtRepuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRepuesto_KeyPress);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(87, 357);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(27, 286);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(27, 162);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblRepuesto
            // 
            this.lblRepuesto.AutoSize = true;
            this.lblRepuesto.Location = new System.Drawing.Point(27, 124);
            this.lblRepuesto.Name = "lblRepuesto";
            this.lblRepuesto.Size = new System.Drawing.Size(53, 13);
            this.lblRepuesto.TabIndex = 2;
            this.lblRepuesto.Text = "Repuesto";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(21, 28);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // mrcConsulta
            // 
            this.mrcConsulta.Controls.Add(this.lstDatosderepuestos);
            this.mrcConsulta.Controls.Add(this.mrcOrigenconsulta);
            this.mrcConsulta.Controls.Add(this.btnConsultar);
            this.mrcConsulta.Controls.Add(this.lblDatosderespuestos);
            this.mrcConsulta.Controls.Add(this.cmbMarca2);
            this.mrcConsulta.Controls.Add(this.lblMarca2);
            this.mrcConsulta.Location = new System.Drawing.Point(297, 17);
            this.mrcConsulta.Name = "mrcConsulta";
            this.mrcConsulta.Size = new System.Drawing.Size(282, 417);
            this.mrcConsulta.TabIndex = 2;
            this.mrcConsulta.TabStop = false;
            this.mrcConsulta.Text = "Consulta";
            // 
            // lstDatosderepuestos
            // 
            this.lstDatosderepuestos.FormattingEnabled = true;
            this.lstDatosderepuestos.Location = new System.Drawing.Point(24, 147);
            this.lstDatosderepuestos.Name = "lstDatosderepuestos";
            this.lstDatosderepuestos.Size = new System.Drawing.Size(231, 186);
            this.lstDatosderepuestos.TabIndex = 16;
            // 
            // mrcOrigenconsulta
            // 
            this.mrcOrigenconsulta.Controls.Add(this.optNacionalconsulta);
            this.mrcOrigenconsulta.Controls.Add(this.optImportadoconsulta);
            this.mrcOrigenconsulta.Location = new System.Drawing.Point(24, 52);
            this.mrcOrigenconsulta.Name = "mrcOrigenconsulta";
            this.mrcOrigenconsulta.Size = new System.Drawing.Size(104, 70);
            this.mrcOrigenconsulta.TabIndex = 11;
            this.mrcOrigenconsulta.TabStop = false;
            this.mrcOrigenconsulta.Text = "Origen";
            this.mrcOrigenconsulta.Enter += new System.EventHandler(this.mrcOrigenconsulta_Enter);
            // 
            // optNacionalconsulta
            // 
            this.optNacionalconsulta.AutoSize = true;
            this.optNacionalconsulta.Checked = true;
            this.optNacionalconsulta.Location = new System.Drawing.Point(6, 19);
            this.optNacionalconsulta.Name = "optNacionalconsulta";
            this.optNacionalconsulta.Size = new System.Drawing.Size(67, 17);
            this.optNacionalconsulta.TabIndex = 2;
            this.optNacionalconsulta.TabStop = true;
            this.optNacionalconsulta.Text = "Nacional";
            this.optNacionalconsulta.UseVisualStyleBackColor = true;
            // 
            // optImportadoconsulta
            // 
            this.optImportadoconsulta.AutoSize = true;
            this.optImportadoconsulta.Location = new System.Drawing.Point(6, 42);
            this.optImportadoconsulta.Name = "optImportadoconsulta";
            this.optImportadoconsulta.Size = new System.Drawing.Size(72, 17);
            this.optImportadoconsulta.TabIndex = 3;
            this.optImportadoconsulta.Text = "Importado";
            this.optImportadoconsulta.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(116, 357);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblDatosderespuestos
            // 
            this.lblDatosderespuestos.AutoSize = true;
            this.lblDatosderespuestos.Location = new System.Drawing.Point(21, 131);
            this.lblDatosderespuestos.Name = "lblDatosderespuestos";
            this.lblDatosderespuestos.Size = new System.Drawing.Size(99, 13);
            this.lblDatosderespuestos.TabIndex = 8;
            this.lblDatosderespuestos.Text = "Datos de Repuesto";
            // 
            // cmbMarca2
            // 
            this.cmbMarca2.FormattingEnabled = true;
            this.cmbMarca2.Items.AddRange(new object[] {
            "Peugeot",
            "Fiat",
            "Renault"});
            this.cmbMarca2.Location = new System.Drawing.Point(116, 25);
            this.cmbMarca2.Name = "cmbMarca2";
            this.cmbMarca2.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca2.TabIndex = 4;
            this.cmbMarca2.SelectedIndexChanged += new System.EventHandler(this.cmbMarca2_SelectedIndexChanged);
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Location = new System.Drawing.Point(21, 28);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(37, 13);
            this.lblMarca2.TabIndex = 3;
            this.lblMarca2.Text = "Marca";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 457);
            this.Controls.Add(this.mrcConsulta);
            this.Controls.Add(this.mrcRegistro);
            this.Name = "main";
            this.Text = "INICIO";
            this.Load += new System.EventHandler(this.main_Load);
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            this.mrcConsulta.ResumeLayout(false);
            this.mrcConsulta.PerformLayout();
            this.mrcOrigenconsulta.ResumeLayout(false);
            this.mrcOrigenconsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtRepuesto;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblRepuesto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox mrcConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblDatosderespuestos;
        private System.Windows.Forms.ComboBox cmbMarca2;
        private System.Windows.Forms.Label lblMarca2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.GroupBox mrcOrigenconsulta;
        private System.Windows.Forms.RadioButton optNacionalconsulta;
        private System.Windows.Forms.RadioButton optImportadoconsulta;
        private System.Windows.Forms.ListBox lstDatosderepuestos;
    }
}

