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
    public partial class frmListarCliente : Form
    {
        private int Contador = 0;
        private bool Bandera = false;
        private Font Fuente = new Font("Tahoma", 8);
        //private PageSettings MiConfiguracionPagina;
        public frmListarCliente()
        {
            InitializeComponent();
        }

        private void frmListarCliente_Load(object sender, EventArgs e)
        {
            
            this.printDocument1.DefaultPageSettings.Landscape = true;
            CargarTablas();
            CargarLista();
        }

        private void CargarTablas()
        {
            this.categoriaCTableAdapter.Fill(this.sFDBDataSet.CategoriaC);
            this.localidadTableAdapter.Fill(this.sFDBDataSet.Localidad);
            this.clienteTableAdapter.Fill(this.sFDBDataSet.Cliente);
        }

        private void CargarLista()
        {
            string Cadena = null;
            string Categoria = null;
            for (int i = 0; i <= this.sFDBDataSet.Cliente.Rows.Count - 1; i++)
            {
                decimal CodC = Convert.ToDecimal(this.sFDBDataSet.Cliente.Rows[i]["IdCliente"].ToString());
                this.lvClientes.Items.Add(CodC.ToString("0000"));
                Categoria = ObtenerCategoria(Convert.ToDecimal(this.sFDBDataSet.Cliente.Rows[i]["IdCategoriaC"].ToString()));
                this.lvClientes.Items[i].SubItems.Add(Categoria.ToLowerInvariant());
                DateTime Fecha = Convert.ToDateTime(this.sFDBDataSet.Cliente.Rows[i]["FechaInicio"].ToString());
                string FechaInicio = Fecha.ToShortDateString();
                this.lvClientes.Items[i].SubItems.Add(FechaInicio);
                this.lvClientes.Items[i].SubItems.Add(this.sFDBDataSet.Cliente.Rows[i]["RazonSocial"].ToString());
                this.lvClientes.Items[i].SubItems.Add(this.sFDBDataSet.Cliente.Rows[i]["Apellido"].ToString()+" "+this.sFDBDataSet.Cliente.Rows[i]["Nombre"].ToString());
                Cadena = this.sFDBDataSet.Cliente.Rows[i]["CUIT"].ToString();
                if (Cadena != null)
                {
                    decimal CUIT=Convert.ToDecimal(this.sFDBDataSet.Cliente.Rows[i]["CUIT"].ToString());
                    this.lvClientes.Items[i].SubItems.Add(CUIT.ToString("00-00000000-0"));
                }
                else
                {
                    this.lvClientes.Items[i].SubItems.Add("");
                }
                Cadena = this.sFDBDataSet.Cliente.Rows[i]["Telefono"].ToString();
                if (Cadena != null)
                {
                    this.lvClientes.Items[i].SubItems.Add(this.sFDBDataSet.Cliente.Rows[i]["Telefono"].ToString());
                }
                else
                {
                    this.lvClientes.Items[i].SubItems.Add("");
                }
                Cadena = this.sFDBDataSet.Cliente.Rows[i]["Celular"].ToString();
                if (Cadena != null)
                {
                    this.lvClientes.Items[i].SubItems.Add(this.sFDBDataSet.Cliente.Rows[i]["Celular"].ToString());
                }
                else
                {
                    this.lvClientes.Items[i].SubItems.Add("");
                }
                decimal Nloc = Convert.ToDecimal(this.sFDBDataSet.Cliente.Rows[i]["IdLocalidad"].ToString());
                Cadena = ObtenerLocalidad(Nloc);
                this.lvClientes.Items[i].SubItems.Add(Cadena);
                this.lvClientes.Items[i].SubItems.Add(this.sFDBDataSet.Cliente.Rows[i]["Domicilio"].ToString());
            }
        }

        private string ObtenerCategoria(decimal Codigo)
        {
            string Cadena = null;
            decimal Cod = Codigo;
            foreach (DataRow Fila in this.sFDBDataSet.CategoriaC)
            {
                if (Convert.ToDecimal(Fila["IdCategoriaC"].ToString()) == Cod)
                {
                    Cadena = Fila["Descripcion"].ToString();
                    break; 
                }
            }
            return Cadena;
        }

        private string ObtenerLocalidad(decimal Nloc)
        {
            string Loc = null;
            foreach (DataRow Fila in this.sFDBDataSet.Localidad)
            {
                if (Nloc == Convert.ToDecimal(Fila["IdLocalidad"].ToString()))
                {
                    Loc = Fila["Nombre"].ToString();
                    break;
                }
            }
            return Loc;
        }
        //---
        private void lvClientes_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //Con este procedimiento se hace una instancia a la clase ListViewItemComparer pasandole como parametro la columna presionada para poder ordenar el ListView.
            this.lvClientes.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }
        //---
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //---
        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //---
        //Estos procedimientos estan relacionados con la impresion del Listado.

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
            this.printDocument1.DocumentName = "Listado de Clientes";
            PaperSize Tamaño = new PaperSize("A4Plus", 630, 1299);
            e.PageSettings.PaperSize = Tamaño;
            e.PageSettings.PaperSize.RawKind = 60;
            e.PageSettings.Margins.Top = 50;
            e.PageSettings.Margins.Bottom = 50;
            e.PageSettings.Margins.Left = 10;
            e.PageSettings.Margins.Right = 10;
            if (Bandera == false)
            {
                Contador = 0;
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            bool Orientacion = e.PageSettings.Landscape == true;
            float LineasPorPagina = 0;
            int LineaActual = 6;
            e.HasMorePages = false;
            LineasPorPagina = e.MarginBounds.Height / Fuente.GetHeight(e.Graphics);
            AgregarEncabezado(e);
            for (int i = Contador; i <= this.lvClientes.Items.Count - 1; i++)
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
            e.Graphics.DrawString("Listado de Clientes", FuenteA, Brushes.Black, MargenIzquierdo, MargenSuperior + PosLinea);
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToShortDateString(), FuenteA, Brushes.Black, MargenDerecho - 135, MargenSuperior + PosLinea);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo, MargenSuperior + 3 * PosLinea, MargenDerecho, MargenSuperior + 3 * PosLinea);
            e.Graphics.DrawString("Código", Fuente, Brushes.Black, 12, 50 + 4 * PosLinea);
            e.Graphics.DrawString("Categoría", Fuente, Brushes.Black, 54, 50 + 4 * PosLinea);
            e.Graphics.DrawString("Fecha", Fuente, Brushes.Black, 125, 50 + 4 * PosLinea);
            e.Graphics.DrawString("Razón Social", Fuente, Brushes.Black, 235, 50 + 4 * PosLinea);
            e.Graphics.DrawString("Apellido y Nombre", Fuente, Brushes.Black, 435, 50 + 4 * PosLinea);
            e.Graphics.DrawString("CUIL/CUIT", Fuente, Brushes.Black, 598, 50 + 4 * PosLinea);
            e.Graphics.DrawString("Teléfono", Fuente, Brushes.Black, 685, 50 + 4 * PosLinea);
            e.Graphics.DrawString("Celular", Fuente, Brushes.Black, 773, 50 + 4 * PosLinea);
            e.Graphics.DrawString("Localidad", Fuente, Brushes.Black, 870, 50 + 4 * PosLinea);
            e.Graphics.DrawString("Domicilio", Fuente, Brushes.Black, 1090, 50 + 4 * PosLinea);
        }

        private void AgregarContenido(System.Drawing.Printing.PrintPageEventArgs e, int i, int LineaActual)
        {
            float MargenSuperior = e.PageSettings.Margins.Top;
            float MargenIzquierdo = e.PageSettings.Margins.Left;
            float PosY = 0;
            PosY = MargenSuperior + LineaActual * Fuente.GetHeight(e.Graphics);
            e.Graphics.DrawString(this.lvClientes.Items[i].Text, Fuente, Brushes.Black, MargenIzquierdo + 8, PosY);
            e.Graphics.DrawString(this.lvClientes.Items[i].SubItems[1].Text, Fuente, Brushes.Black, MargenIzquierdo + 45, PosY);
            e.Graphics.DrawString(this.lvClientes.Items[i].SubItems[2].Text, Fuente, Brushes.Black, MargenIzquierdo + 100, PosY);
            e.Graphics.DrawString(this.lvClientes.Items[i].SubItems[3].Text, Fuente, Brushes.Black, MargenIzquierdo + 165, PosY);
            e.Graphics.DrawString(this.lvClientes.Items[i].SubItems[4].Text, Fuente, Brushes.Black, MargenIzquierdo + 370, PosY);
            e.Graphics.DrawString(this.lvClientes.Items[i].SubItems[5].Text, Fuente, Brushes.Black, MargenIzquierdo + 575, PosY);
            e.Graphics.DrawString(this.lvClientes.Items[i].SubItems[6].Text, Fuente, Brushes.Black, MargenIzquierdo + 660, PosY);
            e.Graphics.DrawString(this.lvClientes.Items[i].SubItems[7].Text, Fuente, Brushes.Black, MargenIzquierdo + 740, PosY);
            e.Graphics.DrawString(this.lvClientes.Items[i].SubItems[8].Text, Fuente, Brushes.Black, MargenIzquierdo + 830, PosY);
            e.Graphics.DrawString(this.lvClientes.Items[i].SubItems[9].Text, Fuente, Brushes.Black, MargenIzquierdo + 985, PosY);
        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            Bandera = false;
        }

        //Estos procedimientos muestran informacion acerca de los controles
        //Formulario

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cierra el formulario de listado de Clientes.";
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        //MenuStrip

        private void ImprimirToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Imprime el Listado activo.";
        }

        private void ImprimirToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void VistaPreliminarToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Muestra páginas completas.";
        }

        private void VistaPreliminarToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void ConfigurarPáginaToolStripMenuItem_MouseHover(object sender, System.EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cambia la configuración del formato de página.";
        }

        private void ConfigurarPáginaToolStripMenuItem_MouseLeave(object sender, System.EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void SalirToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cierra el formulario de listado de Clientes.";
        }

        private void SalirToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }
        //ToolStrip

        private void ToolStripConfigurarP_MouseHover(object sender, System.EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cambia la configuración del formato de página.";
        }

        private void ToolStripConfigurarP_MouseLeave(object sender, System.EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void ToolStripImprimir_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Imprime el Listado activo.";
        }

        private void ToolStripImprimir_MouseLeave(object sender, EventArgs e)
        {
        
        }

        private void ToolStripVistaPreliminar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Muestra páginas completas.";
        }

        private void ToolStripVistaPreliminar_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }
    }
}
