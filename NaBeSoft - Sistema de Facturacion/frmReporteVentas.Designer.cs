namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVentas));
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvVentas = new System.Windows.Forms.ListView();
            this.ColumnCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnRemito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnArticulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblImporteT = new System.Windows.Forms.Label();
            this.txtImporteT = new System.Windows.Forms.TextBox();
            this.sFDBDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloTableAdapter();
            this.chbProd = new System.Windows.Forms.CheckBox();
            this.cmArticulos = new System.Windows.Forms.ComboBox();
            this.remitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remitoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.RemitoTableAdapter();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ClienteTableAdapter();
            this.lineaRemitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineaRemitoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.LineaRemitoTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ToolStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaRemitoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(631, 1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFecHasta
            // 
            this.dtpFecHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecHasta.Location = new System.Drawing.Point(288, 4);
            this.dtpFecHasta.Name = "dtpFecHasta";
            this.dtpFecHasta.Size = new System.Drawing.Size(97, 20);
            this.dtpFecHasta.TabIndex = 13;
            // 
            // lblFecHasta
            // 
            this.lblFecHasta.AutoSize = true;
            this.lblFecHasta.Location = new System.Drawing.Point(241, 6);
            this.lblFecHasta.Name = "lblFecHasta";
            this.lblFecHasta.Size = new System.Drawing.Size(41, 13);
            this.lblFecHasta.TabIndex = 12;
            this.lblFecHasta.Text = "Hasta: ";
            // 
            // dtpFecDesde
            // 
            this.dtpFecDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecDesde.Location = new System.Drawing.Point(136, 4);
            this.dtpFecDesde.Name = "dtpFecDesde";
            this.dtpFecDesde.Size = new System.Drawing.Size(99, 20);
            this.dtpFecDesde.TabIndex = 11;
            // 
            // lblFecDesde
            // 
            this.lblFecDesde.AutoSize = true;
            this.lblFecDesde.Location = new System.Drawing.Point(86, 6);
            this.lblFecDesde.Name = "lblFecDesde";
            this.lblFecDesde.Size = new System.Drawing.Size(44, 13);
            this.lblFecDesde.TabIndex = 10;
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
            this.ToolStrip1.Size = new System.Drawing.Size(910, 25);
            this.ToolStrip1.TabIndex = 17;
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
            this.ToolStripConfigurarP.Click += new System.EventHandler(this.ToolStripConfigurarP_Click);
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
            this.ToolStripImprimir.Click += new System.EventHandler(this.ToolStripImprimir_Click);
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
            this.ToolStripVistaPreliminar.Click += new System.EventHandler(this.ToolStripVistaPreliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(833, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 25);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lvVentas
            // 
            this.lvVentas.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvVentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnCliente,
            this.ColumnRemito,
            this.ColumnFecha,
            this.columnArticulo,
            this.columnCantidad,
            this.columnImporte});
            this.lvVentas.FullRowSelect = true;
            this.lvVentas.GridLines = true;
            this.lvVentas.Location = new System.Drawing.Point(12, 36);
            this.lvVentas.MultiSelect = false;
            this.lvVentas.Name = "lvVentas";
            this.lvVentas.Size = new System.Drawing.Size(886, 356);
            this.lvVentas.TabIndex = 15;
            this.lvVentas.UseCompatibleStateImageBehavior = false;
            this.lvVentas.View = System.Windows.Forms.View.Details;
            this.lvVentas.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvVentas_ColumnClick);
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.Text = "Cliente";
            this.ColumnCliente.Width = 292;
            // 
            // ColumnRemito
            // 
            this.ColumnRemito.Text = "Remito Nº";
            this.ColumnRemito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnRemito.Width = 68;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.Text = "Fecha";
            this.ColumnFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnFecha.Width = 58;
            // 
            // columnArticulo
            // 
            this.columnArticulo.Text = "Articulo";
            this.columnArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnArticulo.Width = 302;
            // 
            // columnCantidad
            // 
            this.columnCantidad.Text = "Cantidad";
            this.columnCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCantidad.Width = 91;
            // 
            // columnImporte
            // 
            this.columnImporte.Text = "Importe";
            this.columnImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnImporte.Width = 69;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 429);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(910, 22);
            this.StatusStrip1.TabIndex = 18;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabelInfo
            // 
            this.ToolStripStatusLabelInfo.Name = "ToolStripStatusLabelInfo";
            this.ToolStripStatusLabelInfo.Size = new System.Drawing.Size(19, 17);
            this.ToolStripStatusLabelInfo.Text = "    ";
            // 
            // lblImporteT
            // 
            this.lblImporteT.AutoSize = true;
            this.lblImporteT.Location = new System.Drawing.Point(585, 404);
            this.lblImporteT.Name = "lblImporteT";
            this.lblImporteT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblImporteT.Size = new System.Drawing.Size(75, 13);
            this.lblImporteT.TabIndex = 19;
            this.lblImporteT.Text = "Importe Total: ";
            // 
            // txtImporteT
            // 
            this.txtImporteT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteT.Location = new System.Drawing.Point(666, 401);
            this.txtImporteT.Name = "txtImporteT";
            this.txtImporteT.ReadOnly = true;
            this.txtImporteT.Size = new System.Drawing.Size(100, 20);
            this.txtImporteT.TabIndex = 20;
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
            // chbProd
            // 
            this.chbProd.AutoSize = true;
            this.chbProd.Location = new System.Drawing.Point(391, 6);
            this.chbProd.Name = "chbProd";
            this.chbProd.Size = new System.Drawing.Size(15, 14);
            this.chbProd.TabIndex = 21;
            this.chbProd.UseVisualStyleBackColor = true;
            this.chbProd.CheckedChanged += new System.EventHandler(this.chbProd_CheckedChanged);
            // 
            // cmArticulos
            // 
            this.cmArticulos.DataSource = this.articuloBindingSource;
            this.cmArticulos.DisplayMember = "Descripcion";
            this.cmArticulos.FormattingEnabled = true;
            this.cmArticulos.Location = new System.Drawing.Point(412, 3);
            this.cmArticulos.Name = "cmArticulos";
            this.cmArticulos.Size = new System.Drawing.Size(213, 21);
            this.cmArticulos.TabIndex = 22;
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
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.sFDBDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.printDocument1.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.printDocument1_QueryPageSettings);
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 451);
            this.Controls.Add(this.cmArticulos);
            this.Controls.Add(this.chbProd);
            this.Controls.Add(this.txtImporteT);
            this.Controls.Add(this.lblImporteT);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFecHasta);
            this.Controls.Add(this.lblFecHasta);
            this.Controls.Add(this.dtpFecDesde);
            this.Controls.Add(this.lblFecDesde);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvVentas);
            this.Controls.Add(this.StatusStrip1);
            this.Name = "frmReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Ventas de Articulos";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaRemitoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.ListView lvVentas;
        internal System.Windows.Forms.ColumnHeader ColumnCliente;
        internal System.Windows.Forms.ColumnHeader ColumnRemito;
        internal System.Windows.Forms.ColumnHeader ColumnFecha;
        private System.Windows.Forms.ColumnHeader columnArticulo;
        private System.Windows.Forms.ColumnHeader columnCantidad;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelInfo;
        private System.Windows.Forms.ColumnHeader columnImporte;
        private System.Windows.Forms.Label lblImporteT;
        private System.Windows.Forms.TextBox txtImporteT;
        private SFDBDataSet sFDBDataSet;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private SFDBDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.CheckBox chbProd;
        private System.Windows.Forms.ComboBox cmArticulos;
        private System.Windows.Forms.BindingSource remitoBindingSource;
        private SFDBDataSetTableAdapters.RemitoTableAdapter remitoTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SFDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource lineaRemitoBindingSource;
        private SFDBDataSetTableAdapters.LineaRemitoTableAdapter lineaRemitoTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}