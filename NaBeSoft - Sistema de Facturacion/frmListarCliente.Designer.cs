namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmListarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarCliente));
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvClientes = new System.Windows.Forms.ListView();
            this.ColumnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCateg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnFecIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnRSocial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnApNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCuilCuit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnTelF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnTelC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnLoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripImprimir = new System.Windows.Forms.ToolStripButton();
            this.ToolStripVistaPreliminar = new System.Windows.Forms.ToolStripButton();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VistaPreliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.sFDBDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ClienteTableAdapter();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidadTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.LocalidadTableAdapter();
            this.categoriaCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaCTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.CategoriaCTableAdapter();
            this.ToolStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(819, 412);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseHover += new System.EventHandler(this.btnSalir_MouseHover);
            // 
            // lvClientes
            // 
            this.lvClientes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnCodigo,
            this.ColumnCateg,
            this.ColumnFecIn,
            this.ColumnRSocial,
            this.ColumnApNom,
            this.ColumnCuilCuit,
            this.ColumnTelF,
            this.ColumnTelC,
            this.ColumnLoc,
            this.ColumnDir});
            this.lvClientes.FullRowSelect = true;
            this.lvClientes.GridLines = true;
            this.lvClientes.Location = new System.Drawing.Point(12, 52);
            this.lvClientes.MultiSelect = false;
            this.lvClientes.Name = "lvClientes";
            this.lvClientes.Size = new System.Drawing.Size(872, 354);
            this.lvClientes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvClientes.TabIndex = 6;
            this.lvClientes.UseCompatibleStateImageBehavior = false;
            this.lvClientes.View = System.Windows.Forms.View.Details;
            this.lvClientes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvClientes_ColumnClick);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.Text = "Codigo";
            this.ColumnCodigo.Width = 50;
            // 
            // ColumnCateg
            // 
            this.ColumnCateg.Text = "Categoría";
            this.ColumnCateg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnCateg.Width = 65;
            // 
            // ColumnFecIn
            // 
            this.ColumnFecIn.Text = "Fecha de Inicio";
            this.ColumnFecIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnFecIn.Width = 88;
            // 
            // ColumnRSocial
            // 
            this.ColumnRSocial.Text = "Razón Social";
            this.ColumnRSocial.Width = 200;
            // 
            // ColumnApNom
            // 
            this.ColumnApNom.Text = "Apellido y Nombre";
            this.ColumnApNom.Width = 200;
            // 
            // ColumnCuilCuit
            // 
            this.ColumnCuilCuit.Text = "CUIL/CUIT";
            this.ColumnCuilCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnCuilCuit.Width = 90;
            // 
            // ColumnTelF
            // 
            this.ColumnTelF.Text = "Teléfono";
            this.ColumnTelF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnTelF.Width = 90;
            // 
            // ColumnTelC
            // 
            this.ColumnTelC.Text = "Celular";
            this.ColumnTelC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnTelC.Width = 90;
            // 
            // ColumnLoc
            // 
            this.ColumnLoc.Text = "Localidad";
            this.ColumnLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnLoc.Width = 130;
            // 
            // ColumnDir
            // 
            this.ColumnDir.Text = "Domicilio";
            this.ColumnDir.Width = 340;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripImprimir,
            this.ToolStripVistaPreliminar});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(896, 25);
            this.ToolStrip1.TabIndex = 5;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripImprimir
            // 
            this.ToolStripImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripImprimir.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripImprimir.Image")));
            this.ToolStripImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripImprimir.Name = "ToolStripImprimir";
            this.ToolStripImprimir.Size = new System.Drawing.Size(23, 22);
            this.ToolStripImprimir.Text = "ToolStripButton1";
            this.ToolStripImprimir.ToolTipText = "Imprimir";
            this.ToolStripImprimir.Click += new System.EventHandler(this.ToolStripImprimir_Click);
            this.ToolStripImprimir.MouseLeave += new System.EventHandler(this.ToolStripImprimir_MouseLeave);
            this.ToolStripImprimir.MouseHover += new System.EventHandler(this.ToolStripImprimir_MouseHover);
            // 
            // ToolStripVistaPreliminar
            // 
            this.ToolStripVistaPreliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripVistaPreliminar.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripVistaPreliminar.Image")));
            this.ToolStripVistaPreliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripVistaPreliminar.Name = "ToolStripVistaPreliminar";
            this.ToolStripVistaPreliminar.Size = new System.Drawing.Size(23, 22);
            this.ToolStripVistaPreliminar.Text = "ToolStripButton2";
            this.ToolStripVistaPreliminar.ToolTipText = "Vista preliminar";
            this.ToolStripVistaPreliminar.Click += new System.EventHandler(this.ToolStripVistaPreliminar_Click);
            this.ToolStripVistaPreliminar.MouseLeave += new System.EventHandler(this.ToolStripVistaPreliminar_MouseLeave);
            this.ToolStripVistaPreliminar.MouseHover += new System.EventHandler(this.ToolStripVistaPreliminar_MouseHover);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LListadoToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(896, 24);
            this.MenuStrip1.TabIndex = 4;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // LListadoToolStripMenuItem
            // 
            this.LListadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImprimirToolStripMenuItem,
            this.VistaPreliminarToolStripMenuItem,
            this.ToolStripSeparator1,
            this.SalirToolStripMenuItem});
            this.LListadoToolStripMenuItem.Name = "LListadoToolStripMenuItem";
            this.LListadoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.LListadoToolStripMenuItem.Text = "&Listado";
            // 
            // ImprimirToolStripMenuItem
            // 
            this.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem";
            this.ImprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.ImprimirToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ImprimirToolStripMenuItem.Text = "Imprimir...";
            this.ImprimirToolStripMenuItem.Click += new System.EventHandler(this.ImprimirToolStripMenuItem_Click);
            this.ImprimirToolStripMenuItem.MouseLeave += new System.EventHandler(this.ImprimirToolStripMenuItem_MouseLeave);
            this.ImprimirToolStripMenuItem.MouseHover += new System.EventHandler(this.ImprimirToolStripMenuItem_MouseHover);
            // 
            // VistaPreliminarToolStripMenuItem
            // 
            this.VistaPreliminarToolStripMenuItem.Name = "VistaPreliminarToolStripMenuItem";
            this.VistaPreliminarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.VistaPreliminarToolStripMenuItem.Text = "Vista preliminar";
            this.VistaPreliminarToolStripMenuItem.Click += new System.EventHandler(this.VistaPreliminarToolStripMenuItem_Click);
            this.VistaPreliminarToolStripMenuItem.MouseLeave += new System.EventHandler(this.VistaPreliminarToolStripMenuItem_MouseLeave);
            this.VistaPreliminarToolStripMenuItem.MouseHover += new System.EventHandler(this.VistaPreliminarToolStripMenuItem_MouseHover);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.SalirToolStripMenuItem.Text = "Salir";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            this.SalirToolStripMenuItem.MouseLeave += new System.EventHandler(this.SalirToolStripMenuItem_MouseLeave);
            this.SalirToolStripMenuItem.MouseHover += new System.EventHandler(this.SalirToolStripMenuItem_MouseHover);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 438);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(896, 22);
            this.StatusStrip1.TabIndex = 8;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabelInfo
            // 
            this.ToolStripStatusLabelInfo.Name = "ToolStripStatusLabelInfo";
            this.ToolStripStatusLabelInfo.Size = new System.Drawing.Size(0, 17);
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
            // frmListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 460);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvClientes);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "frmListarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.frmListarCliente_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.ListView lvClientes;
        internal System.Windows.Forms.ColumnHeader ColumnCodigo;
        internal System.Windows.Forms.ColumnHeader ColumnCateg;
        internal System.Windows.Forms.ColumnHeader ColumnFecIn;
        internal System.Windows.Forms.ColumnHeader ColumnRSocial;
        internal System.Windows.Forms.ColumnHeader ColumnApNom;
        internal System.Windows.Forms.ColumnHeader ColumnCuilCuit;
        internal System.Windows.Forms.ColumnHeader ColumnTelF;
        internal System.Windows.Forms.ColumnHeader ColumnTelC;
        internal System.Windows.Forms.ColumnHeader ColumnLoc;
        internal System.Windows.Forms.ColumnHeader ColumnDir;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripImprimir;
        internal System.Windows.Forms.ToolStripButton ToolStripVistaPreliminar;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem LListadoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ImprimirToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem VistaPreliminarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelInfo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private SFDBDataSet sFDBDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SFDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private SFDBDataSetTableAdapters.LocalidadTableAdapter localidadTableAdapter;
        private System.Windows.Forms.BindingSource categoriaCBindingSource;
        private SFDBDataSetTableAdapters.CategoriaCTableAdapter categoriaCTableAdapter;
    }
}