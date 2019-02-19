namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmListarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarArticulo));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripConfigurarP = new System.Windows.Forms.ToolStripButton();
            this.ToolStripImprimir = new System.Windows.Forms.ToolStripButton();
            this.ToolStripVistaPreliminar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvArticulos = new System.Windows.Forms.ListView();
            this.ColumnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnRubro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPEspecial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPEstandar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPFranquicia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPMayorista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ListadoToolStripMenuListado = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigurarPáginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VistaPreliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sFDBDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloTableAdapter();
            this.articuloCategoriaCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloCategoriaCTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloCategoriaCTableAdapter();
            this.rubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubroTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.RubroTableAdapter();
            this.ToolStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloCategoriaCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripConfigurarP,
            this.ToolStripImprimir,
            this.ToolStripVistaPreliminar});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(718, 25);
            this.ToolStrip1.TabIndex = 14;
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
            this.ToolStripConfigurarP.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
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
            this.ToolStripImprimir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
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
            this.ToolStripVistaPreliminar.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.ToolStripVistaPreliminar.MouseHover += new System.EventHandler(this.VistaPreliminarToolStripMenuItem_MouseHover);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(643, 393);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 25);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseHover += new System.EventHandler(this.btnSalir_MouseHover);
            // 
            // lvArticulos
            // 
            this.lvArticulos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvArticulos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnCodigo,
            this.ColumnRubro,
            this.ColumnDescripcion,
            this.ColumnPEspecial,
            this.ColumnPEstandar,
            this.ColumnPFranquicia,
            this.ColumnPMayorista});
            this.lvArticulos.FullRowSelect = true;
            this.lvArticulos.GridLines = true;
            this.lvArticulos.Location = new System.Drawing.Point(12, 52);
            this.lvArticulos.MultiSelect = false;
            this.lvArticulos.Name = "lvArticulos";
            this.lvArticulos.Size = new System.Drawing.Size(696, 335);
            this.lvArticulos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvArticulos.TabIndex = 11;
            this.lvArticulos.UseCompatibleStateImageBehavior = false;
            this.lvArticulos.View = System.Windows.Forms.View.Details;
            this.lvArticulos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvArticulos_ColumnClick);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.Text = "Código";
            this.ColumnCodigo.Width = 50;
            // 
            // ColumnRubro
            // 
            this.ColumnRubro.Text = "Rubro";
            this.ColumnRubro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnRubro.Width = 83;
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.Text = "Descripción";
            this.ColumnDescripcion.Width = 288;
            // 
            // ColumnPEspecial
            // 
            this.ColumnPEspecial.Text = "Precio Esp.";
            this.ColumnPEspecial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnPEspecial.Width = 69;
            // 
            // ColumnPEstandar
            // 
            this.ColumnPEstandar.Text = "Precio Est.";
            this.ColumnPEstandar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnPEstandar.Width = 66;
            // 
            // ColumnPFranquicia
            // 
            this.ColumnPFranquicia.Text = "Precio Fra.";
            this.ColumnPFranquicia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnPFranquicia.Width = 66;
            // 
            // ColumnPMayorista
            // 
            this.ColumnPMayorista.Text = "Precio May.";
            this.ColumnPMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnPMayorista.Width = 71;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 426);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(718, 22);
            this.StatusStrip1.TabIndex = 13;
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
            this.MenuStrip1.Size = new System.Drawing.Size(718, 24);
            this.MenuStrip1.TabIndex = 10;
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
            this.ConfigurarPáginaToolStripMenuItem.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.ConfigurarPáginaToolStripMenuItem.MouseHover += new System.EventHandler(this.ConfigurarPáginaToolStripMenuItem_MouseHover);
            // 
            // ImprimirToolStripMenuItem
            // 
            this.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem";
            this.ImprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.ImprimirToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ImprimirToolStripMenuItem.Text = "Imprimir...";
            this.ImprimirToolStripMenuItem.Click += new System.EventHandler(this.ImprimirToolStripMenuItem_Click);
            this.ImprimirToolStripMenuItem.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.ImprimirToolStripMenuItem.MouseHover += new System.EventHandler(this.ImprimirToolStripMenuItem_MouseHover);
            // 
            // VistaPreliminarToolStripMenuItem
            // 
            this.VistaPreliminarToolStripMenuItem.Name = "VistaPreliminarToolStripMenuItem";
            this.VistaPreliminarToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.VistaPreliminarToolStripMenuItem.Text = "Vista preliminar";
            this.VistaPreliminarToolStripMenuItem.Click += new System.EventHandler(this.VistaPreliminarToolStripMenuItem_Click);
            this.VistaPreliminarToolStripMenuItem.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
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
            // printDocument1
            // 
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
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
            // rubroBindingSource
            // 
            this.rubroBindingSource.DataMember = "Rubro";
            this.rubroBindingSource.DataSource = this.sFDBDataSet;
            // 
            // rubroTableAdapter
            // 
            this.rubroTableAdapter.ClearBeforeFill = true;
            // 
            // frmListarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 448);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvArticulos);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "frmListarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Artículos";
            this.Load += new System.EventHandler(this.frmListarArticulo_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloCategoriaCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripConfigurarP;
        internal System.Windows.Forms.ToolStripButton ToolStripImprimir;
        internal System.Windows.Forms.ToolStripButton ToolStripVistaPreliminar;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.ListView lvArticulos;
        internal System.Windows.Forms.ColumnHeader ColumnCodigo;
        internal System.Windows.Forms.ColumnHeader ColumnRubro;
        internal System.Windows.Forms.ColumnHeader ColumnDescripcion;
        internal System.Windows.Forms.ColumnHeader ColumnPEspecial;
        internal System.Windows.Forms.ColumnHeader ColumnPEstandar;
        internal System.Windows.Forms.ColumnHeader ColumnPFranquicia;
        internal System.Windows.Forms.ColumnHeader ColumnPMayorista;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelInfo;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ListadoToolStripMenuListado;
        internal System.Windows.Forms.ToolStripMenuItem ConfigurarPáginaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ImprimirToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem VistaPreliminarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private SFDBDataSet sFDBDataSet;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private SFDBDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.BindingSource articuloCategoriaCBindingSource;
        private SFDBDataSetTableAdapters.ArticuloCategoriaCTableAdapter articuloCategoriaCTableAdapter;
        private System.Windows.Forms.BindingSource rubroBindingSource;
        private SFDBDataSetTableAdapters.RubroTableAdapter rubroTableAdapter;
    }
}