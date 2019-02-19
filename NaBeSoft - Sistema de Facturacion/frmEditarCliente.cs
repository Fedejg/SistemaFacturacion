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
    public partial class frmEditarCliente : Form
    {
        private bool Bandera = false;
        private int NLoc = 0;
        private int CodCateg = 0;
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.grbDatosPersonales.Enabled = false;
            CargarTablas();
            CargarCombos();
            CargarLista();
            LimpiarVentana();
        }

        private void CargarTablas()
        {
            try
            {
                this.localidadTableAdapter.Fill(this.sFBDDataSet.Localidad);
                this.categoriaCTableAdapter.Fill(this.sFBDDataSet.CategoriaC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarCombos()
        {
            foreach (DataRow Fila in this.sFBDDataSet.Localidad)
            {
                this.cmbLocalidad.Items.Add(Fila["Nombre"].ToString());
            }
            foreach (DataRow Fila in this.sFBDDataSet.CategoriaC)
            {
                this.cmbCateg.Items.Add(Fila["Descripcion"].ToString());
            }
        }

        private void CargarLista()
        {
            ListView Listado = new ListView();
            int j = 0;
            try
            {
                this.clienteTableAdapter.Fill(this.sFBDDataSet.Cliente);
                for (int i = 0; i <= this.sFBDDataSet.Cliente.Rows.Count - 1; i++)
                {
                    if (this.sFBDDataSet.Cliente.Rows[i]["Borrado"].ToString() == "N")
                    {
                        Listado.Items.Add(this.sFBDDataSet.Cliente.Rows[i]["IdCliente"].ToString());
                        Listado.Items[j].SubItems.Add(this.sFBDDataSet.Cliente.Rows[i]["Apellido"].ToString() + " " + this.sFBDDataSet.Cliente.Rows[i]["Nombre"].ToString());
                        j += 1;
                    }

                }
                for (int i = 0; i < Listado.Items.Count; i++)
                {
                    decimal _Codigo = Convert.ToDecimal(Listado.Items[i].Text);
                    this.lvClientes.Items.Add(_Codigo.ToString("0000"));
                    this.lvClientes.Items[i].SubItems.Add(Listado.Items[i].SubItems[1].Text);
               }
            }
            catch (Exception)
            {
                MessageBox.Show("No existe ningín Cliente en la Base de Datos", "Sistema de Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            LimpiarVentana();
        }

        private void LimpiarVentana()
        {
            foreach (Control c in this.grbDatosPersonales.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = null;
                }
                if (c is ComboBox)
                {
                    c.Text = "Seleccione una...";
                }
            }
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.grbDatosPersonales.Enabled = false;
        }
        //---
        private void lvClientes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            LimpiarVentana();
        }

        private void lvClientes_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection FilaSelect = new ListView.SelectedListViewItemCollection(lvClientes);
            FilaSelect = this.lvClientes.SelectedItems;
            this.btnModificar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.grbDatosPersonales.Enabled = true;
            int CodCliente = int.Parse(FilaSelect[0].Text);
            ConsultarDatos(CodCliente);
            this.txtApe.Select();
            }

        private void ConsultarDatos(int CodCliente)
        {
            //decimal CodC = 0;
            int NLocal = 0;
            int CodCat = 0;
            this.clienteTableAdapter.FillByCliente(this.sFBDDataSet.Cliente, CodCliente);
            //this.localidadTableAdapter.Fill(this.sFBDDataSet.Localidad);
            //this.categoriaCTableAdapter.Fill(this.sFBDDataSet.CategoriaC);
            foreach (DataRow Fila in this.sFBDDataSet.Cliente)
            {
                txtCodCli.Text = CodCliente.ToString("0000");
                txtApe.Text = Fila["Apellido"].ToString();
                txtNombre.Text = Fila["Nombre"].ToString();
                txtRSocial.Text = Fila["RazonSocial"].ToString();
                txtCuilCuit.Text = Fila["CUIT"].ToString();
                txtDir.Text = Fila["Domicilio"].ToString();
                txtTelF.Text = Fila["Telefono"].ToString();
                txtTelC.Text = Fila["Celular"].ToString();
                txtFecIn.Text = Fila["FechaInicio"].ToString();
                NLocal = int.Parse(Fila["IdLocalidad"].ToString());
                CodCat = int.Parse(Fila["IdCategoriaC"].ToString());
            }
            foreach (DataRow Fila in this.sFBDDataSet.Localidad)
            {
                if (NLocal == int.Parse(Fila["IdLocalidad"].ToString()))
                {
                    this.cmbLocalidad.Text = Fila["Nombre"].ToString();
                    this.txtCodPos.Text = Fila["CodPos"].ToString();
                    break;
                }
            }
            foreach (DataRow Fila in this.sFBDDataSet.CategoriaC)
            {
                if (CodCat == int.Parse(Fila["IdCategoriaC"].ToString()))
                {
                    this.cmbCateg.Text = Fila["Descripcion"].ToString();
                    break; 
                }
            }
        }
        //---
        private void txtCuilCuit_KeyDown(object sender, KeyEventArgs e)
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
                        Bandera = true;
                    }
                }
            }
        }

        private void txtCuilCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Bandera == true)
            {
                e.Handled = true;
            }
        }

        private void txtCuilCuit_Leave(object sender, EventArgs e)
        {
            if (this.btnCancelar.Focused == false)
            {
                if (this.txtCuilCuit.Text != null)
                {
                    if (this.txtCuilCuit.TextLength < 10)
                    {
                        MessageBox.Show("La longitud del campo CUIL/CUIT debe tener como mínimo 10 caracteres. Ingrese nuevamente el CUIL/CUIT.", "Sistema de Facturación", MessageBoxButtons.OK);
                        this.txtCuilCuit.Select();
                    }
                }
            }
        }
        //---
        private void cmbLocalidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode < Keys.Left || e.KeyCode > Keys.Down)
            {
                Bandera = true;
            }
        }

        private void cmbLocalidad_TextChanged(object sender, EventArgs e)
        {
            if (this.cmbLocalidad.Text == null)
            {
                this.txtCodPos.Text = null;
            }
        }

        private void cmbLocalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (DataRow Fila in this.sFBDDataSet.Localidad)
            {
                if (cmbLocalidad.SelectedItem.ToString()==Fila["Nombre"].ToString())
                {
                    this.txtCodPos.Text = Fila["CodPos"].ToString();
                    NLoc = int.Parse(Fila["IdLocalidad"].ToString());
                    
                }
            }
        }
        //---
        private void txtTelF_KeyDown(object sender, KeyEventArgs e)
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
                        Bandera = true;
                    }
                }
            }
        }
        //---
        private void cmbCateg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (DataRow Fila in this.sFBDDataSet.CategoriaC)
            {
                if (Fila["Descripcion"].ToString() == this.cmbCateg.SelectedItem.ToString())
                {
                    CodCateg = int.Parse(Fila["IdCategoriaC"].ToString());
                    break;
                }
            }
        }
        //---
        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool Respuesta = false;
            Respuesta = ValidarDatosCliente();
            if (Respuesta == true)
            {
                return;
            }
            this.btnModificar.Cursor = Cursors.WaitCursor;
            if (MessageBox.Show("Se modificarán los datos del Cliente, seguro desea continuar?", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                ModificarDatos();
                MessageBox.Show("El Cliente fue modificado con Exito!!", "Sistema de Facturación", MessageBoxButtons.OK);
            }
            else
            {
                this.btnCancelar.Select();
            }
            this.btnModificar.Cursor = Cursors.Hand;
            this.lvClientes.Items.Clear();
            CargarLista();
        }

        private bool ValidarDatosCliente()
        {
            bool functionReturnValue = false;
            if (this.txtApe.Text == null)
            {
                MessageBox.Show("Ingrese el Apellido del Cliente antes de continuar.", "Sistema de Facturación",MessageBoxButtons.OK);
                this.txtApe.Select();
                return functionReturnValue=true;
            }
            if (this.txtNombre.Text == null)
            {
                MessageBox.Show("Ingrese el Nombre del Cliente antes de continuar.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.txtNombre.Select();
                return functionReturnValue = true;
            }
            if (this.txtRSocial.Text == null)
            {
                MessageBox.Show("Ingrese la Razón Social del Cliente antes de continuar.","Sistema de Facturación", MessageBoxButtons.OK);
                this.txtRSocial.Select();
                return functionReturnValue = true;
            }
            if (this.txtCuilCuit.Text == null)
            {
                MessageBox.Show("Ingrese el CUIL/CUIT del Cliente antes de continuar.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.txtCuilCuit.Select();
                return functionReturnValue = true;
            }
            if (this.cmbLocalidad.Text == "Seleccione una..." || this.cmbLocalidad.Text == null)
            {
                MessageBox.Show("Debe Seleccionar una Localidad para el Cliente antes de continuar.","Sistema de Facturación", MessageBoxButtons.OK);
                this.cmbLocalidad.Select();
                return functionReturnValue = true;
            }
            if (this.txtDir.Text == null)
            {
                MessageBox.Show("Ingrese el Domicilio del Cliente antes de continuar.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.txtDir.Select();
                return functionReturnValue = true;
            }
            if (this.cmbCateg.Text == "Seleccione una..." || this.cmbCateg.Text == null)
            {
                MessageBox.Show("Debe Seleccionar una Categoría para el Cliente antes de continuar.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.cmbCateg.Select();
                return functionReturnValue=true;

            }
            return functionReturnValue;
        }

        private void ModificarDatos()
        {
            Obtenerlocalidad();
            ObtenerCodCategoria();
            int CodCliente = int.Parse(this.txtCodCli.Text);
            
            if (this.txtTelF.Text == null)
            {
                if (this.txtTelC.Text == null)

                    this.clienteTableAdapter.ModificarCliente(txtRSocial.Text, txtApe.Text, txtNombre.Text, txtDir.Text, txtCuilCuit.Text, null, null, txtFecIn.Text, NLoc, CodCateg, CodCliente);
                else
                    this.clienteTableAdapter.ModificarCliente(txtRSocial.Text, txtApe.Text, txtNombre.Text, txtDir.Text, txtCuilCuit.Text, null, txtTelC.Text, txtFecIn.Text, NLoc, CodCateg, CodCliente);
            }
            else
            {
                if (this.txtTelC.Text == null)
                    this.clienteTableAdapter.ModificarCliente(txtRSocial.Text, txtApe.Text, txtNombre.Text,txtDir.Text, txtCuilCuit.Text, txtTelF.Text, null, txtFecIn.Text, NLoc, CodCateg, CodCliente);
                else
                    this.clienteTableAdapter.ModificarCliente(txtRSocial.Text, txtApe.Text, txtNombre.Text,txtDir.Text, txtCuilCuit.Text, txtTelF.Text, txtTelC.Text, txtFecIn.Text, NLoc, CodCateg, CodCliente);
            }
        }

        private void Obtenerlocalidad()
        {
            string Localidad = this.cmbLocalidad.Text;
            foreach (DataRow Fila in this.sFBDDataSet.Localidad)
            {
                string Loc = Fila["Nombre"].ToString();
                if (Localidad == Loc)
                {
                    NLoc = int.Parse(Fila["IdLocalidad"].ToString());
                    break; 
                }
            }
        }

        private void ObtenerCodCategoria()
        {
            string Categoria = this.cmbCateg.Text;
            foreach (DataRow Fila in this.sFBDDataSet.CategoriaC)
            {
                if (Categoria == Fila["Descripcion"].ToString())
                {
                    CodCateg = int.Parse(Fila["IdCategoriaC"].ToString());
                    break; 
                }
            }
        }
        //---
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.btnEliminar.Cursor = Cursors.WaitCursor;
            if (MessageBox.Show("Seguro desea eliminar el Cliente?, Si continua se perderan permanetemente los datos del mismo y no podra recuperarlos.", "Sistema Comercial", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                EliminarDatos();
                MessageBox.Show("El Cliente fue eliminado de la Base de Datos.", "Sistema de Facturación", MessageBoxButtons.OK);
            }
            this.btnEliminar.Cursor = Cursors.Hand;
            this.lvClientes.Items.Clear();
            CargarLista();
        }
 
        private void EliminarDatos()
        {
            int CodCliente = int.Parse(this.txtCodCli.Text);
            this.clienteTableAdapter.BorrarCliente("S", CodCliente);
        }
        //---
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Modifica los datos de un Cliente en la Base de datos.";
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Elimina los datos de un Cliente de la Base de datos.";
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cierra el formulario de Edición/Eliminación de Clientes.";
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }
    }
}
