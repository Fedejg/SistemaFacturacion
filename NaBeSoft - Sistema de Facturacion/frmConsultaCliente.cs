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
    public partial class frmConsultaCliente : Form
    {
        private bool Bandera = false;
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            this.btnBuscar.Enabled = false;
            this.btnAceptar.Enabled = false;
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
            if (this.txtConsulta.Text != null)
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

        private void LimpiarControles()
        {
            this.txtConsulta.Text = null;
            foreach (Control c in this.grbDatosPersonales.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = null;
                }
            }
        }

        private void txtConsulta_Leave(object sender, EventArgs e)
        {
            if (this.txtConsulta.Text !="")
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
                MessageBox.Show("El Cliente no existe en la Base de Datos", "Sistema de Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.txtConsulta.Select();
            }
            this.btnBuscar.Cursor = Cursors.Hand;
        }

        public bool ConsultarDatos()
        {
            int CodCliente = int.Parse(txtConsulta.Text);
            int NLoc=0;
            int CodCateg=0;
            Boolean Bandera = false;
            this.localidadTableAdapter.Fill(this.sFDBDataSet.Localidad);
            this.categoriaCTableAdapter.Fill(this.sFDBDataSet.CategoriaC);
            try
            {
                this.clienteTableAdapter.FillByCliente(this.sFDBDataSet.Cliente, CodCliente);
                foreach (DataRow Fila in this.sFDBDataSet.Cliente)
                {
                    Bandera = true;
                    decimal _Codigo = Convert.ToDecimal(Fila["IdCliente"].ToString());
                    txtCodCli.Text = _Codigo.ToString("0000");
                    txtApeNom.Text = Fila["Apellido"].ToString() +" "+ Fila["Nombre"].ToString();
                    txtRSocial.Text = Fila["RazonSocial"].ToString();
                    decimal _Cuil = Convert.ToDecimal(Fila["CUIT"].ToString());
                    txtCuilCuit.Text = _Cuil.ToString("00-00000000-0");
                    txtDir.Text = Fila["Domicilio"].ToString();
                    txtTelF.Text = Fila["Telefono"].ToString();
                    txtTelC.Text = Fila["Celular"].ToString();
                    txtFecIn.Text = Fila["FechaInicio"].ToString();
                    NLoc = int.Parse(Fila["IdLocalidad"].ToString());
                    CodCateg = int.Parse(Fila["IdCategoriaC"].ToString());
                    foreach (DataRow FilaL in this.sFDBDataSet.Localidad)
                    {
                        if (NLoc == int.Parse(FilaL["IdLocalidad"].ToString()))
                        {
                            txtLocalidad.Text = FilaL["Nombre"].ToString();
                            txtCodPos.Text = FilaL["CodPos"].ToString();
                            break;
                        }
                    }
                    foreach (DataRow FilaC in this.sFDBDataSet.CategoriaC)
                    {
                        if (CodCateg == int.Parse(FilaC["IdCategoriaC"].ToString()))
                        {
                            txtCateg.Text = FilaC["Descripcion"].ToString();
                            break;
                        }
                    }
                    
                }
                if (Bandera == true)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Sistema de Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
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
        private void frmConsultaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea consultar los datos de otro Cliente?", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                e.Cancel = true;
                LimpiarControles();
                this.txtConsulta.Select();
            }
        }

        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Busca un Cliente en la Base de datos.";
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Termina la consulta de los datos del Cliente.";
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cierra el formulario de Consulta de Clientes.";
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;    
        }

        

        

       

        

        

        

        
    }
}
