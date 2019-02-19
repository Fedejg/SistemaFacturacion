namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmConsultaRemito
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
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbDetalleRemito = new System.Windows.Forms.GroupBox();
            this.lvDetalleRemito = new System.Windows.Forms.ListView();
            this.ColumnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnImporteP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtImporteT = new System.Windows.Forms.TextBox();
            this.lblImporteT = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.txtApNom = new System.Windows.Forms.TextBox();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.txtCodC = new System.Windows.Forms.TextBox();
            this.lblRSocial = new System.Windows.Forms.Label();
            this.lblApNom = new System.Windows.Forms.Label();
            this.lblCodC = new System.Windows.Forms.Label();
            this.grbRemito = new System.Windows.Forms.GroupBox();
            this.lvRemito = new System.Windows.Forms.ListView();
            this.ColumnRemitoN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnFechaR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDescuento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnImporteT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sFBDDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ClienteTableAdapter();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloTableAdapter();
            this.articuloCategoriaCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloCategoriaCTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloCategoriaCTableAdapter();
            this.lineaRemitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineaRemitoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.LineaRemitoTableAdapter();
            this.remitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remitoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.RemitoTableAdapter();
            this.grbDetalleRemito.SuspendLayout();
            this.grbCliente.SuspendLayout();
            this.grbRemito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloCategoriaCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaRemitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Location = new System.Drawing.Point(0, 447);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(890, 22);
            this.StatusStrip1.TabIndex = 9;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(803, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grbDetalleRemito
            // 
            this.grbDetalleRemito.Controls.Add(this.lvDetalleRemito);
            this.grbDetalleRemito.Controls.Add(this.lblDescuento);
            this.grbDetalleRemito.Controls.Add(this.txtImporteT);
            this.grbDetalleRemito.Controls.Add(this.lblImporteT);
            this.grbDetalleRemito.Controls.Add(this.txtDescuento);
            this.grbDetalleRemito.Location = new System.Drawing.Point(437, 6);
            this.grbDetalleRemito.Name = "grbDetalleRemito";
            this.grbDetalleRemito.Size = new System.Drawing.Size(441, 396);
            this.grbDetalleRemito.TabIndex = 7;
            this.grbDetalleRemito.TabStop = false;
            this.grbDetalleRemito.Text = "Detalle de Remito";
            // 
            // lvDetalleRemito
            // 
            this.lvDetalleRemito.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvDetalleRemito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnCodigo,
            this.ColumnDescripcion,
            this.ColumnPrecio,
            this.ColumnCantidad,
            this.ColumnImporteP});
            this.lvDetalleRemito.FullRowSelect = true;
            this.lvDetalleRemito.GridLines = true;
            this.lvDetalleRemito.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDetalleRemito.Location = new System.Drawing.Point(6, 16);
            this.lvDetalleRemito.MultiSelect = false;
            this.lvDetalleRemito.Name = "lvDetalleRemito";
            this.lvDetalleRemito.Size = new System.Drawing.Size(429, 348);
            this.lvDetalleRemito.TabIndex = 0;
            this.lvDetalleRemito.UseCompatibleStateImageBehavior = false;
            this.lvDetalleRemito.View = System.Windows.Forms.View.Details;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.Text = "Código";
            this.ColumnCodigo.Width = 50;
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.Text = "Descripción";
            this.ColumnDescripcion.Width = 180;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.Text = "Precio";
            this.ColumnPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnPrecio.Width = 65;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.Text = "Cantidad";
            this.ColumnCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnCantidad.Width = 65;
            // 
            // ColumnImporteP
            // 
            this.ColumnImporteP.Text = "Importe P.";
            this.ColumnImporteP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnImporteP.Width = 65;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(6, 373);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(65, 13);
            this.lblDescuento.TabIndex = 1;
            this.lblDescuento.Text = "Descuento :";
            // 
            // txtImporteT
            // 
            this.txtImporteT.Location = new System.Drawing.Point(224, 370);
            this.txtImporteT.Name = "txtImporteT";
            this.txtImporteT.ReadOnly = true;
            this.txtImporteT.Size = new System.Drawing.Size(60, 20);
            this.txtImporteT.TabIndex = 4;
            this.txtImporteT.TabStop = false;
            this.txtImporteT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblImporteT
            // 
            this.lblImporteT.AutoSize = true;
            this.lblImporteT.Location = new System.Drawing.Point(143, 373);
            this.lblImporteT.Name = "lblImporteT";
            this.lblImporteT.Size = new System.Drawing.Size(75, 13);
            this.lblImporteT.TabIndex = 3;
            this.lblImporteT.Text = "Importe Total :";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(77, 370);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(60, 20);
            this.txtDescuento.TabIndex = 2;
            this.txtDescuento.TabStop = false;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.txtApNom);
            this.grbCliente.Controls.Add(this.txtRSocial);
            this.grbCliente.Controls.Add(this.txtCodC);
            this.grbCliente.Controls.Add(this.lblRSocial);
            this.grbCliente.Controls.Add(this.lblApNom);
            this.grbCliente.Controls.Add(this.lblCodC);
            this.grbCliente.Location = new System.Drawing.Point(12, 343);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(416, 95);
            this.grbCliente.TabIndex = 6;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Información del Cliente";
            // 
            // txtApNom
            // 
            this.txtApNom.Location = new System.Drawing.Point(110, 43);
            this.txtApNom.Name = "txtApNom";
            this.txtApNom.ReadOnly = true;
            this.txtApNom.Size = new System.Drawing.Size(300, 20);
            this.txtApNom.TabIndex = 3;
            this.txtApNom.TabStop = false;
            // 
            // txtRSocial
            // 
            this.txtRSocial.Location = new System.Drawing.Point(110, 69);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.ReadOnly = true;
            this.txtRSocial.Size = new System.Drawing.Size(300, 20);
            this.txtRSocial.TabIndex = 5;
            this.txtRSocial.TabStop = false;
            // 
            // txtCodC
            // 
            this.txtCodC.Location = new System.Drawing.Point(110, 17);
            this.txtCodC.Name = "txtCodC";
            this.txtCodC.ReadOnly = true;
            this.txtCodC.Size = new System.Drawing.Size(80, 20);
            this.txtCodC.TabIndex = 1;
            this.txtCodC.TabStop = false;
            // 
            // lblRSocial
            // 
            this.lblRSocial.AutoSize = true;
            this.lblRSocial.Location = new System.Drawing.Point(6, 72);
            this.lblRSocial.Name = "lblRSocial";
            this.lblRSocial.Size = new System.Drawing.Size(76, 13);
            this.lblRSocial.TabIndex = 4;
            this.lblRSocial.Text = "Razón Social :";
            // 
            // lblApNom
            // 
            this.lblApNom.AutoSize = true;
            this.lblApNom.Location = new System.Drawing.Point(6, 46);
            this.lblApNom.Name = "lblApNom";
            this.lblApNom.Size = new System.Drawing.Size(98, 13);
            this.lblApNom.TabIndex = 2;
            this.lblApNom.Text = "Apellido y Nombre :";
            // 
            // lblCodC
            // 
            this.lblCodC.AutoSize = true;
            this.lblCodC.Location = new System.Drawing.Point(6, 20);
            this.lblCodC.Name = "lblCodC";
            this.lblCodC.Size = new System.Drawing.Size(46, 13);
            this.lblCodC.TabIndex = 0;
            this.lblCodC.Text = "Código :";
            // 
            // grbRemito
            // 
            this.grbRemito.Controls.Add(this.lvRemito);
            this.grbRemito.Location = new System.Drawing.Point(12, 6);
            this.grbRemito.Name = "grbRemito";
            this.grbRemito.Size = new System.Drawing.Size(419, 331);
            this.grbRemito.TabIndex = 5;
            this.grbRemito.TabStop = false;
            this.grbRemito.Text = "Remito";
            // 
            // lvRemito
            // 
            this.lvRemito.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvRemito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnRemitoN,
            this.ColumnFechaR,
            this.ColumnDescuento,
            this.ColumnImporteT});
            this.lvRemito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRemito.FullRowSelect = true;
            this.lvRemito.GridLines = true;
            this.lvRemito.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRemito.Location = new System.Drawing.Point(3, 16);
            this.lvRemito.MultiSelect = false;
            this.lvRemito.Name = "lvRemito";
            this.lvRemito.Size = new System.Drawing.Size(413, 312);
            this.lvRemito.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvRemito.TabIndex = 0;
            this.lvRemito.UseCompatibleStateImageBehavior = false;
            this.lvRemito.View = System.Windows.Forms.View.Details;
            this.lvRemito.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvRemito_ItemSelectionChanged);
            this.lvRemito.DoubleClick += new System.EventHandler(this.lvRemito_DoubleClick);
            // 
            // ColumnRemitoN
            // 
            this.ColumnRemitoN.Text = "Remito Número";
            this.ColumnRemitoN.Width = 150;
            // 
            // ColumnFechaR
            // 
            this.ColumnFechaR.Text = "Fecha";
            this.ColumnFechaR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnFechaR.Width = 74;
            // 
            // ColumnDescuento
            // 
            this.ColumnDescuento.Text = "Descuento";
            this.ColumnDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnDescuento.Width = 67;
            // 
            // ColumnImporteT
            // 
            this.ColumnImporteT.Text = "Importe";
            this.ColumnImporteT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnImporteT.Width = 58;
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
            // lineaRemitoBindingSource
            // 
            this.lineaRemitoBindingSource.DataMember = "LineaRemito";
            this.lineaRemitoBindingSource.DataSource = this.sFBDDataSet;
            // 
            // lineaRemitoTableAdapter
            // 
            this.lineaRemitoTableAdapter.ClearBeforeFill = true;
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
            // frmConsultaRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 469);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbDetalleRemito);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.grbRemito);
            this.Name = "frmConsultaRemito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Remitos";
            this.Load += new System.EventHandler(this.frmConsultaRemito_Load);
            this.grbDetalleRemito.ResumeLayout(false);
            this.grbDetalleRemito.PerformLayout();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.grbRemito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sFBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloCategoriaCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaRemitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.GroupBox grbDetalleRemito;
        internal System.Windows.Forms.ListView lvDetalleRemito;
        internal System.Windows.Forms.ColumnHeader ColumnCodigo;
        internal System.Windows.Forms.ColumnHeader ColumnDescripcion;
        internal System.Windows.Forms.ColumnHeader ColumnPrecio;
        internal System.Windows.Forms.ColumnHeader ColumnCantidad;
        internal System.Windows.Forms.ColumnHeader ColumnImporteP;
        internal System.Windows.Forms.Label lblDescuento;
        internal System.Windows.Forms.TextBox txtImporteT;
        internal System.Windows.Forms.Label lblImporteT;
        internal System.Windows.Forms.TextBox txtDescuento;
        internal System.Windows.Forms.GroupBox grbCliente;
        internal System.Windows.Forms.TextBox txtApNom;
        internal System.Windows.Forms.TextBox txtRSocial;
        internal System.Windows.Forms.TextBox txtCodC;
        internal System.Windows.Forms.Label lblRSocial;
        internal System.Windows.Forms.Label lblApNom;
        internal System.Windows.Forms.Label lblCodC;
        internal System.Windows.Forms.GroupBox grbRemito;
        internal System.Windows.Forms.ListView lvRemito;
        internal System.Windows.Forms.ColumnHeader ColumnRemitoN;
        internal System.Windows.Forms.ColumnHeader ColumnFechaR;
        internal System.Windows.Forms.ColumnHeader ColumnDescuento;
        internal System.Windows.Forms.ColumnHeader ColumnImporteT;
        private SFDBDataSet sFBDDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SFDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private SFDBDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.BindingSource articuloCategoriaCBindingSource;
        private SFDBDataSetTableAdapters.ArticuloCategoriaCTableAdapter articuloCategoriaCTableAdapter;
        private System.Windows.Forms.BindingSource lineaRemitoBindingSource;
        private SFDBDataSetTableAdapters.LineaRemitoTableAdapter lineaRemitoTableAdapter;
        private System.Windows.Forms.BindingSource remitoBindingSource;
        private SFDBDataSetTableAdapters.RemitoTableAdapter remitoTableAdapter;
    }
}