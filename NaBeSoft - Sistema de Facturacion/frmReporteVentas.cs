using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace NaBeSoft___Sistema_de_Facturacion
{
    public partial class frmReporteVentas : Form
    {
        private decimal ImporteT = 0;
        private decimal IdArticulo = 0;
        private bool Bandera = false;
        private int Contador = 0;
        private Font Fuente = new Font("Tahoma", 8);
        public frmReporteVentas()
        {
            InitializeComponent();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            this.printDocument1.DefaultPageSettings.Landscape = false;
            this.cmArticulos.Enabled = false;
            this.articuloTableAdapter.Fill(this.sFDBDataSet.Articulo);
            this.cmArticulos.Text = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.lvVentas.Items.Clear();
            string FecDesde = dtpFecDesde.Text;
            string FecHasta = dtpFecHasta.Text;
            if (this.chbProd.Checked == true)
                IdArticulo = ObtenerArticulo(this.cmArticulos.Text);
            else
                IdArticulo = 0;
            this.remitoTableAdapter.FillByFechas(this.sFDBDataSet.Remito, FecDesde, FecHasta);
            CargarLista();
        }

        private decimal ObtenerArticulo(string Descripcion)
        {
            decimal IdArt=0;
            foreach(DataRow Fila in this.sFDBDataSet.Articulo)
            {
                if(Descripcion==Fila["Descripcion"].ToString())
                {
                    IdArt=Convert.ToDecimal(Fila["IdArticulo"].ToString());
                    break;
                }
            }
            return IdArt;
        }
        private void CargarLista()
        {
            int j = 0;
            foreach(DataRow Fila in this.sFDBDataSet.Remito)
            {
                if (IdArticulo != 0)
                    this.lineaRemitoTableAdapter.FillByRemitoArticulo(this.sFDBDataSet.LineaRemito, int.Parse(IdArticulo.ToString()), int.Parse(Fila["IdRemito"].ToString()));
                else
                    this.lineaRemitoTableAdapter.FillByRemito(this.sFDBDataSet.LineaRemito, int.Parse(Fila["IdRemito"].ToString()));
                
                if(this.sFDBDataSet.LineaRemito.Rows.Count!=0)
                {
                    for (int i = 0; i < this.sFDBDataSet.LineaRemito.Rows.Count; i++)
                    {
                        this.lvVentas.Items.Add(ObtenerRazonSocial(Fila["IdCliente"].ToString()));
                        decimal IdRemito = Convert.ToDecimal(Fila["IdRemito"].ToString());
                        this.lvVentas.Items[j].SubItems.Add(IdRemito.ToString("0000"));
                        DateTime Fecha=Convert.ToDateTime(Fila["FechaRto"].ToString());
                        this.lvVentas.Items[j].SubItems.Add(Fecha.ToShortDateString());
                        this.lvVentas.Items[j].SubItems.Add(ObtenerDescripcionArticulo(this.sFDBDataSet.LineaRemito.Rows[i]["IdArticulo"].ToString()));
                        decimal Cantidad = Convert.ToDecimal(this.sFDBDataSet.LineaRemito.Rows[i]["Cantidad"].ToString());
                        this.lvVentas.Items[j].SubItems.Add(Cantidad.ToString());
                        decimal ImporteL = Convert.ToDecimal(this.sFDBDataSet.LineaRemito.Rows[i]["ImporteLinea"].ToString());
                        this.lvVentas.Items[j].SubItems.Add(ImporteL.ToString("#,##0.00"));

                        j = j + 1;
                        ImporteT = ImporteT + ImporteL;
                    }
                }
                
            }
            this.txtImporteT.Text = ImporteT.ToString("#,##0.00");
            ImporteT = 0;
        }

        private string ObtenerRazonSocial(string IdCliente)
        {
            string RSocial = null;
            this.clienteTableAdapter.Fill(this.sFDBDataSet.Cliente);
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

        private string ObtenerDescripcionArticulo(string IdArticulo)
        {
            string Desc = null;
            foreach(DataRow Fila in this.sFDBDataSet.Articulo)
            {
                if(IdArticulo==Fila["IdArticulo"].ToString())
                {
                    Desc = Fila["Descripcion"].ToString();
                    break;
                }
            }
            return Desc;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbProd_CheckedChanged(object sender, EventArgs e)
        {
            if (chbProd.Checked == true)
                cmArticulos.Enabled = true;
            else
            {
                cmArticulos.Enabled = false;
                this.cmArticulos.Text = null;  
            }
        }

        private void lvVentas_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.lvVentas.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void ToolStripConfigurarP_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToolStripVistaPreliminar_Click(object sender, EventArgs e)
        {
            try
            {
                VistaPreliminar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VistaPreliminar()
        {
            PrintPreviewDialog VPDialogo = default(PrintPreviewDialog);
            VPDialogo = new PrintPreviewDialog();
            VPDialogo.WindowState = FormWindowState.Maximized;
            VPDialogo.Document = this.printDocument1;
            VPDialogo.PrintPreviewControl.StartPage = 0;
            VPDialogo.PrintPreviewControl.Zoom = 1.0;
            VPDialogo.ShowDialog();
            VPDialogo.Dispose();
        }

        private void printDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            this.printDocument1.DocumentName = "Reporte de Ventas";
            e.PageSettings.Margins.Top = 50;
            e.PageSettings.Margins.Bottom = 50;
            e.PageSettings.Margins.Left = 50;
            e.PageSettings.Margins.Right = 50;
            if (Bandera == false)
            {
                Contador = 0;
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            bool Orientacion = e.PageSettings.Landscape == false;
            float LineasPorPagina = 0;
            int LineaActual = 8;
            e.HasMorePages = false;
            LineasPorPagina = e.MarginBounds.Height / Fuente.GetHeight(e.Graphics);
            AgregarEncabezado(e);
            for (int i = Contador; i <= this.lvVentas.Items.Count - 1; i++)
            {
                if (LineaActual < LineasPorPagina)
                {
                    AgregarContenido(e, i, LineaActual);
                    LineaActual += 1;
                }
                else
                {
                    e.HasMorePages = true;
                    Bandera = true;
                    Contador = i;
                    break;
                }
            }
        }

        private void AgregarEncabezado(System.Drawing.Printing.PrintPageEventArgs e)
        {
            float PosLinea = Fuente.GetHeight(e.Graphics);
            Font FuenteA = new Font("Tahoma", 10, FontStyle.Bold);
            float MargenIzquierdo = e.MarginBounds.Left;
            float MargenSuperior = e.MarginBounds.Top;
            float MargenDerecho = e.MarginBounds.Right;
            e.Graphics.DrawString("Reporte de Ventas", FuenteA, Brushes.Black, MargenIzquierdo, MargenSuperior + PosLinea);
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToShortDateString(), FuenteA, Brushes.Black, MargenDerecho - 135, MargenSuperior + PosLinea);
            e.Graphics.DrawString("Período: "+this.dtpFecDesde.Text+" al "+this.dtpFecHasta.Text, FuenteA, Brushes.Black, MargenDerecho - 252, MargenSuperior + 3 * PosLinea);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo, MargenSuperior + 5 * PosLinea, MargenDerecho, MargenSuperior + 5 * PosLinea);
            e.Graphics.DrawString("Cliente", Fuente, Brushes.Black,MargenSuperior + 110, 50 + 6 * PosLinea);
            e.Graphics.DrawString("Remito Nº", Fuente, Brushes.Black,MargenSuperior + 260, 50 + 6 * PosLinea);
            e.Graphics.DrawString("Fecha", Fuente, Brushes.Black, MargenSuperior + 345, 50 + 6 * PosLinea);
            e.Graphics.DrawString("Artículo", Fuente, Brushes.Black, MargenSuperior + 480, 50 + 6 * PosLinea);
            e.Graphics.DrawString("Cantidad", Fuente, Brushes.Black, MargenDerecho - 115 , 50 + 6 * PosLinea);
            e.Graphics.DrawString("Importe", Fuente, Brushes.Black, MargenDerecho - 50, 50 + 6 * PosLinea);
        }

        private void AgregarContenido(System.Drawing.Printing.PrintPageEventArgs e, int i, int LineaActual)
        {
            float MargenSuperior = e.MarginBounds.Top;
            float MargenIzquierdo = e.MarginBounds.Left;
            float MargenDerecho = e.MarginBounds.Right;
            float PosY = 0;
            PosY = MargenSuperior + LineaActual * Fuente.GetHeight(e.Graphics);
            e.Graphics.DrawString(this.lvVentas.Items[i].Text, Fuente, Brushes.Black, MargenIzquierdo + 5, PosY);
            e.Graphics.DrawString(this.lvVentas.Items[i].SubItems[1].Text, Fuente, Brushes.Black, MargenIzquierdo + 270, PosY);
            e.Graphics.DrawString(this.lvVentas.Items[i].SubItems[2].Text, Fuente, Brushes.Black, MargenIzquierdo + 330, PosY);
            e.Graphics.DrawString(this.lvVentas.Items[i].SubItems[3].Text, Fuente, Brushes.Black, MargenIzquierdo + 420, PosY);
            e.Graphics.DrawString(this.lvVentas.Items[i].SubItems[4].Text, Fuente, Brushes.Black, MargenDerecho - 100, PosY);
            int Longitud = this.lvVentas.Items[i].SubItems[5].Text.Length;
            switch (Longitud)
            {
                case 4://0,00
                    e.Graphics.DrawString(this.lvVentas.Items[i].SubItems[5].Text, Fuente, Brushes.Black, MargenDerecho - 31, PosY);
                    break;
                case 5://00,00
                    e.Graphics.DrawString(this.lvVentas.Items[i].SubItems[5].Text, Fuente, Brushes.Black, MargenDerecho - 35, PosY);
                    break;
                case 6://000,00
                    e.Graphics.DrawString(this.lvVentas.Items[i].SubItems[5].Text, Fuente, Brushes.Black, MargenDerecho - 41, PosY);
                    break;
                case 8:
                    e.Graphics.DrawString(this.lvVentas.Items[i].SubItems[5].Text, Fuente, Brushes.Black, MargenDerecho - 50, PosY);
                    break;
            }
        }
    }
}
