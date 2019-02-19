namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmListarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarFactura));
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.chbCliente = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFecHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFecHasta = new System.Windows.Forms.Label();
            this.dtpFecDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFecDesde = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripConfigurarP = new System.Windows.Forms.ToolStripButton();
            this.ToolStripImprimir = new System.Windows.Forms.ToolStripButton();
            this.ToolStripVistaPreliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.lvFacturas = new System.Windows.Forms.ListView();
            this.ColumnDebe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHaber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnCVenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFecVto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sFDBDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.remitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remitoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.RemitoTableAdapter();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.FacturaTableAdapter();
            this.pagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.PagoTableAdapter();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ClienteTableAdapter();
            this.ToolStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataSource = this.clienteBindingSource;
            this.cmbCliente.DisplayMember = "RazonSocial";
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(410, 2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(219, 21);
            this.cmbCliente.TabIndex = 30;
            // 
            // chbCliente
            // 
            this.chbCliente.AutoSize = true;
            this.chbCliente.Location = new System.Drawing.Point(389, 5);
            this.chbCliente.Name = "chbCliente";
            this.chbCliente.Size = new System.Drawing.Size(15, 14);
            this.chbCliente.TabIndex = 29;
            this.chbCliente.UseVisualStyleBackColor = true;
            this.chbCliente.CheckedChanged += new System.EventHandler(this.chbCliente_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(759, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFecHasta
            // 
            this.dtpFecHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecHasta.Location = new System.Drawing.Point(286, 3);
            this.dtpFecHasta.Name = "dtpFecHasta";
            this.dtpFecHasta.Size = new System.Drawing.Size(97, 20);
            this.dtpFecHasta.TabIndex = 26;
            // 
            // lblFecHasta
            // 
            this.lblFecHasta.AutoSize = true;
            this.lblFecHasta.Location = new System.Drawing.Point(239, 5);
            this.lblFecHasta.Name = "lblFecHasta";
            this.lblFecHasta.Size = new System.Drawing.Size(41, 13);
            this.lblFecHasta.TabIndex = 25;
            this.lblFecHasta.Text = "Hasta: ";
            // 
            // dtpFecDesde
            // 
            this.dtpFecDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecDesde.Location = new System.Drawing.Point(134, 3);
            this.dtpFecDesde.Name = "dtpFecDesde";
            this.dtpFecDesde.Size = new System.Drawing.Size(99, 20);
            this.dtpFecDesde.TabIndex = 24;
            // 
            // lblFecDesde
            // 
            this.lblFecDesde.AutoSize = true;
            this.lblFecDesde.Location = new System.Drawing.Point(84, 5);
            this.lblFecDesde.Name = "lblFecDesde";
            this.lblFecDesde.Size = new System.Drawing.Size(44, 13);
            this.lblFecDesde.TabIndex = 23;
            this.lblFecDesde.Text = "Desde: ";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripConfigurarP,
            this.ToolStripImprimir,
            this.ToolStripVistaPreliminar,
            this.toolStripSeparator2});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(846, 25);
            this.ToolStrip1.TabIndex = 28;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripConfigurarP
            // 
            this.ToolStripConfigurarP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripConfigurarP.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripConfigurarP.Image")));
            this.ToolStripConfigurarP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripConfigurarP.Name = "ToolStripConfigurarP";
            this.ToolStripConfigurarP.Size = new System.Drawing.Size(23, 22);
            this.ToolStripConfigurarP.Text = "ToolStripConfigurarP";
            this.ToolStripConfigurarP.ToolTipText = "Configurar página";
            // 
            // ToolStripImprimir
            // 
            this.ToolStripImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripImprimir.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripImprimir.Image")));
            this.ToolStripImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripImprimir.Name = "ToolStripImprimir";
            this.ToolStripImprimir.Size = new System.Drawing.Size(23, 22);
            this.ToolStripImprimir.Text = "ToolStripImprimir";
            this.ToolStripImprimir.ToolTipText = "Imprimir";
            // 
            // ToolStripVistaPreliminar
            // 
            this.ToolStripVistaPreliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripVistaPreliminar.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripVistaPreliminar.Image")));
            this.ToolStripVistaPreliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripVistaPreliminar.Name = "ToolStripVistaPreliminar";
            this.ToolStripVistaPreliminar.Size = new System.Drawing.Size(23, 22);
            this.ToolStripVistaPreliminar.Text = "ToolStripVistaPreliminar";
            this.ToolStripVistaPreliminar.ToolTipText = "Vista preliminar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DisplayMember = "Descripcion";
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Anulado",
            "Con Saldo",
            "Debe",
            "Pagado"});
            this.cmbEstado.Location = new System.Drawing.Point(656, 2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(97, 21);
            this.cmbEstado.TabIndex = 32;
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Location = new System.Drawing.Point(635, 5);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(15, 14);
            this.chbEstado.TabIndex = 31;
            this.chbEstado.UseVisualStyleBackColor = true;
            this.chbEstado.CheckedChanged += new System.EventHandler(this.chbEstado_CheckedChanged);
            // 
            // lvFacturas
            // 
            this.lvFacturas.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnFactura,
            this.ColumnFecha,
            this.columnEstado,
            this.ColumnDebe,
            this.columnHaber,
            this.columnSaldo,
            this.columnCVenta,
            this.columnFecVto,
            this.columnCliente});
            this.lvFacturas.FullRowSelect = true;
            this.lvFacturas.GridLines = true;
            this.lvFacturas.Location = new System.Drawing.Point(12, 29);
            this.lvFacturas.MultiSelect = false;
            this.lvFacturas.Name = "lvFacturas";
            this.lvFacturas.Size = new System.Drawing.Size(822, 385);
            this.lvFacturas.TabIndex = 33;
            this.lvFacturas.UseCompatibleStateImageBehavior = false;
            this.lvFacturas.View = System.Windows.Forms.View.Details;
            // 
            // ColumnDebe
            // 
            this.ColumnDebe.Text = "Debe";
            this.ColumnDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnFactura
            // 
            this.ColumnFactura.Text = "Factura Nº";
            this.ColumnFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnFactura.Width = 94;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.Text = "Fecha";
            this.ColumnFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnFecha.Width = 70;
            // 
            // columnEstado
            // 
            this.columnEstado.Text = "Estado";
            this.columnEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnEstado.Width = 75;
            // 
            // columnHaber
            // 
            this.columnHaber.Text = "Haber";
            this.columnHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnSaldo
            // 
            this.columnSaldo.Text = "Saldo";
            this.columnSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(769, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 25);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 448);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(846, 22);
            this.StatusStrip1.TabIndex = 35;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabelInfo
            // 
            this.ToolStripStatusLabelInfo.Name = "ToolStripStatusLabelInfo";
            this.ToolStripStatusLabelInfo.Size = new System.Drawing.Size(19, 17);
            this.ToolStripStatusLabelInfo.Text = "    ";
            // 
            // columnCVenta
            // 
            this.columnCVenta.Text = "Cond. Venta";
            this.columnCVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCVenta.Width = 93;
            // 
            // columnFecVto
            // 
            this.columnFecVto.Text = "Vence";
            this.columnFecVto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFecVto.Width = 70;
            // 
            // columnCliente
            // 
            this.columnCliente.Text = "Cliente";
            this.columnCliente.Width = 186;
            // 
            // sFDBDataSet
            // 
            this.sFDBDataSet.DataSetName = "SFDBDataSet";
            this.sFDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // pagoBindingSource
            // 
            this.pagoBindingSource.DataMember = "Pago";
            this.pagoBindingSource.DataSource = this.sFDBDataSet;
            // 
            // pagoTableAdapter
            // 
            this.pagoTableAdapter.ClearBeforeFill = true;
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
            // frmListarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 470);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.lvFacturas);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.chbEstado);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.chbCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFecHasta);
            this.Controls.Add(this.lblFecHasta);
            this.Controls.Add(this.dtpFecDesde);
            this.Controls.Add(this.lblFecDesde);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "frmListarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Estados de Facturas";
            this.Load += new System.EventHandler(this.frmListarFactura_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.CheckBox chbCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFecHasta;
        private System.Windows.Forms.Label lblFecHasta;
        private System.Windows.Forms.DateTimePicker dtpFecDesde;
        private System.Windows.Forms.Label lblFecDesde;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripConfigurarP;
        internal System.Windows.Forms.ToolStripButton ToolStripImprimir;
        internal System.Windows.Forms.ToolStripButton ToolStripVistaPreliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.CheckBox chbEstado;
        internal System.Windows.Forms.ListView lvFacturas;
        internal System.Windows.Forms.ColumnHeader ColumnDebe;
        internal System.Windows.Forms.ColumnHeader ColumnFactura;
        internal System.Windows.Forms.ColumnHeader ColumnFecha;
        private System.Windows.Forms.ColumnHeader columnEstado;
        private System.Windows.Forms.ColumnHeader columnHaber;
        private System.Windows.Forms.ColumnHeader columnSaldo;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelInfo;
        private System.Windows.Forms.ColumnHeader columnCVenta;
        private System.Windows.Forms.ColumnHeader columnFecVto;
        private System.Windows.Forms.ColumnHeader columnCliente;
        private SFDBDataSet sFDBDataSet;
        private System.Windows.Forms.BindingSource remitoBindingSource;
        private SFDBDataSetTableAdapters.RemitoTableAdapter remitoTableAdapter;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private SFDBDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.BindingSource pagoBindingSource;
        private SFDBDataSetTableAdapters.PagoTableAdapter pagoTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SFDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}