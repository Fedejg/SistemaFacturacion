namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmAltaFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaFactura));
            this.btnCargarDR = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.txtIVAInsc = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblIVAInsc = new System.Windows.Forms.Label();
            this.lblNeto = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtImporteT = new System.Windows.Forms.TextBox();
            this.lblImporteT = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lvFactura = new System.Windows.Forms.ListView();
            this.ColumnCodArt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbCondVenta = new System.Windows.Forms.ComboBox();
            this.lblCondVenta = new System.Windows.Forms.Label();
            this.dtpFechaR = new System.Windows.Forms.DateTimePicker();
            this.lblFechaR = new System.Windows.Forms.Label();
            this.lblRemitoN = new System.Windows.Forms.Label();
            this.txtRemitoN = new System.Windows.Forms.TextBox();
            this.txtCuitCliente = new System.Windows.Forms.TextBox();
            this.txtFacturaN = new System.Windows.Forms.TextBox();
            this.lblFacturaN = new System.Windows.Forms.Label();
            this.lblCuitCliente = new System.Windows.Forms.Label();
            this.cmbIVA = new System.Windows.Forms.ComboBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.cmbFactura = new System.Windows.Forms.ComboBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtDirCliente = new System.Windows.Forms.TextBox();
            this.lblDirCliente = new System.Windows.Forms.Label();
            this.txtLocCliente = new System.Windows.Forms.TextBox();
            this.lblLocCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripVistaPreliminar = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VistaPreliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sFDBDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ClienteTableAdapter();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidadTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.LocalidadTableAdapter();
            this.categoriaCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaCTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.CategoriaCTableAdapter();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloTableAdapter();
            this.articuloCategoriaCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloCategoriaCTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloCategoriaCTableAdapter();
            this.remitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remitoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.RemitoTableAdapter();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.FacturaTableAdapter();
            this.lineaRemitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineaRemitoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.LineaRemitoTableAdapter();
            this.sFDBDataSet1 = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.pagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.PagoTableAdapter();
            this.ToolStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloCategoriaCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaRemitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarDR
            // 
            this.btnCargarDR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarDR.Location = new System.Drawing.Point(250, 209);
            this.btnCargarDR.Name = "btnCargarDR";
            this.btnCargarDR.Size = new System.Drawing.Size(190, 22);
            this.btnCargarDR.TabIndex = 62;
            this.btnCargarDR.Text = "Cargar Detalle de Remito";
            this.btnCargarDR.UseVisualStyleBackColor = true;
            this.btnCargarDR.Click += new System.EventHandler(this.btnCargarDR_Click);
            this.btnCargarDR.MouseLeave += new System.EventHandler(this.btnCargarDR_MouseLeave);
            this.btnCargarDR.MouseHover += new System.EventHandler(this.btnCargarDR_MouseHover);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(284, 506);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 74;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnCargarDR_MouseLeave);
            this.btnGuardar.MouseHover += new System.EventHandler(this.btnGuardar_MouseHover);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(365, 506);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 75;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCargarDR_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(199, 480);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.Size = new System.Drawing.Size(60, 20);
            this.txtNeto.TabIndex = 69;
            this.txtNeto.TabStop = false;
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIVAInsc
            // 
            this.txtIVAInsc.Location = new System.Drawing.Point(290, 480);
            this.txtIVAInsc.Name = "txtIVAInsc";
            this.txtIVAInsc.ReadOnly = true;
            this.txtIVAInsc.Size = new System.Drawing.Size(60, 20);
            this.txtIVAInsc.TabIndex = 71;
            this.txtIVAInsc.TabStop = false;
            this.txtIVAInsc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(19, 480);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(60, 20);
            this.txtSubtotal.TabIndex = 65;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIVAInsc
            // 
            this.lblIVAInsc.AutoSize = true;
            this.lblIVAInsc.Location = new System.Drawing.Point(282, 464);
            this.lblIVAInsc.Name = "lblIVAInsc";
            this.lblIVAInsc.Size = new System.Drawing.Size(79, 13);
            this.lblIVAInsc.TabIndex = 70;
            this.lblIVAInsc.Text = "I.V.A. Inscr. (%)";
            // 
            // lblNeto
            // 
            this.lblNeto.AutoSize = true;
            this.lblNeto.Location = new System.Drawing.Point(196, 464);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(68, 13);
            this.lblNeto.TabIndex = 68;
            this.lblNeto.Text = "Importe Neto";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(22, 464);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(53, 13);
            this.lblSubTotal.TabIndex = 64;
            this.lblSubTotal.Text = "SubTotal ";
            // 
            // txtImporteT
            // 
            this.txtImporteT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteT.Location = new System.Drawing.Point(380, 480);
            this.txtImporteT.Name = "txtImporteT";
            this.txtImporteT.ReadOnly = true;
            this.txtImporteT.Size = new System.Drawing.Size(60, 20);
            this.txtImporteT.TabIndex = 73;
            this.txtImporteT.TabStop = false;
            this.txtImporteT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblImporteT
            // 
            this.lblImporteT.AutoSize = true;
            this.lblImporteT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteT.Location = new System.Drawing.Point(371, 464);
            this.lblImporteT.Name = "lblImporteT";
            this.lblImporteT.Size = new System.Drawing.Size(69, 13);
            this.lblImporteT.TabIndex = 72;
            this.lblImporteT.Text = "Importe Total";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(106, 480);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(60, 20);
            this.txtDescuento.TabIndex = 67;
            this.txtDescuento.TabStop = false;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(110, 464);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(59, 13);
            this.lblDescuento.TabIndex = 66;
            this.lblDescuento.Text = "Descuento";
            // 
            // lvFactura
            // 
            this.lvFactura.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvFactura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnCodArt,
            this.ColumnDescripcion,
            this.ColumnPrecio,
            this.ColumnCantidad,
            this.ColumnImporte});
            this.lvFactura.FullRowSelect = true;
            this.lvFactura.GridLines = true;
            this.lvFactura.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFactura.Location = new System.Drawing.Point(12, 237);
            this.lvFactura.Name = "lvFactura";
            this.lvFactura.Size = new System.Drawing.Size(428, 224);
            this.lvFactura.TabIndex = 63;
            this.lvFactura.UseCompatibleStateImageBehavior = false;
            this.lvFactura.View = System.Windows.Forms.View.Details;
            // 
            // ColumnCodArt
            // 
            this.ColumnCodArt.Text = "Código";
            this.ColumnCodArt.Width = 55;
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.Text = "Descripción";
            this.ColumnDescripcion.Width = 189;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.Text = "Precio U.";
            this.ColumnPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.Text = "Cantidad";
            this.ColumnCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnImporte
            // 
            this.ColumnImporte.Text = "Importe";
            this.ColumnImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbCondVenta
            // 
            this.cmbCondVenta.FormattingEnabled = true;
            this.cmbCondVenta.Items.AddRange(new object[] {
            "Contado",
            "Cuenta Corriente",
            "Tarjeta"});
            this.cmbCondVenta.Location = new System.Drawing.Point(129, 210);
            this.cmbCondVenta.Name = "cmbCondVenta";
            this.cmbCondVenta.Size = new System.Drawing.Size(108, 21);
            this.cmbCondVenta.TabIndex = 61;
            this.cmbCondVenta.Text = "Seleccione una...";
            this.cmbCondVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbIVA_KeyDown);
            this.cmbCondVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFactura_KeyPress);
            this.cmbCondVenta.Leave += new System.EventHandler(this.cmbCondVenta_Leave);
            // 
            // lblCondVenta
            // 
            this.lblCondVenta.AutoSize = true;
            this.lblCondVenta.Location = new System.Drawing.Point(12, 214);
            this.lblCondVenta.Name = "lblCondVenta";
            this.lblCondVenta.Size = new System.Drawing.Size(106, 13);
            this.lblCondVenta.TabIndex = 60;
            this.lblCondVenta.Text = "Condición de Venta :";
            // 
            // dtpFechaR
            // 
            this.dtpFechaR.Location = new System.Drawing.Point(250, 183);
            this.dtpFechaR.Name = "dtpFechaR";
            this.dtpFechaR.Size = new System.Drawing.Size(190, 20);
            this.dtpFechaR.TabIndex = 59;
            // 
            // lblFechaR
            // 
            this.lblFechaR.AutoSize = true;
            this.lblFechaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaR.Location = new System.Drawing.Point(181, 189);
            this.lblFechaR.Name = "lblFechaR";
            this.lblFechaR.Size = new System.Drawing.Size(63, 13);
            this.lblFechaR.TabIndex = 58;
            this.lblFechaR.Text = "Fecha Rto :";
            // 
            // lblRemitoN
            // 
            this.lblRemitoN.AutoSize = true;
            this.lblRemitoN.Location = new System.Drawing.Point(12, 187);
            this.lblRemitoN.Name = "lblRemitoN";
            this.lblRemitoN.Size = new System.Drawing.Size(61, 13);
            this.lblRemitoN.TabIndex = 56;
            this.lblRemitoN.Text = "Remito Nº :";
            // 
            // txtRemitoN
            // 
            this.txtRemitoN.Location = new System.Drawing.Point(77, 184);
            this.txtRemitoN.Name = "txtRemitoN";
            this.txtRemitoN.Size = new System.Drawing.Size(98, 20);
            this.txtRemitoN.TabIndex = 57;
            this.txtRemitoN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRemitoN_KeyDown);
            this.txtRemitoN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFactura_KeyPress);
            this.txtRemitoN.Leave += new System.EventHandler(this.txtRemitoN_Leave);
            // 
            // txtCuitCliente
            // 
            this.txtCuitCliente.Enabled = false;
            this.txtCuitCliente.Location = new System.Drawing.Point(340, 157);
            this.txtCuitCliente.Name = "txtCuitCliente";
            this.txtCuitCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCuitCliente.TabIndex = 55;
            this.txtCuitCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFacturaN
            // 
            this.txtFacturaN.Location = new System.Drawing.Point(322, 52);
            this.txtFacturaN.Name = "txtFacturaN";
            this.txtFacturaN.ReadOnly = true;
            this.txtFacturaN.Size = new System.Drawing.Size(118, 20);
            this.txtFacturaN.TabIndex = 44;
            this.txtFacturaN.TabStop = false;
            this.txtFacturaN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFacturaN
            // 
            this.lblFacturaN.AutoSize = true;
            this.lblFacturaN.Location = new System.Drawing.Point(252, 55);
            this.lblFacturaN.Name = "lblFacturaN";
            this.lblFacturaN.Size = new System.Drawing.Size(64, 13);
            this.lblFacturaN.TabIndex = 43;
            this.lblFacturaN.Text = "Factura Nº :";
            // 
            // lblCuitCliente
            // 
            this.lblCuitCliente.AutoSize = true;
            this.lblCuitCliente.Location = new System.Drawing.Point(296, 160);
            this.lblCuitCliente.Name = "lblCuitCliente";
            this.lblCuitCliente.Size = new System.Drawing.Size(38, 13);
            this.lblCuitCliente.TabIndex = 54;
            this.lblCuitCliente.Text = "CUIT :";
            // 
            // cmbIVA
            // 
            this.cmbIVA.FormattingEnabled = true;
            this.cmbIVA.Items.AddRange(new object[] {
            "Consumidor Final",
            "Exento",
            "No Responsable",
            "Responsable Monotributo",
            "Responsable No Inscripto",
            "Responsable Inscripto"});
            this.cmbIVA.Location = new System.Drawing.Point(77, 157);
            this.cmbIVA.Name = "cmbIVA";
            this.cmbIVA.Size = new System.Drawing.Size(160, 21);
            this.cmbIVA.TabIndex = 53;
            this.cmbIVA.Text = "Seleccione una categoría...";
            this.cmbIVA.SelectionChangeCommitted += new System.EventHandler(this.cmbIVA_SelectionChangeCommitted);
            this.cmbIVA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbIVA_KeyDown);
            this.cmbIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFactura_KeyPress);
            this.cmbIVA.Leave += new System.EventHandler(this.cmbIVA_Leave);
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(12, 160);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(36, 13);
            this.lblIVA.TabIndex = 52;
            this.lblIVA.Text = "I.V.A.:";
            // 
            // cmbFactura
            // 
            this.cmbFactura.FormattingEnabled = true;
            this.cmbFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbFactura.Location = new System.Drawing.Point(106, 52);
            this.cmbFactura.Name = "cmbFactura";
            this.cmbFactura.Size = new System.Drawing.Size(41, 21);
            this.cmbFactura.TabIndex = 42;
            this.cmbFactura.SelectionChangeCommitted += new System.EventHandler(this.cmbFactura_SelectionChangeCommitted);
            this.cmbFactura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFactura_KeyDown);
            this.cmbFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFactura_KeyPress);
            this.cmbFactura.Leave += new System.EventHandler(this.cmbFactura_Leave);
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(12, 55);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(88, 13);
            this.lblFactura.TabIndex = 41;
            this.lblFactura.Text = "Tipo de Factura :";
            // 
            // txtDirCliente
            // 
            this.txtDirCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDirCliente.Location = new System.Drawing.Point(77, 131);
            this.txtDirCliente.Name = "txtDirCliente";
            this.txtDirCliente.ReadOnly = true;
            this.txtDirCliente.Size = new System.Drawing.Size(363, 20);
            this.txtDirCliente.TabIndex = 51;
            this.txtDirCliente.TabStop = false;
            // 
            // lblDirCliente
            // 
            this.lblDirCliente.AutoSize = true;
            this.lblDirCliente.Location = new System.Drawing.Point(12, 134);
            this.lblDirCliente.Name = "lblDirCliente";
            this.lblDirCliente.Size = new System.Drawing.Size(55, 13);
            this.lblDirCliente.TabIndex = 50;
            this.lblDirCliente.Text = "Domicilio :";
            // 
            // txtLocCliente
            // 
            this.txtLocCliente.Location = new System.Drawing.Point(77, 105);
            this.txtLocCliente.Name = "txtLocCliente";
            this.txtLocCliente.ReadOnly = true;
            this.txtLocCliente.Size = new System.Drawing.Size(236, 20);
            this.txtLocCliente.TabIndex = 49;
            this.txtLocCliente.TabStop = false;
            // 
            // lblLocCliente
            // 
            this.lblLocCliente.AutoSize = true;
            this.lblLocCliente.Location = new System.Drawing.Point(12, 108);
            this.lblLocCliente.Name = "lblLocCliente";
            this.lblLocCliente.Size = new System.Drawing.Size(59, 13);
            this.lblLocCliente.TabIndex = 48;
            this.lblLocCliente.Text = "Localidad :";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(77, 78);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(236, 21);
            this.cmbCliente.TabIndex = 46;
            this.cmbCliente.Text = "Seleccione un Cliente...";
            this.cmbCliente.SelectionChangeCommitted += new System.EventHandler(this.cmbCliente_SelectionChangeCommitted);
            this.cmbCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCliente_KeyDown);
            this.cmbCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFactura_KeyPress);
            this.cmbCliente.Leave += new System.EventHandler(this.cmbCliente_Leave);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 81);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 13);
            this.lblCliente.TabIndex = 45;
            this.lblCliente.Text = "Cliente :";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(368, 78);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(72, 20);
            this.txtFecha.TabIndex = 47;
            this.txtFecha.TabStop = false;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripVistaPreliminar});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(452, 25);
            this.ToolStrip1.TabIndex = 40;
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
            this.ToolStripVistaPreliminar.MouseLeave += new System.EventHandler(this.btnCargarDR_MouseLeave);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 532);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(452, 22);
            this.StatusStrip1.TabIndex = 76;
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
            this.FacturaToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(452, 24);
            this.MenuStrip1.TabIndex = 39;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FacturaToolStripMenuItem
            // 
            this.FacturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImprimirToolStripMenuItem,
            this.VistaPreliminarToolStripMenuItem,
            this.ToolStripSeparator1,
            this.SalirToolStripMenuItem});
            this.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem";
            this.FacturaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.FacturaToolStripMenuItem.Text = "&Factura";
            // 
            // ImprimirToolStripMenuItem
            // 
            this.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem";
            this.ImprimirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ImprimirToolStripMenuItem.Text = "&Imprimir";
            this.ImprimirToolStripMenuItem.Click += new System.EventHandler(this.ImprimirToolStripMenuItem_Click);
            this.ImprimirToolStripMenuItem.MouseLeave += new System.EventHandler(this.btnCargarDR_MouseLeave);
            this.ImprimirToolStripMenuItem.MouseHover += new System.EventHandler(this.ImprimirToolStripMenuItem_MouseHover);
            // 
            // VistaPreliminarToolStripMenuItem
            // 
            this.VistaPreliminarToolStripMenuItem.Name = "VistaPreliminarToolStripMenuItem";
            this.VistaPreliminarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.VistaPreliminarToolStripMenuItem.Text = "&Vista preliminar";
            this.VistaPreliminarToolStripMenuItem.Click += new System.EventHandler(this.VistaPreliminarToolStripMenuItem_Click);
            this.VistaPreliminarToolStripMenuItem.MouseLeave += new System.EventHandler(this.btnCargarDR_MouseLeave);
            this.VistaPreliminarToolStripMenuItem.MouseHover += new System.EventHandler(this.VistaPreliminarToolStripMenuItem_MouseHover);
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
            this.SalirToolStripMenuItem.Text = "&Salir";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            this.SalirToolStripMenuItem.MouseLeave += new System.EventHandler(this.btnCargarDR_MouseLeave);
            this.SalirToolStripMenuItem.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
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
            // sFDBDataSet
            // 
            this.sFDBDataSet.DataSetName = "SFDBDataSet";
            this.sFDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.sFDBDataSet;
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
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "Articulo";
            this.articuloBindingSource.DataSource = this.sFDBDataSet;
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // articuloCategoriaCBindingSource
            // 
            this.articuloCategoriaCBindingSource.DataMember = "ArticuloCategoriaC";
            this.articuloCategoriaCBindingSource.DataSource = this.sFDBDataSet;
            // 
            // articuloCategoriaCTableAdapter
            // 
            this.articuloCategoriaCTableAdapter.ClearBeforeFill = true;
            // 
            // remitoBindingSource
            // 
            this.remitoBindingSource.DataMember = "Remito";
            this.remitoBindingSource.DataSource = this.sFDBDataSet;
            // 
            // remitoTableAdapter
            // 
            this.remitoTableAdapter.ClearBeforeFill = true;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.sFDBDataSet;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // lineaRemitoBindingSource
            // 
            this.lineaRemitoBindingSource.DataMember = "LineaRemito";
            this.lineaRemitoBindingSource.DataSource = this.sFDBDataSet;
            // 
            // lineaRemitoTableAdapter
            // 
            this.lineaRemitoTableAdapter.ClearBeforeFill = true;
            // 
            // sFDBDataSet1
            // 
            this.sFDBDataSet1.DataSetName = "SFDBDataSet";
            this.sFDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pagoBindingSource
            // 
            this.pagoBindingSource.DataMember = "Pago";
            this.pagoBindingSource.DataSource = this.sFDBDataSet1;
            // 
            // pagoTableAdapter
            // 
            this.pagoTableAdapter.ClearBeforeFill = true;
            // 
            // frmAltaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 554);
            this.Controls.Add(this.btnCargarDR);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.txtIVAInsc);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblIVAInsc);
            this.Controls.Add(this.lblNeto);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.txtImporteT);
            this.Controls.Add(this.lblImporteT);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lvFactura);
            this.Controls.Add(this.cmbCondVenta);
            this.Controls.Add(this.lblCondVenta);
            this.Controls.Add(this.dtpFechaR);
            this.Controls.Add(this.lblFechaR);
            this.Controls.Add(this.lblRemitoN);
            this.Controls.Add(this.txtRemitoN);
            this.Controls.Add(this.txtCuitCliente);
            this.Controls.Add(this.txtFacturaN);
            this.Controls.Add(this.lblFacturaN);
            this.Controls.Add(this.lblCuitCliente);
            this.Controls.Add(this.cmbIVA);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.cmbFactura);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.txtDirCliente);
            this.Controls.Add(this.lblDirCliente);
            this.Controls.Add(this.txtLocCliente);
            this.Controls.Add(this.lblLocCliente);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "frmAltaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emisión de Facturas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAltaFactura_FormClosing);
            this.Load += new System.EventHandler(this.frmAltaFactura_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloCategoriaCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaRemitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCargarDR;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.TextBox txtNeto;
        internal System.Windows.Forms.TextBox txtIVAInsc;
        internal System.Windows.Forms.TextBox txtSubtotal;
        internal System.Windows.Forms.Label lblIVAInsc;
        internal System.Windows.Forms.Label lblNeto;
        internal System.Windows.Forms.Label lblSubTotal;
        internal System.Windows.Forms.TextBox txtImporteT;
        internal System.Windows.Forms.Label lblImporteT;
        internal System.Windows.Forms.TextBox txtDescuento;
        internal System.Windows.Forms.Label lblDescuento;
        internal System.Windows.Forms.ListView lvFactura;
        internal System.Windows.Forms.ColumnHeader ColumnCodArt;
        internal System.Windows.Forms.ColumnHeader ColumnDescripcion;
        internal System.Windows.Forms.ColumnHeader ColumnPrecio;
        internal System.Windows.Forms.ColumnHeader ColumnCantidad;
        internal System.Windows.Forms.ColumnHeader ColumnImporte;
        internal System.Windows.Forms.ComboBox cmbCondVenta;
        internal System.Windows.Forms.Label lblCondVenta;
        internal System.Windows.Forms.DateTimePicker dtpFechaR;
        internal System.Windows.Forms.Label lblFechaR;
        internal System.Windows.Forms.Label lblRemitoN;
        internal System.Windows.Forms.TextBox txtRemitoN;
        internal System.Windows.Forms.TextBox txtCuitCliente;
        internal System.Windows.Forms.TextBox txtFacturaN;
        internal System.Windows.Forms.Label lblFacturaN;
        internal System.Windows.Forms.Label lblCuitCliente;
        internal System.Windows.Forms.ComboBox cmbIVA;
        internal System.Windows.Forms.Label lblIVA;
        internal System.Windows.Forms.ComboBox cmbFactura;
        internal System.Windows.Forms.Label lblFactura;
        internal System.Windows.Forms.TextBox txtDirCliente;
        internal System.Windows.Forms.Label lblDirCliente;
        internal System.Windows.Forms.TextBox txtLocCliente;
        internal System.Windows.Forms.Label lblLocCliente;
        internal System.Windows.Forms.ComboBox cmbCliente;
        internal System.Windows.Forms.Label lblCliente;
        internal System.Windows.Forms.TextBox txtFecha;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripVistaPreliminar;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelInfo;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FacturaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ImprimirToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem VistaPreliminarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private SFDBDataSet sFDBDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SFDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private SFDBDataSetTableAdapters.LocalidadTableAdapter localidadTableAdapter;
        private System.Windows.Forms.BindingSource categoriaCBindingSource;
        private SFDBDataSetTableAdapters.CategoriaCTableAdapter categoriaCTableAdapter;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private SFDBDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.BindingSource articuloCategoriaCBindingSource;
        private SFDBDataSetTableAdapters.ArticuloCategoriaCTableAdapter articuloCategoriaCTableAdapter;
        private System.Windows.Forms.BindingSource remitoBindingSource;
        private SFDBDataSetTableAdapters.RemitoTableAdapter remitoTableAdapter;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private SFDBDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.BindingSource lineaRemitoBindingSource;
        private SFDBDataSetTableAdapters.LineaRemitoTableAdapter lineaRemitoTableAdapter;
        private SFDBDataSet sFDBDataSet1;
        private System.Windows.Forms.BindingSource pagoBindingSource;
        private SFDBDataSetTableAdapters.PagoTableAdapter pagoTableAdapter;
    }
}