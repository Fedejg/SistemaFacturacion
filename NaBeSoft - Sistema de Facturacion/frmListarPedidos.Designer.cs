namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmListarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarPedidos));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripConfigurarP = new System.Windows.Forms.ToolStripButton();
            this.ToolStripImprimir = new System.Windows.Forms.ToolStripButton();
            this.ToolStripVistaPreliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvPedidos = new System.Windows.Forms.ListView();
            this.ColumnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnFechaP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCodCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRSocial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCatCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ListadoToolStripMenuListado = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigurarPáginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VistaPreliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFecDesde = new System.Windows.Forms.Label();
            this.dtpFecDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFecHasta = new System.Windows.Forms.Label();
            this.dtpFecHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.sFDBDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.PedidoTableAdapter();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ClienteTableAdapter();
            this.categoriaCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaCTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.CategoriaCTableAdapter();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.ToolStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripConfigurarP,
            this.ToolStripImprimir,
            this.ToolStripVistaPreliminar,
            this.toolStripSeparator2});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(720, 25);
            this.ToolStrip1.TabIndex = 8;
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
            this.ToolStripConfigurarP.MouseHover += new System.EventHandler(this.ConfigurarPáginaToolStripMenuItem_MouseHover);
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
            this.ToolStripImprimir.MouseHover += new System.EventHandler(this.ImprimirToolStripMenuItem_MouseHover);
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
            this.ToolStripVistaPreliminar.Click += new System.EventHandler(this.VistaPreliminarToolStripMenuItem_Click);
            this.ToolStripVistaPreliminar.MouseHover += new System.EventHandler(this.VistaPreliminarToolStripMenuItem_MouseHover);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(643, 414);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 25);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseHover += new System.EventHandler(this.btnSalir_MouseHover);
            // 
            // lvPedidos
            // 
            this.lvPedidos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnCodigo,
            this.ColumnFechaP,
            this.ColumnCodCli,
            this.columnRSocial,
            this.columnCatCli});
            this.lvPedidos.FullRowSelect = true;
            this.lvPedidos.GridLines = true;
            this.lvPedidos.Location = new System.Drawing.Point(12, 53);
            this.lvPedidos.MultiSelect = false;
            this.lvPedidos.Name = "lvPedidos";
            this.lvPedidos.Size = new System.Drawing.Size(696, 356);
            this.lvPedidos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvPedidos.TabIndex = 5;
            this.lvPedidos.UseCompatibleStateImageBehavior = false;
            this.lvPedidos.View = System.Windows.Forms.View.Details;
            this.lvPedidos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvPedidos_ColumnClick);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.Text = "Pedido";
            this.ColumnCodigo.Width = 77;
            // 
            // ColumnFechaP
            // 
            this.ColumnFechaP.Text = "Fecha ";
            this.ColumnFechaP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnFechaP.Width = 83;
            // 
            // ColumnCodCli
            // 
            this.ColumnCodCli.Text = "Cliente";
            this.ColumnCodCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnCodCli.Width = 76;
            // 
            // columnRSocial
            // 
            this.columnRSocial.Text = "Razon Social";
            this.columnRSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnRSocial.Width = 285;
            // 
            // columnCatCli
            // 
            this.columnCatCli.Text = "Categoria Cliente";
            this.columnCatCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCatCli.Width = 172;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 442);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(720, 22);
            this.StatusStrip1.TabIndex = 9;
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
            this.ListadoToolStripMenuListado});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(720, 24);
            this.MenuStrip1.TabIndex = 7;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ListadoToolStripMenuListado
            // 
            this.ListadoToolStripMenuListado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigurarPáginaToolStripMenuItem,
            this.ImprimirToolStripMenuItem,
            this.VistaPreliminarToolStripMenuItem,
            this.ToolStripSeparator1,
            this.SalirToolStripMenuItem});
            this.ListadoToolStripMenuListado.Name = "ListadoToolStripMenuListado";
            this.ListadoToolStripMenuListado.Size = new System.Drawing.Size(57, 20);
            this.ListadoToolStripMenuListado.Text = "&Listado";
            // 
            // ConfigurarPáginaToolStripMenuItem
            // 
            this.ConfigurarPáginaToolStripMenuItem.Name = "ConfigurarPáginaToolStripMenuItem";
            this.ConfigurarPáginaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ConfigurarPáginaToolStripMenuItem.Text = "Configurar página...";
            this.ConfigurarPáginaToolStripMenuItem.Click += new System.EventHandler(this.ConfigurarPáginaToolStripMenuItem_Click);
            this.ConfigurarPáginaToolStripMenuItem.MouseHover += new System.EventHandler(this.ConfigurarPáginaToolStripMenuItem_MouseHover);
            // 
            // ImprimirToolStripMenuItem
            // 
            this.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem";
            this.ImprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.ImprimirToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ImprimirToolStripMenuItem.Text = "Imprimir...";
            this.ImprimirToolStripMenuItem.Click += new System.EventHandler(this.ImprimirToolStripMenuItem_Click);
            this.ImprimirToolStripMenuItem.MouseHover += new System.EventHandler(this.ImprimirToolStripMenuItem_MouseHover);
            // 
            // VistaPreliminarToolStripMenuItem
            // 
            this.VistaPreliminarToolStripMenuItem.Name = "VistaPreliminarToolStripMenuItem";
            this.VistaPreliminarToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.VistaPreliminarToolStripMenuItem.Text = "Vista preliminar";
            this.VistaPreliminarToolStripMenuItem.Click += new System.EventHandler(this.VistaPreliminarToolStripMenuItem_Click);
            this.VistaPreliminarToolStripMenuItem.MouseHover += new System.EventHandler(this.VistaPreliminarToolStripMenuItem_MouseHover);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.SalirToolStripMenuItem.Text = "Salir";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            this.SalirToolStripMenuItem.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.SalirToolStripMenuItem.MouseHover += new System.EventHandler(this.btnSalir_MouseHover);
            // 
            // lblFecDesde
            // 
            this.lblFecDesde.AutoSize = true;
            this.lblFecDesde.Location = new System.Drawing.Point(86, 28);
            this.lblFecDesde.Name = "lblFecDesde";
            this.lblFecDesde.Size = new System.Drawing.Size(44, 13);
            this.lblFecDesde.TabIndex = 0;
            this.lblFecDesde.Text = "Desde: ";
            // 
            // dtpFecDesde
            // 
            this.dtpFecDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecDesde.Location = new System.Drawing.Point(136, 26);
            this.dtpFecDesde.Name = "dtpFecDesde";
            this.dtpFecDesde.Size = new System.Drawing.Size(99, 20);
            this.dtpFecDesde.TabIndex = 1;
            // 
            // lblFecHasta
            // 
            this.lblFecHasta.AutoSize = true;
            this.lblFecHasta.Location = new System.Drawing.Point(241, 28);
            this.lblFecHasta.Name = "lblFecHasta";
            this.lblFecHasta.Size = new System.Drawing.Size(41, 13);
            this.lblFecHasta.TabIndex = 2;
            this.lblFecHasta.Text = "Hasta: ";
            // 
            // dtpFecHasta
            // 
            this.dtpFecHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecHasta.Location = new System.Drawing.Point(288, 26);
            this.dtpFecHasta.Name = "dtpFecHasta";
            this.dtpFecHasta.Size = new System.Drawing.Size(97, 20);
            this.dtpFecHasta.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(391, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.printDocument1.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.printDocument1_QueryPageSettings);
            // 
            // sFDBDataSet
            // 
            this.sFDBDataSet.DataSetName = "SFDBDataSet";
            this.sFDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "Pedido";
            this.pedidoBindingSource.DataSource = this.sFDBDataSet;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
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
            // categoriaCBindingSource
            // 
            this.categoriaCBindingSource.DataMember = "CategoriaC";
            this.categoriaCBindingSource.DataSource = this.sFDBDataSet;
            // 
            // categoriaCTableAdapter
            // 
            this.categoriaCTableAdapter.ClearBeforeFill = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmListarPedidos
            // 
            this.AcceptButton = this.btnSalir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 464);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFecHasta);
            this.Controls.Add(this.lblFecHasta);
            this.Controls.Add(this.dtpFecDesde);
            this.Controls.Add(this.lblFecDesde);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvPedidos);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "frmListarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Pedidos";
            this.Load += new System.EventHandler(this.frmListarPedidos_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripConfigurarP;
        internal System.Windows.Forms.ToolStripButton ToolStripImprimir;
        internal System.Windows.Forms.ToolStripButton ToolStripVistaPreliminar;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.ListView lvPedidos;
        internal System.Windows.Forms.ColumnHeader ColumnCodigo;
        internal System.Windows.Forms.ColumnHeader ColumnFechaP;
        internal System.Windows.Forms.ColumnHeader ColumnCodCli;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelInfo;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ListadoToolStripMenuListado;
        internal System.Windows.Forms.ToolStripMenuItem ConfigurarPáginaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ImprimirToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem VistaPreliminarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblFecDesde;
        private System.Windows.Forms.DateTimePicker dtpFecDesde;
        private System.Windows.Forms.Label lblFecHasta;
        private System.Windows.Forms.DateTimePicker dtpFecHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ColumnHeader columnRSocial;
        private System.Windows.Forms.ColumnHeader columnCatCli;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private SFDBDataSet sFDBDataSet;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private SFDBDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SFDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource categoriaCBindingSource;
        private SFDBDataSetTableAdapters.CategoriaCTableAdapter categoriaCTableAdapter;
        private System.Windows.Forms.PrintDialog printDialog1;

    }
}