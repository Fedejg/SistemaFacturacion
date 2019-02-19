namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmAltaRemito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaRemito));
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblImporteT = new System.Windows.Forms.Label();
            this.txtImporteT = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvLineaRemito = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImporteP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRemitoN = new System.Windows.Forms.TextBox();
            this.lblRemitoN = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblLocCliente = new System.Windows.Forms.Label();
            this.txtDirCliente = new System.Windows.Forms.TextBox();
            this.lblDirCliente = new System.Windows.Forms.Label();
            this.cmbCli = new System.Windows.Forms.ComboBox();
            this.lblApe = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripVistaPreliminar = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RemitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VistaPreliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sFBDDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ClienteTableAdapter();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidadTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.LocalidadTableAdapter();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloTableAdapter();
            this.articuloCategoriaCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloCategoriaCTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloCategoriaCTableAdapter();
            this.remitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remitoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.RemitoTableAdapter();
            this.lineaRemitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineaRemitoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.LineaRemitoTableAdapter();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.StockTableAdapter();
            this.rubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubroTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.RubroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineaRemito)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloCategoriaCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaRemitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(83, 498);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(60, 20);
            this.txtDescuento.TabIndex = 34;
            this.txtDescuento.Text = "0,00";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.Leave += new System.EventHandler(this.txtDescuento_Leave);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(12, 501);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(65, 13);
            this.lblDescuento.TabIndex = 33;
            this.lblDescuento.Text = "Descuento :";
            // 
            // lblImporteT
            // 
            this.lblImporteT.AutoSize = true;
            this.lblImporteT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteT.Location = new System.Drawing.Point(149, 501);
            this.lblImporteT.Name = "lblImporteT";
            this.lblImporteT.Size = new System.Drawing.Size(75, 13);
            this.lblImporteT.TabIndex = 35;
            this.lblImporteT.Text = "Importe Total :";
            // 
            // txtImporteT
            // 
            this.txtImporteT.Location = new System.Drawing.Point(230, 498);
            this.txtImporteT.Name = "txtImporteT";
            this.txtImporteT.ReadOnly = true;
            this.txtImporteT.Size = new System.Drawing.Size(60, 20);
            this.txtImporteT.TabIndex = 36;
            this.txtImporteT.TabStop = false;
            this.txtImporteT.Text = "0,00";
            this.txtImporteT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(395, 496);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(65, 23);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnGuardar.MouseHover += new System.EventHandler(this.btnGuardar_MouseHover);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(466, 496);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // dgvLineaRemito
            // 
            this.dgvLineaRemito.AllowUserToResizeColumns = false;
            this.dgvLineaRemito.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLineaRemito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLineaRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineaRemito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnDescripcion,
            this.ColumnPrecio,
            this.ColumnCantidad,
            this.ColumnImporteP});
            this.dgvLineaRemito.Location = new System.Drawing.Point(12, 133);
            this.dgvLineaRemito.Name = "dgvLineaRemito";
            this.dgvLineaRemito.RowHeadersWidth = 26;
            this.dgvLineaRemito.Size = new System.Drawing.Size(519, 357);
            this.dgvLineaRemito.StandardTab = true;
            this.dgvLineaRemito.TabIndex = 32;
            this.dgvLineaRemito.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLineaRemito_CellEndEdit);
            this.dgvLineaRemito.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLineaRemito_CellMouseDoubleClick);
            this.dgvLineaRemito.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvLineaRemito_RowsAdded);
            this.dgvLineaRemito.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvLineaRemito_RowsRemoved);
            // 
            // ColumnCodigo
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "000000";
            this.ColumnCodigo.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.MaxInputLength = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnCodigo.Width = 50;
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.HeaderText = "Descripción";
            this.ColumnDescripcion.Name = "ColumnDescripcion";
            this.ColumnDescripcion.ReadOnly = true;
            this.ColumnDescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDescripcion.Width = 261;
            // 
            // ColumnPrecio
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.ColumnPrecio.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.MaxInputLength = 7;
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.ReadOnly = true;
            this.ColumnPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnPrecio.Width = 60;
            // 
            // ColumnCantidad
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnCantidad.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnCantidad.HeaderText = "Cant";
            this.ColumnCantidad.MaxInputLength = 6;
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnCantidad.Width = 60;
            // 
            // ColumnImporteP
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.ColumnImporteP.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnImporteP.HeaderText = "Importe";
            this.ColumnImporteP.MaxInputLength = 7;
            this.ColumnImporteP.Name = "ColumnImporteP";
            this.ColumnImporteP.ReadOnly = true;
            this.ColumnImporteP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnImporteP.Width = 60;
            // 
            // txtRemitoN
            // 
            this.txtRemitoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemitoN.Location = new System.Drawing.Point(447, 81);
            this.txtRemitoN.Name = "txtRemitoN";
            this.txtRemitoN.ReadOnly = true;
            this.txtRemitoN.Size = new System.Drawing.Size(84, 20);
            this.txtRemitoN.TabIndex = 29;
            this.txtRemitoN.TabStop = false;
            this.txtRemitoN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRemitoN
            // 
            this.lblRemitoN.AutoSize = true;
            this.lblRemitoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemitoN.Location = new System.Drawing.Point(380, 84);
            this.lblRemitoN.Name = "lblRemitoN";
            this.lblRemitoN.Size = new System.Drawing.Size(61, 13);
            this.lblRemitoN.TabIndex = 28;
            this.lblRemitoN.Text = "Remito N° :";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(447, 52);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(84, 20);
            this.txtFecha.TabIndex = 25;
            this.txtFecha.TabStop = false;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(398, 55);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 13);
            this.lblFecha.TabIndex = 24;
            this.lblFecha.Text = "Fecha :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(77, 81);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(236, 20);
            this.txtNom.TabIndex = 27;
            this.txtNom.TabStop = false;
            // 
            // lblLocCliente
            // 
            this.lblLocCliente.AutoSize = true;
            this.lblLocCliente.Location = new System.Drawing.Point(12, 84);
            this.lblLocCliente.Name = "lblLocCliente";
            this.lblLocCliente.Size = new System.Drawing.Size(56, 13);
            this.lblLocCliente.TabIndex = 26;
            this.lblLocCliente.Text = "Localidad:";
            // 
            // txtDirCliente
            // 
            this.txtDirCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDirCliente.Location = new System.Drawing.Point(77, 107);
            this.txtDirCliente.Name = "txtDirCliente";
            this.txtDirCliente.ReadOnly = true;
            this.txtDirCliente.Size = new System.Drawing.Size(454, 20);
            this.txtDirCliente.TabIndex = 31;
            this.txtDirCliente.TabStop = false;
            // 
            // lblDirCliente
            // 
            this.lblDirCliente.AutoSize = true;
            this.lblDirCliente.Location = new System.Drawing.Point(12, 110);
            this.lblDirCliente.Name = "lblDirCliente";
            this.lblDirCliente.Size = new System.Drawing.Size(55, 13);
            this.lblDirCliente.TabIndex = 30;
            this.lblDirCliente.Text = "Domicilio :";
            // 
            // cmbCli
            // 
            this.cmbCli.FormattingEnabled = true;
            this.cmbCli.Location = new System.Drawing.Point(77, 54);
            this.cmbCli.Name = "cmbCli";
            this.cmbCli.Size = new System.Drawing.Size(236, 21);
            this.cmbCli.TabIndex = 23;
            this.cmbCli.Text = "Seleccione un Cliente...";
            this.cmbCli.SelectionChangeCommitted += new System.EventHandler(this.cmbCli_SelectionChangeCommitted);
            this.cmbCli.TextChanged += new System.EventHandler(this.cmbCli_TextChanged);
            this.cmbCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCli_KeyDown);
            this.cmbCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCli_KeyPress);
            this.cmbCli.Leave += new System.EventHandler(this.cmbCli_Leave);
            this.cmbCli.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.cmbCli.MouseHover += new System.EventHandler(this.cmbCli_MouseHover);
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(12, 55);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(42, 13);
            this.lblApe.TabIndex = 22;
            this.lblApe.Text = "Cliente:";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripVistaPreliminar});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(543, 25);
            this.ToolStrip1.TabIndex = 21;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripVistaPreliminar
            // 
            this.ToolStripVistaPreliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripVistaPreliminar.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripVistaPreliminar.Image")));
            this.ToolStripVistaPreliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripVistaPreliminar.Name = "ToolStripVistaPreliminar";
            this.ToolStripVistaPreliminar.Size = new System.Drawing.Size(23, 22);
            this.ToolStripVistaPreliminar.Text = "ToolStripButton1";
            this.ToolStripVistaPreliminar.ToolTipText = "Vista preliminar";
            this.ToolStripVistaPreliminar.Click += new System.EventHandler(this.VistaPreliminarToolStripMenuItem_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 522);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(543, 22);
            this.StatusStrip1.TabIndex = 39;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabelInfo
            // 
            this.ToolStripStatusLabelInfo.Name = "ToolStripStatusLabelInfo";
            this.ToolStripStatusLabelInfo.Size = new System.Drawing.Size(19, 17);
            this.ToolStripStatusLabelInfo.Text = "    ";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemitoToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(543, 24);
            this.MenuStrip1.TabIndex = 20;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // RemitoToolStripMenuItem
            // 
            this.RemitoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImprimirToolStripMenuItem,
            this.VistaPreliminarToolStripMenuItem,
            this.ToolStripSeparator1,
            this.SalirToolStripMenuItem});
            this.RemitoToolStripMenuItem.Name = "RemitoToolStripMenuItem";
            this.RemitoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.RemitoToolStripMenuItem.Text = "&Remito";
            // 
            // ImprimirToolStripMenuItem
            // 
            this.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem";
            this.ImprimirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ImprimirToolStripMenuItem.Text = "&Imprimir";
            this.ImprimirToolStripMenuItem.Click += new System.EventHandler(this.ImprimirToolStripMenuItem_Click);
            // 
            // VistaPreliminarToolStripMenuItem
            // 
            this.VistaPreliminarToolStripMenuItem.Name = "VistaPreliminarToolStripMenuItem";
            this.VistaPreliminarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.VistaPreliminarToolStripMenuItem.Text = "&Vista preliminar";
            this.VistaPreliminarToolStripMenuItem.Click += new System.EventHandler(this.VistaPreliminarToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.SalirToolStripMenuItem.Text = "Salir";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.printDocument1.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.printDocument1_QueryPageSettings);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // sFBDDataSet
            // 
            this.sFBDDataSet.DataSetName = "SFBDDataSet";
            this.sFBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // localidadBindingSource
            // 
            this.localidadBindingSource.DataMember = "Localidad";
            this.localidadBindingSource.DataSource = this.sFBDDataSet;
            // 
            // localidadTableAdapter
            // 
            this.localidadTableAdapter.ClearBeforeFill = true;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "Articulo";
            this.articuloBindingSource.DataSource = this.sFBDDataSet;
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // articuloCategoriaCBindingSource
            // 
            this.articuloCategoriaCBindingSource.DataMember = "ArticuloCategoriaC";
            this.articuloCategoriaCBindingSource.DataSource = this.sFBDDataSet;
            // 
            // articuloCategoriaCTableAdapter
            // 
            this.articuloCategoriaCTableAdapter.ClearBeforeFill = true;
            // 
            // remitoBindingSource
            // 
            this.remitoBindingSource.DataMember = "Remito";
            this.remitoBindingSource.DataSource = this.sFBDDataSet;
            // 
            // remitoTableAdapter
            // 
            this.remitoTableAdapter.ClearBeforeFill = true;
            // 
            // lineaRemitoBindingSource
            // 
            this.lineaRemitoBindingSource.DataMember = "LineaRemito";
            this.lineaRemitoBindingSource.DataSource = this.sFBDDataSet;
            // 
            // lineaRemitoTableAdapter
            // 
            this.lineaRemitoTableAdapter.ClearBeforeFill = true;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.sFBDDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // rubroBindingSource
            // 
            this.rubroBindingSource.DataMember = "Rubro";
            this.rubroBindingSource.DataSource = this.sFBDDataSet;
            // 
            // rubroTableAdapter
            // 
            this.rubroTableAdapter.ClearBeforeFill = true;
            // 
            // frmAltaRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 544);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblImporteT);
            this.Controls.Add(this.txtImporteT);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvLineaRemito);
            this.Controls.Add(this.txtRemitoN);
            this.Controls.Add(this.lblRemitoN);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblLocCliente);
            this.Controls.Add(this.txtDirCliente);
            this.Controls.Add(this.lblDirCliente);
            this.Controls.Add(this.cmbCli);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "frmAltaRemito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emisión de Remitos";
            this.Load += new System.EventHandler(this.frmAltaRemito_Load);
            this.Leave += new System.EventHandler(this.frmAltaRemito_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineaRemito)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloCategoriaCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaRemitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtDescuento;
        internal System.Windows.Forms.Label lblDescuento;
        internal System.Windows.Forms.Label lblImporteT;
        internal System.Windows.Forms.TextBox txtImporteT;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.DataGridView dgvLineaRemito;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcion;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnImporteP;
        internal System.Windows.Forms.TextBox txtRemitoN;
        internal System.Windows.Forms.Label lblRemitoN;
        internal System.Windows.Forms.TextBox txtFecha;
        internal System.Windows.Forms.Label lblFecha;
        internal System.Windows.Forms.TextBox txtNom;
        internal System.Windows.Forms.Label lblLocCliente;
        internal System.Windows.Forms.TextBox txtDirCliente;
        internal System.Windows.Forms.Label lblDirCliente;
        internal System.Windows.Forms.ComboBox cmbCli;
        internal System.Windows.Forms.Label lblApe;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripVistaPreliminar;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelInfo;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem RemitoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ImprimirToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem VistaPreliminarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private SFDBDataSet sFBDDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SFDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private SFDBDataSetTableAdapters.LocalidadTableAdapter localidadTableAdapter;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private SFDBDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.BindingSource articuloCategoriaCBindingSource;
        private SFDBDataSetTableAdapters.ArticuloCategoriaCTableAdapter articuloCategoriaCTableAdapter;
        private System.Windows.Forms.BindingSource remitoBindingSource;
        private SFDBDataSetTableAdapters.RemitoTableAdapter remitoTableAdapter;
        private System.Windows.Forms.BindingSource lineaRemitoBindingSource;
        private SFDBDataSetTableAdapters.LineaRemitoTableAdapter lineaRemitoTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private SFDBDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource rubroBindingSource;
        private SFDBDataSetTableAdapters.RubroTableAdapter rubroTableAdapter;
    }
}