using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaBeSoft___Sistema_de_Facturacion
{
    public partial class frmListarPedidos : Form
    {
        private Font Fuente = new Font("Tahoma", 8);
        private PageSettings MiConfiguracionPagina;
        private bool Bandera = false;
        private int Contador = 0;
        private decimal CatCli = 0;
        public frmListarPedidos()
        {
            InitializeComponent();
        }

        private void frmListarPedidos_Load(object sender, EventArgs e)
        {
            this.printDocument1.DefaultPageSettings.Landscape = false;
            CargarTablas();
            
        }

        private void CargarTablas()
        {
            this.categoriaCTableAdapter.Fill(this.sFDBDataSet.CategoriaC);
            this.clienteTableAdapter.Fill(this.sFDBDataSet.Cliente);
            //this.pedidoTableAdapter.Fill(this.sFDBDataSet.Pedido);
        }

        private void CargarLista()
        {
            for (int i = 0; i < this.sFDBDataSet.Pedido.Rows.Count; i++)
            {
                decimal IdPedido = Convert.ToDecimal(this.sFDBDataSet.Pedido.Rows[i]["IdPedido"].ToString());
                this.lvPedidos.Items.Add(IdPedido.ToString("000000"));
                DateTime FechaP=Convert.ToDateTime(this.sFDBDataSet.Pedido.Rows[i]["FechaPed"].ToString());
                this.lvPedidos.Items[i].SubItems.Add(FechaP.ToShortDateString());
                decimal CodCli = Convert.ToDecimal(this.sFDBDataSet.Pedido.Rows[i]["IdCliente"].ToString());
                this.lvPedidos.Items[i].SubItems.Add(CodCli.ToString("0000"));
                string RSocial = ObtenerRazonSocial(CodCli);
                this.lvPedidos.Items[i].SubItems.Add(RSocial);
                string Categoria = ObtenerCatCliente(CatCli);
                this.lvPedidos.Items[i].SubItems.Add(Categoria);
            }
        }

        private string ObtenerRazonSocial(decimal CodCli)
        {
            string Cliente = null;
            foreach(DataRow Fila in this.sFDBDataSet.Cliente)
            {
                if(CodCli==Convert.ToDecimal(Fila["IdCliente"].ToString()))
                {
                    Cliente = Fila["RazonSocial"].ToString();
                    CatCli = Convert.ToDecimal(Fila["IdCategoriaC"].ToString());
                    break;
                }
            }
            return Cliente;
        }

        private string ObtenerCatCliente(decimal CatCli)
        {
            string CatCliente = null;
            foreach (DataRow Fila in this.sFDBDataSet.CategoriaC)
            {
                if (CatCli == Convert.ToDecimal(Fila["IdCategoriaC"].ToString()))
                {
                    CatCliente = Fila["Descripcion"].ToString();
                }
            }
            return CatCliente;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string FecDesde = dtpFecDesde.Text;
            string FecHasta = dtpFecHasta.Text;
            this.pedidoTableAdapter.FillByFechas(this.sFDBDataSet.Pedido, FecDesde, FecHasta);
            CargarLista();
        }

        private void lvPedidos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //Con este procedimiento se hace una instancia a la clase ListViewItemComparer pasandole como parametro la columna presionada para poder ordenar el ListView.
            this.lvPedidos.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurarPáginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configurar();
        }

        private void ToolStripConfigurarP_Click(object sender, EventArgs e)
        {
            Configurar();
        }

        private void Configurar()
        {
            //Section #1 - presentar los valores de los margenes
            if (MiConfiguracionPagina == null)
            {
                MiConfiguracionPagina = new PageSettings();
            }
            pageSetupDialog1.PageSettings = MiConfiguracionPagina;
            pageSetupDialog1.PageSettings.Margins.Top = 50;
            pageSetupDialog1.PageSettings.Margins.Left = 50;
            pageSetupDialog1.PageSettings.Margins.Bottom = 50;
            pageSetupDialog1.PageSettings.Margins.Right = 50;
            //Section #2 - establishing minimum allowed margin values
            pageSetupDialog1.MinMargins.Top = 50;
            pageSetupDialog1.MinMargins.Left = 50;
            pageSetupDialog1.MinMargins.Bottom = 50;
            pageSetupDialog1.MinMargins.Right = 50;
            //Section #3 - enabling the printer button and disabling page settings
            pageSetupDialog1.PrinterSettings = printDocument1.PrinterSettings;
            pageSetupDialog1.AllowMargins = false;
            pageSetupDialog1.AllowOrientation = true;
            //Section #4 - disabling printer portions of the dialog 
            pageSetupDialog1.AllowPaper = true;
            pageSetupDialog1.AllowPrinter = true;
            ConfigurarPagina();
            //Section #5 - controlling the upper range for margins
            if (pageSetupDialog1.PageSettings.Landscape == false)
            {
                if (pageSetupDialog1.PageSettings.Margins.Top > 120)
                    pageSetupDialog1.PageSettings.Margins.Top = 120;
                if (pageSetupDialog1.PageSettings.Margins.Left > 150)
                    pageSetupDialog1.PageSettings.Margins.Left = 150;
                if (pageSetupDialog1.PageSettings.Margins.Right > 100)
                    pageSetupDialog1.PageSettings.Margins.Right = 100;
                if (pageSetupDialog1.PageSettings.Margins.Bottom > 100)
                    pageSetupDialog1.PageSettings.Margins.Bottom = 100;
            }
            else
            {
                if (pageSetupDialog1.PageSettings.Margins.Top > 150)
                    pageSetupDialog1.PageSettings.Margins.Top = 150;
                if (pageSetupDialog1.PageSettings.Margins.Left > 100)
                    pageSetupDialog1.PageSettings.Margins.Left = 100;
                if (pageSetupDialog1.PageSettings.Margins.Right > 100)
                    pageSetupDialog1.PageSettings.Margins.Right = 100;
                if (pageSetupDialog1.PageSettings.Margins.Bottom > 100)
                    pageSetupDialog1.PageSettings.Margins.Bottom = 100;
            }
        }

        private void ConfigurarPagina()
        {
            if (MiConfiguracionPagina == null)
            {
                MiConfiguracionPagina = new PageSettings();
            }
            pageSetupDialog1.PageSettings = MiConfiguracionPagina;
            pageSetupDialog1.ShowDialog();
            if ((MiConfiguracionPagina != null))
            {
                printDocument1.DefaultPageSettings = MiConfiguracionPagina;
            }
        }

        private void ImprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImprimirDocumento();
        }

        private void ImprimirDocumento()
        {
            DialogResult Respuesta = default(DialogResult);
            this.printDialog1.Document = this.printDocument1;
            Respuesta = this.printDialog1.ShowDialog();
            if ((Respuesta == DialogResult.OK))
            {
                this.printDocument1.Print();
            }
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

        private void VistaPreliminarToolStripMenuItem_Click(object sender, EventArgs e)
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
            this.printDocument1.DocumentName = "Listado de Pedidos";
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
            int LineaActual = 6;
            e.HasMorePages = false;
            LineasPorPagina = e.MarginBounds.Height / Fuente.GetHeight(e.Graphics);
            AgregarEncabezado(e);
            for (int i = Contador; i <= this.lvPedidos.Items.Count - 1; i++)
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
            e.Graphics.DrawString("Listado de Pedidos", FuenteA, Brushes.Black, MargenIzquierdo, MargenSuperior + PosLinea);
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToShortDateString(), FuenteA, Brushes.Black, MargenDerecho - 135, MargenSuperior + PosLinea);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo, MargenSuperior + 3 * PosLinea, MargenDerecho, MargenSuperior + 3 * PosLinea);
            e.Graphics.DrawString("Pedido", Fuente, Brushes.Black, MargenIzquierdo + 30, 50 + 4 * PosLinea);
            e.Graphics.DrawString("Fecha", Fuente, Brushes.Black, MargenIzquierdo + 120, 50 + 4 * PosLinea);
            e.Graphics.DrawString("Cliente", Fuente, Brushes.Black, MargenIzquierdo + 204, 50 + 4 * PosLinea);
            e.Graphics.DrawString("Razón Social", Fuente, Brushes.Black, MargenDerecho - 345, 50 + 4 * PosLinea);
            e.Graphics.DrawString("Categoría Cliente", Fuente, Brushes.Black, MargenDerecho - 115, 50 + 4 * PosLinea);
        }

        private void AgregarContenido(System.Drawing.Printing.PrintPageEventArgs e, int i, int LineaActual)
        {
            float MargenSuperior = e.MarginBounds.Top;
            float MargenIzquierdo = e.MarginBounds.Left;
            float MargenDerecho = e.MarginBounds.Right;
            float PosY = 0;
            PosY = MargenSuperior + LineaActual * Fuente.GetHeight(e.Graphics);
            e.Graphics.DrawString(this.lvPedidos.Items[i].Text, Fuente, Brushes.Black, MargenIzquierdo + 29, PosY);
            e.Graphics.DrawString(this.lvPedidos.Items[i].SubItems[1].Text, Fuente, Brushes.Black, MargenIzquierdo + 107, PosY);
            e.Graphics.DrawString(this.lvPedidos.Items[i].SubItems[2].Text, Fuente, Brushes.Black, MargenIzquierdo + 210, PosY);
            e.Graphics.DrawString(this.lvPedidos.Items[i].SubItems[3].Text, Fuente, Brushes.Black, MargenDerecho - 445, PosY);
            e.Graphics.DrawString(this.lvPedidos.Items[i].SubItems[4].Text, Fuente, Brushes.Black, MargenDerecho - 100, PosY);
        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            Bandera = false;
        }
        //Estos procedimientos muestran informacion acerca de los controles
        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cierra el formulario de listado de Pedidos.";
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void ImprimirToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Imprime el Listado activo.";
        }

        private void VistaPreliminarToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Muestra páginas completas.";
        }

        private void ConfigurarPáginaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cambia la configuración del formato de página.";
        }
    }
}
