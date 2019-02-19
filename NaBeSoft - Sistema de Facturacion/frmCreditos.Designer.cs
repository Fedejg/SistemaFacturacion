namespace NaBeSoft___Sistema_de_Facturacion
{
    partial class frmCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreditos));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblFacultad = new System.Windows.Forms.Label();
            this.btmAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(12, 9);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(61, 67);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 15;
            this.PictureBox1.TabStop = false;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(12, 158);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(267, 14);
            this.lblAutor.TabIndex = 14;
            this.lblAutor.Text = "GRAMAJO, Federico Javier - Legajo: 24296";
            // 
            // lblNota
            // 
            this.lblNota.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblNota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNota.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(12, 192);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(251, 72);
            this.lblNota.TabIndex = 13;
            this.lblNota.Text = "NaBeSoft Software Solutions y Sistema de Facturación® son propiedad exclusiva de " +
    "Federico Javier Gramajo. Todos los derechos de propiedad intelectual Reservados." +
    " Copyright © 2018 NaBeSoft.";
            // 
            // lblFacultad
            // 
            this.lblFacultad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFacultad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFacultad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFacultad.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultad.ForeColor = System.Drawing.Color.Blue;
            this.lblFacultad.Location = new System.Drawing.Point(79, 9);
            this.lblFacultad.Name = "lblFacultad";
            this.lblFacultad.Size = new System.Drawing.Size(323, 67);
            this.lblFacultad.TabIndex = 12;
            this.lblFacultad.Text = "Universidad Tecnológica Nacional Facultad Regional Tucumán";
            this.lblFacultad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btmAceptar
            // 
            this.btmAceptar.Location = new System.Drawing.Point(327, 241);
            this.btmAceptar.Name = "btmAceptar";
            this.btmAceptar.Size = new System.Drawing.Size(75, 23);
            this.btmAceptar.TabIndex = 11;
            this.btmAceptar.Text = "Aceptar";
            this.btmAceptar.UseVisualStyleBackColor = true;
            this.btmAceptar.Click += new System.EventHandler(this.btmAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-687, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lime;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(390, 62);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 273);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblFacultad);
            this.Controls.Add(this.btmAceptar);
            this.Name = "frmCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créditos";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label lblAutor;
        internal System.Windows.Forms.Label lblNota;
        internal System.Windows.Forms.Label lblFacultad;
        internal System.Windows.Forms.Button btmAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}