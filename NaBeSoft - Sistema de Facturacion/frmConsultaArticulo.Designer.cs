namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmConsultaArticulo
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
            this.ToolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbDepositos = new System.Windows.Forms.GroupBox();
            this.txtUStock = new System.Windows.Forms.TextBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.txtStockSeguridad = new System.Windows.Forms.TextBox();
            this.txtNroDeposito = new System.Windows.Forms.TextBox();
            this.lblStockSeguridad = new System.Windows.Forms.Label();
            this.lblUStock = new System.Windows.Forms.Label();
            this.lblNroDeposito = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
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
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtCodArt = new System.Windows.Forms.TextBox();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblDescArticulo = new System.Windows.Forms.Label();
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.sFBDDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloTableAdapter();
            this.depositoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depositoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.DepositoTableAdapter();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.StockTableAdapter();
            this.articuloCategoriaCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloCategoriaCTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloCategoriaCTableAdapter();
            this.rubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubroTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.RubroTableAdapter();
            this.StatusStrip1.SuspendLayout();
            this.gbDepositos.SuspendLayout();
            this.grbPrecios.SuspendLayout();
            this.grbArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloCategoriaCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 328);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(529, 22);
            this.StatusStrip1.TabIndex = 17;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabelInfo
            // 
            this.ToolStripStatusLabelInfo.Name = "ToolStripStatusLabelInfo";
            this.ToolStripStatusLabelInfo.Size = new System.Drawing.Size(19, 17);
            this.ToolStripStatusLabelInfo.Text = "    ";
            // 
            // gbDepositos
            // 
            this.gbDepositos.Controls.Add(this.txtUStock);
            this.gbDepositos.Controls.Add(this.txtDeposito);
            this.gbDepositos.Controls.Add(this.txtStockSeguridad);
            this.gbDepositos.Controls.Add(this.txtNroDeposito);
            this.gbDepositos.Controls.Add(this.lblStockSeguridad);
            this.gbDepositos.Controls.Add(this.lblUStock);
            this.gbDepositos.Controls.Add(this.lblNroDeposito);
            this.gbDepositos.Controls.Add(this.lblDeposito);
            this.gbDepositos.Location = new System.Drawing.Point(12, 143);
            this.gbDepositos.Name = "gbDepositos";
            this.gbDepositos.Size = new System.Drawing.Size(508, 90);
            this.gbDepositos.TabIndex = 13;
            this.gbDepositos.TabStop = false;
            this.gbDepositos.Text = "Asignación a Deposito";
            // 
            // txtUStock
            // 
            this.txtUStock.Location = new System.Drawing.Point(90, 54);
            this.txtUStock.Name = "txtUStock";
            this.txtUStock.ReadOnly = true;
            this.txtUStock.Size = new System.Drawing.Size(160, 20);
            this.txtUStock.TabIndex = 5;
            this.txtUStock.TabStop = false;
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(84, 19);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.ReadOnly = true;
            this.txtDeposito.Size = new System.Drawing.Size(160, 20);
            this.txtDeposito.TabIndex = 1;
            this.txtDeposito.TabStop = false;
            // 
            // txtStockSeguridad
            // 
            this.txtStockSeguridad.Location = new System.Drawing.Point(369, 54);
            this.txtStockSeguridad.Name = "txtStockSeguridad";
            this.txtStockSeguridad.ReadOnly = true;
            this.txtStockSeguridad.Size = new System.Drawing.Size(80, 20);
            this.txtStockSeguridad.TabIndex = 7;
            this.txtStockSeguridad.TabStop = false;
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
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Location = new System.Drawing.Point(6, 22);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(55, 13);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Deposito :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(455, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Location = new System.Drawing.Point(386, 271);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(65, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnAceptar.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
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
            this.grbPrecios.Location = new System.Drawing.Point(12, 239);
            this.grbPrecios.Name = "grbPrecios";
            this.grbPrecios.Size = new System.Drawing.Size(368, 80);
            this.grbPrecios.TabIndex = 14;
            this.grbPrecios.TabStop = false;
            this.grbPrecios.Text = "Precios para Clientes";
            // 
            // txtPrecioMay
            // 
            this.txtPrecioMay.Location = new System.Drawing.Point(298, 52);
            this.txtPrecioMay.MaxLength = 6;
            this.txtPrecioMay.Name = "txtPrecioMay";
            this.txtPrecioMay.ReadOnly = true;
            this.txtPrecioMay.Size = new System.Drawing.Size(45, 20);
            this.txtPrecioMay.TabIndex = 7;
            this.txtPrecioMay.TabStop = false;
            this.txtPrecioMay.WordWrap = false;
            // 
            // txtPrecioFra
            // 
            this.txtPrecioFra.Location = new System.Drawing.Point(109, 52);
            this.txtPrecioFra.MaxLength = 6;
            this.txtPrecioFra.Name = "txtPrecioFra";
            this.txtPrecioFra.ReadOnly = true;
            this.txtPrecioFra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrecioFra.Size = new System.Drawing.Size(45, 20);
            this.txtPrecioFra.TabIndex = 5;
            this.txtPrecioFra.TabStop = false;
            this.txtPrecioFra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.Location = new System.Drawing.Point(298, 19);
            this.txtPrecioMin.MaxLength = 6;
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.ReadOnly = true;
            this.txtPrecioMin.Size = new System.Drawing.Size(45, 20);
            this.txtPrecioMin.TabIndex = 3;
            this.txtPrecioMin.TabStop = false;
            // 
            // txtPrecioEsp
            // 
            this.txtPrecioEsp.Location = new System.Drawing.Point(109, 19);
            this.txtPrecioEsp.MaxLength = 6;
            this.txtPrecioEsp.Name = "txtPrecioEsp";
            this.txtPrecioEsp.ReadOnly = true;
            this.txtPrecioEsp.Size = new System.Drawing.Size(45, 20);
            this.txtPrecioEsp.TabIndex = 1;
            this.txtPrecioEsp.TabStop = false;
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
            this.lblCLMin.Size = new System.Drawing.Size(87, 13);
            this.lblCLMin.TabIndex = 2;
            this.lblCLMin.Text = "Cliente Minorista:";
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
            this.grbArticulo.Controls.Add(this.txtRubro);
            this.grbArticulo.Controls.Add(this.txtDesc);
            this.grbArticulo.Controls.Add(this.txtCodArt);
            this.grbArticulo.Controls.Add(this.lblRubro);
            this.grbArticulo.Controls.Add(this.lblDescArticulo);
            this.grbArticulo.Controls.Add(this.lblCodArticulo);
            this.grbArticulo.Location = new System.Drawing.Point(12, 37);
            this.grbArticulo.Name = "grbArticulo";
            this.grbArticulo.Size = new System.Drawing.Size(508, 100);
            this.grbArticulo.TabIndex = 12;
            this.grbArticulo.TabStop = false;
            this.grbArticulo.Text = "Artículo";
            // 
            // txtRubro
            // 
            this.txtRubro.Location = new System.Drawing.Point(84, 71);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.ReadOnly = true;
            this.txtRubro.Size = new System.Drawing.Size(160, 20);
            this.txtRubro.TabIndex = 5;
            this.txtRubro.TabStop = false;
            // 
            // txtDesc
            // 
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesc.Location = new System.Drawing.Point(84, 45);
            this.txtDesc.MaxLength = 40;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(356, 20);
            this.txtDesc.TabIndex = 3;
            this.txtDesc.TabStop = false;
            // 
            // txtCodArt
            // 
            this.txtCodArt.Location = new System.Drawing.Point(84, 19);
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.ReadOnly = true;
            this.txtCodArt.Size = new System.Drawing.Size(45, 20);
            this.txtCodArt.TabIndex = 1;
            this.txtCodArt.TabStop = false;
            this.txtCodArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // lblCodArticulo
            // 
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Location = new System.Drawing.Point(6, 22);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(49, 13);
            this.lblCodArticulo.TabIndex = 0;
            this.lblCodArticulo.Text = "Código : ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuscar.Location = new System.Drawing.Point(266, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 25);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnBuscar.MouseHover += new System.EventHandler(this.btnBuscar_MouseHover);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(215, 8);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(45, 20);
            this.txtConsulta.TabIndex = 10;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            this.txtConsulta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConsulta_KeyDown);
            this.txtConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsulta_KeyPress);
            this.txtConsulta.Leave += new System.EventHandler(this.txtConsulta_Leave);
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(12, 11);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(199, 13);
            this.lblConsulta.TabIndex = 9;
            this.lblConsulta.Text = "Ingrese el Artículo que desea Consultar :";
            // 
            // sFBDDataSet
            // 
            this.sFBDDataSet.DataSetName = "SFBDDataSet";
            this.sFBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // depositoBindingSource
            // 
            this.depositoBindingSource.DataMember = "Deposito";
            this.depositoBindingSource.DataSource = this.sFBDDataSet;
            // 
            // depositoTableAdapter
            // 
            this.depositoTableAdapter.ClearBeforeFill = true;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.sFBDDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
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
            // rubroBindingSource
            // 
            this.rubroBindingSource.DataMember = "Rubro";
            this.rubroBindingSource.DataSource = this.sFBDDataSet;
            // 
            // rubroTableAdapter
            // 
            this.rubroTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(529, 350);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.gbDepositos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grbPrecios);
            this.Controls.Add(this.grbArticulo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.lblConsulta);
            this.Name = "frmConsultaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Artículos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaArticulo_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultaArticulo_Load);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.gbDepositos.ResumeLayout(false);
            this.gbDepositos.PerformLayout();
            this.grbPrecios.ResumeLayout(false);
            this.grbPrecios.PerformLayout();
            this.grbArticulo.ResumeLayout(false);
            this.grbArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloCategoriaCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelInfo;
        internal System.Windows.Forms.GroupBox gbDepositos;
        internal System.Windows.Forms.TextBox txtUStock;
        internal System.Windows.Forms.TextBox txtDeposito;
        internal System.Windows.Forms.TextBox txtStockSeguridad;
        internal System.Windows.Forms.TextBox txtNroDeposito;
        internal System.Windows.Forms.Label lblStockSeguridad;
        internal System.Windows.Forms.Label lblUStock;
        internal System.Windows.Forms.Label lblNroDeposito;
        internal System.Windows.Forms.Label lblDeposito;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnAceptar;
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
        internal System.Windows.Forms.TextBox txtRubro;
        internal System.Windows.Forms.TextBox txtDesc;
        internal System.Windows.Forms.TextBox txtCodArt;
        internal System.Windows.Forms.Label lblRubro;
        internal System.Windows.Forms.Label lblDescArticulo;
        internal System.Windows.Forms.Label lblCodArticulo;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.TextBox txtConsulta;
        internal System.Windows.Forms.Label lblConsulta;
        private SFDBDataSet sFBDDataSet;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private SFDBDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.BindingSource depositoBindingSource;
        private SFDBDataSetTableAdapters.DepositoTableAdapter depositoTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private SFDBDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource articuloCategoriaCBindingSource;
        private SFDBDataSetTableAdapters.ArticuloCategoriaCTableAdapter articuloCategoriaCTableAdapter;
        private System.Windows.Forms.BindingSource rubroBindingSource;
        private SFDBDataSetTableAdapters.RubroTableAdapter rubroTableAdapter;
    }
}