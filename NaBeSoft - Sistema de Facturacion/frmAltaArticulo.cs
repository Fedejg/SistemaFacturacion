using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NaBeSoft___Sistema_de_Facturacion
{
    public partial class frmAltaArticulo : Form
    {
        private decimal Codigo;
        private int Rubro;
        private int NDepos;
        private string Cadena;
        private bool Bandera = false;
        //private string Control = null;
        //private int Valor;
        TextBox Actual;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CargarTablas();
            CargarComboRubro();
            CargarComboDeposito();
        }

        private void CargarTablas()
        {
            try
            {
                this.rubroTableAdapter.Fill(this.sFDBDataSet.Rubro); 
                this.depositoTableAdapter.Fill(this.sFDBDataSet.Deposito);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarComboRubro()
        { 
            foreach(DataRow Fila in this.sFDBDataSet.Rubro)
            {
                this.cmbRubro.Items.Add(Fila["Descripcion"].ToString());
            }
        }

        private void CargarComboDeposito()
        {
            foreach (DataRow Fila in this.sFDBDataSet.Deposito)
            {
                this.cmbDeposito.Items.Add(Fila["Nombre"].ToString());
            }
        }
        //---
        private void cmbRubro_KeyDown(object sender, KeyEventArgs e)
        {
            //Este procedimiento valida y no permite el ingreso de algun caracter en el combo
            if (e.KeyCode < Keys.Left || e.KeyCode > Keys.Down)
            {
                Bandera = true;
            }
        }

        private void cmbRubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Este procedimiento cancela el ingreso del caracter validado en el proceso keydown
            if (Bandera == true)
            {
                e.Handled = true;
            }
        }
        //---
        private void cmbRubro_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmbRubro_TextChanged(object sender, EventArgs e)
        {
            foreach (DataRow Fila in this.sFDBDataSet.Rubro)
            {
                string Cadena = Fila["Descripcion"].ToString();
                string Cadena2 = this.cmbRubro.SelectedItem.ToString();
                if (Cadena==Cadena2)
                {
                    Rubro = int.Parse(Fila["IdRubro"].ToString());
                    break;
                }
            }
        }

        private void cmbDeposito_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cmbDeposito.Text == null)
            {
                this.txtNroDeposito.Text = null;
            }
        }

        private void cmbDeposito_TextChanged(object sender, EventArgs e)
        {
            foreach (DataRow Fila in this.sFDBDataSet.Deposito)
            {
                string Cadena=Fila["Nombre"].ToString();
                string Cadena2=this.cmbDeposito.SelectedItem.ToString();
                if (Cadena==Cadena2)
                {
                    this.txtNroDeposito.Text = Fila["IdDeposito"].ToString();
                    NDepos = int.Parse(Fila["IdDeposito"].ToString());
                    break;
                }
            }
        }
        //---
        private void txtStockSeguridad_KeyDown(object sender, KeyEventArgs e)
        {
            Bandera = false;
            //Si el Ascii presionado es < 48 o > 57
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                //Si el Ascii presionado es < 96 o > 105
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        if (e.KeyCode != Keys.Decimal)
                        {
                            Bandera = true;
                        }
                    }
                }
            }
        }
        //---
        private void txtPrecioEsp_Leave(object sender, EventArgs e)
        {
            //Este procedimiento le da un formato al precio ingresado en el campo, y genera la validacion del campo.
            Actual = (TextBox)sender;
            if (this.btnCancelar.Focused == false)
            {
                if (Actual.Text != "")
                {
                    Cadena = Actual.Text;
                    Actual.Text = Cadena.Replace('.', ',');
                    Codigo = Convert.ToDecimal(Actual.Text);
                    //this.txtPrecioEsp.Text = Strings.Format(Codigo, "#,##0.00");
                }
            }
        }
        //---
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Este procedimiento permite que se realicen los procedimiento necesarios sobre la DB, y muestra un mensaje si no hubo error
            bool Respuesta = false;
            Respuesta = ValidarDatosArticulo();
            if (Respuesta == true)
            {
                return;
            }
            this.btnGuardar.Cursor = Cursors.WaitCursor;
            GuardarDatos();
            this.btnGuardar.Cursor = Cursors.Hand;
            MessageBox.Show("El Artículo fue guardado con Exito!", "Sistema de Facturación", MessageBoxButtons.OK);
            LimpiarCampos();
        }

        private bool ValidarDatosArticulo()
        {
            bool functionReturnValue = false;
            if (this.txtDesc.Text=="")
            {
                MessageBox.Show("Debe Ingresar la descripción del Artículo antes de continuar.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.txtDesc.Select();
                return functionReturnValue=true;
            }
            if (this.cmbRubro.Text == "" || this.cmbRubro.Text == "Seleccione uno...")
            {
                MessageBox.Show("Debe Seleccionar el Rubro del Artículo antes de continuar.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.cmbRubro.Select();
                return functionReturnValue=true;
            }
            if (this.cmbDeposito.Text == "" || this.cmbDeposito.Text == "Seleccione uno...")
            {
                MessageBox.Show("Debe Seleccionar el Deposito donde se almacenará el Artículo antes de continuar.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.cmbDeposito.Select();
                return functionReturnValue=true;
            }
            if (this.cmbUStock.Text == "" || this.cmbUStock.Text == "Seleccione una...")
            {
                MessageBox.Show("Debe Seleccionar la Unidad de Stock del Artículo antes de continuar.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.cmbUStock.Select();
                return functionReturnValue=true;
            }
            if (this.txtStockSeguridad.Text=="")
            {
                MessageBox.Show("Debe Ingresar el Stock de Seguridad que tendrá el Artículo antes de continuar.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.txtStockSeguridad.Select();
                return functionReturnValue=true;
            }
            if (this.txtPrecioEsp.Text=="")
            {
                MessageBox.Show("Debe ingresar el Precio para Clientes Especiales, antes de continuar", "Sistema de Facturación", MessageBoxButtons.OK);
                this.txtPrecioEsp.Select();
                return functionReturnValue=true;
            }
            if (this.txtPrecioMin.Text=="")
            {
                MessageBox.Show("Debe ingresar el Precio para Clientes Minoristas, antes de continuar", "Sistema de Facturación", MessageBoxButtons.OK);
                this.txtPrecioMin.Select();
                return functionReturnValue=true;
            }
            if (this.txtPrecioFra.Text=="")
            {
                MessageBox.Show("Debe ingresar el Precio para Clientes Franquiciados, antes de continuar", "Sistema de Facturación", MessageBoxButtons.OK);
                this.txtPrecioFra.Select();
                return functionReturnValue=true;
            }
            if (this.txtPrecioMay.Text=="")
            {
                MessageBox.Show("Debe ingresar el Precio para Clientes Mayoristas, antes de continuar", "Sistema de Facturación", MessageBoxButtons.OK);
                this.txtPrecioMay.Select();
                return functionReturnValue=true;
            }
            return functionReturnValue;
        }

        private void GuardarDatos()
        {
            //Este procedimiento almacena los datos del Articulo en la DB
            decimal StockSeguridad = Convert.ToDecimal(this.txtStockSeguridad.Text);
            int IdArt =this.articuloTableAdapter.InsertarArticulo(txtDesc.Text, Rubro,"N");
            
            var Id=this.articuloTableAdapter.ObtenerUltimoArticulo();
            IdArt = int.Parse(Id.ToString());

            this.stockTableAdapter.InsertarStockArticulo(cmbUStock.Text, 0, int.Parse(txtStockSeguridad.Text), NDepos, IdArt);
            for (int i = 1; i <= 4; i++)
            {
                string CodC = i.ToString();
                switch (CodC)
                {
                    case "1":
                        this.articuloCategoriaCTableAdapter.InsertarPrecioArticulo(txtPrecioEsp.Text, 1, IdArt);
                        break;
                    case "2":
                        this.articuloCategoriaCTableAdapter.InsertarPrecioArticulo(txtPrecioFra.Text, 2, IdArt);
                        break;
                    case "3":
                        this.articuloCategoriaCTableAdapter.InsertarPrecioArticulo(txtPrecioMay.Text, 3, IdArt);
                        break;
                    case "4":
                        this.articuloCategoriaCTableAdapter.InsertarPrecioArticulo(txtPrecioMin.Text, 4, IdArt);
                        break;
                }
            }
        }

        private void LimpiarCampos()
        {
            //Este procedimiento limpia los campos para permitir al usuario un nuevo ingreso de Articulo
            foreach (Control c in this.grbArticulo.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = null;
                }
                if (c is ComboBox)
                {
                    c.Text = "Seleccione uno...";
                }
            }
            foreach (Control c in this.gbDepositos.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = null;
                }
                if (c is ComboBox)
                {
                    c.Text = "Seleccione uno...";
                }
            }
            this.cmbUStock.Text = "Seleccione una...";
            this.txtNroDeposito.Text = null;
            foreach (Control c in this.grbPrecios.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = null;
                }
            }
            this.txtDesc.Select();
        }
        //---
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //---
        private void frmAltaArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Este procedimiento cancela el cierre del ingreso de Articulos de acuerdo a la eleccion del usuario
            if (MessageBox.Show("Seguro desea Salir?, Si continua se perderan los datos del Artículo que no hayan sido guardados.", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        //---
        //Estos procedimientos muestran informacion acerca de los controles
        //Botones

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Guarda un Artículo en la Base de Datos.";
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Todos los datos son obligatorios.";
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cierra el formulario de ingreso de Artículos.";
        }

        //Combobox
        private void cmbRubro_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cambia el Rubro del Artículo de la selección.";
        }
        

        private void cmbCateg_MouseLeave(object sender, System.EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Todos los datos son obligatorios.";
        }

        private void cmbDeposito_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cambia el Deposito de la selección.";
        }

        private void cmbUStock_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cambia la Unidad del Artículo de la selección.";
        }

        private void cmbDeposito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        
    }
}
