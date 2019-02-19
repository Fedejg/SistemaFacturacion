namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmAltaPago
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblFecIn = new System.Windows.Forms.Label();
            this.txtFecIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.lvFactura = new System.Windows.Forms.ListView();
            this.columnFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDebe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHaber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFecVto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtHaber = new System.Windows.Forms.TextBox();
            this.txtDebe = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNuevoVto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.sFDBDataSet = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.ClienteTableAdapter();
            this.pagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagoTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.PagoTableAdapter();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidadTableAdapter = new NaBeSoft___Sistema_de_Facturacion.SFDBDataSetTableAdapters.LocalidadTableAdapter();
            this.gbCliente.SuspendLayout();
            this.gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtDireccion);
            this.gbCliente.Controls.Add(this.txtLocalidad);
            this.gbCliente.Controls.Add(this.txtRSocial);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.txtFecIn);
            this.gbCliente.Controls.Add(this.lblFecIn);
            this.gbCliente.Controls.Add(this.cmbCliente);
            this.gbCliente.Controls.Add(this.lblCliente);
            this.gbCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(485, 134);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Cliente";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 29);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente :";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(57, 26);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(238, 21);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectionChangeCommitted += new System.EventHandler(this.cmbCliente_SelectionChangeCommitted);
            this.cmbCliente.TextChanged += new System.EventHandler(this.cmbCliente_TextChanged);
            // 
            // lblFecIn
            // 
            this.lblFecIn.AutoSize = true;
            this.lblFecIn.Location = new System.Drawing.Point(301, 29);
            this.lblFecIn.Name = "lblFecIn";
            this.lblFecIn.Size = new System.Drawing.Size(77, 13);
            this.lblFecIn.TabIndex = 2;
            this.lblFecIn.Text = "Cliente desde :";
            // 
            // txtFecIn
            // 
            this.txtFecIn.Location = new System.Drawing.Point(384, 26);
            this.txtFecIn.Name = "txtFecIn";
            this.txtFecIn.ReadOnly = true;
            this.txtFecIn.Size = new System.Drawing.Size(70, 20);
            this.txtFecIn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Razón Social :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Localidad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Domicilio :";
            // 
            // txtRSocial
            // 
            this.txtRSocial.Location = new System.Drawing.Point(88, 53);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.ReadOnly = true;
            this.txtRSocial.Size = new System.Drawing.Size(297, 20);
            this.txtRSocial.TabIndex = 5;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(88, 79);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ReadOnly = true;
            this.txtLocalidad.Size = new System.Drawing.Size(297, 20);
            this.txtLocalidad.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(88, 105);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(391, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // gbFactura
            // 
            this.gbFactura.Controls.Add(this.btnAceptar);
            this.gbFactura.Controls.Add(this.btnCancelar);
            this.gbFactura.Controls.Add(this.txtNuevoVto);
            this.gbFactura.Controls.Add(this.label7);
            this.gbFactura.Controls.Add(this.label6);
            this.gbFactura.Controls.Add(this.label5);
            this.gbFactura.Controls.Add(this.label4);
            this.gbFactura.Controls.Add(this.txtSaldo);
            this.gbFactura.Controls.Add(this.txtDebe);
            this.gbFactura.Controls.Add(this.txtHaber);
            this.gbFactura.Controls.Add(this.lvFactura);
            this.gbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFactura.Location = new System.Drawing.Point(12, 152);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(485, 273);
            this.gbFactura.TabIndex = 1;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Facturas";
            // 
            // lvFactura
            // 
            this.lvFactura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFactura,
            this.columnDebe,
            this.columnHaber,
            this.columnSaldo,
            this.columnEstado,
            this.columnFecVto});
            this.lvFactura.FullRowSelect = true;
            this.lvFactura.GridLines = true;
            this.lvFactura.Location = new System.Drawing.Point(6, 19);
            this.lvFactura.Name = "lvFactura";
            this.lvFactura.Size = new System.Drawing.Size(473, 170);
            this.lvFactura.TabIndex = 0;
            this.lvFactura.UseCompatibleStateImageBehavior = false;
            this.lvFactura.View = System.Windows.Forms.View.Details;
            this.lvFactura.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvFactura_ItemSelectionChanged);
            this.lvFactura.DoubleClick += new System.EventHandler(this.lvFactura_DoubleClick);
            // 
            // columnFactura
            // 
            this.columnFactura.Text = "Factura Nº";
            this.columnFactura.Width = 126;
            // 
            // columnDebe
            // 
            this.columnDebe.Text = "Debe";
            this.columnDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // columnEstado
            // 
            this.columnEstado.Text = "Estado";
            this.columnEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnEstado.Width = 84;
            // 
            // columnFecVto
            // 
            this.columnFecVto.Text = "Vence";
            this.columnFecVto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFecVto.Width = 77;
            // 
            // txtHaber
            // 
            this.txtHaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHaber.Location = new System.Drawing.Point(100, 221);
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.Size = new System.Drawing.Size(100, 20);
            this.txtHaber.TabIndex = 8;
            this.txtHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHaber.Leave += new System.EventHandler(this.txtHaber_Leave);
            // 
            // txtDebe
            // 
            this.txtDebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebe.Location = new System.Drawing.Point(100, 195);
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.ReadOnly = true;
            this.txtDebe.Size = new System.Drawing.Size(100, 20);
            this.txtDebe.TabIndex = 5;
            this.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(100, 247);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.ShortcutsEnabled = false;
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 6;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Debe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Importe a Pagar :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Saldo :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Su proximo vencimiento de Pago es : ";
            // 
            // txtNuevoVto
            // 
            this.txtNuevoVto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNuevoVto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNuevoVto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoVto.Location = new System.Drawing.Point(397, 208);
            this.txtNuevoVto.Name = "txtNuevoVto";
            this.txtNuevoVto.ReadOnly = true;
            this.txtNuevoVto.Size = new System.Drawing.Size(83, 20);
            this.txtNuevoVto.TabIndex = 7;
            this.txtNuevoVto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(404, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(323, 240);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            // pagoBindingSource
            // 
            this.pagoBindingSource.DataMember = "Pago";
            this.pagoBindingSource.DataSource = this.sFDBDataSet;
            // 
            // pagoTableAdapter
            // 
            this.pagoTableAdapter.ClearBeforeFill = true;
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
            // frmAltaPago
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(509, 436);
            this.Controls.Add(this.gbFactura);
            this.Controls.Add(this.gbCliente);
            this.Name = "frmAltaPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar pago de Facturas";
            this.Load += new System.EventHandler(this.frmAltaPago_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtRSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFecIn;
        private System.Windows.Forms.Label lblFecIn;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNuevoVto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtDebe;
        private System.Windows.Forms.TextBox txtHaber;
        private System.Windows.Forms.ListView lvFactura;
        private System.Windows.Forms.ColumnHeader columnFactura;
        private System.Windows.Forms.ColumnHeader columnDebe;
        private System.Windows.Forms.ColumnHeader columnHaber;
        private System.Windows.Forms.ColumnHeader columnSaldo;
        private System.Windows.Forms.ColumnHeader columnEstado;
        private System.Windows.Forms.ColumnHeader columnFecVto;
        private SFDBDataSet sFDBDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SFDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource pagoBindingSource;
        private SFDBDataSetTableAdapters.PagoTableAdapter pagoTableAdapter;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private SFDBDataSetTableAdapters.LocalidadTableAdapter localidadTableAdapter;
    }
}