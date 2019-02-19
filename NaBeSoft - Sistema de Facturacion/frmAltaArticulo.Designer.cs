namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmAltaArticulo
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
            this.gbDepositos = new System.Windows.Forms.GroupBox();
            this.txtStockSeguridad = new System.Windows.Forms.TextBox();
            this.txtNroDeposito = new System.Windows.Forms.TextBox();
            this.lblStockSeguridad = new System.Windows.Forms.Label();
            this.cmbUStock = new System.Windows.Forms.ComboBox();
            this.lblUStock = new System.Windows.Forms.Label();
            this.lblNroDeposito = new System.Windows.Forms.Label();
            this.cmbDeposito = new System.Windows.Forms.ComboBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbPrecios = new System.Windows.Forms.GroupBox();
            this.txtPrecioMay = new System.Windows.Forms.TextBox();
            this.txtPrecioFra = new System.Windows.Forms.TextBox();
            this.txtPrecioMin = new System.Windows.Forms.TextBox();
            this.txtPrecioEsp = new System.Windows.Forms.TextBox();
            this.lblCLMay = new System.Windows.Forms.Label();
            this.lblCLFra = new System.Windows.Forms.Label();
            this.lblCLMin = new System.Windows.Forms.Label();
            this.lblCLEsp = new System.Windows.Forms.Label();
            this.grbArticulo = new System.Windows.Forms.GroupBox();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblDescArticulo = new System.Windows.Forms.Label();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sFDBDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.rubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloTableAdapter();
            this.rubroTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.RubroTableAdapter();
            this.depositoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depositoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.DepositoTableAdapter();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.StockTableAdapter();
            this.articuloCategoriaCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloCategoriaCTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloCategoriaCTableAdapter();
            this.gbDepositos.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.grbPrecios.SuspendLayout();
            this.grbArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloCategoriaCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDepositos
            // 
            this.gbDepositos.Controls.Add(this.txtStockSeguridad);
            this.gbDepositos.Controls.Add(this.txtNroDeposito);
            this.gbDepositos.Controls.Add(this.lblStockSeguridad);
            this.gbDepositos.Controls.Add(this.cmbUStock);
            this.gbDepositos.Controls.Add(this.lblUStock);
            this.gbDepositos.Controls.Add(this.lblNroDeposito);
            this.gbDepositos.Controls.Add(this.cmbDeposito);
            this.gbDepositos.Controls.Add(this.lblDeposito);
            this.gbDepositos.Location = new System.Drawing.Point(12, 109);
            this.gbDepositos.Name = "gbDepositos";
            this.gbDepositos.Size = new System.Drawing.Size(508, 90);
            this.gbDepositos.TabIndex = 7;
            this.gbDepositos.TabStop = false;
            this.gbDepositos.Text = "Asignación a Deposito";
            // 
            // txtStockSeguridad
            // 
            this.txtStockSeguridad.Location = new System.Drawing.Point(369, 54);
            this.txtStockSeguridad.Name = "txtStockSeguridad";
            this.txtStockSeguridad.Size = new System.Drawing.Size(80, 20);
            this.txtStockSeguridad.TabIndex = 7;
            this.txtStockSeguridad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStockSeguridad_KeyDown);
            this.txtStockSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRubro_KeyPress);
            // 
            // txtNroDeposito
            // 
            this.txtNroDeposito.Location = new System.Drawing.Point(369, 19);
            this.txtNroDeposito.Name = "txtNroDeposito";
            this.txtNroDeposito.ReadOnly = true;
            this.txtNroDeposito.Size = new System.Drawing.Size(32, 20);
            this.txtNroDeposito.TabIndex = 3;
            this.txtNroDeposito.TabStop = false;
            this.txtNroDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStockSeguridad
            // 
            this.lblStockSeguridad.AutoSize = true;
            this.lblStockSeguridad.Location = new System.Drawing.Point(256, 57);
            this.lblStockSeguridad.Name = "lblStockSeguridad";
            this.lblStockSeguridad.Size = new System.Drawing.Size(107, 13);
            this.lblStockSeguridad.TabIndex = 6;
            this.lblStockSeguridad.Text = "Stock de Seguridad :";
            // 
            // cmbUStock
            // 
            this.cmbUStock.FormattingEnabled = true;
            this.cmbUStock.Items.AddRange(new object[] {
            "Bolsa",
            "Caja",
            "Kilogramo",
            "Unidad"});
            this.cmbUStock.Location = new System.Drawing.Point(90, 53);
            this.cmbUStock.Name = "cmbUStock";
            this.cmbUStock.Size = new System.Drawing.Size(160, 21);
            this.cmbUStock.TabIndex = 5;
            this.cmbUStock.Text = "Seleccione una...";
            this.cmbUStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRubro_KeyDown);
            this.cmbUStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRubro_KeyPress);
            this.cmbUStock.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.cmbUStock.MouseHover += new System.EventHandler(this.cmbUStock_MouseHover);
            // 
            // lblUStock
            // 
            this.lblUStock.AutoSize = true;
            this.lblUStock.Location = new System.Drawing.Point(6, 57);
            this.lblUStock.Name = "lblUStock";
            this.lblUStock.Size = new System.Drawing.Size(78, 13);
            this.lblUStock.TabIndex = 4;
            this.lblUStock.Text = "Unidad Stock :";
            // 
            // lblNroDeposito
            // 
            this.lblNroDeposito.AutoSize = true;
            this.lblNroDeposito.Location = new System.Drawing.Point(313, 22);
            this.lblNroDeposito.Name = "lblNroDeposito";
            this.lblNroDeposito.Size = new System.Drawing.Size(50, 13);
            this.lblNroDeposito.TabIndex = 2;
            this.lblNroDeposito.Text = "Número :";
            // 
            // cmbDeposito
            // 
            this.cmbDeposito.FormattingEnabled = true;
            this.cmbDeposito.Location = new System.Drawing.Point(90, 18);
            this.cmbDeposito.Name = "cmbDeposito";
            this.cmbDeposito.Size = new System.Drawing.Size(160, 21);
            this.cmbDeposito.TabIndex = 1;
            this.cmbDeposito.Text = "Seleccione uno...";
            this.cmbDeposito.SelectedIndexChanged += new System.EventHandler(this.cmbDeposito_SelectedIndexChanged);
            this.cmbDeposito.SelectionChangeCommitted += new System.EventHandler(this.cmbDeposito_SelectionChangeCommitted);
            this.cmbDeposito.TextChanged += new System.EventHandler(this.cmbDeposito_TextChanged);
            this.cmbDeposito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRubro_KeyDown);
            this.cmbDeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRubro_KeyPress);
            this.cmbDeposito.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.cmbDeposito.MouseHover += new System.EventHandler(this.cmbDeposito_MouseHover);
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Location = new System.Drawing.Point(6, 22);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(55, 13);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Deposito :";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 296);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(532, 22);
            this.StatusStrip1.TabIndex = 11;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabelInfo
            // 
            this.ToolStripStatusLabelInfo.Name = "ToolStripStatusLabelInfo";
            this.ToolStripStatusLabelInfo.Size = new System.Drawing.Size(181, 17);
            this.ToolStripStatusLabelInfo.Text = "Todos los datos son obligatorios.";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(455, 237);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(386, 237);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(65, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnGuardar.MouseHover += new System.EventHandler(this.btnGuardar_MouseHover);
            // 
            // grbPrecios
            // 
            this.grbPrecios.Controls.Add(this.txtPrecioMay);
            this.grbPrecios.Controls.Add(this.txtPrecioFra);
            this.grbPrecios.Controls.Add(this.txtPrecioMin);
            this.grbPrecios.Controls.Add(this.txtPrecioEsp);
            this.grbPrecios.Controls.Add(this.lblCLMay);
            this.grbPrecios.Controls.Add(this.lblCLFra);
            this.grbPrecios.Controls.Add(this.lblCLMin);
            this.grbPrecios.Controls.Add(this.lblCLEsp);
            this.grbPrecios.Location = new System.Drawing.Point(12, 205);
            this.grbPrecios.Name = "grbPrecios";
            this.grbPrecios.Size = new System.Drawing.Size(368, 80);
            this.grbPrecios.TabIndex = 8;
            this.grbPrecios.TabStop = false;
            this.grbPrecios.Text = "Precios para Clientes";
            // 
            // txtPrecioMay
            // 
            this.txtPrecioMay.Location = new System.Drawing.Point(298, 52);
            this.txtPrecioMay.MaxLength = 6;
            this.txtPrecioMay.Name = "txtPrecioMay";
            this.txtPrecioMay.Size = new System.Drawing.Size(45, 20);
            this.txtPrecioMay.TabIndex = 7;
            this.txtPrecioMay.WordWrap = false;
            this.txtPrecioMay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStockSeguridad_KeyDown);
            this.txtPrecioMay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRubro_KeyPress);
            this.txtPrecioMay.Leave += new System.EventHandler(this.txtPrecioEsp_Leave);
            // 
            // txtPrecioFra
            // 
            this.txtPrecioFra.Location = new System.Drawing.Point(109, 52);
            this.txtPrecioFra.MaxLength = 6;
            this.txtPrecioFra.Name = "txtPrecioFra";
            this.txtPrecioFra.Size = new System.Drawing.Size(45, 20);
            this.txtPrecioFra.TabIndex = 5;
            this.txtPrecioFra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStockSeguridad_KeyDown);
            this.txtPrecioFra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRubro_KeyPress);
            this.txtPrecioFra.Leave += new System.EventHandler(this.txtPrecioEsp_Leave);
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.Location = new System.Drawing.Point(298, 19);
            this.txtPrecioMin.MaxLength = 6;
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.Size = new System.Drawing.Size(45, 20);
            this.txtPrecioMin.TabIndex = 3;
            this.txtPrecioMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStockSeguridad_KeyDown);
            this.txtPrecioMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRubro_KeyPress);
            this.txtPrecioMin.Leave += new System.EventHandler(this.txtPrecioEsp_Leave);
            // 
            // txtPrecioEsp
            // 
            this.txtPrecioEsp.Location = new System.Drawing.Point(109, 19);
            this.txtPrecioEsp.MaxLength = 6;
            this.txtPrecioEsp.Name = "txtPrecioEsp";
            this.txtPrecioEsp.Size = new System.Drawing.Size(45, 20);
            this.txtPrecioEsp.TabIndex = 1;
            this.txtPrecioEsp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStockSeguridad_KeyDown);
            this.txtPrecioEsp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRubro_KeyPress);
            this.txtPrecioEsp.Leave += new System.EventHandler(this.txtPrecioEsp_Leave);
            // 
            // lblCLMay
            // 
            this.lblCLMay.AutoSize = true;
            this.lblCLMay.Location = new System.Drawing.Point(199, 55);
            this.lblCLMay.Name = "lblCLMay";
            this.lblCLMay.Size = new System.Drawing.Size(93, 13);
            this.lblCLMay.TabIndex = 6;
            this.lblCLMay.Text = "Cliente Mayorista :";
            // 
            // lblCLFra
            // 
            this.lblCLFra.AutoSize = true;
            this.lblCLFra.Location = new System.Drawing.Point(6, 55);
            this.lblCLFra.Name = "lblCLFra";
            this.lblCLFra.Size = new System.Drawing.Size(99, 13);
            this.lblCLFra.TabIndex = 4;
            this.lblCLFra.Text = "Cliente Franquícia :";
            // 
            // lblCLMin
            // 
            this.lblCLMin.AutoSize = true;
            this.lblCLMin.Location = new System.Drawing.Point(199, 22);
            this.lblCLMin.Name = "lblCLMin";
            this.lblCLMin.Size = new System.Drawing.Size(90, 13);
            this.lblCLMin.TabIndex = 2;
            this.lblCLMin.Text = "Cliente Minorista :";
            // 
            // lblCLEsp
            // 
            this.lblCLEsp.AutoSize = true;
            this.lblCLEsp.Location = new System.Drawing.Point(6, 22);
            this.lblCLEsp.Name = "lblCLEsp";
            this.lblCLEsp.Size = new System.Drawing.Size(91, 13);
            this.lblCLEsp.TabIndex = 0;
            this.lblCLEsp.Text = "Cliente Especial : ";
            // 
            // grbArticulo
            // 
            this.grbArticulo.Controls.Add(this.cmbRubro);
            this.grbArticulo.Controls.Add(this.txtDesc);
            this.grbArticulo.Controls.Add(this.lblRubro);
            this.grbArticulo.Controls.Add(this.lblDescArticulo);
            this.grbArticulo.Location = new System.Drawing.Point(12, 3);
            this.grbArticulo.Name = "grbArticulo";
            this.grbArticulo.Size = new System.Drawing.Size(508, 100);
            this.grbArticulo.TabIndex = 6;
            this.grbArticulo.TabStop = false;
            this.grbArticulo.Text = "Artículo";
            // 
            // cmbRubro
            // 
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(90, 71);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(160, 21);
            this.cmbRubro.TabIndex = 5;
            this.cmbRubro.SelectionChangeCommitted += new System.EventHandler(this.cmbRubro_SelectionChangeCommitted);
            this.cmbRubro.TextChanged += new System.EventHandler(this.cmbRubro_TextChanged);
            this.cmbRubro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRubro_KeyDown);
            this.cmbRubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRubro_KeyPress);
            this.cmbRubro.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.cmbRubro.MouseHover += new System.EventHandler(this.cmbRubro_MouseHover);
            // 
            // txtDesc
            // 
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloBindingSource, "Descripcion", true));
            this.txtDesc.Location = new System.Drawing.Point(90, 45);
            this.txtDesc.MaxLength = 40;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(356, 20);
            this.txtDesc.TabIndex = 3;
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(6, 74);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(42, 13);
            this.lblRubro.TabIndex = 4;
            this.lblRubro.Text = "Rubro :";
            // 
            // lblDescArticulo
            // 
            this.lblDescArticulo.AutoSize = true;
            this.lblDescArticulo.Location = new System.Drawing.Point(6, 48);
            this.lblDescArticulo.Name = "lblDescArticulo";
            this.lblDescArticulo.Size = new System.Drawing.Size(72, 13);
            this.lblDescArticulo.TabIndex = 2;
            this.lblDescArticulo.Text = "Descripción : ";
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "Articulo";
            this.articuloBindingSource.DataSource = this.sFDBDataSet;
            // 
            // sFDBDataSet
            // 
            this.sFDBDataSet.DataSetName = "SFDBDataSet";
            this.sFDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubroBindingSource
            // 
            this.rubroBindingSource.DataMember = "Rubro";
            this.rubroBindingSource.DataSource = this.sFDBDataSet;
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // rubroTableAdapter
            // 
            this.rubroTableAdapter.ClearBeforeFill = true;
            // 
            // depositoBindingSource
            // 
            this.depositoBindingSource.DataMember = "Deposito";
            this.depositoBindingSource.DataSource = this.sFDBDataSet;
            // 
            // depositoTableAdapter
            // 
            this.depositoTableAdapter.ClearBeforeFill = true;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.sFDBDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
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
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 318);
            this.Controls.Add(this.gbDepositos);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbPrecios);
            this.Controls.Add(this.grbArticulo);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Nuevo Articulo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAltaArticulo_FormClosing);
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            this.gbDepositos.ResumeLayout(false);
            this.gbDepositos.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.grbPrecios.ResumeLayout(false);
            this.grbPrecios.PerformLayout();
            this.grbArticulo.ResumeLayout(false);
            this.grbArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloCategoriaCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbDepositos;
        internal System.Windows.Forms.TextBox txtStockSeguridad;
        internal System.Windows.Forms.TextBox txtNroDeposito;
        internal System.Windows.Forms.Label lblStockSeguridad;
        internal System.Windows.Forms.ComboBox cmbUStock;
        internal System.Windows.Forms.Label lblUStock;
        internal System.Windows.Forms.Label lblNroDeposito;
        internal System.Windows.Forms.ComboBox cmbDeposito;
        internal System.Windows.Forms.Label lblDeposito;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelInfo;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.GroupBox grbPrecios;
        internal System.Windows.Forms.TextBox txtPrecioMay;
        internal System.Windows.Forms.TextBox txtPrecioFra;
        internal System.Windows.Forms.TextBox txtPrecioMin;
        internal System.Windows.Forms.TextBox txtPrecioEsp;
        internal System.Windows.Forms.Label lblCLMay;
        internal System.Windows.Forms.Label lblCLFra;
        internal System.Windows.Forms.Label lblCLMin;
        internal System.Windows.Forms.Label lblCLEsp;
        internal System.Windows.Forms.GroupBox grbArticulo;
        internal System.Windows.Forms.ComboBox cmbRubro;
        internal System.Windows.Forms.TextBox txtDesc;
        internal System.Windows.Forms.Label lblRubro;
        internal System.Windows.Forms.Label lblDescArticulo;
        private SFDBDataSet sFDBDataSet;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private SFDBDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.BindingSource rubroBindingSource;
        private SFDBDataSetTableAdapters.RubroTableAdapter rubroTableAdapter;
        private System.Windows.Forms.BindingSource depositoBindingSource;
        private SFDBDataSetTableAdapters.DepositoTableAdapter depositoTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private SFDBDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource articuloCategoriaCBindingSource;
        private SFDBDataSetTableAdapters.ArticuloCategoriaCTableAdapter articuloCategoriaCTableAdapter;
    }
}