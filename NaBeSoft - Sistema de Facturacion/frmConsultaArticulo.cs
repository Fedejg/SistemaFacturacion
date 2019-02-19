using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaBeSoft___Sistema_de_Facturacion
{
    public partial class frmConsultaArticulo : Form
    {
        private bool Bandera = false;
        public frmConsultaArticulo()
        {
            InitializeComponent();
        }

        private void frmConsultaArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sFBDDataSet.Rubro' Puede moverla o quitarla según sea necesario.
            this.rubroTableAdapter.Fill(this.sFBDDataSet.Rubro);
            this.btnBuscar.Enabled = false;
            this.btnAceptar.Enabled = false;
        }

        //---
	    private void txtConsulta_KeyDown(object sender, KeyEventArgs e)
        {
            Bandera = false;
		    //Si el Ascii presionado es < 48 o > 57
		    if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) {
			    //Si el Ascii presionado es < 96 o > 105
			    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) {
				    if (e.KeyCode != Keys.Back) {
					    Bandera = true;
				    }
			    }
		    }
        }
	
        private void txtConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Bandera == true)
            {
			    e.Handled = true;
		    }
        }
	    
        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            //Se activa o desactiva los botones Consulta y Aceptar como validacion de que el usuario ingreso un codigo para consultar.
		    if (txtConsulta.Text != null) 
            {
			    this.Cursor = Cursors.Default;
			    this.btnBuscar.Enabled = true;
		    } 
            else 
            {
			    this.Cursor = Cursors.Default;
			    this.btnBuscar.Enabled = false;
			    this.btnAceptar.Enabled = false;
			    LimpiarControles();
		    }
        }

	    public void LimpiarControles()
	    {
		    //Con este ciclo se limpian todos los Textbox del GrupBox Articulo.
		    foreach (Control c in this.grbArticulo.Controls)
            {
			    if (c is TextBox) 
                {
				    c.Text = null;
			    }
		    }
		    foreach (Control c in this.gbDepositos.Controls)
            {
			    if (c is TextBox) 
                {
				    c.Text = null;
			    }
		    }
		    //Con este ciclo se limpian los Textbox del GrupBox Precios.
		    foreach (Control c in this.grbPrecios.Controls) 
            {
			    if (c is TextBox)
                {
				    c.Text = null;
			    }
		    }
	    }

         private void txtConsulta_Leave(object sender, EventArgs e)
        {
            if (this.txtConsulta.Text != "") 
            {
			    int Codigo = int.Parse(this.txtConsulta.Text);
                this.txtConsulta.Text = Codigo.ToString("0000");
		    }
        }
	    //---
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool Respuesta = false;
		    this.btnBuscar.Cursor = Cursors.WaitCursor;
		    Respuesta = ConsultarDatos();
		    if (Respuesta == true) 
            {
			    this.btnAceptar.Enabled = true;
			    this.btnAceptar.Select();
		    } 
            else
            {
                MessageBox.Show("El Artículo no existe en la Base de Datos", "Sistema de Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.txtConsulta.Select();
		    }
		    this.btnBuscar.Cursor = Cursors.Hand;
        }

	    public bool ConsultarDatos()
	    {
		    //Asigno el valor ingresado a la variable codigo, la cual es parametro para realizar las consultas en la DBDim Codigo As Integer
		    int Codigo = int.Parse(txtConsulta.Text);
		    int Rubro = 0;
		    int NroDepos = 0;
            bool Bandera = false;
		    try 
            {
                this.stockTableAdapter.Fill(this.sFBDDataSet.Stock);
                this.depositoTableAdapter.Fill(this.sFBDDataSet.Deposito);
                this.articuloTableAdapter.FillByArticulo(this.sFBDDataSet.Articulo, Codigo);
                foreach (DataRow Fila in this.sFBDDataSet.Articulo)
                {
                    Bandera = true;
                    int Cod=int.Parse(Fila["IdArticulo"].ToString());
                    txtCodArt.Text = Cod.ToString("0000");
                    txtDesc.Text = Fila["Descripcion"].ToString();
                    Rubro = int.Parse(Fila["IdRubro"].ToString());
                }
                foreach(DataRow Fila in this.sFBDDataSet.Rubro)
                {
                    if(Rubro==int.Parse(Fila["IdRubro"].ToString()))
                    {
                        txtRubro.Text = Fila["Descripcion"].ToString();
                        break;
                    }
                }
                foreach (DataRow Fila in this.sFBDDataSet.Stock)
                {
				    if (Codigo == int.Parse(Fila["IdArticulo"].ToString()))
                    {
					    this.txtUStock.Text = Fila["UnidadStock"].ToString();
					    this.txtStockSeguridad.Text = Fila["StockSeguridad"].ToString();
					    NroDepos = int.Parse(Fila["IdDeposito"].ToString());
					    break; 
				    }
			    }
			    foreach (DataRow Fila in this.sFBDDataSet.Deposito)
                {
				    if (NroDepos == int.Parse(Fila["IdDeposito"].ToString()))
                    {
					    this.txtDeposito.Text = Fila["Nombre"].ToString();
					    this.txtNroDeposito.Text = NroDepos.ToString("00");
					    break;
				    }
			    }
			    this.articuloCategoriaCTableAdapter.FillByArticulo(this.sFBDDataSet.ArticuloCategoriaC, Codigo);
			    foreach (DataRow Fila in this.sFBDDataSet.ArticuloCategoriaC)
                {
				    switch (Fila["IdCategoriaC"].ToString()) 
                    {
					    case "1":
                                this.txtPrecioEsp.Text = Fila["Precio"].ToString();
                                //this.txtPrecioEsp.Text = Strings.Format(Fila("Precio"), "#,##0.00");
						        break;
					    case "2":
                                this.txtPrecioMin.Text = Fila["Precio"].ToString();
                                //this.txtPrecioEst.Text = Strings.Format(Fila("Precio"), "#,##0.00");
						        break;
					    case "3":
                                this.txtPrecioFra.Text = Fila["Precio"].ToString();
                                //this.txtPrecioFra.Text = Strings.Format(Fila("Precio"), "#,##0.00");
						        break;
					    case "4":
                                this.txtPrecioMay.Text = Fila["Precio"].ToString();
                                //this.txtPrecioMay.Text = Strings.Format(Fila("Precio"), "#,##0.00");
						        break;
				    }
			    }
                return Bandera;
		    } catch (Exception ex) 
            {
			    LimpiarControles();
			    MessageBox.Show("Error "+ex.Message, "Sistema de Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			    return Bandera;
		    }
	    }
	    //---
	    private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	    //---
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
		    this.Dispose();
        }
	    //---
	    private void frmConsultaArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea consultar los datos de otro Artículo?", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
			    e.Cancel = true;
			    LimpiarControles();
			    this.txtConsulta.Text = null;
			    this.txtConsulta.Select();
		    }
        }
	    //---
	    //Estos procedimientos muestran informacion acerca de los controles
        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Realiza una consulta en la Base de Datos.";
        }

         private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        } 
	
        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Termina la consulta del Artículo.";
        }
         private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cierra el formulario de consulta de Artículos.";
        }
    }
}
