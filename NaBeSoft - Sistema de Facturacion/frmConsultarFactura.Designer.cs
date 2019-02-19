namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmConsultarFactura
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
            this.cmbIngresoFactTipo = new System.Windows.Forms.ComboBox();
            this.lblIngresoFactTipo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.txtFechaR = new System.Windows.Forms.TextBox();
            this.txtCondVenta = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtImporteT = new System.Windows.Forms.TextBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblImporteT = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtIVAInsc = new System.Windows.Forms.TextBox();
            this.lblFacturaN = new System.Windows.Forms.Label();
            this.lblIVAInsc = new System.Windows.Forms.Label();
            this.txtFacturaN = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNeto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblLocCliente = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtLocCliente = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblDirCliente = new System.Windows.Forms.Label();
            this.lvFactura = new System.Windows.Forms.ListView();
            this.ColumnCodArt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDirCliente = new System.Windows.Forms.TextBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblFechaR = new System.Windows.Forms.Label();
            this.lblCuitCliente = new System.Windows.Forms.Label();
            this.txtRemitoN = new System.Windows.Forms.TextBox();
            this.lblCondVenta = new System.Windows.Forms.Label();
            this.lblRemitoN = new System.Windows.Forms.Label();
            this.txtCuitCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIngresoFact = new System.Windows.Forms.TextBox();
            this.lblIngresoFact = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.sFDBDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloTableAdapter();
            this.articuloCategoriaCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloCategoriaCTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloCategoriaCTableAdapter();
            this.clienteTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ClienteTableAdapter();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remitoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.RemitoTableAdapter();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.FacturaTableAdapter();
            this.lineaRemitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineaRemitoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.LineaRemitoTableAdapter();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidadTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.LocalidadTableAdapter();
            this.pagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.PagoTableAdapter();
            this.gbFactura.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloCategoriaCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaRemitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIngresoFactTipo
            // 
            this.cmbIngresoFactTipo.FormattingEnabled = true;
            this.cmbIngresoFactTipo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbIngresoFactTipo.Location = new System.Drawing.Point(299, 6);
            this.cmbIngresoFactTipo.Name = "cmbIngresoFactTipo";
            this.cmbIngresoFactTipo.Size = new System.Drawing.Size(90, 21);
            this.cmbIngresoFactTipo.TabIndex = 18;
            this.cmbIngresoFactTipo.SelectionChangeCommitted += new System.EventHandler(this.cmbIngresoFactTipo_SelectionChangeCommitted);
            this.cmbIngresoFactTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbIngresoFactTipo_KeyDown);
            this.cmbIngresoFactTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbIngresoFactTipo_KeyPress);
            this.cmbIngresoFactTipo.Leave += new System.EventHandler(this.cmbIngresoFactTipo_Leave);
            // 
            // lblIngresoFactTipo
            // 
            this.lblIngresoFactTipo.AutoSize = true;
            this.lblIngresoFactTipo.Location = new System.Drawing.Point(12, 9);
            this.lblIngresoFactTipo.Name = "lblIngresoFactTipo";
            this.lblIngresoFactTipo.Size = new System.Drawing.Size(151, 13);
            this.lblIngresoFactTipo.TabIndex = 17;
            this.lblIngresoFactTipo.Text = "Seleccione el tipo de Factura :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(395, 497);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(314, 497);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnAceptar.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // gbFactura
            // 
            this.gbFactura.Controls.Add(this.txtFechaR);
            this.gbFactura.Controls.Add(this.txtCondVenta);
            this.gbFactura.Controls.Add(this.txtIVA);
            this.gbFactura.Controls.Add(this.txtCliente);
            this.gbFactura.Controls.Add(this.txtImporteT);
            this.gbFactura.Controls.Add(this.lblFactura);
            this.gbFactura.Controls.Add(this.lblImporteT);
            this.gbFactura.Controls.Add(this.txtFactura);
            this.gbFactura.Controls.Add(this.txtIVAInsc);
            this.gbFactura.Controls.Add(this.lblFacturaN);
            this.gbFactura.Controls.Add(this.lblIVAInsc);
            this.gbFactura.Controls.Add(this.txtFacturaN);
            this.gbFactura.Controls.Add(this.txtNeto);
            this.gbFactura.Controls.Add(this.lblCliente);
            this.gbFactura.Controls.Add(this.lblNeto);
            this.gbFactura.Controls.Add(this.lblFecha);
            this.gbFactura.Controls.Add(this.txtDescuento);
            this.gbFactura.Controls.Add(this.txtFecha);
            this.gbFactura.Controls.Add(this.lblDescuento);
            this.gbFactura.Controls.Add(this.lblLocCliente);
            this.gbFactura.Controls.Add(this.txtSubtotal);
            this.gbFactura.Controls.Add(this.txtLocCliente);
            this.gbFactura.Controls.Add(this.lblSubTotal);
            this.gbFactura.Controls.Add(this.lblDirCliente);
            this.gbFactura.Controls.Add(this.lvFactura);
            this.gbFactura.Controls.Add(this.txtDirCliente);
            this.gbFactura.Controls.Add(this.lblIVA);
            this.gbFactura.Controls.Add(this.lblFechaR);
            this.gbFactura.Controls.Add(this.lblCuitCliente);
            this.gbFactura.Controls.Add(this.txtRemitoN);
            this.gbFactura.Controls.Add(this.lblCondVenta);
            this.gbFactura.Controls.Add(this.lblRemitoN);
            this.gbFactura.Controls.Add(this.txtCuitCliente);
            this.gbFactura.Location = new System.Drawing.Point(12, 59);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(458, 432);
            this.gbFactura.TabIndex = 22;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Detalle de Factura";
            // 
            // txtFechaR
            // 
            this.txtFechaR.Location = new System.Drawing.Point(379, 123);
            this.txtFechaR.Name = "txtFechaR";
            this.txtFechaR.ReadOnly = true;
            this.txtFechaR.Size = new System.Drawing.Size(73, 20);
            this.txtFechaR.TabIndex = 17;
            this.txtFechaR.TabStop = false;
            this.txtFechaR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCondVenta
            // 
            this.txtCondVenta.Location = new System.Drawing.Point(118, 149);
            this.txtCondVenta.Name = "txtCondVenta";
            this.txtCondVenta.ReadOnly = true;
            this.txtCondVenta.Size = new System.Drawing.Size(171, 20);
            this.txtCondVenta.TabIndex = 19;
            this.txtCondVenta.TabStop = false;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(48, 123);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(123, 20);
            this.txtIVA.TabIndex = 13;
            this.txtIVA.TabStop = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(71, 45);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(236, 20);
            this.txtCliente.TabIndex = 5;
            this.txtCliente.TabStop = false;
            // 
            // txtImporteT
            // 
            this.txtImporteT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteT.Location = new System.Drawing.Point(392, 406);
            this.txtImporteT.Name = "txtImporteT";
            this.txtImporteT.ReadOnly = true;
            this.txtImporteT.Size = new System.Drawing.Size(60, 20);
            this.txtImporteT.TabIndex = 32;
            this.txtImporteT.TabStop = false;
            this.txtImporteT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(196, 22);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(49, 13);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "Factura :";
            // 
            // lblImporteT
            // 
            this.lblImporteT.AutoSize = true;
            this.lblImporteT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteT.Location = new System.Drawing.Point(386, 390);
            this.lblImporteT.Name = "lblImporteT";
            this.lblImporteT.Size = new System.Drawing.Size(69, 13);
            this.lblImporteT.TabIndex = 31;
            this.lblImporteT.Text = "Importe Total";
            // 
            // txtFactura
            // 
            this.txtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Location = new System.Drawing.Point(251, 19);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.ReadOnly = true;
            this.txtFactura.Size = new System.Drawing.Size(20, 20);
            this.txtFactura.TabIndex = 1;
            this.txtFactura.TabStop = false;
            this.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIVAInsc
            // 
            this.txtIVAInsc.Location = new System.Drawing.Point(296, 406);
            this.txtIVAInsc.Name = "txtIVAInsc";
            this.txtIVAInsc.ReadOnly = true;
            this.txtIVAInsc.Size = new System.Drawing.Size(60, 20);
            this.txtIVAInsc.TabIndex = 30;
            this.txtIVAInsc.TabStop = false;
            this.txtIVAInsc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFacturaN
            // 
            this.lblFacturaN.AutoSize = true;
            this.lblFacturaN.Location = new System.Drawing.Point(277, 22);
            this.lblFacturaN.Name = "lblFacturaN";
            this.lblFacturaN.Size = new System.Drawing.Size(64, 13);
            this.lblFacturaN.TabIndex = 2;
            this.lblFacturaN.Text = "Factura Nº :";
            // 
            // lblIVAInsc
            // 
            this.lblIVAInsc.AutoSize = true;
            this.lblIVAInsc.Location = new System.Drawing.Point(288, 390);
            this.lblIVAInsc.Name = "lblIVAInsc";
            this.lblIVAInsc.Size = new System.Drawing.Size(79, 13);
            this.lblIVAInsc.TabIndex = 29;
            this.lblIVAInsc.Text = "I.V.A. Inscr. (%)";
            // 
            // txtFacturaN
            // 
            this.txtFacturaN.Location = new System.Drawing.Point(347, 19);
            this.txtFacturaN.Name = "txtFacturaN";
            this.txtFacturaN.ReadOnly = true;
            this.txtFacturaN.Size = new System.Drawing.Size(105, 20);
            this.txtFacturaN.TabIndex = 3;
            this.txtFacturaN.TabStop = false;
            this.txtFacturaN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(199, 406);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.Size = new System.Drawing.Size(60, 20);
            this.txtNeto.TabIndex = 28;
            this.txtNeto.TabStop = false;
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 48);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente :";
            // 
            // lblNeto
            // 
            this.lblNeto.AutoSize = true;
            this.lblNeto.Location = new System.Drawing.Point(196, 390);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(68, 13);
            this.lblNeto.TabIndex = 27;
            this.lblNeto.Text = "Importe Neto";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(313, 48);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha :";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(101, 406);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(60, 20);
            this.txtDescuento.TabIndex = 26;
            this.txtDescuento.TabStop = false;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(362, 45);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(90, 20);
            this.txtFecha.TabIndex = 7;
            this.txtFecha.TabStop = false;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(102, 390);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(59, 13);
            this.lblDescuento.TabIndex = 25;
            this.lblDescuento.Text = "Descuento";
            // 
            // lblLocCliente
            // 
            this.lblLocCliente.AutoSize = true;
            this.lblLocCliente.Location = new System.Drawing.Point(6, 74);
            this.lblLocCliente.Name = "lblLocCliente";
            this.lblLocCliente.Size = new System.Drawing.Size(59, 13);
            this.lblLocCliente.TabIndex = 8;
            this.lblLocCliente.Text = "Localidad :";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(6, 406);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(60, 20);
            this.txtSubtotal.TabIndex = 24;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLocCliente
            // 
            this.txtLocCliente.Location = new System.Drawing.Point(71, 71);
            this.txtLocCliente.Name = "txtLocCliente";
            this.txtLocCliente.ReadOnly = true;
            this.txtLocCliente.Size = new System.Drawing.Size(381, 20);
            this.txtLocCliente.TabIndex = 9;
            this.txtLocCliente.TabStop = false;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(11, 390);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(53, 13);
            this.lblSubTotal.TabIndex = 23;
            this.lblSubTotal.Text = "SubTotal ";
            // 
            // lblDirCliente
            // 
            this.lblDirCliente.AutoSize = true;
            this.lblDirCliente.Location = new System.Drawing.Point(6, 100);
            this.lblDirCliente.Name = "lblDirCliente";
            this.lblDirCliente.Size = new System.Drawing.Size(55, 13);
            this.lblDirCliente.TabIndex = 10;
            this.lblDirCliente.Text = "Domicilio :";
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
            this.lvFactura.Location = new System.Drawing.Point(6, 175);
            this.lvFactura.Name = "lvFactura";
            this.lvFactura.Size = new System.Drawing.Size(446, 212);
            this.lvFactura.TabIndex = 22;
            this.lvFactura.TabStop = false;
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
            this.ColumnDescripcion.Width = 207;
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
            // txtDirCliente
            // 
            this.txtDirCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDirCliente.Location = new System.Drawing.Point(71, 97);
            this.txtDirCliente.Name = "txtDirCliente";
            this.txtDirCliente.ReadOnly = true;
            this.txtDirCliente.Size = new System.Drawing.Size(381, 20);
            this.txtDirCliente.TabIndex = 11;
            this.txtDirCliente.TabStop = false;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(6, 126);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(36, 13);
            this.lblIVA.TabIndex = 12;
            this.lblIVA.Text = "I.V.A.:";
            // 
            // lblFechaR
            // 
            this.lblFechaR.AutoSize = true;
            this.lblFechaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaR.Location = new System.Drawing.Point(312, 126);
            this.lblFechaR.Name = "lblFechaR";
            this.lblFechaR.Size = new System.Drawing.Size(63, 13);
            this.lblFechaR.TabIndex = 16;
            this.lblFechaR.Text = "Fecha Rto :";
            // 
            // lblCuitCliente
            // 
            this.lblCuitCliente.AutoSize = true;
            this.lblCuitCliente.Location = new System.Drawing.Point(177, 126);
            this.lblCuitCliente.Name = "lblCuitCliente";
            this.lblCuitCliente.Size = new System.Drawing.Size(38, 13);
            this.lblCuitCliente.TabIndex = 14;
            this.lblCuitCliente.Text = "CUIT :";
            // 
            // txtRemitoN
            // 
            this.txtRemitoN.Location = new System.Drawing.Point(362, 149);
            this.txtRemitoN.Name = "txtRemitoN";
            this.txtRemitoN.ReadOnly = true;
            this.txtRemitoN.Size = new System.Drawing.Size(90, 20);
            this.txtRemitoN.TabIndex = 21;
            this.txtRemitoN.TabStop = false;
            this.txtRemitoN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCondVenta
            // 
            this.lblCondVenta.AutoSize = true;
            this.lblCondVenta.Location = new System.Drawing.Point(6, 152);
            this.lblCondVenta.Name = "lblCondVenta";
            this.lblCondVenta.Size = new System.Drawing.Size(106, 13);
            this.lblCondVenta.TabIndex = 18;
            this.lblCondVenta.Text = "Condición de Venta :";
            // 
            // lblRemitoN
            // 
            this.lblRemitoN.AutoSize = true;
            this.lblRemitoN.Location = new System.Drawing.Point(295, 152);
            this.lblRemitoN.Name = "lblRemitoN";
            this.lblRemitoN.Size = new System.Drawing.Size(61, 13);
            this.lblRemitoN.TabIndex = 20;
            this.lblRemitoN.Text = "Remito Nº :";
            // 
            // txtCuitCliente
            // 
            this.txtCuitCliente.Location = new System.Drawing.Point(221, 123);
            this.txtCuitCliente.Name = "txtCuitCliente";
            this.txtCuitCliente.ReadOnly = true;
            this.txtCuitCliente.Size = new System.Drawing.Size(85, 20);
            this.txtCuitCliente.TabIndex = 15;
            this.txtCuitCliente.TabStop = false;
            this.txtCuitCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(395, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 47);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnBuscar.MouseHover += new System.EventHandler(this.btnBuscar_MouseHover);
            // 
            // txtIngresoFact
            // 
            this.txtIngresoFact.Location = new System.Drawing.Point(269, 33);
            this.txtIngresoFact.MaxLength = 12;
            this.txtIngresoFact.Name = "txtIngresoFact";
            this.txtIngresoFact.Size = new System.Drawing.Size(120, 20);
            this.txtIngresoFact.TabIndex = 20;
            this.txtIngresoFact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIngresoFact_KeyDown);
            this.txtIngresoFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbIngresoFactTipo_KeyPress);
            this.txtIngresoFact.Leave += new System.EventHandler(this.txtIngresoFact_Leave);
            // 
            // lblIngresoFact
            // 
            this.lblIngresoFact.AutoSize = true;
            this.lblIngresoFact.Location = new System.Drawing.Point(12, 36);
            this.lblIngresoFact.Name = "lblIngresoFact";
            this.lblIngresoFact.Size = new System.Drawing.Size(261, 13);
            this.lblIngresoFact.TabIndex = 19;
            this.lblIngresoFact.Text = "Ingrese el número de la Factura que desea consultar :";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 529);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(482, 22);
            this.StatusStrip1.TabIndex = 16;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabelInfo
            // 
            this.ToolStripStatusLabelInfo.Name = "ToolStripStatusLabelInfo";
            this.ToolStripStatusLabelInfo.Size = new System.Drawing.Size(19, 17);
            this.ToolStripStatusLabelInfo.Text = "    ";
            // 
            // sFDBDataSet
            // 
            this.sFDBDataSet.DataSetName = "SFDBDataSet";
            this.sFDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.sFDBDataSet;
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
            // localidadBindingSource
            // 
            this.localidadBindingSource.DataMember = "Localidad";
            this.localidadBindingSource.DataSource = this.sFDBDataSet;
            // 
            // localidadTableAdapter
            // 
            this.localidadTableAdapter.ClearBeforeFill = true;
            // 
            // pagoBindingSource
            // 
            this.pagoBindingSource.DataMember = "Pago";
            this.pagoBindingSource.DataSource = this.sFDBDataSet;
            // 
            // pagoTableAdapter
            // 
            this.pagoTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 551);
            this.Controls.Add(this.cmbIngresoFactTipo);
            this.Controls.Add(this.lblIngresoFactTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbFactura);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIngresoFact);
            this.Controls.Add(this.lblIngresoFact);
            this.Controls.Add(this.StatusStrip1);
            this.Name = "frmConsultarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Facturas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultarFactura_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultarFactura_Load);
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloCategoriaCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaRemitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cmbIngresoFactTipo;
        internal System.Windows.Forms.Label lblIngresoFactTipo;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.GroupBox gbFactura;
        internal System.Windows.Forms.TextBox txtFechaR;
        internal System.Windows.Forms.TextBox txtCondVenta;
        internal System.Windows.Forms.TextBox txtIVA;
        internal System.Windows.Forms.TextBox txtCliente;
        internal System.Windows.Forms.TextBox txtImporteT;
        internal System.Windows.Forms.Label lblFactura;
        internal System.Windows.Forms.Label lblImporteT;
        internal System.Windows.Forms.TextBox txtFactura;
        internal System.Windows.Forms.TextBox txtIVAInsc;
        internal System.Windows.Forms.Label lblFacturaN;
        internal System.Windows.Forms.Label lblIVAInsc;
        internal System.Windows.Forms.TextBox txtFacturaN;
        internal System.Windows.Forms.TextBox txtNeto;
        internal System.Windows.Forms.Label lblCliente;
        internal System.Windows.Forms.Label lblNeto;
        internal System.Windows.Forms.Label lblFecha;
        internal System.Windows.Forms.TextBox txtDescuento;
        internal System.Windows.Forms.TextBox txtFecha;
        internal System.Windows.Forms.Label lblDescuento;
        internal System.Windows.Forms.Label lblLocCliente;
        internal System.Windows.Forms.TextBox txtSubtotal;
        internal System.Windows.Forms.TextBox txtLocCliente;
        internal System.Windows.Forms.Label lblSubTotal;
        internal System.Windows.Forms.Label lblDirCliente;
        internal System.Windows.Forms.ListView lvFactura;
        internal System.Windows.Forms.ColumnHeader ColumnCodArt;
        internal System.Windows.Forms.ColumnHeader ColumnDescripcion;
        internal System.Windows.Forms.ColumnHeader ColumnPrecio;
        internal System.Windows.Forms.ColumnHeader ColumnCantidad;
        internal System.Windows.Forms.ColumnHeader ColumnImporte;
        internal System.Windows.Forms.TextBox txtDirCliente;
        internal System.Windows.Forms.Label lblIVA;
        internal System.Windows.Forms.Label lblFechaR;
        internal System.Windows.Forms.Label lblCuitCliente;
        internal System.Windows.Forms.TextBox txtRemitoN;
        internal System.Windows.Forms.Label lblCondVenta;
        internal System.Windows.Forms.Label lblRemitoN;
        internal System.Windows.Forms.TextBox txtCuitCliente;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.TextBox txtIngresoFact;
        internal System.Windows.Forms.Label lblIngresoFact;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelInfo;
        private SFDBDataSet sFDBDataSet;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private SFDBDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.BindingSource articuloCategoriaCBindingSource;
        private SFDBDataSetTableAdapters.ArticuloCategoriaCTableAdapter articuloCategoriaCTableAdapter;
        private SFDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource remitoBindingSource;
        private SFDBDataSetTableAdapters.RemitoTableAdapter remitoTableAdapter;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private SFDBDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.BindingSource lineaRemitoBindingSource;
        private SFDBDataSetTableAdapters.LineaRemitoTableAdapter lineaRemitoTableAdapter;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private SFDBDataSetTableAdapters.LocalidadTableAdapter localidadTableAdapter;
        private System.Windows.Forms.BindingSource pagoBindingSource;
        private SFDBDataSetTableAdapters.PagoTableAdapter pagoTableAdapter;
    }
}