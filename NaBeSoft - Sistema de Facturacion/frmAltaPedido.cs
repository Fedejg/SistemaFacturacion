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
using System.IO;

namespace NaBeSoft___Sistema_de_Facturacion
{
    public partial class frmAltaPedido : Form
    {
        string RutaArchivo = System.Windows.Forms.Application.StartupPath + ".\\Comercial (Datos)\\MPedido.sce";
        //private FileStream MCodPedido;
        private int Contador = 0;
        private decimal Codigo;
        private bool Bandera = false;
        private bool Band = false;
        private Font Fuente = new Font("Tahoma", 8);
        //private PageSettings MiConfiguracionPagina;
        private int CodCat;
        private int CodCli;
        private int NLoc;

        public frmAltaPedido()
        {
            InitializeComponent();
        }

        private void frmAltaRemito_Load(object sender, EventArgs e)
        {
            this.rubroTableAdapter.Fill(this.sFBDDataSet.Rubro);
            this.stockTableAdapter.Fill(this.sFBDDataSet.Stock);
            this.printDocument1.DefaultPageSettings.Landscape = true;
            this.txtFecha.Text = DateTime.Now.ToShortDateString();
            ObtenerCodPedido();
            CargarTablas();
            CargarComboCliente();
        }
        private void ObtenerCodPedido()
        {
            int Codigo = 0;
            if (File.Exists(RutaArchivo) == true)
            {
                Codigo = Convert.ToInt32(File.ReadAllText(RutaArchivo));
                if (Codigo == 100000000)
                {
                    Codigo = 0;
                }
            }
            else
            {
                File.Create(RutaArchivo);
                Codigo = 0;
            }
            //le asigno al campo numero de remito un incremento de 1 del numero leido del archivo, que representa el ultimo numero asignado.
            Codigo += 1;
            this.txtPedido.Text = Codigo.ToString("0000-00000000");
        }

        private void CargarTablas()
        {
            try
            {
                this.clienteTableAdapter.Fill(this.sFBDDataSet.Cliente);
                this.localidadTableAdapter.Fill(this.sFBDDataSet.Localidad);
                this.articuloTableAdapter.Fill(this.sFBDDataSet.Articulo);
                this.articuloCategoriaCTableAdapter.Fill(this.sFBDDataSet.ArticuloCategoriaC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarComboCliente()
        {
            foreach (DataRow Fila in this.sFBDDataSet.Cliente)
            {
                if(Fila["Borrado"].ToString()=="N")
                    this.cmbCli.Items.Add(Fila["RazonSocial"].ToString());
            }
        }
        //---
        private void cmbCli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode < Keys.Left || e.KeyCode > Keys.Down)
            {
                Bandera = true;
            }
        }

        private void cmbCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Bandera == true)
            {
                e.Handled = true;
            }
        }

        private void cmbCli_TextChanged(object sender, EventArgs e)
        {
            if (this.cmbCli.Text == "")
            {
                this.txtNom.Text = null;
                this.txtDirCliente.Text = null;
            }
        }

