using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;
using System.Diagnostics;
using System.IO;

namespace NaBeSoft___Sistema_de_Facturacion
{
    public partial class frmAltaCliente : Form
    {
        private bool Bandera = false;
        private int NLoc = 0;
        private int CodCateg = 0;
        public frmAltaCliente()
        {
            InitializeComponent();
        }

        private void frmAltaCliente_Load(object sender, EventArgs e)
        {
            this.txtFecIn.Text = DateTime.Now.ToShortDateString();
            CargarTablas();
            CargarCombos();
        }


        private void CargarTablas()
        {
            try
            {
                this.localidadTableAdapter.Fill(this.sFDBDataSet.Localidad);
                this.categoriaCTableAdapter.Fill(this.sFDBDataSet.CategoriaC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarCombos()
        {
            foreach (DataRow Fila in this.sFDBDataSet.Localidad)
            {
                this.cmbLocalidad.Items.Add(Fila["Nombre"].ToString());
            }
            foreach (DataRow Fila in this.sFDBDataSet.CategoriaC)
            {
                this.cmbCateg.Items.Add(Fila["Descripcion"].ToString());
            }
        }

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
            foreach (DataRow Fila in this.sFDBDataSet.Localidad)
            {
                if (Fila["Nombre"].ToString() == this.cmbLocalidad.SelectedItem.ToString())
                {
                    this.txtCodPos.Text = Fila["CodPos"].ToString();
                    NLoc = int.Parse(Fila["IdLocalidad"].ToString());
                    break;
                }
            }
        }
        //---
        private void cmbCateg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (DataRow Fila in this.sFDBDataSet.CategoriaC)
            {
                if (Fila["Descripcion"].ToString() == this.cmbCateg.SelectedItem.ToString())
                {
                    CodCateg = int.Parse(Fila["IdCategoriaC"].ToString());
                    break;
                }
            }
        }
        //---
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool Respuesta = false;
            Respuesta = ValidarDatosCliente();
            if (Respuesta == true)
            {
                return;
            }
            this.btnGuardar.Cursor = Cursors.WaitCursor;
            GuardarDatos();
            this.btnGuardar.Cursor = Cursors.Hand;
            MessageBox.Show("El Cliente fue guardado con Exito!", "Sistema de Facturación", MessageBoxButtons.OK);
            LimpiarCampos();
        }

        private bool ValidarDatosCliente()
        {
            bool functionReturnValue = false;
            if (this.txtApe.Text == "")
            {
                MessageBox.Show("Ingrese el Apellido y Nombre del Cliente antes de continuar.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.txtApe.Select();
                functionReturnValue=true;
                return functionReturnValue;
            }
            if (this.txtRSocial.Text == "")
            {
                MessageBox.Show("Ingrese la Razón Social del Cliente antes de continuar.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.txtRSocial.Select();
                return functionReturnValue=true;
            }
            if (this.cmbLocalidad.Text == "Seleccione una..." || this.cmbLocalidad.Text == "")
            {
                MessageBox.Show("Debe Seleccionar una Localidad para el Cliente antes de continuar.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.cmbLocalidad.Select();
                return functionReturnValue=true;
            }
            if (this.txtDir.Text=="")
            {
                MessageBox.Show("Ingrese el Domicilio del Cliente antes de continuar.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.txtDir.Select();
                return true;
                //return functionReturnValue;
            }
            if (this.cmbCateg.Text == "Seleccione una..." || this.cmbCateg.Text == null)
            {
                MessageBox.Show("Debe Seleccionar una Categoría para el Cliente antes de continuar.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.cmbCateg.Select();
                return true;
                //return functionReturnValue;
            }
            return functionReturnValue;
        }

        public void GuardarDatos()
        {
            if (txtTelF.Text=="")
            { 
                if(txtTelC.Text=="")
                    this.clienteTableAdapter.InsertarCliente(txtRSocial.Text,txtApe.Text,txtNombre.Text,txtCuilCuit.Text,txtDir.Text, null,null,txtFecIn.Text,NLoc,CodCateg,"N");
                else
                    this.clienteTableAdapter.InsertarCliente(txtRSocial.Text,txtApe.Text,txtNombre.Text,txtCuilCuit.Text,txtDir.Text, null,txtTelC.Text,txtFecIn.Text,NLoc,CodCateg,"N");
                    
            }
            else
            {
                if(txtTelC.Text=="")
                    this.clienteTableAdapter.InsertarCliente(txtRSocial.Text,txtApe.Text,txtNombre.Text,txtCuilCuit.Text,txtDir.Text,txtTelF.Text,null,txtFecIn.Text,NLoc,CodCateg,"N");
                else
                    this.clienteTableAdapter.InsertarCliente(txtRSocial.Text,txtApe.Text,txtNombre.Text,txtCuilCuit.Text,txtDir.Text,txtTelF.Text,txtTelC.Text,txtFecIn.Text,NLoc,CodCateg,"N");
            }
        }

        private void LimpiarCampos()
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
            this.txtFecIn.Text = DateTime.Now.ToShortDateString();
            this.txtApe.Select();
        }
        //---

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro desea Salir?, Si continua se perderán los datos del Cliente que no hayan sido guardados.", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cierra el formulario de Ingreso de Clientes.";
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Registra los datos de un nuevo Cliente.";
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void txtCodPos_TextChanged(object sender, EventArgs e)
        {

        }

        

        
        

        

       

        

        

        

        

        
    }      
}
