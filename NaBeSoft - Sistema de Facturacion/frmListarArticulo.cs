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
    public partial class frmListarArticulo : Form
    {
        private Font Fuente = new Font("Tahoma", 8);
        private PageSettings MiConfiguracionPagina;
        private bool Bandera = false;
        private int Contador = 0;
        public frmListarArticulo()
        {
            InitializeComponent();
        }

        private void frmListarArticulo_Load(object sender, EventArgs e)
        {
            this.printDocument1.DefaultPageSettings.Landscape = false;
            CargarTablas();
            CargarLista();
        }
        private void CargarTablas()
        {
            //Con este procedimiento se cargan en memoria las tablas relacionadas con la informacion del Articulo (Articulo, CategoriaArticulo)
            this.articuloCategoriaCTableAdapter.Fill(this.sFDBDataSet.ArticuloCategoriaC);
            this.rubroTableAdapter.Fill(this.sFDBDataSet.Rubro);
            this.articuloTableAdapter.Fill(this.sFDBDataSet.Articulo);
        }

        private void CargarLista()
        {
            //Con este procedimiento se va adicionando cada fila dentro de la lista de Clientes.
            decimal Precio = 0;
            string Cadena;
            for (int i = 0; i <= this.sFDBDataSet.Articulo.Rows.Count - 1; i++)
            {
                decimal IdArt = Convert.ToDecimal(this.sFDBDataSet.Articulo.Rows[i]["IdArticulo"].ToString());
                this.lvArticulos.Items.Add(IdArt.ToString("0000"));
                Cadena = ObtenerRubroArticulo(Convert.ToDecimal(this.sFDBDataSet.Articulo.Rows[i]["IdRubro"].ToString()));
                this.lvArticulos.Items[i].SubItems.Add(Cadena.ToLower());
                this.lvArticulos.Items[i].SubItems.Add(this.sFDBDataSet.Articulo.Rows[i]["Descripcion"].ToString());
                Precio = ObtenerPrecio(Convert.ToDecimal(this.sFDBDataSet.Articulo.Rows[i]["IdArticulo"].ToString()), 1);
                this.lvArticulos.Items[i].SubItems.Add(Precio.ToString("#,##0.00"));
                Precio = ObtenerPrecio(Convert.ToDecimal(this.sFDBDataSet.Articulo.Rows[i]["IdArticulo"].ToString()), 2);
                this.lvArticulos.Items[i].SubItems.Add(Precio.ToString("#,##0.00"));
                Precio = ObtenerPrecio(Convert.ToDecimal(this.sFDBDataSet.Articulo.Rows[i]["IdArticulo"].ToString()), 3);
                this.lvArticulos.Items[i].SubItems.Add(Precio.ToString("#,##0.00"));                
                Precio = ObtenerPrecio(Convert.ToDecimal(this.sFDBDataSet.Articulo.Rows[i]["IdArticulo"].ToString()), 4);
                this.lvArticulos.Items[i].SubItems.Add(Precio.ToString("#,##0.00"));  
            }
        }

        private string ObtenerRubroArticulo(decimal IdRubro)
        {
            string Rubro=null;
            foreach(DataRow Fila in this.sFDBDataSet.Rubro)
            {
                if(IdRubro==Convert.ToDecimal(Fila["IdRubro"].ToString()))
                {
                    Rubro=Fila["Descripcion"].ToString();
                    break;
                }
                    
            }
            return Rubro;
        }

        private decimal ObtenerPrecio(decimal CodigoA, decimal CodigoC)
        {
            //Con este procedimiento se obtiene el precio del articulo mediante el codigo de articulo, y el codigo de categoria del cliente.
            decimal Precio = 0;
            decimal CodA = CodigoA;
            decimal CodC = CodigoC;
            foreach (DataRow Fila in this.sFDBDataSet.ArticuloCategoriaC)
            {
                if (Convert.ToDecimal(Fila["IdCategoriaC"].ToString()) == CodC)
                {
                    if (Convert.ToDecimal(Fila["IdArticulo"].ToString()) == CodA)
                    {
                        Precio = Convert.ToDecimal(Fila["Precio"].ToString());
                        break; 
                    }
                }
            }
            return Precio;
        }
        //---
        private void lvArticulos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //Con este procedimiento se hace una instancia a la clase ListViewItemComparer pasandole como parametro la columna presionada para poder ordenar el ListView.
            this.lvArticulos.ListViewItemSorter = new ListViewItemComparer(e.Column);
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
            this.printDocument1.DocumentName = "Listado de Articulos";
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
            for (int i = Contador; i <= this.lvArticulos.Items.Count - 1; i++)
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
            e.Graphics.DrawString("Listado de Artículos", FuenteA, Brushes.Black, MargenIzquierdo, MargenSuperior + PosLinea);
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToShortDateString(), FuenteA, Brushes.Black, MargenDerecho - 135, MargenSuperior + PosLinea);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo, MargenSuperior + 3 * PosLinea, MargenDerecho, MargenSuperior + 3 * PosLinea);
            e.Graphics.DrawString("Código", Fuente, Brushes.Black, MargenIzquierdo + 2, 50 + 4 * PosLinea);
            e.Graphics.DrawString("Categoría", Fuente, Brushes.Black, MargenIzquierdo + 60, 50 + 4 * PosLinea);
            e.Graphics.DrawString("Descripción", Fuente, Brushes.Black, MargenIzquierdo + 250, 50 + 4 * PosLinea);
            e.Graphics.DrawString("P. Especial", Fuente, Brushes.Black, MargenDerecho - 290, 50 + 4 * PosLinea);
            e.Graphics.DrawString("P. Estándar", Fuente, Brushes.Black, MargenDerecho - 220, 50 + 4 * PosLinea);
            e.Graphics.DrawString("P. Franquicia", Fuente, Brushes.Black, MargenDerecho - 145, 50 + 4 * PosLinea);
            e.Graphics.DrawString("P. Mayorista", Fuente, Brushes.Black, MargenDerecho - 65, 50 + 4 * PosLinea);
        }

        private void AgregarContenido(System.Drawing.Printing.PrintPageEventArgs e, int i, int LineaActual)
        {
            float MargenSuperior = e.MarginBounds.Top;
            float MargenIzquierdo = e.MarginBounds.Left;
            float MargenDerecho = e.MarginBounds.Right;
            float PosY = 0;
            PosY = MargenSuperior + LineaActual * Fuente.GetHeight(e.Graphics);
            e.Graphics.DrawString(this.lvArticulos.Items[i].Text, Fuente, Brushes.Black, MargenIzquierdo + 8, PosY);
            e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[1].Text, Fuente, Brushes.Black, MargenIzquierdo + 50, PosY);
            e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[2].Text, Fuente, Brushes.Black, MargenIzquierdo + 140, PosY);
            int Longitud = this.lvArticulos.Items[i].SubItems[3].Text.Length;
            switch (Longitud)
            {
                case 4:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[3].Text, Fuente, Brushes.Black, MargenIzquierdo + 480, PosY);
                    break;
                case 5:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[3].Text, Fuente, Brushes.Black, MargenIzquierdo + 454, PosY);
                    break;
                case 6:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[3].Text, Fuente, Brushes.Black, MargenIzquierdo + 448, PosY);
                    break;
                case 7:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[3].Text, Fuente, Brushes.Black, MargenIzquierdo + 432, PosY);
                    break;
            }
            Longitud = this.lvArticulos.Items[i].SubItems[4].Text.Length;
            switch (Longitud)
            {
                case 4:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[4].Text, Fuente, Brushes.Black, MargenDerecho - 197, PosY);
                    break;
                case 5:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[4].Text, Fuente, Brushes.Black, MargenDerecho - 203, PosY);
                    break;
                case 6:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[4].Text, Fuente, Brushes.Black, MargenDerecho - 209, PosY);
                    break;
                case 7:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[4].Text, Fuente, Brushes.Black, MargenDerecho - 215, PosY);
                    break;
            }
            Longitud = this.lvArticulos.Items[i].SubItems[5].Text.Length;
            switch (Longitud)
            {
                case 4:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[5].Text, Fuente, Brushes.Black, MargenDerecho - 117, PosY);
                    break;
                case 5:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[5].Text, Fuente, Brushes.Black, MargenDerecho - 123, PosY);
                    break;
                case 6:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[5].Text, Fuente, Brushes.Black, MargenDerecho - 129, PosY);
                    break;
                case 7:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[5].Text, Fuente, Brushes.Black, MargenDerecho - 135, PosY);
                    break;
            }
            Longitud = this.lvArticulos.Items[i].SubItems[6].Text.Length;
            switch (Longitud)
            {
                case 4:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[6].Text, Fuente, Brushes.Black, MargenDerecho - 37, PosY);
                    break;
                case 5:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[6].Text, Fuente, Brushes.Black, MargenDerecho - 43, PosY);
                    break;
                case 6:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[6].Text, Fuente, Brushes.Black, MargenDerecho - 49, PosY);
                    break;
                case 7:
                    e.Graphics.DrawString(this.lvArticulos.Items[i].SubItems[6].Text, Fuente, Brushes.Black, MargenDerecho - 54, PosY);
                    break;
            }
        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            Bandera = false;
        }
        //Estos procedimientos muestran informacion acerca de los controles
        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cierra el formulario de listado de Artículos.";
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
