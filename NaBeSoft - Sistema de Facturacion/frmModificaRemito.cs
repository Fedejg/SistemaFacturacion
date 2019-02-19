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
    public partial class frmModificaRemito : Form
    {
        private bool Bandera = false;

        public frmModificaRemito()
        {
            InitializeComponent();
        }

        private void frmModificaRemito_Load(object sender, EventArgs e)
        {
            //Inicialmente el estado del Remito, el boton buscar y aceptar estan deshabilitados hasta que se introduzcan los datos del Remito.
            cmbEstado.Enabled = false;
            btnBuscar.Enabled = false;
            btnModificar.Enabled = false;
            CargarTablas();
        }

            private void CargarTablas()
	    {
		    //this.clienteTableAdapter1.Fill(this.scDataBaseDataSet1.Cliente);
		    //this.remitoTableAdapter1.Fill(this.scDataBaseDataSet1.Remito);
	    }
	    //---
        private void txtNumR_KeyDown(object sender, KeyEventArgs e)
        {
    
            //Inicializo la bandera en false
            Bandera = false;
            //Determino si la tecla presionada NO es un numero de la parte superior del teclado.
            //Si el Ascii presionado es < 48 o > 57
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
            //Determino si la tecla presionada NO es un numero del keypad
            //Si el Ascii presionado es < 96 o > 105
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    //Determino si la tecla presionada NO es backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        //Si estas 3 condiciones negadas se cumplen, entonces el usuario presiono una tecla no numerica, y se cambia el valor de la bandera a Verdadero.
                        Bandera = true;
                    }
                }
            }
        }
        private void txtNumR_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evaluo el estado de la bandera proveniente del evento KeyDown
            if (Bandera == true)
            {
                //Detengo el ingreso del caracter en el control si la tecla presionada es no numerica.
                e.Handled = true;
            }
        }

        private void txtNumR_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNumR.Text == null)
            {
                this.Cursor = Cursors.Default;
                this.btnBuscar.Enabled = false;
            }
            else
            {
                this.Cursor = Cursors.Default;
                this.btnBuscar.Enabled = true;
            }
        }

	    private void txtNumR_Leave(object sender, System.EventArgs e)
	    {
		    if (this.txtNumR.Text != null)
            {
			    //decimal NumeroR = this.txtNumR.Text;
			    //this.txtNumR.Text = Strings.Format(NumeroR, "000000000000");
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
                this.cmbEstado.Enabled = true;
                this.btnModificar.Enabled = true;
                this.cmbEstado.Select();
            }
            else
            {
                this.txtNumR.Select();
            }
            this.btnBuscar.Cursor = Cursors.Default;
        }

	    private bool ConsultarDatos()
	    {
            string Codigo;
		    string NroRto = this.txtNumR.Text;
		    string Fecha = this.dtpFecR.Text;
            decimal NRTO = Convert.ToDecimal(NroRto);
            DateTime FEC = Convert.ToDateTime(Fecha);
            int Respuesta = 0;// this.clienteRemitoTableAdapter1.FillByNroRtoFecRto(this.scDataBaseDataSet1.ClienteRemito, NRTO, FEC);
            if (Respuesta >= 1)
            {
                Codigo = this.txtCodC.Text;
                //this.txtCodC.Text = Strings.Format(Codigo, "0000");
                //NumR = this.txtRtoN.Text;
                //this.txtRtoN.Text = Strings.Format(NumR, "0000-00000000");
                this.txtRSocial.Text = ObtenerRSocial(Codigo);
                this.txtImporteT.Text = ObtenerImporteT(NroRto, FEC);
                return true;
            }
            else
            {
                MessageBox.Show("El Remito no existe en la Base de Datos. Error ", "Sistema de Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.cmbEstado.Enabled = false;
                this.btnModificar.Enabled = false;
                this.txtRSocial.Text = null;
                this.txtImporteT.Text = null;
                return false; 
            }
	    }

	    private string ObtenerRSocial(string Codigo)
	    {
		    string Cadena = null;
		    /*foreach (DataRow Fila in this.scDataBaseDataSet1.Cliente)
            {
			    if (Fila["CodCliente"].ToString() == Codigo) 
                {
				    Cadena = Fila["RSocial"].ToString();
				    break; 
			    }
		    }*/
		    return Cadena;
	    }

	    private string ObtenerImporteT(string NroRto, DateTime Fecha)
	    {
            string Importe="";
		    /*foreach (DataRow Fila in this.scDataBaseDataSet1.Remito)
            {
			    if (Fila["NroRemito"].ToString() == NroRto)
                {
				    if (Convert.ToDateTime(Fila["FechaR"].ToString()) == Fecha)
                    {
					    Importe = Fila["Importe"].ToString();
					    break;
				    }
			    }
		    }*/
		    return Importe;
	    }
	    //---
        private void cmbEstado_KeyDown(object sender, KeyEventArgs e)
        {
            //Inicializo la bandera en false
           Bandera = false;
            if (e.KeyCode < Keys.Left || e.KeyCode > Keys.Down)
            {
                Bandera = true;
            }
        }
	    //---
        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.btnModificar.Cursor = Cursors.WaitCursor;
            if (MessageBox.Show("Se modificara el estado del Remito, seguro desea continuar?", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                ModificarEstado();
                if (MessageBox.Show("El estado del Remito fue modificado en la Base de Datos con Exito!!. Desea modificar el estado de otro Remito?", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    LimpiarControles();
                    this.btnModificar.Enabled = false;
                    this.btnModificar.Cursor = Cursors.Hand;
                    this.txtNumR.Select();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.btnModificar.Cursor = Cursors.Hand;
            }
        } 

	    private void ModificarEstado()
	    {
		    decimal NroRto = Convert.ToDecimal(this.txtNumR.Text);
		    DateTime Fecha = Convert.ToDateTime(this.dtpFecR.Text);
		    decimal CodCliente = Convert.ToDecimal(this.txtCodC.Text);
		    //this.clienteRemitoTableAdapter1.ModificarEstadoRemito(this.cmbEstado.Text, NroRto, Fecha, CodCliente);
	    }

	    private void LimpiarControles()
	    {
		    txtNumR.Text = null;
		    foreach (Control c in this.grbDatosR.Controls)
            {
			    if (c is Label)
                {
				    c.Text = null;
			    }
		    }
	    }
	    //---
	    
	    //---
	    //Estos procedimientos muestran informacion acerca de los controles
	    //Botones

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Busca el Remito especificado en la Base de Datos.";
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Modifica el estado del Remito en la Base de Datos.";
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cierra el formulario de Modificación de Estado de Remito.";
        }

        private void cmbEstado_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cambia el estado del Remito de la seleccion.";
        }

        private void dtpFecR_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cambia la fecha de la seleccion.";
        }
    }
}
