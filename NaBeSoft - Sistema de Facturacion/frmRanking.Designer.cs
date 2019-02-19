namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmRanking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRanking));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripConfigurarP = new System.Windows.Forms.ToolStripButton();
            this.ToolStripImprimir = new System.Windows.Forms.ToolStripButton();
            this.ToolStripVistaPreliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dtpFecHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFecHasta = new System.Windows.Forms.Label();
            this.dtpFecDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFecDesde = new System.Windows.Forms.Label();
            this.lvRank = new System.Windows.Forms.ListView();
            this.columnArticulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.sFDBDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloTableAdapter();
            this.lineaRemitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineaRemitoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.LineaRemitoTableAdapter();
            this.remitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remitoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.RemitoTableAdapter();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ToolStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaRemitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.ToolStrip1.Size = new System.Drawing.Size(478, 25);
            this.ToolStrip1.TabIndex = 18;
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
            // dtpFecHasta
            // 
            this.dtpFecHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecHasta.Location = new System.Drawing.Point(279, 4);
            this.dtpFecHasta.Name = "dtpFecHasta";
            this.dtpFecHasta.Size = new System.Drawing.Size(97, 20);
            this.dtpFecHasta.TabIndex = 22;
            // 
            // lblFecHasta
            // 
            this.lblFecHasta.AutoSize = true;
            this.lblFecHasta.Location = new System.Drawing.Point(238, 6);
            this.lblFecHasta.Name = "lblFecHasta";
            this.lblFecHasta.Size = new System.Drawing.Size(41, 13);
            this.lblFecHasta.TabIndex = 21;
            this.lblFecHasta.Text = "Hasta: ";
            // 
            // dtpFecDesde
            // 
            this.dtpFecDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecDesde.Location = new System.Drawing.Point(131, 4);
            this.dtpFecDesde.Name = "dtpFecDesde";
            this.dtpFecDesde.Size = new System.Drawing.Size(99, 20);
            this.dtpFecDesde.TabIndex = 20;
            // 
            // lblFecDesde
            // 
            this.lblFecDesde.AutoSize = true;
            this.lblFecDesde.Location = new System.Drawing.Point(87, 6);
            this.lblFecDesde.Name = "lblFecDesde";
            this.lblFecDesde.Size = new System.Drawing.Size(44, 13);
            this.lblFecDesde.TabIndex = 19;
            this.lblFecDesde.Text = "Desde: ";
            // 
            // lvRank
            // 
            this.lvRank.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvRank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnArticulo,
            this.columnDescripcion,
            this.columnCantidad});
            this.lvRank.FullRowSelect = true;
            this.lvRank.GridLines = true;
            this.lvRank.Location = new System.Drawing.Point(12, 30);
            this.lvRank.MultiSelect = false;
            this.lvRank.Name = "lvRank";
            this.lvRank.Size = new System.Drawing.Size(454, 275);
            this.lvRank.TabIndex = 23;
            this.lvRank.UseCompatibleStateImageBehavior = false;
            this.lvRank.View = System.Windows.Forms.View.Details;
            // 
            // columnArticulo
            // 
            this.columnArticulo.Text = "Articulo";
            this.columnArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnArticulo.Width = 71;
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.Text = "Descripcion";
            this.columnDescripcion.Width = 271;
            // 
            // columnCantidad
            // 
            this.columnCantidad.Text = "Cantidad Vendida";
            this.columnCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCantidad.Width = 104;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(401, 311);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 25);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 339);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(478, 22);
            this.StatusStrip1.TabIndex = 25;
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
            // lineaRemitoBindingSource
            // 
            this.lineaRemitoBindingSource.DataMember = "LineaRemito";
            this.lineaRemitoBindingSource.DataSource = this.sFDBDataSet;
            // 
            // lineaRemitoTableAdapter
            // 
            this.lineaRemitoTableAdapter.ClearBeforeFill = true;
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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(382, 1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmRanking
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(478, 361);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.lvRank);
            this.Controls.Add(this.dtpFecHasta);
            this.Controls.Add(this.lblFecHasta);
            this.Controls.Add(this.dtpFecDesde);
            this.Controls.Add(this.lblFecDesde);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "frmRanking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking de Articulos";
            this.Load += new System.EventHandler(this.frmRanking_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaRemitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripConfigurarP;
        internal System.Windows.Forms.ToolStripButton ToolStripImprimir;
        internal System.Windows.Forms.ToolStripButton ToolStripVistaPreliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DateTimePicker dtpFecHasta;
        private System.Windows.Forms.Label lblFecHasta;
        private System.Windows.Forms.DateTimePicker dtpFecDesde;
        private System.Windows.Forms.Label lblFecDesde;
        internal System.Windows.Forms.ListView lvRank;
        private System.Windows.Forms.ColumnHeader columnArticulo;
        private System.Windows.Forms.ColumnHeader columnDescripcion;
        private System.Windows.Forms.ColumnHeader columnCantidad;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelInfo;
        private SFDBDataSet sFDBDataSet;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private SFDBDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.BindingSource lineaRemitoBindingSource;
        private SFDBDataSetTableAdapters.LineaRemitoTableAdapter lineaRemitoTableAdapter;
        private System.Windows.Forms.BindingSource remitoBindingSource;
        private SFDBDataSetTableAdapters.RemitoTableAdapter remitoTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
    }
}