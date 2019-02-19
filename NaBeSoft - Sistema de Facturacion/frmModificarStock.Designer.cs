namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmModificarStock
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
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.sFDBDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ArticuloTableAdapter();
            this.rubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubroTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.RubroTableAdapter();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.StockTableAdapter();
            this.ColumnIdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStockSeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToOrderColumns = true;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdArticulo,
            this.ColumnDescripcion,
            this.ColumnStockSeg,
            this.ColumnStock});
            this.dgvStock.Location = new System.Drawing.Point(12, 12);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(546, 419);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellEndEdit);
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
            // rubroBindingSource
            // 
            this.rubroBindingSource.DataMember = "Rubro";
            this.rubroBindingSource.DataSource = this.sFDBDataSet;
            // 
            // rubroTableAdapter
            // 
            this.rubroTableAdapter.ClearBeforeFill = true;
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
            // ColumnIdArticulo
            // 
            this.ColumnIdArticulo.Frozen = true;
            this.ColumnIdArticulo.HeaderText = "Artículo";
            this.ColumnIdArticulo.Name = "ColumnIdArticulo";
            this.ColumnIdArticulo.ReadOnly = true;
            this.ColumnIdArticulo.Width = 50;
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.Frozen = true;
            this.ColumnDescripcion.HeaderText = "Descripción";
            this.ColumnDescripcion.Name = "ColumnDescripcion";
            this.ColumnDescripcion.ReadOnly = true;
            this.ColumnDescripcion.Width = 250;
            // 
            // ColumnStockSeg
            // 
            this.ColumnStockSeg.Frozen = true;
            this.ColumnStockSeg.HeaderText = "Stock Seg.";
            this.ColumnStockSeg.Name = "ColumnStockSeg";
            // 
            // ColumnStock
            // 
            this.ColumnStock.Frozen = true;
            this.ColumnStock.HeaderText = "Stock";
            this.ColumnStock.Name = "ColumnStock";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(403, 437);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(484, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmModificarStock
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(571, 466);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvStock);
            this.MaximizeBox = false;
            this.Name = "frmModificarStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Stock de Artículos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmModificarStock_FormClosing);
            this.Load += new System.EventHandler(this.frmModificarStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private SFDBDataSet sFDBDataSet;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private SFDBDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.BindingSource rubroBindingSource;
        private SFDBDataSetTableAdapters.RubroTableAdapter rubroTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private SFDBDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockSeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}