        private void cmbCli_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.dgvLineaPedido.Rows.Clear();
            int Codigo = 0;
            foreach (DataRow FilaC in this.sFBDDataSet.Cliente)
            {
                string Cadena=FilaC["RazonSocial"].ToString();
                string Cadena2=this.cmbCli.SelectedItem.ToString();
                if (Cadena==Cadena2)
                {
                    Codigo = int.Parse(FilaC["IdCliente"].ToString());
                    CodCli = Codigo;
                    CodCat = int.Parse(FilaC["IdCategoriaC"].ToString());
                    NLoc = int.Parse(FilaC["IdLocalidad"].ToString());
                    this.txtDirCliente.Text = FilaC["Domicilio"].ToString();
                    break;
                }
            }
            foreach (DataRow Fila in this.sFBDDataSet.Localidad)
            {
                if (NLoc == int.Parse(Fila["IdLocalidad"].ToString()))
                {
                    this.txtNom.Text = Fila["Nombre"].ToString();
                    break;
                }
            }
        }

        private void cmbCli_Leave(object sender, EventArgs e)
        {
            if (this.btnCancelar.Focused == false)
            {
                if (this.cmbCli.Text == "Seleccione un Cliente..." || this.cmbCli.Text == "")
                {
                    MessageBox.Show("Debe seleccionar un Cliente de la lista, para poder remitir el pedido", "Sistema de Facturaciónl", MessageBoxButtons.OK);
                    cmbCli.Select();
                }
            }
        }
        //---
        private void dgvLineaPedido_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int i = this.dgvLineaPedido.CurrentCellAddress.Y;
            if (this.dgvLineaPedido.RowCount == 33)
            {
                MessageBox.Show("Usted ha alcanzado el limite maximo de ingreso de Artículos. Si todavia necesita ingresar mas Artículos, termine la edicion de la fila Actual, y genere un nuevo Remito.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.dgvLineaPedido.CurrentCell.Value = null;
                Band = true;
            }
        }

        private void dgvLineaPedido_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int CoordenadaY = this.dgvLineaPedido.CurrentCellAddress.Y;
            if (ValidarCodigo(CoordenadaY, this.dgvLineaPedido.CurrentRow.Cells[0].Value.ToString()) == false)
            {
                MessageBox.Show("El formato del código ingresado es incorrecto, asegurese de ingresar solamente caracteres numericos.", "Sistema de Facturación", MessageBoxButtons.OK);
                this.dgvLineaPedido.CurrentCell.Value = null;
                return;
            }
            
            if (CoordenadaY >= 0)
            {
                decimal Celda = Convert.ToDecimal(this.dgvLineaPedido.CurrentRow.Cells["ColumnCodigo"].Value);
                if(ChequearCodigoenDB(CoordenadaY,this.dgvLineaPedido.CurrentRow.Cells[0].Value.ToString()) ==true)
                {
                    MessageBox.Show("El Artículo no existe en la base de datos.", "Sistema de Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.dgvLineaPedido.CurrentCell.Value = null;
                    this.dgvLineaPedido.CurrentRow.Cells["ColumnDescripcion"].Value=null;
                    this.dgvLineaPedido.CurrentRow.Cells["ColumnPrecio"].Value = null;
                    return;
                }
                if (ChequearCodigo(CoordenadaY, Celda) == true)
                {
                    MessageBox.Show("El Código del Artículo ya fue ingresado anteriormente, solo puede ingresar una linea por Remito en relacion a ese Codigo.", "Sistema de Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.dgvLineaPedido.CurrentCell.Value = null;
                    return;
                }
            }
            switch (this.dgvLineaPedido.CurrentCellAddress.X)
            {
                case 0: CargarColumnas23();
                    break;
                case 3: if (this.dgvLineaPedido.CurrentRow.Cells["ColumnCantidad"].Value != null)
                        {
                            if (this.dgvLineaPedido.CurrentRow.Cells["ColumnCantidad"].Value == null)
                            {
                                MessageBox.Show("La Cantidad Ingresada debe ser mayor a 0", "Sistema de Facturación", MessageBoxButtons.OK);
                                this.dgvLineaPedido.CurrentRow.Cells["ColumnImporteP"].Value = null;
                                return;
                            }
                        }
                        else
                        {
                            this.dgvLineaPedido.CurrentRow.Cells["ColumnImporteP"].Value = null;
                        }
                        CargarColumna4();
                        if (Band == true)
                        {
                            this.btnGuardar.Select();
                        }
                        break;
                case 4: ModificarColumna4();
                    break;
            }
        }

        private bool ChequearCodigoenDB(int CoodenadaY, string Celda)
        {
            int IdArticulo = int.Parse(Celda);
            this.articuloTableAdapter.FillByArticulo(this.sFBDDataSet.Articulo, IdArticulo);
            if(this.sFBDDataSet.Articulo.Rows.Count==0)
                return true;
            else
                return false;
        }

        private bool ValidarCodigo(int CoordenadaY, string Celda)
        {
            bool Respuesta = false;
            string Cadena = Celda;
            int Longitud = Celda.Length;
            for (int i = 1; i <= Longitud; i++)
            {
                switch (Cadena[i - 1].ToString())
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
                break;
            }
            return Respuesta;
        }

        private bool ChequearCodigo(int CoordenadaY, decimal Celda)
        {
            int Contador = CoordenadaY - 1;
            bool Bandera = false;
            if (this.dgvLineaPedido.CurrentRow.Cells["ColumnCodigo"].Value != null)
            {
                while (Contador >= 0)
                {
                    if (Convert.ToDecimal(this.dgvLineaPedido.Rows[Contador].Cells["ColumnCodigo"].Value) == Celda)
                    {
                        Bandera = true;
                    }
                    Contador -= 1;
                }
            }
            if (Bandera == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CargarColumnas23()
        {
            Codigo = Convert.ToDecimal(this.dgvLineaPedido.CurrentRow.Cells["ColumnCodigo"].Value);
            if (this.dgvLineaPedido.CurrentRow.Cells["ColumnCodigo"].Value == null)
            {
                this.dgvLineaPedido.CurrentRow.Cells["ColumnDescripcion"].Value = null;
                this.dgvLineaPedido.CurrentRow.Cells["ColumnPrecio"].Value = null;
            }
            else
            {
                if (this.dgvLineaPedido.CurrentRow.Cells["ColumnCodigo"].Value != null)
                {
                    this.dgvLineaPedido.CurrentRow.Cells["ColumnCodigo"].Value = Codigo.ToString("00000");
                }
                foreach (DataRow FilaA in this.sFBDDataSet.Articulo)
                {
                    if (int.Parse(FilaA["IdArticulo"].ToString()) == Codigo)
                    {
                        this.dgvLineaPedido.CurrentRow.Cells["ColumnDescripcion"].Value = FilaA["Descripcion"].ToString();
                        break;
                    }
                }
                foreach (DataRow FilaCA in this.sFBDDataSet.ArticuloCategoriaC)
                {
                    if (int.Parse(FilaCA["IdArticulo"].ToString()) == Codigo)
                    {
                        if (int.Parse(FilaCA["IdCategoriaC"].ToString()) == CodCat)
                        {
                            this.dgvLineaPedido.CurrentRow.Cells["ColumnPrecio"].Value = FilaCA["Precio"].ToString();
                            break; 
                        }
                    }
                }
            }
        }

        public void CargarColumna4()
        {
            string Cadena = null;
            decimal Cantidad = 0;
            int Stock=0;
            int StockS=0;
            //Esta porcion de codigo obtiene el stock de seguridad y la cantidad para el articulo
            int IdArt=int.Parse(this.dgvLineaPedido.CurrentRow.Cells["ColumnCodigo"].Value.ToString());
            this.stockTableAdapter.FillByStockArticulo(this.sFBDDataSet.Stock,IdArt);
            foreach(DataRow Fila in this.sFBDDataSet.Stock)
            {
                if(IdArt==int.Parse(Fila["IdArticulo"].ToString()))
                {
                    Stock=int.Parse(Fila["CantStock"].ToString());
                    StockS=int.Parse(Fila["StockSeguridad"].ToString());
                    break;
                }
            }

            if (this.dgvLineaPedido.CurrentRow.Cells["ColumnCodigo"].Value != null)
            {
                int CoordenadaY = this.dgvLineaPedido.CurrentCellAddress.Y;
                //Esta porcion de codigo valida que el formato ingresado como cantidad es correcto               
                if (ValidarCodigo(CoordenadaY, this.dgvLineaPedido.CurrentRow.Cells["ColumnCantidad"].Value.ToString()) == false)
                {
                    MessageBox.Show("El formato del código ingresado es incorrecto, asegurese de ingresar solamente caracteres numericos.", "Sistema de Facturación", MessageBoxButtons.OK);
                    decimal Importe = Convert.ToDecimal(txtImporteT.Text) - Convert.ToDecimal(this.dgvLineaPedido.CurrentRow.Cells["ColumnImporteP"].Value);
                    txtImporteT.Text = Importe.ToString();
                    this.dgvLineaPedido.CurrentCell.Value = null;
                    this.dgvLineaPedido.CurrentRow.Cells["ColumnImporteP"].Value = null;
                    return;
                }
                Cadena = this.dgvLineaPedido.CurrentRow.Cells["ColumnCantidad"].Value.ToString();
                if (this.dgvLineaPedido.CurrentRow.Cells["ColumnCantidad"].Value != null)
                {
                    //esta porcion de codigo cambia el formato de los datos ingresados
                    if (Cadena.Contains('.') == true)
                    {
                        this.dgvLineaPedido.CurrentRow.Cells["ColumnCantidad"].Value = Cadena.Replace('.', ',');
                        Codigo = Convert.ToDecimal(this.dgvLineaPedido.CurrentRow.Cells["ColumnCantidad"].Value);
                        this.dgvLineaPedido.CurrentRow.Cells["ColumnCantidad"].Value = Codigo;//Strings.Format(Codigo, "##,#0.00");
                    }
                    //Verifico si la cantidad pedida se encuentra en stock
                    string Rubro = ObtenerDescripcionRubro(int.Parse(this.dgvLineaPedido.CurrentRow.Cells["ColumnCodigo"].Value.ToString()));
                    if (Rubro == "PANIFICADOS" || Rubro == "TORTILLAS" || Rubro == "FACTURAS")
                    {
                        //Asigno el importe a la columna de importe parcial
                        Cantidad = Convert.ToDecimal(this.dgvLineaPedido.CurrentRow.Cells["ColumnCantidad"].Value);
                        this.dgvLineaPedido.CurrentRow.Cells["ColumnImporteP"].Value = Cantidad * Convert.ToDecimal(this.dgvLineaPedido.CurrentRow.Cells["ColumnPrecio"].Value);
                        return;         
                    }
                    int ControlStock = Stock - int.Parse(this.dgvLineaPedido.CurrentRow.Cells["ColumnCantidad"].Value.ToString());
                    if (ControlStock <= 0)
                    {
                        MessageBox.Show("La cantidad ingresada del Articulo excede la disponibilidad en stock del mismo. Ingrese una cantidad menor." + "\n\n" + "Cantidad en Stock = " + Stock, "Sistema de facturación", MessageBoxButtons.OK);
                        this.dgvLineaPedido.CurrentCell.Value = null;
                        decimal Importe = Convert.ToDecimal(txtImporteT.Text) - Convert.ToDecimal(this.dgvLineaPedido.CurrentRow.Cells["ColumnImporteP"].Value);
                        txtImporteT.Text = Importe.ToString();
                        this.dgvLineaPedido.CurrentRow.Cells["ColumnImporteP"].Value = null;
                        return;
                    }
                    else
                    {
                        if (ControlStock < StockS)
                        {
                            MessageBox.Show("La Cantidad ingresada del Articulo esta haciendo uso del Stock de Seguridad existente del mismo. Asegurese de generar un pedido a Producción.", "Sistema de Facturación", MessageBoxButtons.OK);
                        }
                    }
                    //Asigno el importe a la columna de importe parcial
                    Cantidad = Convert.ToDecimal(this.dgvLineaPedido.CurrentRow.Cells["ColumnCantidad"].Value);
                    this.dgvLineaPedido.CurrentRow.Cells["ColumnImporteP"].Value = Cantidad * Convert.ToDecimal(this.dgvLineaPedido.CurrentRow.Cells["ColumnPrecio"].Value);
                }
            }
            int CantFilas = this.dgvLineaPedido.RowCount;
            decimal ImporteT = 0;
            for (int i = 0; i <= CantFilas - 1; i++)
            {
                if (this.dgvLineaPedido.Rows[i].Cells["ColumnImporteP"].Value != null)
                {
                    ImporteT = ImporteT + Convert.ToDecimal(this.dgvLineaPedido.Rows[i].Cells["ColumnImporteP"].Value);
                }
            }
            this.txtImporteT.Text = ImporteT.ToString();//Strings.Format(ImporteT, "#,##0.00");
        }
        private string ObtenerDescripcionRubro(int CodArt)
        {
            this.articuloTableAdapter.Fill(this.sFBDDataSet.Articulo);
            this.rubroTableAdapter.Fill(this.sFBDDataSet.Rubro);
            string Rubro = null;
            int IdRubro=0;
            foreach(DataRow Fila in this.sFBDDataSet.Articulo)
            {
                if(CodArt==int.Parse(Fila["IdArticulo"].ToString()))
                {
                    IdRubro = int.Parse(Fila["IdRubro"].ToString());
                    break;
                }
            }
            foreach(DataRow Fila in this.sFBDDataSet.Rubro)
            {
                if(IdRubro==int.Parse(Fila["IdRubro"].ToString()))
                {
                    Rubro = Fila["Descripcion"].ToString();
                    break;
                }
            }
            return Rubro;
        }

        public void ModificarColumna4()
        {
            string Cadena = null;
            if (this.dgvLineaPedido.CurrentCell.ReadOnly == false)
            {
                Cadena = this.dgvLineaPedido.CurrentRow.Cells["ColumnImporteP"].Value.ToString();
                this.dgvLineaPedido.CurrentRow.Cells["ColumnImporteP"].Value = Cadena.Replace('.', ',');
                Codigo = Convert.ToDecimal(this.dgvLineaPedido.CurrentRow.Cells["ColumnImporteP"].Value);
                this.dgvLineaPedido.CurrentRow.Cells["ColumnImporteP"].Value = Codigo;//Strings.Format(Codigo, "#,##0.00");
                this.dgvLineaPedido.Columns[4].ReadOnly = true;
                this.dgvLineaPedido.CurrentRow.Cells["ColumnCantidad"].ReadOnly = true;
            }
        }

        private void dgvLineaPedido_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dgvLineaPedido.CurrentCellAddress.X == 4)
            {
                this.dgvLineaPedido.CurrentCell.ReadOnly = false;
            }
        }

        private void dgvLineaPedido_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            decimal ImporteT = 0;
            for (int i = 0; i <= this.dgvLineaPedido.RowCount - 1; i++)
            {
                if (this.dgvLineaPedido.Rows[i].Cells["ColumnImporteP"].Value != null)
                {
                    ImporteT = ImporteT + Convert.ToDecimal(this.dgvLineaPedido.Rows[i].Cells["ColumnImporteP"].Value);
                }
            }
            this.txtImporteT.Text = ImporteT.ToString();//Strings.Format(ImporteT, "#,##0.00");
        }

        private void frmAltaPedido_Leave(object sender, EventArgs e)
        {
            decimal ImporteT = 0;
            for (int i = 0; i <= this.dgvLineaPedido.RowCount - 1; i++)
            {
                if (this.dgvLineaPedido.Rows[i].Cells["ColumnImporteP"].Value != null)
                {
                    ImporteT = ImporteT + Convert.ToDecimal(this.dgvLineaPedido.Rows[i].Cells["ColumnImporteP"].Value);
                }
            }
            this.txtImporteT.Text = ImporteT.ToString();//Strings.Format(ImporteT, "#,##0.00");
        }
        //---
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //aqui va el procedimiento para guardar los datos en la DB
            this.btnGuardar.Cursor = Cursors.WaitCursor;
            int Id=GuardarDatos();
            this.btnGuardar.Cursor = Cursors.Hand;
            File.WriteAllText(RutaArchivo,Id.ToString());
            //this.printDocument1.Print();
            MessageBox.Show("El Pedido fue ingresado con Exito!", "Sistema de Facturación", MessageBoxButtons.OK);
            LimpiarPedido();
        }

        private int GuardarDatos()
        {
            decimal Importe = 0;
            int CodArticulo = 0;
            int Cantidad = 0;
            int IdPedido;
            string Pedido = this.txtPedido.Text.Remove(4, 1);
            decimal NroPedido = Convert.ToDecimal(Pedido);
            Importe = Convert.ToDecimal(this.txtImporteT.Text);
            this.stockTableAdapter.Fill(this.sFBDDataSet.Stock);
            //Esta porcion de codigo guarda el Remito en DB
            DateTime Fecha = DateTime.Now;
            this.pedidoTableAdapter.InsertarPedido(Fecha.ToString(), CodCli, null);

            IdPedido = int.Parse(this.pedidoTableAdapter.ObtenerUltimoPedido().ToString());
            //Esta porcion de codigo guarda las lineas del Pedido en DB
            int CantFilas = this.dgvLineaPedido.RowCount - 1;
            for (int i = 0; i <= CantFilas - 1; i++)
            {
                CodArticulo = int.Parse(this.dgvLineaPedido.Rows[i].Cells["ColumnCodigo"].Value.ToString());
                /*foreach(DataRow Fila in this.sFBDDataSet.Stock)
                {
                    if(CodArticulo==int.Parse(Fila["IdArticulo"].ToString()))
                    {
                        IdStock=int.Parse(Fila["IdStock"].ToString());
                        CantStock = int.Parse(Fila["CantStock"].ToString());
                        break;
                    }
                }
                Cantidad = int.Parse(this.dgvLineaPedido.Rows[i].Cells["ColumnCantidad"].Value.ToString());
                int StockActual = CantStock - Cantidad;
                this.stockTableAdapter.ActualizarStockArticulo(StockActual, CodArticulo, IdStock);*/
                //ImporteP = Convert.ToDecimal(this.dgvLineaPedido.Rows[i].Cells["ColumnImporteP"].Value);
                Cantidad = int.Parse(this.dgvLineaPedido.Rows[i].Cells["ColumnCantidad"].Value.ToString());
                this.lineaPedidoTableAdapter.InsertarLineaPedido(Cantidad, IdPedido, CodArticulo);
            }
            return IdPedido;
        }

        private void LimpiarPedido()
        {
            ObtenerCodPedido();
            Band = false;
            this.cmbCli.Text = "Seleccione un Cliente...";
            this.txtNom.Text = null;
            this.txtDirCliente.Text = null;
            this.dgvLineaPedido.Rows.Clear();
            this.txtImporteT.Text = "0,00";
            this.cmbCli.Select();
        }
        //---
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //---
        //Estos procedimientos estan relacionados con la impresion del Listado.
        //---
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
        //---
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
            VPDialogo.ShowDialog();
            VPDialogo.Dispose();
        }
        //---
        private void printDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            this.printDocument1.DocumentName = "Pedido N° " + this.txtPedido.Text;
            e.PageSettings.Margins.Top = 50;
            e.PageSettings.Margins.Bottom = 50;
            e.PageSettings.Margins.Left = 20;
            e.PageSettings.Margins.Right = 20;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            bool Orientacion = e.PageSettings.Landscape == true;
            float MargenSuperior = e.PageSettings.Margins.Top;
            float MargenIzquierdo = e.PageSettings.Margins.Left;
            //float LineasPorPagina = 0;
            float PosY = 0;
            int LineaActual = 0;
            int UltimaLinea = 32;
            int Longitud = 0;
            GenerarRemitos(e);
            CargarEncabezado(e);
            for (int i = Contador; i <= this.dgvLineaPedido.RowCount - 2; i++)
            {
                if (LineaActual < UltimaLinea)
                {
                    PosY = MargenSuperior + LineaActual * Fuente.GetHeight(e.Graphics);
                    e.Graphics.DrawString(this.dgvLineaPedido.Rows[i].Cells[0].Value.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 21, 200 + PosY);
                    //e.Graphics.DrawString(this.dgvLineaRemito.Rows[i].Cells[0].Value.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 561, 200 + PosY);
                    e.Graphics.DrawString(this.dgvLineaPedido.Rows[i].Cells[1].Value.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 72, 200 + PosY);
                    //e.Graphics.DrawString(this.dgvLineaRemito.Rows[i].Cells[1].Value.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 612, 200 + PosY);
                    string Long = this.dgvLineaPedido.Rows[i].Cells[1].Value.ToString();
                    Longitud = Long.Length;
                    e.Graphics.DrawString(this.dgvLineaPedido.Rows[i].Cells[2].Value.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 351, 200 + PosY);
                    switch (Longitud)
                    {
                        case 4:
                            e.Graphics.DrawString(this.dgvLineaPedido.Rows[i].Cells[2].Value.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 351, 200 + PosY);
                            //e.Graphics.DrawString(this.dgvLineaRemito.Rows[i].Cells[2].Value.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 881, 200 + PosY);
                            break;
                        case 5:
                            e.Graphics.DrawString(this.dgvLineaPedido.Rows[i].Cells[2].Value.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 345, 200 + PosY);
                            //e.Graphics.DrawString(this.dgvLineaRemito.Rows[i].Cells[2].Value.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 875, 200 + PosY);
                            break;
                        case 6:
                            e.Graphics.DrawString(this.dgvLineaPedido.Rows[i].Cells[2].Value.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 339, 200 + PosY);
                            //e.Graphics.DrawString(this.dgvLineaRemito.Rows[i].Cells[2].Value.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 869, 200 + PosY);
                            break;
                    }
                    decimal Cant = Convert.ToDecimal(this.dgvLineaPedido.Rows[i].Cells[3].Value);
                    string Cadena = Cant.ToString("#,##0.000");//Strings.Format(Cant, "#,##0.000");
                    Longitud = Cadena.Length;
                    switch (Longitud)
                    {
                        case 5:
                            e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 405, 200 + PosY);
                            //e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 935, 200 + PosY);
                            break;
                        case 6:
                            e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 399, 200 + PosY);
                            //e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 929, 200 + PosY);
                            break;
                        case 7:
                            e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 393, 200 + PosY);
                            //e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 923, 200 + PosY);
                            break;
                    }
                    Cant = Convert.ToDecimal(this.dgvLineaPedido.Rows[i].Cells[4].Value);
                    Cadena = Cant.ToString();//Strings.Format(Cant, "#,##0.00");
                    Longitud = Cadena.Length;
                    switch (Longitud)
                    {
                        case 4:
                            e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 471, 200 + PosY);
                            //e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 1001, 200 + PosY);
                            break;
                        case 5:
                            e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 465, 200 + PosY);
                            //e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 995, 200 + PosY);
                            break;
                        case 6:
                            e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 459, 200 + PosY);
                            //e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 989, 200 + PosY);
                            break;
                        case 8:
                            e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 449, 200 + PosY);
                            //e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 979, 200 + PosY);
                            break;
                    }
                    LineaActual += 1;
                }
            }
        }
       

        private void GenerarRemitos(System.Drawing.Printing.PrintPageEventArgs e)
        {
            float MargenSuperior = e.MarginBounds.Top;
            float MargenIzquierdo = e.MarginBounds.Left;
            float MargenInferior = e.MarginBounds.Bottom;
            Font FuenteA = new Font("Tahoma", 10, FontStyle.Bold);
            //---
            e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo, MargenSuperior, 515, 720);
            //e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 530, MargenSuperior, 515, 720);
            //---
            e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 360, MargenSuperior + 40, 40, 40);
            e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 410, MargenSuperior + 40, 40, 40);
            e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 460, MargenSuperior + 40, 40, 40);
            //e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 890, MargenSuperior + 40, 40, 40);
            //e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 940, MargenSuperior + 40, 40, 40);
            //e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 990, MargenSuperior + 40, 40, 40);
            //---
            e.Graphics.DrawString("Documento no válido como Factura", Fuente, Brushes.Black, MargenIzquierdo + 90, MargenSuperior + 40);
            //e.Graphics.DrawString("Documento no válido como Factura", Fuente, Brushes.Black, MargenIzquierdo + 620, MargenSuperior + 40);
            //---
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 55, MargenSuperior + 55, MargenIzquierdo + 300, MargenSuperior + 55);
            //e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 595, MargenSuperior + 55, MargenIzquierdo + 830, MargenSuperior + 55);
            //---
            e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 165, MargenSuperior + 55, 25, 25);
            //e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 695, MargenSuperior + 55, 25, 25);
            //---
            e.Graphics.DrawString("X", FuenteA, Brushes.Black, MargenIzquierdo + 171, MargenSuperior + 60);
            //e.Graphics.DrawString("X", FuenteA, Brushes.Black, MargenIzquierdo + 701, MargenSuperior + 60);
            //---
            e.Graphics.DrawString("DIA", Fuente, Brushes.Black, MargenIzquierdo + 369, MargenSuperior + 42);
            e.Graphics.DrawString("MES", Fuente, Brushes.Black, MargenIzquierdo + 418, MargenSuperior + 42);
            e.Graphics.DrawString("AÑO", Fuente, Brushes.Black, MargenIzquierdo + 467, MargenSuperior + 42);
            //e.Graphics.DrawString("DIA", Fuente, Brushes.Black, MargenIzquierdo + 899, MargenSuperior + 42);
            //e.Graphics.DrawString("MES", Fuente, Brushes.Black, MargenIzquierdo + 948, MargenSuperior + 42);
            //e.Graphics.DrawString("AÑO", Fuente, Brushes.Black, MargenIzquierdo + 997, MargenSuperior + 42);
            //---
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 360, MargenSuperior + 55, MargenIzquierdo + 400, MargenSuperior + 55);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 410, MargenSuperior + 55, MargenIzquierdo + 450, MargenSuperior + 55);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 460, MargenSuperior + 55, MargenIzquierdo + 500, MargenSuperior + 55);
            //e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 890, MargenSuperior + 55, MargenIzquierdo + 930, MargenSuperior + 55);
            //e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 940, MargenSuperior + 55, MargenIzquierdo + 980, MargenSuperior + 55);
            //e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 990, MargenSuperior + 55, MargenIzquierdo + 1030, MargenSuperior + 55);
            //---
            e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 360, MargenSuperior + 90, 140, 30);
            //e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 890, MargenSuperior + 90, 140, 30);
            //---
            e.Graphics.DrawString("Nº", FuenteA, Brushes.Black, MargenIzquierdo + 365, MargenSuperior + 97);
            //e.Graphics.DrawString("Nº", FuenteA, Brushes.Black, MargenIzquierdo + 895, MargenSuperior + 97);
            //---
            e.Graphics.DrawString("Cliente :", Fuente, Brushes.Black, MargenIzquierdo + 15, MargenSuperior + 100);
            e.Graphics.DrawString("Localidad :", Fuente, Brushes.Black, MargenIzquierdo + 15, MargenSuperior + 125);
            e.Graphics.DrawString("Domicilio :", Fuente, Brushes.Black, MargenIzquierdo + 15, MargenSuperior + 150);
            //e.Graphics.DrawString("Cliente :", Fuente, Brushes.Black, MargenIzquierdo + 545, MargenSuperior + 100);
            //e.Graphics.DrawString("Localidad :", Fuente, Brushes.Black, MargenIzquierdo + 545, MargenSuperior + 125);
            //e.Graphics.DrawString("Domicilio :", Fuente, Brushes.Black, MargenIzquierdo + 545, MargenSuperior + 150);
            //---
            e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 15, MargenSuperior + 180, 52, 465);
            e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 69, MargenSuperior + 180, 257, 465);
            e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 328, MargenSuperior + 180, 53, 465);
            e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 383, MargenSuperior + 180, 58, 465);
            e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 443, MargenSuperior + 180, 57, 465);
            //e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 545, MargenSuperior + 180, 52, 465);
            //e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 599, MargenSuperior + 180, 257, 465);
            //e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 858, MargenSuperior + 180, 53, 465);
            //e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 913, MargenSuperior + 180, 58, 465);
            //e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 973, MargenSuperior + 180, 57, 465);
            //---
            e.Graphics.DrawString("Código", Fuente, Brushes.Black, MargenIzquierdo + 22, MargenSuperior + 182);
            e.Graphics.DrawString("Descripción", Fuente, Brushes.Black, MargenIzquierdo + 169, MargenSuperior + 182);
            e.Graphics.DrawString("Precio", Fuente, Brushes.Black, MargenIzquierdo + 338, MargenSuperior + 182);
            e.Graphics.DrawString("Cant.", Fuente, Brushes.Black, MargenIzquierdo + 397, MargenSuperior + 182);
            e.Graphics.DrawString("Importe", Fuente, Brushes.Black, MargenIzquierdo + 450, MargenSuperior + 182);
            //e.Graphics.DrawString("Código", Fuente, Brushes.Black, MargenIzquierdo + 552, MargenSuperior + 182);
            //e.Graphics.DrawString("Descripción", Fuente, Brushes.Black, MargenIzquierdo + 699, MargenSuperior + 182);
            //e.Graphics.DrawString("Precio", Fuente, Brushes.Black, MargenIzquierdo + 868, MargenSuperior + 182);
            //e.Graphics.DrawString("Cant.", Fuente, Brushes.Black, MargenIzquierdo + 927, MargenSuperior + 182);
            //e.Graphics.DrawString("Importe", Fuente, Brushes.Black, MargenIzquierdo + 980, MargenSuperior + 182);
            //---
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 15, MargenSuperior + 197, MargenIzquierdo + 67, MargenSuperior + 197);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 69, MargenSuperior + 197, MargenIzquierdo + 326, MargenSuperior + 197);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 328, MargenSuperior + 197, MargenIzquierdo + 381, MargenSuperior + 197);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 383, MargenSuperior + 197, MargenIzquierdo + 441, MargenSuperior + 197);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 443, MargenSuperior + 197, MargenIzquierdo + 500, MargenSuperior + 197);
            //e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 545, MargenSuperior + 197, MargenIzquierdo + 597, MargenSuperior + 197);
            //e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 599, MargenSuperior + 197, MargenIzquierdo + 856, MargenSuperior + 197);
            //e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 858, MargenSuperior + 197, MargenIzquierdo + 911, MargenSuperior + 197);
            //e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 913, MargenSuperior + 197, MargenIzquierdo + 971, MargenSuperior + 197);
            //e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 973, MargenSuperior + 197, MargenIzquierdo + 1030, MargenSuperior + 197);
            //---
            e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 15, MargenSuperior + 660, 485, 30);
            //e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 545, MargenSuperior + 660, 485, 30);
            //---
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 201, MargenSuperior + 660, MargenIzquierdo + 201, MargenSuperior + 690);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 258, MargenSuperior + 660, MargenIzquierdo + 258, MargenSuperior + 690);
            e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 443, MargenSuperior + 660, MargenIzquierdo + 443, MargenSuperior + 690);
            //e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 731, MargenSuperior + 660, MargenIzquierdo + 731, MargenSuperior + 690);
            //e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 788, MargenSuperior + 660, MargenIzquierdo + 788, MargenSuperior + 690);
            //e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 973, MargenSuperior + 660, MargenIzquierdo + 973, MargenSuperior + 690);
            //---
            e.Graphics.DrawString("Descuento :", Fuente, Brushes.Black, MargenIzquierdo + 35, MargenSuperior + 668);
            e.Graphics.DrawString("Total a pagar :", Fuente, Brushes.Black, MargenIzquierdo + 278, MargenSuperior + 668);
            //e.Graphics.DrawString("Descuento :", Fuente, Brushes.Black, MargenIzquierdo + 565, MargenSuperior + 668);
            //e.Graphics.DrawString("Total a pagar :", Fuente, Brushes.Black, MargenIzquierdo + 808, MargenSuperior + 668);
        }

        private void CargarEncabezado(System.Drawing.Printing.PrintPageEventArgs e)
        {
            float MargenSuperior = e.MarginBounds.Top;
            float MargenIzquierdo = e.MarginBounds.Left;
            float MargenInferior = e.MarginBounds.Bottom;
            //---
            DateTime FechaD = Convert.ToDateTime(this.txtFecha.Text);
            e.Graphics.DrawString(FechaD.Day.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 372, MargenSuperior + 62);
            e.Graphics.DrawString(FechaD.Month.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 422, MargenSuperior + 62);
            e.Graphics.DrawString(FechaD.Year.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 472, MargenSuperior + 62);
            //e.Graphics.DrawString(FechaD.Day.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 902, MargenSuperior + 62);
            //e.Graphics.DrawString(FechaD.Month.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 952, MargenSuperior + 62);
            //e.Graphics.DrawString(FechaD.Year.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 1002, MargenSuperior + 62);
            //---
            e.Graphics.DrawString(this.txtPedido.Text, Fuente, Brushes.Black, MargenIzquierdo + 415, MargenSuperior + 99);
            //e.Graphics.DrawString(this.txtRemitoN.Text, Fuente, Brushes.Black, MargenIzquierdo + 945, MargenSuperior + 99);
            //---
            e.Graphics.DrawString(this.cmbCli.Text, Fuente, Brushes.Black, MargenIzquierdo + 85, MargenSuperior + 100);
            e.Graphics.DrawString(this.txtNom.Text, Fuente, Brushes.Black, MargenIzquierdo + 85, MargenSuperior + 125);
            e.Graphics.DrawString(this.txtDirCliente.Text, Fuente, Brushes.Black, MargenIzquierdo + 85, MargenSuperior + 150);
            //e.Graphics.DrawString(this.cmbCli.Text, Fuente, Brushes.Black, MargenIzquierdo + 615, MargenSuperior + 100);
            //e.Graphics.DrawString(this.txtNom.Text, Fuente, Brushes.Black, MargenIzquierdo + 615, MargenSuperior + 125);
            //e.Graphics.DrawString(this.txtDirCliente.Text, Fuente, Brushes.Black, MargenIzquierdo + 615, MargenSuperior + 150);
            //---
            //e.Graphics.DrawString(this.txtDescuento.Text, Fuente, Brushes.Black, MargenIzquierdo + 206, MargenSuperior + 668);
            e.Graphics.DrawString(this.txtImporteT.Text, Fuente, Brushes.Black, MargenIzquierdo + 448, MargenSuperior + 668);
            //e.Graphics.DrawString(this.txtDescuento.Text, Fuente, Brushes.Black, MargenIzquierdo + 736, MargenSuperior + 668);
            //e.Graphics.DrawString(this.txtImporteT.Text, Fuente, Brushes.Black, MargenIzquierdo + 978, MargenSuperior + 668);
        }
        //---
        //Estos procedimientos muestran informacion acerca de los controles
        //Botones
        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Imprime el Pedido y guarda los datos en la Base de Datos.";
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cierra el formulario de Ingreso de Pedidos.";
        }

        private void cmbCli_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cambia el Cliente de la selección.";
        }

    }
}
