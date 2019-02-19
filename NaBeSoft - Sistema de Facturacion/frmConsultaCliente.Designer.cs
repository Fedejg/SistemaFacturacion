namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmConsultaCliente
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtCateg = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtFecIn = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sFDBDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.txtCodPos = new System.Windows.Forms.TextBox();
            this.txtTelC = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtTelF = new System.Windows.Forms.TextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtCuilCuit = new System.Windows.Forms.TextBox();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.txtApeNom = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.clienteTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ClienteTableAdapter();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidadTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.LocalidadTableAdapter();
            this.categoriaCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaCTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.CategoriaCTableAdapter();
            this.grbDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(435, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Location = new System.Drawing.Point(364, 280);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(65, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnAceptar_MouseLeave);
            this.btnAceptar.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(218, 14);
            this.txtConsulta.MaxLength = 4;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(43, 20);
            this.txtConsulta.TabIndex = 7;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            this.txtConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsulta_KeyPress);
            this.txtConsulta.Leave += new System.EventHandler(this.txtConsulta_Leave);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(16, 17);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(196, 13);
            this.Label12.TabIndex = 6;
            this.Label12.Text = "Ingrese el Cliente que desea consultar : ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(267, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnBuscar.MouseHover += new System.EventHandler(this.btnBuscar_MouseHover);
            // 
            // grbDatosPersonales
            // 
            this.grbDatosPersonales.Controls.Add(this.txtCateg);
            this.grbDatosPersonales.Controls.Add(this.txtLocalidad);
            this.grbDatosPersonales.Controls.Add(this.Label1);
            this.grbDatosPersonales.Controls.Add(this.txtDir);
            this.grbDatosPersonales.Controls.Add(this.txtFecIn);
            this.grbDatosPersonales.Controls.Add(this.txtCodPos);
            this.grbDatosPersonales.Controls.Add(this.txtTelC);
            this.grbDatosPersonales.Controls.Add(this.Label2);
            this.grbDatosPersonales.Controls.Add(this.Label3);
            this.grbDatosPersonales.Controls.Add(this.txtTelF);
            this.grbDatosPersonales.Controls.Add(this.txtCodCli);
            this.grbDatosPersonales.Controls.Add(this.Label4);
            this.grbDatosPersonales.Controls.Add(this.txtCuilCuit);
            this.grbDatosPersonales.Controls.Add(this.txtRSocial);
            this.grbDatosPersonales.Controls.Add(this.txtApeNom);
            this.grbDatosPersonales.Controls.Add(this.Label5);
            this.grbDatosPersonales.Controls.Add(this.Label6);
            this.grbDatosPersonales.Controls.Add(this.Label7);
            this.grbDatosPersonales.Controls.Add(this.Label8);
            this.grbDatosPersonales.Controls.Add(this.Label9);
            this.grbDatosPersonales.Controls.Add(this.Label10);
            this.grbDatosPersonales.Controls.Add(this.Label11);
            this.grbDatosPersonales.Location = new System.Drawing.Point(12, 40);
            this.grbDatosPersonales.Name = "grbDatosPersonales";
            this.grbDatosPersonales.Size = new System.Drawing.Size(488, 234);
            this.grbDatosPersonales.TabIndex = 9;
            this.grbDatosPersonales.TabStop = false;
            this.grbDatosPersonales.Text = "Datos Personales";
            // 
            // txtCateg
            // 
            this.txtCateg.Location = new System.Drawing.Point(114, 202);
            this.txtCateg.Name = "txtCateg";
            this.txtCateg.ReadOnly = true;
            this.txtCateg.Size = new System.Drawing.Size(132, 20);
            this.txtCateg.TabIndex = 21;
            this.txtCateg.TabStop = false;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(114, 123);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ReadOnly = true;
            this.txtLocalidad.Size = new System.Drawing.Size(214, 20);
            this.txtLocalidad.TabIndex = 11;
            this.txtLocalidad.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 153);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Dirección :";
            // 
            // txtDir
            // 
            this.txtDir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDir.Location = new System.Drawing.Point(114, 150);
            this.txtDir.MaxLength = 60;
            this.txtDir.Name = "txtDir";
            this.txtDir.ReadOnly = true;
            this.txtDir.Size = new System.Drawing.Size(368, 20);
            this.txtDir.TabIndex = 15;
            this.txtDir.TabStop = false;
            // 
            // txtFecIn
            // 
            this.txtFecIn.Location = new System.Drawing.Point(370, 19);
            this.txtFecIn.Name = "txtFecIn";
            this.txtFecIn.ReadOnly = true;
            this.txtFecIn.Size = new System.Drawing.Size(65, 20);
            this.txtFecIn.TabIndex = 3;
            this.txtFecIn.TabStop = false;
            this.txtFecIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.sFDBDataSet;
            // 
            // sFDBDataSet
            // 
            this.sFDBDataSet.DataSetName = "SFBDDataSet";
            this.sFDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCodPos
            // 
            this.txtCodPos.Location = new System.Drawing.Point(370, 123);
            this.txtCodPos.MaxLength = 4;
            this.txtCodPos.Name = "txtCodPos";
            this.txtCodPos.ReadOnly = true;
            this.txtCodPos.Size = new System.Drawing.Size(65, 20);
            this.txtCodPos.TabIndex = 13;
            this.txtCodPos.TabStop = false;
            this.txtCodPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelC
            // 
            this.txtTelC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelC.Location = new System.Drawing.Point(303, 176);
            this.txtTelC.MaxLength = 15;
            this.txtTelC.Name = "txtTelC";
            this.txtTelC.ReadOnly = true;
            this.txtTelC.Size = new System.Drawing.Size(132, 20);
            this.txtTelC.TabIndex = 19;
            this.txtTelC.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 126);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Localidad :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 22);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(96, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Código de Cliente :";
            // 
            // txtTelF
            // 
            this.txtTelF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelF.Location = new System.Drawing.Point(114, 176);
            this.txtTelF.MaxLength = 15;
            this.txtTelF.Name = "txtTelF";
            this.txtTelF.ReadOnly = true;
            this.txtTelF.Size = new System.Drawing.Size(132, 20);
            this.txtTelF.TabIndex = 17;
            this.txtTelF.TabStop = false;
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(114, 19);
            this.txtCodCli.MaxLength = 4;
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.ReadOnly = true;
            this.txtCodCli.Size = new System.Drawing.Size(43, 20);
            this.txtCodCli.TabIndex = 1;
            this.txtCodCli.TabStop = false;
            this.txtCodCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(334, 126);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(30, 13);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "C.P.:";
            // 
            // txtCuilCuit
            // 
            this.txtCuilCuit.AccessibleDescription = "";
            this.txtCuilCuit.AccessibleName = "";
            this.txtCuilCuit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuilCuit.Location = new System.Drawing.Point(114, 97);
            this.txtCuilCuit.MaxLength = 11;
            this.txtCuilCuit.Name = "txtCuilCuit";
            this.txtCuilCuit.ReadOnly = true;
            this.txtCuilCuit.Size = new System.Drawing.Size(132, 20);
            this.txtCuilCuit.TabIndex = 9;
            this.txtCuilCuit.TabStop = false;
            // 
            // txtRSocial
            // 
            this.txtRSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRSocial.Location = new System.Drawing.Point(114, 71);
            this.txtRSocial.MaxLength = 40;
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.ReadOnly = true;
            this.txtRSocial.Size = new System.Drawing.Size(368, 20);
            this.txtRSocial.TabIndex = 7;
            this.txtRSocial.TabStop = false;
            // 
            // txtApeNom
            // 
            this.txtApeNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApeNom.Location = new System.Drawing.Point(114, 45);
            this.txtApeNom.MaxLength = 40;
            this.txtApeNom.Name = "txtApeNom";
            this.txtApeNom.ReadOnly = true;
            this.txtApeNom.Size = new System.Drawing.Size(368, 20);
            this.txtApeNom.TabIndex = 5;
            this.txtApeNom.TabStop = false;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(278, 22);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(86, 13);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "Fecha de Inicio :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(6, 205);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(60, 13);
            this.Label6.TabIndex = 20;
            this.Label6.Text = "Categoría :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(252, 179);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(45, 13);
            this.Label7.TabIndex = 18;
            this.Label7.Text = "Celular :";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(6, 179);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(55, 13);
            this.Label8.TabIndex = 16;
            this.Label8.Text = "Teléfono :";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(6, 102);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(67, 13);
            this.Label9.TabIndex = 8;
            this.Label9.Text = "CUIL/CUIT :";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(6, 74);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(76, 13);
            this.Label10.TabIndex = 6;
            this.Label10.Text = "Razon Social :";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(6, 48);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(98, 13);
            this.Label11.TabIndex = 4;
            this.Label11.Text = "Apellido y Nombre :";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 311);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(512, 22);
            this.StatusStrip1.TabIndex = 12;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabelInfo
            // 
            this.ToolStripStatusLabelInfo.Name = "ToolStripStatusLabelInfo";
            this.ToolStripStatusLabelInfo.Size = new System.Drawing.Size(19, 17);
            this.ToolStripStatusLabelInfo.Text = "    ";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // localidadBindingSource
            // 
            this.localidadBindingSource.DataMember = "Localidad";
            this.localidadBindingSource.DataSource = this.sFDBDataSet;
            // 
            // localidadTableAdapter
            // 
            this.localidadTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaCBindingSource
            // 
            this.categoriaCBindingSource.DataMember = "CategoriaC";
            this.categoriaCBindingSource.DataSource = this.sFDBDataSet;
            // 
            // categoriaCTableAdapter
            // 
            this.categoriaCTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultaCliente
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(512, 333);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grbDatosPersonales);
            this.Name = "frmConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaCliente_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultaCliente_Load);
            this.grbDatosPersonales.ResumeLayout(false);
            this.grbDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.TextBox txtConsulta;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.GroupBox grbDatosPersonales;
        internal System.Windows.Forms.TextBox txtCateg;
        internal System.Windows.Forms.TextBox txtLocalidad;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtDir;
        internal System.Windows.Forms.TextBox txtFecIn;
        internal System.Windows.Forms.TextBox txtCodPos;
        internal System.Windows.Forms.TextBox txtTelC;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtTelF;
        internal System.Windows.Forms.TextBox txtCodCli;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtCuilCuit;
        internal System.Windows.Forms.TextBox txtRSocial;
        internal System.Windows.Forms.TextBox txtApeNom;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelInfo;
        private SFDBDataSet sFDBDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SFDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private SFDBDataSetTableAdapters.LocalidadTableAdapter localidadTableAdapter;
        private System.Windows.Forms.BindingSource categoriaCBindingSource;
        private SFDBDataSetTableAdapters.CategoriaCTableAdapter categoriaCTableAdapter;

    }
}