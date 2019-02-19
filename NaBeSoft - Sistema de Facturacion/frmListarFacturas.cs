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
    public partial class frmListarFactura : Form
    {
        string FechaDesde;
        string FechaHasta;
        string Estado = null;
        int IdCliente = 0;
        public frmListarFactura()
        {
            InitializeComponent();
        }

        private void frmListarFactura_Load(object sender, EventArgs e)
        {
            this.cmbCliente.Enabled = false;
            this.cmbEstado.Enabled = false;
            CargarTablas();
            this.cmbCliente.Text = null;
        }

        private void CargarTablas()
        {
            this.clienteTableAdapter.Fill(this.sFDBDataSet.Cliente);
            this.remitoTableAdapter.Fill(this.sFDBDataSet.Remito);
            this.facturaTableAdapter.Fill(this.sFDBDataSet.Factura);
        }
        
        private void chbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbCliente.Checked == true)
                this.cmbCliente.Enabled = true;
            else
            {
                this.cmbCliente.Enabled = false;
                this.cmbCliente.Text = null;
            }
        }

        private void chbEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbEstado.Checked == true)
                this.cmbEstado.Enabled = true;
            else
            {
                this.cmbEstado.Enabled = false;
                this.cmbEstado.Text = null;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.lvFacturas.Items.Clear();
            FechaDesde = this.dtpFecDesde.Text;
            FechaHasta = this.dtpFecHasta.Text;
            Estado = this.cmbEstado.Text;
            if((this.chbCliente.Checked==true)&&(this.chbEstado.Checked==true))
            {
                //los dos filtros seleccionados
                ObtenerCliente();
                this.pagoTableAdapter.FillByFechaClienteEstado(this.sFDBDataSet.Pago, FechaDesde, FechaHasta, IdCliente, Estado);
            }
            else
            {
                if(this.chbCliente.Checked==true)
                {
                    //filtro cliente seleccionado
                    ObtenerCliente();
                    this.pagoTableAdapter.FillByFechaCliente(this.sFDBDataSet.Pago, FechaDesde, FechaHasta, IdCliente);
                }
                else 
                {
                    if(this.chbEstado.Checked==true)
                    {
                        //filtro estado seleccionado
                        this.pagoTableAdapter.FillByFechaEstado(this.sFDBDataSet.Pago, FechaDesde, FechaHasta, Estado);
                    }
                    else 
                    { 
                        //ningun filtro seleccionado
                        this.pagoTableAdapter.FillByFecha(this.sFDBDataSet.Pago, FechaDesde, FechaHasta);
                    }
                }
            }
            CargarLista();
        }

        private void ObtenerCliente()
        {
            string RSocial = this.cmbCliente.Text;
            foreach(DataRow Fila in this.sFDBDataSet.Cliente)
            {
                if(RSocial==Fila["RazonSocial"].ToString())
                {
                    IdCliente = Convert.ToInt32(Fila["IdCliente"].ToString());
                    break;
                }
            }
        }

        private void CargarLista()
        {
            int i = 0;
            foreach(DataRow Fila in this.sFDBDataSet.Pago)
            {
                int Fact=Convert.ToInt32(Fila["IdFactura"].ToString());
                this.lvFacturas.Items.Add(Fact.ToString("0000-000000000"));
                DateTime Fecha = Convert.ToDateTime(ObtenerFechaFact(Fila["IdFactura"].ToString()));
                this.lvFacturas.Items[i].SubItems.Add(Fecha.ToShortDateString());
                this.lvFacturas.Items[i].SubItems.Add(Fila["Estado"].ToString());
                decimal valor = Convert.ToDecimal(Fila["Debe"].ToString());
                this.lvFacturas.Items[i].SubItems.Add(valor.ToString("#,##0.00"));
                valor = Convert.ToDecimal(Fila["Haber"].ToString());
                this.lvFacturas.Items[i].SubItems.Add(valor.ToString("#,##0.00"));
                valor = Convert.ToDecimal(Fila["Saldo"].ToString());
                this.lvFacturas.Items[i].SubItems.Add(valor.ToString("#,##0.00"));
                this.lvFacturas.Items[i].SubItems.Add(Fila["CondVenta"].ToString());
                Fecha = Convert.ToDateTime(Fila["FechaVtoPago"].ToString());
                this.lvFacturas.Items[i].SubItems.Add(Fecha.ToShortDateString());
                string Cliente = ObtenerRazonSocial(Fila["IdCliente"].ToString());
                this.lvFacturas.Items[i].SubItems.Add(Cliente);
                i += 1;
            }

        }

        private string ObtenerFechaFact(string IdFactura)
        {
            string Fec = null;
            string IdRemito = null;
            foreach(DataRow FilaF in this.sFDBDataSet.Factura)
            {
                if(IdFactura==FilaF["IdFactura"].ToString())
                {
                    IdRemito = FilaF["IdRemito"].ToString();
                    break;
                }
            }
            foreach(DataRow FilaR in this.sFDBDataSet.Remito)
            {
                if(IdRemito==FilaR["IdRemito"].ToString())
                {
                    Fec = FilaR["FechaRto"].ToString();
                    break;
                }
            }
            return Fec;
        }

        private string ObtenerRazonSocial(string IdCliente)
        {
            string RSocial = null;
            foreach(DataRow Fila in this.sFDBDataSet.Cliente)
            {
                if(IdCliente==Fila["IdCliente"].ToString())
                {
                    RSocial = Fila["RazonSocial"].ToString();
                    break;
                }
            }
            return RSocial;
        }
    }
}
