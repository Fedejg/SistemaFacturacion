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
    public partial class frmAltaPago : Form
    {
        ListView.SelectedListViewItemCollection FilaSel = default(ListView.SelectedListViewItemCollection);
        TextBox Actual = new TextBox();
        private string Cadena = null;
        private decimal valorDebe = 0;
        private decimal valorHaber = 0;
        private decimal valorSaldo = 0;
        private string IdCliente = null;
        public frmAltaPago()
        {
            InitializeComponent();
        }

        private void frmAltaPago_Load(object sender, EventArgs e)
        {
            CargarTablas();
            this.cmbCliente.Text = "Seleccione un Cliente...";
            CargarComboCliente();
        }

        private void CargarTablas()
        {
            this.localidadTableAdapter.Fill(this.sFDBDataSet.Localidad);
            this.clienteTableAdapter.Fill(this.sFDBDataSet.Cliente);
        }

        public void CargarComboCliente()
        {
            foreach (DataRow Fila in this.sFDBDataSet.Cliente)
            {
                if (Fila["Borrado"].ToString() == "N")
                    this.cmbCliente.Items.Add(Fila["RazonSocial"].ToString());
            }
        }

        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.lvFactura.Items.Clear();
            foreach(DataRow FilaC in this.sFDBDataSet.Cliente)
            {
                if(FilaC["RazonSocial"].ToString()==this.cmbCliente.SelectedItem.ToString())
                {
                    DateTime Fecha = Convert.ToDateTime(FilaC["FechaInicio"].ToString());
                    this.txtFecIn.Text = Fecha.ToShortDateString();
                    this.txtRSocial.Text = FilaC["RazonSocial"].ToString();
                    this.txtLocalidad.Text = ObtenerLocalidad(FilaC["IdLocalidad"].ToString());
                    this.txtDireccion.Text = FilaC["Domicilio"].ToString();
                    IdCliente=FilaC["IdCliente"].ToString();
                    CargarListaFacturas(IdCliente);
                    break;
                }
            }
        }

        private string ObtenerLocalidad(string IdLocalidad)
        {
            string Loc = null;
            foreach(DataRow Fila in this.sFDBDataSet.Localidad)
            {
                if(IdLocalidad==Fila["IdLocalidad"].ToString())
                {
                    Loc = Fila["Nombre"].ToString();
                    break;
                }
            }
            return Loc;
        }

        private void CargarListaFacturas(string IdCli)
        {
            this.lvFactura.Items.Clear();
            int i = 0;
            this.pagoTableAdapter.FillByCliente(this.sFDBDataSet.Pago, Convert.ToInt32(IdCli));
            foreach(DataRow Fila in this.sFDBDataSet.Pago)
            {
                int Fact=Convert.ToInt32(Fila["IdFactura"].ToString());
                this.lvFactura.Items.Add(Fact.ToString("0000000000000"));
                decimal valor=Convert.ToDecimal(Fila["Debe"].ToString());
                this.lvFactura.Items[i].SubItems.Add(valor.ToString("#,##0.00"));
                valor = Convert.ToDecimal(Fila["Haber"].ToString());
                this.lvFactura.Items[i].SubItems.Add(valor.ToString("#,##0.00"));
                valor = Convert.ToDecimal(Fila["Saldo"].ToString());
                this.lvFactura.Items[i].SubItems.Add(valor.ToString("#,##0.00"));
                this.lvFactura.Items[i].SubItems.Add(Fila["Estado"].ToString());
                DateTime Fecha = Convert.ToDateTime(Fila["FechaVtoPago"].ToString());
                this.lvFactura.Items[i].SubItems.Add(Fecha.ToShortDateString());
                i += 1;
            }
        }

        private void cmbCliente_TextChanged(object sender, EventArgs e)
        {
            if (this.cmbCliente.Text == "")
            {
                this.txtFecIn.Text = null;
                this.txtRSocial.Text = null;
                this.txtLocalidad.Text = null;
                this.txtDireccion.Text = null;
            }
        }

        private void lvFactura_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            RefrescarControles();
        }

        private void RefrescarControles()
        {
            this.txtDebe.Text = null;
            this.txtHaber.Text = null;
            this.txtSaldo.Text = null;
            this.txtSaldo.ForeColor = Color.Black;
            this.txtNuevoVto.Text = null;
            this.txtNuevoVto.BackColor = Color.WhiteSmoke;
        }

        private void lvFactura_DoubleClick(object sender, EventArgs e)
        {
            
            FilaSel = this.lvFactura.SelectedItems;
            this.txtDebe.Text=FilaSel[0].SubItems[1].Text;
            this.txtHaber.Text = FilaSel[0].SubItems[2].Text;
            if(Convert.ToDecimal(FilaSel[0].SubItems[3].Text)>0)
            {
                this.txtSaldo.Text = FilaSel[0].SubItems[3].Text;
                this.txtSaldo.ForeColor = Color.Red;
            }
            DateTime Fecha = Convert.ToDateTime(FilaSel[0].SubItems[5].Text);
            this.txtNuevoVto.Text = Fecha.AddDays(7).ToShortDateString();
            this.txtNuevoVto.BackColor = Color.Red;

            this.txtHaber.Focus();
        }

        private void txtHaber_Leave(object sender, EventArgs e)
        {
            Actual = (TextBox)sender;
            if (this.btnCancelar.Focused == false)
            {
                if (Actual.Text != "")
                {
                    Cadena = Actual.Text;
                    Actual.Text = Cadena.Replace('.', ',');
                    valorHaber = Convert.ToDecimal(Actual.Text);
                    this.txtHaber.Text = valorHaber.ToString("#,##0.00");

                    valorDebe = Convert.ToDecimal(this.txtDebe.Text);
                    valorSaldo = Convert.ToDecimal(this.txtSaldo.Text);

                    decimal resultado = valorDebe - valorHaber;

                    if(resultado <=0)
                    {
                        this.txtSaldo.Text = resultado.ToString("#,##0.00");
                        this.txtSaldo.ForeColor = Color.Green;
                        this.txtNuevoVto.Text = null;
                        this.txtNuevoVto.BackColor = Color.WhiteSmoke;
                    }
                    else
                    {
                        this.txtSaldo.Text = resultado.ToString("#,##0.00");
                        this.txtSaldo.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Estado = null;
            int Factura = Convert.ToInt32(FilaSel[0].SubItems[0].Text);
            valorDebe = Convert.ToDecimal(this.txtSaldo.Text);
            valorSaldo = Convert.ToDecimal(this.txtSaldo.Text);
            if (valorSaldo <= 0)
            {
                Estado = "Pagado";
            }
            else
            {
                Estado = "Con Saldo";
            }
            DateTime Fecha;
            if(Estado=="Pagado")
            {
                Fecha = Convert.ToDateTime(FilaSel[0].SubItems[5].Text);
            }
            else
            {
                Fecha = Convert.ToDateTime(this.txtNuevoVto.Text);
            }
            this.pagoTableAdapter.ModificarPago(Estado, valorDebe, 0, valorSaldo, Fecha.ToShortDateString(), Factura);
            if (MessageBox.Show("El Pago fue registrado con exito! Desea gestionar algun otro pago?", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                CargarListaFacturas(IdCliente);
                RefrescarControles();
            }
            else
                this.Close();
        }
    }
}
