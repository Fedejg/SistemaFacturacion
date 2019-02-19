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
    public partial class frmPrincipal : Form
    {
        private Font Fuente = new Font("Tahoma", 8);
        private PageSettings MiConfiguracionPagina;
        private ListView lvProduccion = new ListView();
        private bool Bandera = false;
        private int Contador = 0;
        private int TotalProduccion = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sFDBDataSet.LineaProduccion' Puede moverla o quitarla según sea necesario.
            this.lineaProduccionTableAdapter.Fill(this.sFDBDataSet.LineaProduccion);
            // TODO: esta línea de código carga datos en la tabla 'sFDBDataSet.Produccion' Puede moverla o quitarla según sea necesario.
            this.produccionTableAdapter.Fill(this.sFDBDataSet.Produccion);
            // TODO: esta línea de código carga datos en la tabla 'sFDBDataSet.LineaPedido' Puede moverla o quitarla según sea necesario.
            this.lineaPedidoTableAdapter.Fill(this.sFDBDataSet.LineaPedido);
            // TODO: esta línea de código carga datos en la tabla 'sFDBDataSet.Pedido' Puede moverla o quitarla según sea necesario.
            this.pedidoTableAdapter.Fill(this.sFDBDataSet.Pedido);
            // TODO: esta línea de código carga datos en la tabla 'sFDBDataSet.Rubro' Puede moverla o quitarla según sea necesario.
            this.rubroTableAdapter.Fill(this.sFDBDataSet.Rubro);
            // TODO: esta línea de código carga datos en la tabla 'sFDBDataSet.Articulo' Puede moverla o quitarla según sea necesario.
            this.articuloTableAdapter.Fill(this.sFDBDataSet.Articulo);
            this.lvProduccion.Items.Clear();
            this.printDocument1.DefaultPageSettings.Landscape = false;
        }

        private void AgregarNuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAltaCliente ofrmAltaCliente = new frmAltaCliente();
            ofrmAltaCliente.Show();
        }

        private void ConsultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCliente ofrmConsultaCliente = new frmConsultaCliente();
            ofrmConsultaCliente.Show();
        }

        private void SeleccionarEditarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarCliente ofrmEditarCliente = new frmEditarCliente();
            ofrmEditarCliente.Show();
        }

        private void ListarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarCliente ofrmListarCliente = new frmListarCliente();
            ofrmListarCliente.Show();
        }

        private void ToolStripAltaCliente_Click(object sender, EventArgs e)
        {
            frmAltaCliente ofrmAltaCliente = new frmAltaCliente();
            ofrmAltaCliente.Show();
        }

        private void ToolStripConsultaCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente ofrmConsultaCliente = new frmConsultaCliente();
            ofrmConsultaCliente.Show();
        }

        private void ToolStripEditarCliente_Click(object sender, EventArgs e)
        {
            frmEditarCliente ofrmEditarCliente = new frmEditarCliente();
            ofrmEditarCliente.Show();
        }

        private void AgregarNuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAltaArticulo ofrmAltaArticulo = new frmAltaArticulo();
            ofrmAltaArticulo.Show();
        }

        private void ConsultarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaArticulo ofrmConsultaArticulo = new frmConsultaArticulo();
            ofrmConsultaArticulo.Show();
        }

        private void seleccionarEditarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarArticulo ofrmEditarArticulo = new frmEditarArticulo();
            ofrmEditarArticulo.Show();
        }

        private void listarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarArticulo ofrmListarArticulo = new frmListarArticulo();
            ofrmListarArticulo.Show();
        }

        private void EmitirRemitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaRemito ofrmAltaRemito = new frmAltaRemito();
            ofrmAltaRemito.Show();
        }

        private void ConsultarRemitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaRemito ofrmConsultaRemito = new frmConsultaRemito();
            ofrmConsultaRemito.Show();
        }

        private void ModificarEstadoDeRemitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificaRemito ofrmModificarRemito = new frmModificaRemito();
            ofrmModificarRemito.Show();
        }

        private void EmitirFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaFactura ofrmAltaFactura = new frmAltaFactura();
            ofrmAltaFactura.Show();
        }

        private void ConsultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarFactura ofrmConsultaFactura=new frmConsultarFactura();
            ofrmConsultaFactura.Show();
        }

        private void CreditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreditos frm = new frmCreditos();
            frm.ShowDialog();
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe frm = new frmAcercaDe();
            frm.ShowDialog();
        }

        private void emitirPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaPedido frm = new frmAltaPedido();
            frm.ShowDialog();
        }

        private void listarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarPedidos frm = new frmListarPedidos();
            frm.ShowDialog();
        }

        private void ProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvProduccion.Items.Clear();
            TotalProduccion=GenerarListaProduccion();
            bool Bandera = RegistrarProduccion();
            if(Bandera==false)
            {
                //Configurar();
                try
                {
                    VistaPreliminar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int GenerarListaProduccion()
        {
            int IdArt; 
            decimal IdRub;
            string Desc;
            decimal TotalProd = 0;
            decimal CantPedida = 0;
            foreach (DataRow Fila in this.sFDBDataSet.Articulo)
            {
                IdArt =int.Parse(Fila["IdArticulo"].ToString());
                IdRub = Convert.ToDecimal(Fila["IdRubro"].ToString());
                Desc = Fila["Descripcion"].ToString();
                switch (Desc)
                {
                    case "PAN FRANCES X KG.":   
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[0].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[0].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[0].SubItems.Add(IdArt.ToString());
                        break;
                    case "PAN MIGNON X KG.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[1].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[1].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[1].SubItems.Add(IdArt.ToString());
                        break;
                    case "PAN SANDWICHERO X KG.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[2].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[2].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[2].SubItems.Add(IdArt.ToString());
                        break;
                    case "PAN ALEMAN X KG.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[3].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[3].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[3].SubItems.Add(IdArt.ToString());
                        break;
                    case "PAN TRENSADO X KG.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[4].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[4].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[4].SubItems.Add(IdArt.ToString());
                        break;
                    case "PAN MALTEADO X KG.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[5].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[5].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[5].SubItems.Add(IdArt.ToString());
                        break;
                    case "TORTILLAS FINAS X UN.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[6].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[6].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[6].SubItems.Add(IdArt.ToString());
                        break;
                    case "TORTILLAS GRUESAS X UN.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[7].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[7].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[7].SubItems.Add(IdArt.ToString());
                        break;
                    case "CUERNITOS X UN.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[8].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[8].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[8].SubItems.Add(IdArt.ToString());
                        break;
                    case "TOMATITOS X UN.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[9].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[9].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[9].SubItems.Add(IdArt.ToString());
                        break;
                    case "BOLLITOS X UN.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[10].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[10].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[10].SubItems.Add(IdArt.ToString());
                        break;
                    case "FACTURAS CON CREMA X UN.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[11].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[11].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[11].SubItems.Add(IdArt.ToString());
                        break;
                    case "MEDIALUNAS X UN.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[12].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[12].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[12].SubItems.Add(IdArt.ToString());
                        break;
                    case "VIGILANTES X UN.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[13].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[13].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[13].SubItems.Add(IdArt.ToString());
                        break;
                    case "SACRAMENTOS X UN.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[14].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[14].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[14].SubItems.Add(IdArt.ToString());
                        break;
                    case "MEDIALUNAS RELLENAS X UN.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[15].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[15].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[15].SubItems.Add(IdArt.ToString());
                        break;
                    case "PAN DE LECHE RELLENO X UN.":
                        lvProduccion.Items.Add(ObtenerRubro(IdRub));
                        lvProduccion.Items[16].SubItems.Add(Desc);
                        CantPedida = ObtenerCantidadPedida(IdArt);
                        lvProduccion.Items[16].SubItems.Add(CantPedida.ToString());
                        lvProduccion.Items[16].SubItems.Add(IdArt.ToString());
                        break;
                }
                TotalProd = TotalProd + CantPedida;
            }
            return int.Parse(TotalProd.ToString());
        }

        private string ObtenerRubro(decimal IdRub)
        {
            string Rubro = null;
            foreach(DataRow Fila in this.sFDBDataSet.Rubro)
            {
                if(IdRub==Convert.ToDecimal(Fila["IdRubro"].ToString()))
                {
                    Rubro = Fila["Descripcion"].ToString();
                    break;
                }
            }
            return Rubro;
        }

        private decimal ObtenerCantidadPedida(int IdArt)
        {
            DateTime Fecha= DateTime.Now;
            return Convert.ToDecimal(this.lineaPedidoTableAdapter.ObtenerTotalPedido(IdArt,Fecha.ToShortDateString()));
        }

        private bool RegistrarProduccion()
        {
            Bandera = false;
            DateTime Fecha = DateTime.Now;
            int PedidosHoy = int.Parse(this.pedidoTableAdapter.PedidosRealizadosHoy(Fecha.ToShortDateString()).ToString());
            if (PedidosHoy != 0)
            {
                if (MessageBox.Show("Se esta por generar una nueva Orden de Producción, esta seguro que desea continuar?", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    //Registro la Produccion en DB
                    DateTime FechaActual = DateTime.Now;
                    this.produccionTableAdapter.InsertarProduccion(FechaActual, TotalProduccion);
                    int IdProd = int.Parse(this.produccionTableAdapter.ObtenerUltimaProduccion().ToString());
                    //Registro las Lineas de Produccion
                    for (int i = 0; i < this.lvProduccion.Items.Count; i++)
                    {
                        int TotalLinea = int.Parse(this.lvProduccion.Items[i].SubItems[2].Text);
                        int IdArt = int.Parse(this.lvProduccion.Items[i].SubItems[3].Text);
                        this.lineaProduccionTableAdapter.InsertarLineaProduccion(TotalLinea, IdProd, IdArt);
                    }
                    //Actualizo los Pedidos y los vinculo a la Produccion
                    DateTime FechaRef1 = Convert.ToDateTime("08:00:00");
                    DateTime FechaRef2 = Convert.ToDateTime("13:00:00");
                    DateTime FechaRef3 = Convert.ToDateTime("18:00:00");
                    DateTime FechaRef4 = Convert.ToDateTime("23:00:00");
                    DateTime FechaDiurnaInicial = new DateTime(FechaActual.Year, FechaActual.Month, FechaActual.Day, FechaRef1.Hour, FechaRef1.Minute, FechaRef1.Second);
                    DateTime FechaDiurnaFinal = new DateTime(FechaActual.Year, FechaActual.Month, FechaActual.Day, FechaRef2.Hour, FechaRef2.Minute, FechaRef2.Second);
                    DateTime FechaNocturnaInicial = new DateTime(FechaActual.Year, FechaActual.Month, FechaActual.Day, FechaRef3.Hour, FechaRef3.Minute, FechaRef3.Second);
                    DateTime FechaNocturnaFinal = new DateTime(FechaActual.Year, FechaActual.Month, FechaActual.Day, FechaRef4.Hour, FechaRef4.Minute, FechaRef4.Second);
                    if ((FechaActual > FechaDiurnaInicial) && (FechaActual < FechaDiurnaFinal))
                    {
                        this.pedidoTableAdapter.VincularProduccionDiurna(IdProd, FechaActual.ToShortDateString());
                    }
                    else
                    {
                        if ((FechaActual > FechaNocturnaInicial) && (FechaActual < FechaNocturnaFinal))
                        {
                            this.pedidoTableAdapter.VincularProduccionNocturna(IdProd, FechaActual.ToShortDateString());
                        }
                    }
                }
            }
            else
            {
                if (MessageBox.Show("No ha sido registrado algun Pedido en el dia de la Fecha. No se puede generar una Orden de Produccion hasta ingresar al menos un Pedido. Desea Ingresarlo ahora?", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    frmAltaPedido frm = new frmAltaPedido();
                    frm.ShowDialog();
                    Bandera = true;
                }
            }
            return Bandera;
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
            this.printDocument1.DocumentName = "Orden de Produccion - Fecha: "+ DateTime.Now.ToShortDateString();
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
            bool BandP=false, BandT=false,BandF = false;
            int LineaActual = 6;
            e.HasMorePages = false;
            LineasPorPagina = e.MarginBounds.Height / Fuente.GetHeight(e.Graphics);
            AgregarEncabezado(e);
            LineaActual = 10;
            for (int i = Contador; i <= this.lvProduccion.Items.Count - 1; i++)
            {
                if (LineaActual < LineasPorPagina)
                {
                    string Cadena = this.lvProduccion.Items[i].Text;
                    switch (Cadena)
                    {
                        case "PANIFICADOS":
                            if (BandP == false)
                            {
                                AgregarTituloP(e);
                                AgregarContenido(e, i, LineaActual);
                                BandP = true;
                            }
                            else
                                AgregarContenido(e, i, LineaActual);
                            break;
                        case "TORTILLAS":
                            if(BandT==false)
                            {
                                LineaActual = 22;
                                AgregarTituloT(e);
                                AgregarContenido(e, i, LineaActual);
                                BandT = true;
                            }
                            else
                                AgregarContenido(e, i, LineaActual);
                            break;
                        case "FACTURAS":
                            if(BandF==false)
                            {
                                LineaActual = 33;
                                AgregarTituloF(e);
                                AgregarContenido(e, i, LineaActual);
                                BandF = true;
                            }
                            else
                                AgregarContenido(e, i, LineaActual);
                            break;
                    }
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
            AgregarTotalProduccion(e);
        }

        private void AgregarEncabezado(System.Drawing.Printing.PrintPageEventArgs e)
        {
            float PosLinea = Fuente.GetHeight(e.Graphics);
            Font FuenteA = new Font("Tahoma", 10, FontStyle.Bold);
            float MargenIzquierdo = e.MarginBounds.Left;
            float MargenSuperior = e.MarginBounds.Top;
            float MargenDerecho = e.MarginBounds.Right;
            e.Graphics.DrawString("ORDEN DE PRODUCCIÓN", FuenteA, Brushes.Black, MargenIzquierdo, MargenSuperior + PosLinea);
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToShortDateString(), FuenteA, Brushes.Black, MargenDerecho - 135, MargenSuperior + PosLinea);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo, MargenSuperior + 3 * PosLinea, MargenDerecho, MargenSuperior + 3 * PosLinea);
        }

        private void AgregarTituloP(System.Drawing.Printing.PrintPageEventArgs e)
        {
            float PosLinea = Fuente.GetHeight(e.Graphics);
            Font FuenteA = new Font("Tahoma", 10, FontStyle.Bold);
            float MargenIzquierdo = e.MarginBounds.Left;
            float MargenSuperior = e.MarginBounds.Top;
            float MargenDerecho = e.MarginBounds.Right;
            e.Graphics.DrawString("Producción de Panificados", FuenteA, Brushes.Black, MargenIzquierdo, MargenSuperior + 5 * PosLinea);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo, MargenSuperior + 7 * PosLinea, MargenDerecho, MargenSuperior + 7 * PosLinea);
            e.Graphics.DrawString("Rubro", Fuente, Brushes.Black, MargenIzquierdo + 20, 50 + 8 * PosLinea);
            e.Graphics.DrawString("Producto", Fuente, Brushes.Black, MargenIzquierdo + 100, 50 + 8 * PosLinea);
            e.Graphics.DrawString("Total Producción", Fuente, Brushes.Black, MargenDerecho - 100, 50 + 8 * PosLinea);
        }

        private void AgregarTituloT(System.Drawing.Printing.PrintPageEventArgs e)
        {
            float PosLinea = Fuente.GetHeight(e.Graphics);
            Font FuenteA = new Font("Tahoma", 10, FontStyle.Bold);
            float MargenIzquierdo = e.MarginBounds.Left;
            float MargenSuperior = e.MarginBounds.Top;
            float MargenDerecho = e.MarginBounds.Right;
            e.Graphics.DrawString("Producción de Tortillas", FuenteA, Brushes.Black, MargenIzquierdo, MargenSuperior + 17 * PosLinea);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo, MargenSuperior + 19 * PosLinea, MargenDerecho, MargenSuperior + 19 * PosLinea);
            e.Graphics.DrawString("Rubro", Fuente, Brushes.Black, MargenIzquierdo + 20, 50 + 20 * PosLinea);
            e.Graphics.DrawString("Producto", Fuente, Brushes.Black, MargenIzquierdo + 100, 50 + 20 * PosLinea);
            e.Graphics.DrawString("Total Producción", Fuente, Brushes.Black, MargenDerecho - 100, 50 + 20 * PosLinea);
        }
        private void AgregarTituloF(System.Drawing.Printing.PrintPageEventArgs e)
        {
            float PosLinea = Fuente.GetHeight(e.Graphics);
            Font FuenteA = new Font("Tahoma", 10, FontStyle.Bold);
            float MargenIzquierdo = e.MarginBounds.Left;
            float MargenSuperior = e.MarginBounds.Top;
            float MargenDerecho = e.MarginBounds.Right;
            e.Graphics.DrawString("Produccion de Facturas", FuenteA, Brushes.Black, MargenIzquierdo, MargenSuperior + 28 * PosLinea);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo, MargenSuperior + 30 * PosLinea, MargenDerecho, MargenSuperior + 30 * PosLinea);
            e.Graphics.DrawString("Rubro", Fuente, Brushes.Black, MargenIzquierdo + 20, 50 + 31 * PosLinea);
            e.Graphics.DrawString("Producto", Fuente, Brushes.Black, MargenIzquierdo + 100, 50 + 31 * PosLinea);
            e.Graphics.DrawString("Total Producción", Fuente, Brushes.Black, MargenDerecho - 100, 50 + 31 * PosLinea);
        }
        private void AgregarContenido(System.Drawing.Printing.PrintPageEventArgs e, int i, int LineaActual)
        {
            float MargenSuperior = e.MarginBounds.Top;
            float MargenIzquierdo = e.MarginBounds.Left;
            float MargenDerecho = e.MarginBounds.Right;
            float PosY = 0;
            PosY = MargenSuperior + LineaActual * Fuente.GetHeight(e.Graphics);
            e.Graphics.DrawString(this.lvProduccion.Items[i].Text, Fuente, Brushes.Black, MargenIzquierdo + 8, PosY);
            e.Graphics.DrawString(this.lvProduccion.Items[i].SubItems[1].Text, Fuente, Brushes.Black, MargenIzquierdo + 100, PosY);
            e.Graphics.DrawString(this.lvProduccion.Items[i].SubItems[2].Text, Fuente, Brushes.Black, MargenDerecho - 60, PosY);
        }

        private void AgregarTotalProduccion(System.Drawing.Printing.PrintPageEventArgs e)
        {
            float PosLinea = Fuente.GetHeight(e.Graphics);
            Font FuenteA = new Font("Tahoma", 10, FontStyle.Bold);
            float MargenIzquierdo = e.MarginBounds.Left;
            float MargenSuperior = e.MarginBounds.Top;
            float MargenDerecho = e.MarginBounds.Right;
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo, MargenSuperior + 41 * PosLinea, MargenDerecho, MargenSuperior + 41 * PosLinea);
            e.Graphics.DrawString("TOTAL DE PRODUCCION", FuenteA, Brushes.Black, MargenIzquierdo, MargenSuperior + 42 * PosLinea);
            e.Graphics.DrawString(TotalProduccion.ToString(), FuenteA, Brushes.Black, MargenDerecho - 60, MargenSuperior + 42 * PosLinea);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo, MargenSuperior + 44 * PosLinea, MargenDerecho, MargenSuperior + 44 * PosLinea);
       
        }
        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            Bandera = false;
        }

        private void entreFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVentas frm = new frmReporteVentas();
            frm.ShowDialog();
        }

        private void rankingDeArtículosPorPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRanking frm = new frmRanking();
            frm.ShowDialog();
        }

        private void modificarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarStock frm = new frmModificarStock();
            frm.ShowDialog();
        }

        private void listarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarFactura frm = new frmListarFactura();
            frm.ShowDialog();
        }

        private void ingresarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaPago frm = new frmAltaPago();
            frm.ShowDialog();
        }

    }
}
