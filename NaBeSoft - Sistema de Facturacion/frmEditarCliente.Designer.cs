namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmEditarCliente
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.lblApe = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.cmbCateg = new System.Windows.Forms.ComboBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtFecIn = new System.Windows.Forms.TextBox();
            this.txtCodPos = new System.Windows.Forms.TextBox();
            this.txtTelC = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.txtTelF = new System.Windows.Forms.TextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.lblCodPos = new System.Windows.Forms.Label();
            this.txtCuilCuit = new System.Windows.Forms.TextBox();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.lblFecIn = new System.Windows.Forms.Label();
            this.lblCateg = new System.Windows.Forms.Label();
            this.lblTelC = new System.Windows.Forms.Label();
            this.lblTelF = new System.Windows.Forms.Label();
            this.lblCuilCuit = new System.Windows.Forms.Label();
            this.lblRSocial = new System.Windows.Forms.Label();
            this.lvClientes = new System.Windows.Forms.ListView();
            this.colCodCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.sFBDDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidadTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.LocalidadTableAdapter();
            this.categoriaCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaCTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.CategoriaCTableAdapter();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ClienteTableAdapter();
            this.grbDatosPersonales.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(696, 252);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(615, 252);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Location = new System.Drawing.Point(534, 252);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.MouseLeave += new System.EventHandler(this.btnModificar_MouseLeave);
            this.btnModificar.MouseHover += new System.EventHandler(this.btnModificar_MouseHover);
            // 
            // grbDatosPersonales
            // 
            this.grbDatosPersonales.Controls.Add(this.lblNombre);
            this.grbDatosPersonales.Controls.Add(this.txtNombre);
            this.grbDatosPersonales.Controls.Add(this.txtApe);
            this.grbDatosPersonales.Controls.Add(this.lblApe);
            this.grbDatosPersonales.Controls.Add(this.cmbLocalidad);
            this.grbDatosPersonales.Controls.Add(this.lblDir);
            this.grbDatosPersonales.Controls.Add(this.cmbCateg);
            this.grbDatosPersonales.Controls.Add(this.txtDir);
            this.grbDatosPersonales.Controls.Add(this.txtFecIn);
            this.grbDatosPersonales.Controls.Add(this.txtCodPos);
            this.grbDatosPersonales.Controls.Add(this.txtTelC);
            this.grbDatosPersonales.Controls.Add(this.lblLocalidad);
            this.grbDatosPersonales.Controls.Add(this.lblCodCli);
            this.grbDatosPersonales.Controls.Add(this.txtTelF);
            this.grbDatosPersonales.Controls.Add(this.txtCodCli);
            this.grbDatosPersonales.Controls.Add(this.lblCodPos);
            this.grbDatosPersonales.Controls.Add(this.txtCuilCuit);
            this.grbDatosPersonales.Controls.Add(this.txtRSocial);
            this.grbDatosPersonales.Controls.Add(this.lblFecIn);
            this.grbDatosPersonales.Controls.Add(this.lblCateg);
            this.grbDatosPersonales.Controls.Add(this.lblTelC);
            this.grbDatosPersonales.Controls.Add(this.lblTelF);
            this.grbDatosPersonales.Controls.Add(this.lblCuilCuit);
            this.grbDatosPersonales.Controls.Add(this.lblRSocial);
            this.grbDatosPersonales.Location = new System.Drawing.Point(283, 12);
            this.grbDatosPersonales.Name = "grbDatosPersonales";
            this.grbDatosPersonales.Size = new System.Drawing.Size(488, 234);
            this.grbDatosPersonales.TabIndex = 1;
            this.grbDatosPersonales.TabStop = false;
            this.grbDatosPersonales.Text = "Datos Personales";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(234, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(290, 45);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApe
            // 
            this.txtApe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApe.Location = new System.Drawing.Point(114, 45);
            this.txtApe.MaxLength = 40;
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(114, 20);
            this.txtApe.TabIndex = 5;
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(6, 48);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(50, 13);
            this.lblApe.TabIndex = 4;
            this.lblApe.Text = "Apellido :";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(114, 123);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(211, 21);
            this.cmbLocalidad.TabIndex = 13;
            this.cmbLocalidad.Text = "Seleccione una...";
            this.cmbLocalidad.SelectionChangeCommitted += new System.EventHandler(this.cmbLocalidad_SelectionChangeCommitted);
            this.cmbLocalidad.TextChanged += new System.EventHandler(this.cmbLocalidad_TextChanged);
            this.cmbLocalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLocalidad_KeyDown);
            this.cmbLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuilCuit_KeyPress);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(6, 153);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(58, 13);
            this.lblDir.TabIndex = 16;
            this.lblDir.Text = "Dirección :";
            // 
            // cmbCateg
            // 
            this.cmbCateg.Location = new System.Drawing.Point(114, 202);
            this.cmbCateg.Name = "cmbCateg";
            this.cmbCateg.Size = new System.Drawing.Size(132, 21);
            this.cmbCateg.TabIndex = 23;
            this.cmbCateg.Text = "Seleccione una...";
            this.cmbCateg.SelectionChangeCommitted += new System.EventHandler(this.cmbCateg_SelectionChangeCommitted);
            this.cmbCateg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLocalidad_KeyDown);
            this.cmbCateg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuilCuit_KeyPress);
            // 
            // txtDir
            // 
            this.txtDir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDir.Location = new System.Drawing.Point(114, 150);
            this.txtDir.MaxLength = 60;
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(368, 20);
            this.txtDir.TabIndex = 17;
            // 
            // txtFecIn
            // 
            this.txtFecIn.Location = new System.Drawing.Point(370, 19);
            this.txtFecIn.Name = "txtFecIn";
            this.txtFecIn.ReadOnly = true;
            this.txtFecIn.Size = new System.Drawing.Size(65, 20);
            this.txtFecIn.TabIndex = 3;
            this.txtFecIn.TabStop = false;
            // 
            // txtCodPos
            // 
            this.txtCodPos.Location = new System.Drawing.Point(370, 123);
            this.txtCodPos.MaxLength = 4;
            this.txtCodPos.Name = "txtCodPos";
            this.txtCodPos.ReadOnly = true;
            this.txtCodPos.Size = new System.Drawing.Size(65, 20);
            this.txtCodPos.TabIndex = 15;
            this.txtCodPos.TabStop = false;
            this.txtCodPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelC
            // 
            this.txtTelC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelC.Location = new System.Drawing.Point(303, 176);
            this.txtTelC.MaxLength = 15;
            this.txtTelC.Name = "txtTelC";
            this.txtTelC.Size = new System.Drawing.Size(132, 20);
            this.txtTelC.TabIndex = 21;
            this.txtTelC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelF_KeyDown);
            this.txtTelC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuilCuit_KeyPress);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(6, 126);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(59, 13);
            this.lblLocalidad.TabIndex = 12;
            this.lblLocalidad.Text = "Localidad :";
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Location = new System.Drawing.Point(6, 22);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(96, 13);
            this.lblCodCli.TabIndex = 0;
            this.lblCodCli.Text = "Código de Cliente :";
            // 
            // txtTelF
            // 
            this.txtTelF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelF.Location = new System.Drawing.Point(114, 176);
            this.txtTelF.MaxLength = 15;
            this.txtTelF.Name = "txtTelF";
            this.txtTelF.Size = new System.Drawing.Size(132, 20);
            this.txtTelF.TabIndex = 19;
            this.txtTelF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelF_KeyDown);
            this.txtTelF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuilCuit_KeyPress);
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
            // lblCodPos
            // 
            this.lblCodPos.AutoSize = true;
            this.lblCodPos.Location = new System.Drawing.Point(334, 126);
            this.lblCodPos.Name = "lblCodPos";
            this.lblCodPos.Size = new System.Drawing.Size(30, 13);
            this.lblCodPos.TabIndex = 14;
            this.lblCodPos.Text = "C.P.:";
            // 
            // txtCuilCuit
            // 
            this.txtCuilCuit.AccessibleDescription = "";
            this.txtCuilCuit.AccessibleName = "";
            this.txtCuilCuit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuilCuit.Location = new System.Drawing.Point(114, 97);
            this.txtCuilCuit.MaxLength = 11;
            this.txtCuilCuit.Name = "txtCuilCuit";
            this.txtCuilCuit.Size = new System.Drawing.Size(132, 20);
            this.txtCuilCuit.TabIndex = 11;
            this.txtCuilCuit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuilCuit_KeyDown);
            this.txtCuilCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuilCuit_KeyPress);
            this.txtCuilCuit.Leave += new System.EventHandler(this.txtCuilCuit_Leave);
            // 
            // txtRSocial
            // 
            this.txtRSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRSocial.Location = new System.Drawing.Point(114, 71);
            this.txtRSocial.MaxLength = 40;
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Size = new System.Drawing.Size(368, 20);
            this.txtRSocial.TabIndex = 9;
            // 
            // lblFecIn
            // 
            this.lblFecIn.AutoSize = true;
            this.lblFecIn.Location = new System.Drawing.Point(278, 22);
            this.lblFecIn.Name = "lblFecIn";
            this.lblFecIn.Size = new System.Drawing.Size(86, 13);
            this.lblFecIn.TabIndex = 2;
            this.lblFecIn.Text = "Fecha de Inicio :";
            // 
            // lblCateg
            // 
            this.lblCateg.AutoSize = true;
            this.lblCateg.Location = new System.Drawing.Point(6, 205);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(60, 13);
            this.lblCateg.TabIndex = 22;
            this.lblCateg.Text = "Categoría :";
            // 
            // lblTelC
            // 
            this.lblTelC.AutoSize = true;
            this.lblTelC.Location = new System.Drawing.Point(252, 179);
            this.lblTelC.Name = "lblTelC";
            this.lblTelC.Size = new System.Drawing.Size(45, 13);
            this.lblTelC.TabIndex = 20;
            this.lblTelC.Text = "Celular :";
            // 
            // lblTelF
            // 
            this.lblTelF.AutoSize = true;
            this.lblTelF.Location = new System.Drawing.Point(6, 179);
            this.lblTelF.Name = "lblTelF";
            this.lblTelF.Size = new System.Drawing.Size(55, 13);
            this.lblTelF.TabIndex = 18;
            this.lblTelF.Text = "Teléfono :";
            // 
            // lblCuilCuit
            // 
            this.lblCuilCuit.AutoSize = true;
            this.lblCuilCuit.Location = new System.Drawing.Point(6, 102);
            this.lblCuilCuit.Name = "lblCuilCuit";
            this.lblCuilCuit.Size = new System.Drawing.Size(67, 13);
            this.lblCuilCuit.TabIndex = 10;
            this.lblCuilCuit.Text = "CUIL/CUIT :";
            // 
            // lblRSocial
            // 
            this.lblRSocial.AutoSize = true;
            this.lblRSocial.Location = new System.Drawing.Point(6, 74);
            this.lblRSocial.Name = "lblRSocial";
            this.lblRSocial.Size = new System.Drawing.Size(76, 13);
            this.lblRSocial.TabIndex = 8;
            this.lblRSocial.Text = "Razon Social :";
            // 
            // lvClientes
            // 
            this.lvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCodCli,
            this.colAN});
            this.lvClientes.FullRowSelect = true;
            this.lvClientes.GridLines = true;
            this.lvClientes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvClientes.Location = new System.Drawing.Point(12, 12);
            this.lvClientes.Name = "lvClientes";
            this.lvClientes.Scrollable = false;
            this.lvClientes.Size = new System.Drawing.Size(265, 263);
            this.lvClientes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvClientes.TabIndex = 0;
            this.lvClientes.UseCompatibleStateImageBehavior = false;
            this.lvClientes.View = System.Windows.Forms.View.Details;
            this.lvClientes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvClientes_ItemSelectionChanged);
            this.lvClientes.DoubleClick += new System.EventHandler(this.lvClientes_DoubleClick);
            // 
            // colCodCli
            // 
            this.colCodCli.Text = "Código";
            this.colCodCli.Width = 50;
            // 
            // colAN
            // 
            this.colAN.Text = "Apellido y Nombre";
            this.colAN.Width = 215;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 284);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(783, 22);
            this.StatusStrip1.TabIndex = 5;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabelInfo
            // 
            this.ToolStripStatusLabelInfo.Name = "ToolStripStatusLabelInfo";
            this.ToolStripStatusLabelInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // sFBDDataSet
            // 
            this.sFBDDataSet.DataSetName = "SFBDDataSet";
            this.sFBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localidadBindingSource
            // 
            this.localidadBindingSource.DataMember = "Localidad";
            this.localidadBindingSource.DataSource = this.sFBDDataSet;
            // 
            // localidadTableAdapter
            // 
            this.localidadTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaCBindingSource
            // 
            this.categoriaCBindingSource.DataMember = "CategoriaC";
            this.categoriaCBindingSource.DataSource = this.sFBDDataSet;
            // 
            // categoriaCTableAdapter
            // 
            this.categoriaCTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.sFBDDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 306);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grbDatosPersonales);
            this.Controls.Add(this.lvClientes);
            this.Name = "frmEditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar/Eliminar datos de Clientes";
            this.Load += new System.EventHandler(this.frmEditarCliente_Load);
            this.grbDatosPersonales.ResumeLayout(false);
            this.grbDatosPersonales.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnModificar;
        internal System.Windows.Forms.GroupBox grbDatosPersonales;
        internal System.Windows.Forms.ComboBox cmbLocalidad;
        internal System.Windows.Forms.Label lblDir;
        internal System.Windows.Forms.ComboBox cmbCateg;
        internal System.Windows.Forms.TextBox txtDir;
        internal System.Windows.Forms.TextBox txtFecIn;
        internal System.Windows.Forms.TextBox txtCodPos;
        internal System.Windows.Forms.TextBox txtTelC;
        internal System.Windows.Forms.Label lblLocalidad;
        internal System.Windows.Forms.Label lblCodCli;
        internal System.Windows.Forms.TextBox txtTelF;
        internal System.Windows.Forms.TextBox txtCodCli;
        internal System.Windows.Forms.Label lblCodPos;
        internal System.Windows.Forms.TextBox txtCuilCuit;
        internal System.Windows.Forms.TextBox txtRSocial;
        internal System.Windows.Forms.Label lblFecIn;
        internal System.Windows.Forms.Label lblCateg;
        internal System.Windows.Forms.Label lblTelC;
        internal System.Windows.Forms.Label lblTelF;
        internal System.Windows.Forms.Label lblCuilCuit;
        internal System.Windows.Forms.Label lblRSocial;
        internal System.Windows.Forms.ListView lvClientes;
        internal System.Windows.Forms.ColumnHeader colCodCli;
        internal System.Windows.Forms.ColumnHeader colAN;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelInfo;
        private SFDBDataSet sFBDDataSet;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private SFDBDataSetTableAdapters.LocalidadTableAdapter localidadTableAdapter;
        private System.Windows.Forms.BindingSource categoriaCBindingSource;
        private SFDBDataSetTableAdapters.CategoriaCTableAdapter categoriaCTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SFDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        internal System.Windows.Forms.Label lblNombre;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.TextBox txtApe;
        internal System.Windows.Forms.Label lblApe;
    }
}