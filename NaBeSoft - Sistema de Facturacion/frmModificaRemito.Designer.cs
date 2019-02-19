namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmModificaRemito
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbDatosR = new System.Windows.Forms.GroupBox();
            this.txtFecRto = new System.Windows.Forms.TextBox();
            this.txtRtoN = new System.Windows.Forms.TextBox();
            this.lblFecRto = new System.Windows.Forms.Label();
            this.lblRtoN = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtImporteT = new System.Windows.Forms.TextBox();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.txtCodC = new System.Windows.Forms.TextBox();
            this.lblImporteT = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblRSocial = new System.Windows.Forms.Label();
            this.lblCodC = new System.Windows.Forms.Label();
            this.grbIngDatos = new System.Windows.Forms.GroupBox();
            this.dtpFecR = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFecR = new System.Windows.Forms.Label();
            this.txtNumR = new System.Windows.Forms.TextBox();
            this.lblNumR = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.clienteRemitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbDatosR.SuspendLayout();
            this.grbIngDatos.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteRemitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Location = new System.Drawing.Point(186, 221);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnModificar.MouseHover += new System.EventHandler(this.btnModificar_MouseHover);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(267, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // grbDatosR
            // 
            this.grbDatosR.Controls.Add(this.txtFecRto);
            this.grbDatosR.Controls.Add(this.txtRtoN);
            this.grbDatosR.Controls.Add(this.lblFecRto);
            this.grbDatosR.Controls.Add(this.lblRtoN);
            this.grbDatosR.Controls.Add(this.cmbEstado);
            this.grbDatosR.Controls.Add(this.txtImporteT);
            this.grbDatosR.Controls.Add(this.txtRSocial);
            this.grbDatosR.Controls.Add(this.txtCodC);
            this.grbDatosR.Controls.Add(this.lblImporteT);
            this.grbDatosR.Controls.Add(this.lblEstado);
            this.grbDatosR.Controls.Add(this.lblRSocial);
            this.grbDatosR.Controls.Add(this.lblCodC);
            this.grbDatosR.Location = new System.Drawing.Point(12, 90);
            this.grbDatosR.Name = "grbDatosR";
            this.grbDatosR.Size = new System.Drawing.Size(330, 125);
            this.grbDatosR.TabIndex = 6;
            this.grbDatosR.TabStop = false;
            this.grbDatosR.Text = "Datos del Remito";
            // 
            // txtFecRto
            // 
            this.txtFecRto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteRemitoBindingSource, "FechaR", true));
            this.txtFecRto.Location = new System.Drawing.Point(253, 71);
            this.txtFecRto.Name = "txtFecRto";
            this.txtFecRto.ReadOnly = true;
            this.txtFecRto.Size = new System.Drawing.Size(71, 20);
            this.txtFecRto.TabIndex = 7;
            this.txtFecRto.TabStop = false;
            this.txtFecRto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRtoN
            // 
            this.txtRtoN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteRemitoBindingSource, "NroRemito", true));
            this.txtRtoN.Location = new System.Drawing.Point(113, 71);
            this.txtRtoN.Name = "txtRtoN";
            this.txtRtoN.ReadOnly = true;
            this.txtRtoN.Size = new System.Drawing.Size(85, 20);
            this.txtRtoN.TabIndex = 5;
            this.txtRtoN.TabStop = false;
            // 
            // lblFecRto
            // 
            this.lblFecRto.AutoSize = true;
            this.lblFecRto.Location = new System.Drawing.Point(204, 74);
            this.lblFecRto.Name = "lblFecRto";
            this.lblFecRto.Size = new System.Drawing.Size(43, 13);
            this.lblFecRto.TabIndex = 6;
            this.lblFecRto.Text = "Fecha :";
            // 
            // lblRtoN
            // 
            this.lblRtoN.AutoSize = true;
            this.lblRtoN.Location = new System.Drawing.Point(6, 74);
            this.lblRtoN.Name = "lblRtoN";
            this.lblRtoN.Size = new System.Drawing.Size(101, 13);
            this.lblRtoN.TabIndex = 4;
            this.lblRtoN.Text = "Número de Remito :";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteRemitoBindingSource, "Estado", true));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Anulado",
            "Debe",
            "Pagado"});
            this.cmbEstado.Location = new System.Drawing.Point(225, 97);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(99, 21);
            this.cmbEstado.TabIndex = 11;
            this.cmbEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEstado_KeyDown);
            this.cmbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumR_KeyPress);
            this.cmbEstado.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.cmbEstado.MouseHover += new System.EventHandler(this.cmbEstado_MouseHover);
            // 
            // txtImporteT
            // 
            this.txtImporteT.Location = new System.Drawing.Point(113, 97);
            this.txtImporteT.Name = "txtImporteT";
            this.txtImporteT.ReadOnly = true;
            this.txtImporteT.Size = new System.Drawing.Size(54, 20);
            this.txtImporteT.TabIndex = 9;
            this.txtImporteT.TabStop = false;
            // 
            // txtRSocial
            // 
            this.txtRSocial.Location = new System.Drawing.Point(113, 45);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.ReadOnly = true;
            this.txtRSocial.Size = new System.Drawing.Size(211, 20);
            this.txtRSocial.TabIndex = 3;
            this.txtRSocial.TabStop = false;
            // 
            // txtCodC
            // 
            this.txtCodC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteRemitoBindingSource, "CodCliente", true));
            this.txtCodC.Location = new System.Drawing.Point(113, 19);
            this.txtCodC.Name = "txtCodC";
            this.txtCodC.ReadOnly = true;
            this.txtCodC.Size = new System.Drawing.Size(85, 20);
            this.txtCodC.TabIndex = 1;
            this.txtCodC.TabStop = false;
            // 
            // lblImporteT
            // 
            this.lblImporteT.AutoSize = true;
            this.lblImporteT.Location = new System.Drawing.Point(6, 100);
            this.lblImporteT.Name = "lblImporteT";
            this.lblImporteT.Size = new System.Drawing.Size(75, 13);
            this.lblImporteT.TabIndex = 8;
            this.lblImporteT.Text = "Importe Total :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(173, 100);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 13);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado :";
            // 
            // lblRSocial
            // 
            this.lblRSocial.AutoSize = true;
            this.lblRSocial.Location = new System.Drawing.Point(6, 48);
            this.lblRSocial.Name = "lblRSocial";
            this.lblRSocial.Size = new System.Drawing.Size(76, 13);
            this.lblRSocial.TabIndex = 2;
            this.lblRSocial.Text = "Razón Social :";
            // 
            // lblCodC
            // 
            this.lblCodC.AutoSize = true;
            this.lblCodC.Location = new System.Drawing.Point(6, 22);
            this.lblCodC.Name = "lblCodC";
            this.lblCodC.Size = new System.Drawing.Size(96, 13);
            this.lblCodC.TabIndex = 0;
            this.lblCodC.Text = "Código de Cliente :";
            // 
            // grbIngDatos
            // 
            this.grbIngDatos.Controls.Add(this.dtpFecR);
            this.grbIngDatos.Controls.Add(this.btnBuscar);
            this.grbIngDatos.Controls.Add(this.lblFecR);
            this.grbIngDatos.Controls.Add(this.txtNumR);
            this.grbIngDatos.Controls.Add(this.lblNumR);
            this.grbIngDatos.Location = new System.Drawing.Point(12, 6);
            this.grbIngDatos.Name = "grbIngDatos";
            this.grbIngDatos.Size = new System.Drawing.Size(330, 78);
            this.grbIngDatos.TabIndex = 5;
            this.grbIngDatos.TabStop = false;
            this.grbIngDatos.Text = "Ingreso de Datos";
            // 
            // dtpFecR
            // 
            this.dtpFecR.CustomFormat = "";
            this.dtpFecR.Location = new System.Drawing.Point(113, 45);
            this.dtpFecR.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpFecR.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFecR.Name = "dtpFecR";
            this.dtpFecR.Size = new System.Drawing.Size(211, 20);
            this.dtpFecR.TabIndex = 3;
            this.dtpFecR.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.dtpFecR.MouseHover += new System.EventHandler(this.dtpFecR_MouseHover);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(249, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnBuscar.MouseHover += new System.EventHandler(this.btnBuscar_MouseHover);
            // 
            // lblFecR
            // 
            this.lblFecR.AutoSize = true;
            this.lblFecR.Location = new System.Drawing.Point(6, 50);
            this.lblFecR.Name = "lblFecR";
            this.lblFecR.Size = new System.Drawing.Size(96, 13);
            this.lblFecR.TabIndex = 2;
            this.lblFecR.Text = "Fecha del Remito :";
            // 
            // txtNumR
            // 
            this.txtNumR.Location = new System.Drawing.Point(113, 19);
            this.txtNumR.Name = "txtNumR";
            this.txtNumR.Size = new System.Drawing.Size(85, 20);
            this.txtNumR.TabIndex = 1;
            this.txtNumR.TextChanged += new System.EventHandler(this.txtNumR_TextChanged);
            this.txtNumR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumR_KeyDown);
            this.txtNumR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumR_KeyPress);
            // 
            // lblNumR
            // 
            this.lblNumR.AutoSize = true;
            this.lblNumR.Location = new System.Drawing.Point(6, 22);
            this.lblNumR.Name = "lblNumR";
            this.lblNumR.Size = new System.Drawing.Size(101, 13);
            this.lblNumR.TabIndex = 0;
            this.lblNumR.Text = "Número de Remito :";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelInfo});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 253);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(354, 22);
            this.StatusStrip1.TabIndex = 9;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabelInfo
            // 
            this.ToolStripStatusLabelInfo.Name = "ToolStripStatusLabelInfo";
            this.ToolStripStatusLabelInfo.Size = new System.Drawing.Size(19, 17);
            this.ToolStripStatusLabelInfo.Text = "    ";
            // 
            // clienteRemitoBindingSource
            // 
            this.clienteRemitoBindingSource.DataMember = "ClienteRemito";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            // 
            // remitoBindingSource
            // 
            this.remitoBindingSource.DataMember = "Remito";
            // 
            // frmModificaRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 275);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbDatosR);
            this.Controls.Add(this.grbIngDatos);
            this.Controls.Add(this.StatusStrip1);
            this.Name = "frmModificaRemito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación de estado de Remitos";
            this.Load += new System.EventHandler(this.frmModificaRemito_Load);
            this.grbDatosR.ResumeLayout(false);
            this.grbDatosR.PerformLayout();
            this.grbIngDatos.ResumeLayout(false);
            this.grbIngDatos.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteRemitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remitoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnModificar;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.GroupBox grbDatosR;
        internal System.Windows.Forms.TextBox txtFecRto;
        internal System.Windows.Forms.TextBox txtRtoN;
        internal System.Windows.Forms.Label lblFecRto;
        internal System.Windows.Forms.Label lblRtoN;
        internal System.Windows.Forms.ComboBox cmbEstado;
        internal System.Windows.Forms.TextBox txtImporteT;
        internal System.Windows.Forms.TextBox txtRSocial;
        internal System.Windows.Forms.TextBox txtCodC;
        internal System.Windows.Forms.Label lblImporteT;
        internal System.Windows.Forms.Label lblEstado;
        internal System.Windows.Forms.Label lblRSocial;
        internal System.Windows.Forms.Label lblCodC;
        internal System.Windows.Forms.GroupBox grbIngDatos;
        internal System.Windows.Forms.DateTimePicker dtpFecR;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.Label lblFecR;
        internal System.Windows.Forms.TextBox txtNumR;
        internal System.Windows.Forms.Label lblNumR;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelInfo;
        private System.Windows.Forms.BindingSource clienteRemitoBindingSource;
        private System.Windows.Forms.BindingSource remitoBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource;
    }
}