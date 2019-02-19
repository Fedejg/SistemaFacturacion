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
    public partial class frmModificarStock : Form
    {
        public frmModificarStock()
        {
            InitializeComponent();
        }

        private void frmModificarStock_Load(object sender, EventArgs e)
        {
            this.dgvStock.Rows.Clear();
            CargarTablas();
            InsertarFilasListado();
        }

        private void CargarTablas()
        {
            this.rubroTableAdapter.Fill(this.sFDBDataSet.Rubro);
            this.articuloTableAdapter.Fill(this.sFDBDataSet.Articulo);
            this.stockTableAdapter.Fill(this.sFDBDataSet.Stock);
        }

        private void InsertarFilasListado()
        {
            int i = 0;
            foreach(DataRow Fila in this.sFDBDataSet.Articulo)
            {
                if(Fila["Borrado"].ToString()=="N")
                {
                    string Rubro = ObtenerDescRubro(Fila["IdRubro"].ToString());
                    if(Rubro != "FACTURAS" && Rubro != "PANIFICADOS" && Rubro != "TORTILLAS")
                    {
                        this.dgvStock.Rows.Add(1);
                        this.dgvStock.Rows[i].Cells["ColumnIdArticulo"].Value = Fila["IdArticulo"].ToString();
                        this.dgvStock.Rows[i].Cells["ColumnDescripcion"].Value = Fila["Descripcion"].ToString();
                        this.dgvStock.Rows[i].Cells["ColumnStockSeg"].Value = ObtenerStockSeguridad(Fila["IdArticulo"].ToString());
                        this.dgvStock.Rows[i].Cells["ColumnStock"].Value = ObtenerCantidadStock(Fila["IdArticulo"].ToString());
                        i += 1;
                    }
                }
            }
        }

        private string ObtenerDescRubro(string IdRubro)
        {
            string respuesta = null;
            foreach(DataRow Fila in this.sFDBDataSet.Rubro)
            {
                if(IdRubro==Fila["IdRubro"].ToString())
                {
                    respuesta = Fila["Descripcion"].ToString();
                    break;
                }
            }
            return respuesta;
        }

        private decimal ObtenerStockSeguridad(string IdArticulo)
        {
            decimal valor = 0;
            foreach(DataRow Fila in this.sFDBDataSet.Stock)
            {
                if(IdArticulo==Fila["IdArticulo"].ToString())
                {
                    valor = Convert.ToDecimal(Fila["StockSeguridad"].ToString());
                    break;
                }
            }
            return valor;
        }

        private decimal ObtenerCantidadStock(string IdArticulo)
        {
            decimal valor = 0;
            foreach (DataRow Fila in this.sFDBDataSet.Stock)
            {
                if (IdArticulo == Fila["IdArticulo"].ToString())
                {
                    valor = Convert.ToDecimal(Fila["CantStock"].ToString());
                    break;
                }
            }
            return valor;
        }

        private bool ValidarCodigo(int CoordenadaY, string Celda)
        {
            bool Respuesta = false;
            string Cadena = Celda;
            int Longitud = Celda.Length;
            for (int indice = 1; indice <= Longitud; indice++)
            {
                switch (Cadena[indice - 1].ToString())
                {
                    case "0":
                        Respuesta = true;
                        break;
                    case "1":
                        Respuesta = true;
                        break;
                    case "2":
                        Respuesta = true;
                        break;
                    case "3":
                        Respuesta = true;
                        break;
                    case "4":
                        Respuesta = true;
                        break;
                    case "5":
                        Respuesta = true;
                        break;
                    case "6":
                        Respuesta = true;
                        break;
                    case "7":
                        Respuesta = true;
                        break;
                    case "8":
                        Respuesta = true;
                        break;
                    case "9":
                        Respuesta = true;
                        break;
                    default:
                        Respuesta = false;
                        break;
                }
                //break;
            }
            return Respuesta;
        }

        private void dgvStock_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int CoordenadaY = this.dgvStock.CurrentCellAddress.Y;
            if ((ValidarCodigo(CoordenadaY, this.dgvStock.CurrentRow.Cells["ColumnStockSeg"].Value.ToString()) == false) || (ValidarCodigo(CoordenadaY, this.dgvStock.CurrentRow.Cells["ColumnStock"].Value.ToString()) == false))
            {
                MessageBox.Show("El formato del código ingresado es incorrecto, asegurese de ingresar solamente caracteres numericos.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.dgvStock.CurrentCell.Selected = true;
                
                //this.dgvStock.CurrentCell.Value = null;
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificarStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro desea Salir?, Si continua se perderán los datos de Stock que no hayan sido guardados.", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            MessageBox.Show("El Stock de los Articulos fue actualizado con Exito!", "Sistema de Facturación", MessageBoxButtons.OK);
            this.Close();
        }

        private void GuardarDatos()
        {
            try
            {
                for (int i = 0; i < this.dgvStock.Rows.Count; i++)
                {
                    int Stock = Convert.ToInt32(this.dgvStock.Rows[i].Cells["ColumnStock"].Value.ToString());
                    int StockS = Convert.ToInt32(this.dgvStock.Rows[i].Cells["ColumnStockSeg"].Value.ToString());
                    int IdArt = Convert.ToInt32(this.dgvStock.Rows[i].Cells["ColumnIdArticulo"].Value.ToString());
                    this.stockTableAdapter.ModificarStock(Stock, StockS, IdArt);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Actualizar el Stock " + e.Message);
                throw;
            }
            
        }
    }
}
