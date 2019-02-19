using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaBeSoft___Sistema_de_Facturacion
{
    public partial class frmAltaFactura : Form
    {
        string RutaArchivoA = System.Windows.Forms.Application.StartupPath + ".\\Comercial (Datos)\\MFacturaA.sce";
        //string RutaA=@"|DataDirectory|\Comercial (Datos)\FacturaA.sce";
        string RutaArchivoB = System.Windows.Forms.Application.StartupPath + ".\\Comercial (Datos)\\MFacturaB.sce";
        string RutaArchivoC = System.Windows.Forms.Application.StartupPath + ".\\Comercial (Datos)\\MFacturaC.sce";
        decimal Codigo = 0;
        private decimal CodCat;
        private decimal CodCli;
        private int Contador = 0;
        private bool Bandera = false;
        private Font Fuente = new Font("Tahoma", 8);
        //private PageSettings MiConfiguracionPagina;

        public frmAltaFactura()
        {
            InitializeComponent();
        }

        private void frmAltaFactura_Load(object sender, EventArgs e)
        {
            this.printDocument1.DefaultPageSettings.Landscape = true;
            this.txtFecha.Text = DateTime.Now.ToShortDateString();
            this.txtCuitCliente.Visible = false;
            this.txtIVAInsc.Visible = false;
            CargarTablas();
            CargarComboCliente();
        }

        private void CargarTablas()
	    {
		    try 
            {
                this.clienteTableAdapter.Fill(this.sFDBDataSet.Cliente);
                this.localidadTableAdapter.Fill(this.sFDBDataSet.Localidad);
                this.remitoTableAdapter.Fill(this.sFDBDataSet.Remito);
                this.articuloTableAdapter.Fill(this.sFDBDataSet.Articulo);
                this.articuloCategoriaCTableAdapter.Fill(this.sFDBDataSet.ArticuloCategoriaC);
		    } 
            catch (Exception ex)
            {
			    MessageBox.Show(ex.Message);
		    }
	    }

	    public void CargarComboCliente()
	    {
		    foreach (DataRow Fila in this.sFDBDataSet.Cliente)
            {
			    if(Fila["Borrado"].ToString()=="N")
                    this.cmbCliente.Items.Add(Fila["RazonSocial"].ToString());
		    }
	    }
	    //---
	    private void cmbFactura_KeyDown(object sender, KeyEventArgs e)
        {
            Bandera = false;
		    if (e.KeyCode == Keys.Delete) 
            {
			    this.txtFacturaN.Text = null;
		    }
		    if (e.KeyCode < Keys.Left || e.KeyCode > Keys.Down)
            {
			    Bandera = true;
		    }
        }

        private void cmbFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Bandera == true)
            {
			    e.Handled = true;
		    }
        }

	    private void cmbFactura_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string FacturaA = "A";
		    switch (this.cmbFactura.SelectedItem.ToString())
            {
			    case "A":
				    ObtenerNroFactura(RutaArchivoA);
				    HabilitarCamposFA();
				    RecalcularImporteT(FacturaA);
				    break;
			    case "B":
				    ObtenerNroFactura(RutaArchivoA);
				    this.cmbIVA.Text = "Consumidor final";
				    this.cmbIVA.Enabled = false;
				    HabilitarCamposFBC();
				    RecalcularImporteT(null);
				    break;
			    case "C":
				    ObtenerNroFactura(RutaArchivoA);
				    this.cmbIVA.Text = "Seleccione una categoría...";
				    this.cmbIVA.Enabled = true;
				    HabilitarCamposFBC();
				    RecalcularImporteT(null);
				    break;
		    }
        }

	    private void ObtenerNroFactura(string Ruta)
	    {
		    if (File.Exists(Ruta) == true) 
            {
			    Codigo = Convert.ToDecimal(File.ReadAllText(Ruta));
		    } 
            else
            {
			    File.Create(Ruta);
			    Codigo = 0;
		    }
            txtFacturaN.Text = (Codigo + 1).ToString("0000-000000000000");
        }

	    private void HabilitarCamposFA()
	    {
		    this.cmbIVA.SelectedIndex = 5;
		    this.cmbIVA.Enabled = false;
		    this.txtCuitCliente.Visible = true;
		    this.txtCuitCliente.Enabled = true;
		    this.txtCuitCliente.ReadOnly = true;
		    this.txtCuitCliente.TabStop = false;
		    this.txtIVAInsc.Visible = true;
		    this.txtIVAInsc.Enabled = true;
		    this.txtIVAInsc.ReadOnly = true;
		    this.txtIVAInsc.TabStop = false;
	    }

	    private void HabilitarCamposFBC()
	    {
		    this.txtCuitCliente.Visible = false;
		    this.txtIVAInsc.Visible = false;
	    }

	    private void RecalcularImporteT(string TipoFactura)
	    {
		    string TFactura = TipoFactura;
		    if (this.txtImporteT.Text != "")
            {
			    if (TFactura == "A")
                {
				    decimal MontoNeto = Convert.ToDecimal(this.txtNeto.Text);
				    decimal MontoIva = Convert.ToDecimal(this.txtIVAInsc.Text);
				    this.txtImporteT.Text = (MontoNeto+MontoIva).ToString();//Strings.Format(MontoNeto + MontoIva, "#,##0.00");
			    } 
                else
                {
				    this.txtImporteT.Text = this.txtNeto.Text;
			    }
		    }
	    }
        
        private void cmbFactura_Leave(object sender, EventArgs e)
        {
            if (this.btnCancelar.Focused == false)
            {
			    if (this.cmbFactura.Text == "") 
                {
				    MessageBox.Show("Seleccione el tipo de Factura que desea emitir antes de continuar.", "Sistema de Facturación",MessageBoxButtons.OK);
				    this.cmbFactura.Select();
			    }
		    }
        }
	    //---
	     private void cmbCliente_KeyDown(object sender, KeyEventArgs e)
        {
            Bandera = false;
		    if (e.KeyCode == Keys.Delete)
            {
			    this.txtLocCliente.Text = null;
			    this.txtDirCliente.Text = null;
			    this.txtCuitCliente.Text = null;
		    }
		    if (e.KeyCode < Keys.Left || e.KeyCode > Keys.Down)
            {
			    Bandera = true;
		    }
        }
        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            decimal Codigo = 0;
		    decimal CUIT = 0;
		    decimal NLoc = 0;
		    foreach (DataRow FilaC in this.sFDBDataSet.Cliente)
            {
			    if (FilaC["RazonSocial"].ToString() == this.cmbCliente.SelectedItem.ToString()) 
                {
				    Codigo = Convert.ToDecimal(FilaC["IdCliente"].ToString());
				    CodCli = Codigo;
				    CodCat = Convert.ToDecimal(FilaC["IdCategoriaC"].ToString());
				    NLoc = Convert.ToDecimal(FilaC["IdLocalidad"].ToString());
				    this.txtDirCliente.Text = FilaC["Domicilio"].ToString();
				    if (FilaC["CUIT"].ToString() != "")
                    {
					    CUIT = Convert.ToDecimal(FilaC["CUIT"].ToString());
					    this.txtCuitCliente.Text = CUIT.ToString("00-00000000-0");//Strings.Format(CUIT, "00-00000000-0");
				    } 
                    else
                    {
					    this.txtCuitCliente.Text = "";
				    }
				    break;
			    }
		    }
		    foreach (DataRow Fila in this.sFDBDataSet.Localidad)
            {
			    if (NLoc == Convert.ToDecimal(Fila["IdLocalidad"].ToString()))
                {
				    this.txtLocCliente.Text = Fila["Nombre"].ToString();
				    break; 
			    }
		    }
        }

	    private void cmbCliente_Leave(object sender, EventArgs e)
        {
            if (this.btnCancelar.Focused == false)
            {
			    if (this.cmbCliente.Text == "Seleccione un Cliente..." || this.cmbCliente.Text == null)
                {
				    MessageBox.Show("Debe seleccionar un Cliente de la lista, para poder emitir la Factura", "Sistema de Facturación",MessageBoxButtons.OK);
				    this.cmbCliente.Select();
			    }
		    }
        }
	    //---
	    private void cmbIVA_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode < Keys.Left || e.KeyCode > Keys.Down) {
			    Bandera = true;
		    }
        }

         private void cmbIVA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((this.cmbIVA.SelectedItem.ToString() == "Responsable Inscripto")||(this.cmbIVA.SelectedItem.ToString() == "Responsable Monotributo"))
            {
			    this.txtCuitCliente.Visible = true;
			    this.txtCuitCliente.Enabled = true;
			    this.txtCuitCliente.ReadOnly = true;
			    this.txtCuitCliente.TabStop = false;
		    } 
            else
            {
			    this.txtCuitCliente.Visible = false;
		    }
        }
	   
	   private void cmbIVA_Leave(object sender, EventArgs e)
        {
             if (this.btnCancelar.Focused == false) 
            {
			    if (this.cmbIVA.Text == "Seleccione una categoría..." || this.cmbIVA.Text == null)
                {
				    MessageBox.Show("Debe seleccionar una categoría IVA antes de continuar.", "Sistema de Facturación",MessageBoxButtons.OK);
				    this.cmbIVA.Select();
			    }
		    }
        }
	    //---
	    private void txtRemitoN_KeyDown(object sender, KeyEventArgs e)
        {
            Bandera = false;
		    //Si el Ascii presionado es < 48 o > 57
		    if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) 
            {
			    //Si el Ascii presionado es < 96 o > 105
			    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
				    if (e.KeyCode != Keys.Back)
                    {
					    Bandera = true;
				    }
			    }
		    }
        }

	    private void txtRemitoN_Leave(object sender, EventArgs e)
        {
             decimal NroRto = 0;
		    if (this.btnCancelar.Focused == false)
            {
			    if (this.txtRemitoN.Text != "")
                {
				    NroRto = Convert.ToDecimal(this.txtRemitoN.Text);
				    this.txtRemitoN.Text = NroRto.ToString();//Strings.Format(NroRto, "000000000000");
			    } 
                else
                {
				    MessageBox.Show("Debe ingresar el número de Remito antes de continuar.", "Sistema de Facturación");
				    this.txtRemitoN.Select();
			    }
		    }
        }
	    //---
	    private void cmbCondVenta_Leave(object sender, EventArgs e)
        {
            if (this.btnCancelar.Focused == false)
            {
			    if (this.cmbCondVenta.Text == "" || this.cmbCondVenta.Text == "Seleccione una...") 
                {
				    MessageBox.Show("Seleccione la condición de venta.",  "Sistema de Facturación",MessageBoxButtons.OK);
				    this.cmbCondVenta.Select();
			    }
		    }
        }
	    //---
	    private void btnCargarDR_Click(object sender, EventArgs e)
        {
            int NumRemito = int.Parse(this.txtRemitoN.Text);
		    DateTime FechaR = Convert.ToDateTime(this.dtpFechaR.Text);
		    bool Respuesta = false;
		    BorrarCamposDF();
		    Respuesta = ValidarClienteRemito(NumRemito);
		    if (Respuesta == false)
            {
			    MessageBox.Show("El Remito ingresado no pertenece al Cliente seleccionado. Asegurese de que los datos son correctos, e ingreselos nuevamente.", "Sistema de Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			    this.txtRemitoN.Select();
			    return;
		    }
		    CargarListaFactura(NumRemito);
		    CargarMontos(NumRemito);
        }

	    private bool ValidarClienteRemito(int NumRemito)
	    {
		    bool OK = false;
		    foreach (DataRow Fila in this.sFDBDataSet.Remito) 
            {
			    if (int.Parse(Fila["IdRemito"].ToString()) == NumRemito)
                {
					if (Convert.ToDecimal(Fila["IdCliente"].ToString()) == CodCli)
                    {
					    OK = true;
				    }
			    }
		    }
		    return OK;
	    }

	    private void BorrarCamposDF()
	    {
		    this.lvFactura.Items.Clear();
		    this.txtSubtotal.Text = null;
		    this.txtDescuento.Text = null;
		    this.txtNeto.Text = null;
		    this.txtIVAInsc.Text = null;
		    this.txtImporteT.Text = null;
	    }

	    private void CargarListaFactura(int NumRemito)
	    {
		    string Descrip = null;
		    decimal Precio = 0;
            this.lineaRemitoTableAdapter.FillByRemito(this.sFDBDataSet.LineaRemito, NumRemito);
		    for (int i = 0; i <= this.sFDBDataSet.LineaRemito.Rows.Count - 1; i++)
            {
                decimal idArt = Convert.ToDecimal(this.sFDBDataSet.Articulo.Rows[i]["IdArticulo"].ToString());
                this.lvFactura.Items.Add(idArt.ToString("0000"));
                Descrip = ObtenerDescArticulo(int.Parse(this.sFDBDataSet.LineaRemito.Rows[i]["IdArticulo"].ToString()));
			    this.lvFactura.Items[i].SubItems.Add(Descrip);
			    Precio = ObtenerPrecioArticulo(int.Parse(this.sFDBDataSet.LineaRemito.Rows[i]["IdArticulo"].ToString()), CodCat);
			    this.lvFactura.Items[i].SubItems.Add(Precio.ToString("#,##0.00"));
			    this.lvFactura.Items[i].SubItems.Add(this.sFDBDataSet.LineaRemito.Rows[i]["Cantidad"].ToString());
                decimal imp = Convert.ToDecimal(this.sFDBDataSet.LineaRemito.Rows[i]["ImporteLinea"].ToString());
                this.lvFactura.Items[i].SubItems.Add(imp.ToString("#,##0.00"));
            }
	    }

	    private string ObtenerDescArticulo(int CodA)
	    {
		    //Con este procedimiento se obtiene la descripcion del articulo desde la Base de Datos.
		    string Cadena = null;
		    foreach (DataRow Fila in this.sFDBDataSet.Articulo)
            {
			    if (int.Parse(Fila["IdArticulo"].ToString()) == CodA) 
                {
				    Cadena = Fila["Descripcion"].ToString();
				    break;
			    }
		    }
		    return Cadena;
	    }

	    private decimal ObtenerPrecioArticulo(int CodA, decimal CodC)
	    {
		    //Con este procedimiento se obtiene el precio del Articulo desde la Base de Datos.
		    decimal Precio = 0;
		    foreach (DataRow Fila in this.sFDBDataSet.ArticuloCategoriaC)
            {
			    if (Convert.ToDecimal(Fila["IdCategoriaC"].ToString()) == CodC) 
                {
				    if (int.Parse(Fila["IdArticulo"].ToString()) == CodA)
                    {
					    Precio = Convert.ToDecimal(Fila["Precio"].ToString());
					    break; 
				    }
			    }
		    }
		    return Precio;
	    }

	    private void CargarMontos(int NumRemito)
	    {
		    decimal MontoNeto = 0;
		    decimal MontoIva = 0;
		    foreach (DataRow Fila in this.sFDBDataSet.Remito)
            {
			    if (int.Parse(Fila["IdRemito"].ToString()) == NumRemito)
                {
					MontoNeto=Convert.ToDecimal(Fila["ImporteRto"].ToString());
                    this.txtNeto.Text = MontoNeto.ToString("#,##0.00");
					
                    decimal Dto=Convert.ToDecimal(Fila["Descuento"].ToString());
                    this.txtDescuento.Text = Dto.ToString("#,##0.00");
                    
                    this.txtSubtotal.Text = (MontoNeto + Dto).ToString("#,##0.00");
					break; 
			    }
		    }
            MontoIva = (MontoNeto * 21) / 100;
		    this.txtIVAInsc.Text = MontoIva.ToString("#,##0.00");
		    if (this.cmbFactura.Text == "A") 
            {
			    txtImporteT.Text = (MontoNeto+MontoIva).ToString("#,##0.00");
		    } 
            else
            {
			    this.txtImporteT.Text = this.txtNeto.Text;
		    }
	    }
	    //---
	    private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.btnGuardar.Cursor = Cursors.WaitCursor;
		    GuardarDatos();
		    this.btnGuardar.Cursor = Cursors.Hand;
		    GuardarNroFactura();
		    this.Hide();
		    this.printDocument1.Print();
        }

	    private void GuardarDatos()
	    {
		    
            txtFacturaN.Text=txtFacturaN.Text.Remove(4, 1);
            decimal NroFactura = Convert.ToDecimal(this.txtFacturaN.Text);
		    DateTime FechaF = Convert.ToDateTime(this.txtFecha.Text);
		    decimal Bruto = Convert.ToDecimal(this.txtImporteT.Text);
		    decimal Neto = Convert.ToDecimal(this.txtNeto.Text);
		    decimal Iva = default(decimal);
		    int NroRemito = int.Parse(this.txtRemitoN.Text);
		    DateTime FechaR = Convert.ToDateTime(this.dtpFechaR.Text);
		    string CIva = this.cmbIVA.Text;
		    string CVenta = this.cmbCondVenta.Text;
		    if (this.cmbFactura.Text == "A") 
            {
			    Iva = Convert.ToDecimal(this.txtIVAInsc.Text);
                this.facturaTableAdapter.InsertarFactura(cmbFactura.Text, Bruto, Neto, Iva, NroRemito);
		    } 
            else
            {
                this.facturaTableAdapter.InsertarFactura(cmbFactura.Text, Bruto, Neto, 0, NroRemito);
		    }
		    var IdFactura=this.facturaTableAdapter.ObtenerUltimaFactura();
            if (this.cmbCondVenta.Text == "Contado") 
            {
                this.pagoTableAdapter.InsertarDebeCliente("Debe", Bruto, 0, Bruto, cmbCondVenta.Text, FechaF.ToString(), int.Parse(CodCli.ToString()), int.Parse(IdFactura.ToString()));
		    }
            else
            {
			    if (this.cmbCondVenta.Text == "Cuenta Corriente") 
                {
                    this.pagoTableAdapter.InsertarDebeCliente("Debe", Bruto, 0, Bruto, cmbCondVenta.Text, (FechaF.AddDays(15)).ToString(), int.Parse(CodCli.ToString()), int.Parse(IdFactura.ToString()));
			    }
		    }
	    }

	    private void GuardarNroFactura()
	    {
		    switch (this.cmbFactura.Text)
            {
			    case "A":
				    Guardar(RutaArchivoA);
				    break;
			    case "B":
				    Guardar(RutaArchivoA);
				    break;
			    case "C":
                    Guardar(RutaArchivoA);
				    break;
		    }
	    }

	    private void Guardar(string Ruta)
        {
		    this.txtFacturaN.Text = this.txtFacturaN.Text.Remove(4, 1);
		    File.WriteAllText(Ruta, int.Parse(this.txtFacturaN.Text).ToString());
	    }

	    private void LimpiarCampos()
	    {
	    }
	    //---
	    private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

	    private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

	    private void frmAltaFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
             if (MessageBox.Show("Seguro desea cancelar la emisión de la Factura?.", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
             {
			    e.Cancel = true;
		    }
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

	    private void printDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            this.printDocument1.DocumentName = "Factura " + this.cmbFactura.Text + " N° " + this.txtFacturaN.Text;
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
		    GenerarFacturas(e);
		    CargarEncabezado(e);
		    for (int i = Contador; i <= this.lvFactura.Items.Count - 1; i++) 
            {
			    if (LineaActual < UltimaLinea) 
                {
				    PosY = MargenSuperior + LineaActual * Fuente.GetHeight(e.Graphics);
				    e.Graphics.DrawString(this.lvFactura.Items[i].SubItems[0].Text, Fuente, Brushes.Black, MargenIzquierdo + 26, 220 + PosY);
				    e.Graphics.DrawString(this.lvFactura.Items[i].SubItems[0].Text, Fuente, Brushes.Black, MargenIzquierdo + 556, 220 + PosY);
				    e.Graphics.DrawString(this.lvFactura.Items[i].SubItems[1].Text, Fuente, Brushes.Black, MargenIzquierdo + 72, 220 + PosY);
				    e.Graphics.DrawString(this.lvFactura.Items[i].SubItems[1].Text, Fuente, Brushes.Black, MargenIzquierdo + 602, 220 + PosY);
				    Longitud = this.lvFactura.Items[i].SubItems[2].Text.Length;
				    switch (Longitud) 
                    {
					    case 4:
						    e.Graphics.DrawString(this.lvFactura.Items[i].SubItems[2].Text, Fuente, Brushes.Black, MargenIzquierdo + 351, 220 + PosY);
						    e.Graphics.DrawString(this.lvFactura.Items[i].SubItems[2].Text, Fuente, Brushes.Black, MargenIzquierdo + 881, 220 + PosY);
						    break;
					    case 5:
						    e.Graphics.DrawString(this.lvFactura.Items[i].SubItems[2].Text, Fuente, Brushes.Black, MargenIzquierdo + 345, 220 + PosY);
						    e.Graphics.DrawString(this.lvFactura.Items[i].SubItems[2].Text, Fuente, Brushes.Black, MargenIzquierdo + 875, 220 + PosY);
						    break;
					    case 6:
						    e.Graphics.DrawString(this.lvFactura.Items[i].SubItems[2].Text, Fuente, Brushes.Black, MargenIzquierdo + 339, 220 + PosY);
						    e.Graphics.DrawString(this.lvFactura.Items[i].SubItems[2].Text, Fuente, Brushes.Black, MargenIzquierdo + 869, 220 + PosY);
						    break;
				    }
				    decimal Cant = Convert.ToDecimal(this.lvFactura.Items[i].SubItems[3].Text);
				    string Cadena = Cant.ToString();//Strings.Format(Cant, "#,##0.000");
				    Longitud = Cadena.Length;
				    switch (Longitud) 
                    {
					    case 5:
						    e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 405, 220 + PosY);
						    e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 935, 220 + PosY);
						    break;
					    case 6:
						    e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 399, 220 + PosY);
						    e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 929, 220 + PosY);
						    break;
					    case 7:
						    e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 393, 220 + PosY);
						    e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 923, 220 + PosY);
						    break;
				    }
				    Cant = Convert.ToDecimal(this.lvFactura.Items[i].SubItems[4].Text);
				    Cadena = Cant.ToString();//Strings.Format(Cant, "#,##0.00");
				    Longitud = Cadena.Length;
				    switch (Longitud) 
                    {
					    case 4:
						    e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 471, 220 + PosY);
						    e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 1001, 220 + PosY);
						    break;
					    case 5:
						    e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 465, 220 + PosY);
						    e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 995, 220 + PosY);
						    break;
					    case 6:
						    e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 459, 220 + PosY);
						    e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 989, 220 + PosY);
						    break;
					    case 8:
						    e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 449, 220 + PosY);
						    e.Graphics.DrawString(Cadena, Fuente, Brushes.Black, MargenIzquierdo + 979, 220 + PosY);
						    break;
				    }
				    LineaActual += 1;
			    }
		    }
        }

	    private void GenerarFacturas(System.Drawing.Printing.PrintPageEventArgs e)
	    {
		    float MargenSuperior = e.MarginBounds.Top;
		    float MargenIzquierdo = e.MarginBounds.Left;
		    float MargenInferior = e.MarginBounds.Bottom;
		    Font FuenteA = new Font("Tahoma", 10, FontStyle.Bold);
		    Font FuenteB = new Font("Tahoma", 6, FontStyle.Bold);
		    Font FuenteC = new Font("Tahoma", 8, FontStyle.Bold);
            Bitmap Imagen = new Bitmap(System.Windows.Forms.Application.StartupPath + ".\\Comercial (Datos)\\Logo.gif");
		    e.Graphics.DrawImage(Imagen, MargenIzquierdo + 25, MargenSuperior + 20);
		    e.Graphics.DrawImage(Imagen, MargenIzquierdo + 555, MargenSuperior + 20);
		    //---Titulo 1
		    e.Graphics.DrawString("NaBeSoft Software Solutions", FuenteB, Brushes.Black, MargenIzquierdo + 95, MargenSuperior + 20);
		    e.Graphics.DrawString("NaBeSoft Software Solutions", FuenteB, Brushes.Black, MargenIzquierdo + 625, MargenSuperior + 20);
		    e.Graphics.DrawString("UTN - Rivadavia 1050", FuenteB, Brushes.Black, MargenIzquierdo + 95, MargenSuperior + 30);
		    e.Graphics.DrawString("UTN - Rivadavia 1050", FuenteB, Brushes.Black, MargenIzquierdo + 625, MargenSuperior + 30);
		    e.Graphics.DrawString("CUIT 20-28887517-1", FuenteB, Brushes.Black, MargenIzquierdo + 95, MargenSuperior + 40);
		    e.Graphics.DrawString("CUIT 20-28887517-1", FuenteB, Brushes.Black, MargenIzquierdo + 625, MargenSuperior + 40);
		    //--- Bordes Factura
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo, MargenSuperior, 515, 720);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 530, MargenSuperior, 515, 720);
		    //--- Bordes Emcabezado
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 15, MargenSuperior + 10, 485, 190);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 545, MargenSuperior + 10, 485, 190);
		    //--- Bordes Fecha
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 350, MargenSuperior + 35, 40, 40);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 400, MargenSuperior + 35, 40, 40);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 450, MargenSuperior + 35, 40, 40);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 880, MargenSuperior + 35, 40, 40);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 930, MargenSuperior + 35, 40, 40);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 980, MargenSuperior + 35, 40, 40);
		    //--- Info Fecha
		    e.Graphics.DrawString("DIA", Fuente, Brushes.Black, MargenIzquierdo + 359, MargenSuperior + 37);
		    e.Graphics.DrawString("MES", Fuente, Brushes.Black, MargenIzquierdo + 408, MargenSuperior + 37);
		    e.Graphics.DrawString("AÑO", Fuente, Brushes.Black, MargenIzquierdo + 457, MargenSuperior + 37);
		    e.Graphics.DrawString("DIA", Fuente, Brushes.Black, MargenIzquierdo + 889, MargenSuperior + 37);
		    e.Graphics.DrawString("MES", Fuente, Brushes.Black, MargenIzquierdo + 938, MargenSuperior + 37);
		    e.Graphics.DrawString("AÑO", Fuente, Brushes.Black, MargenIzquierdo + 987, MargenSuperior + 37);
		    //--- Lineas Fecha
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 350, MargenSuperior + 50, MargenIzquierdo + 390, MargenSuperior + 50);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 400, MargenSuperior + 50, MargenIzquierdo + 440, MargenSuperior + 50);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 450, MargenSuperior + 50, MargenIzquierdo + 490, MargenSuperior + 50);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 880, MargenSuperior + 50, MargenIzquierdo + 920, MargenSuperior + 50);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 930, MargenSuperior + 50, MargenIzquierdo + 970, MargenSuperior + 50);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 980, MargenSuperior + 50, MargenIzquierdo + 1020, MargenSuperior + 50);
		    //--- 
		    e.Graphics.DrawString("FACTURA", FuenteA, Brushes.Black, MargenIzquierdo + 350, MargenSuperior + 15);
		    e.Graphics.DrawString("FACTURA", FuenteA, Brushes.Black, MargenIzquierdo + 880, MargenSuperior + 15);
		    //--- Linea Division Encabezado
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 255, MargenSuperior + 50, MargenIzquierdo + 255, MargenSuperior + 115);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 785, MargenSuperior + 50, MargenIzquierdo + 785, MargenSuperior + 115);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 15, MargenSuperior + 115, MargenIzquierdo + 500, MargenSuperior + 115);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 545, MargenSuperior + 115, MargenIzquierdo + 1030, MargenSuperior + 115);
		    //--- Cuadro Tipo Factura
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 235, MargenSuperior + 10, 40, 40);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 765, MargenSuperior + 10, 40, 40);
		    //--- Borde N Factura
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 350, MargenSuperior + 80, 140, 30);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 880, MargenSuperior + 80, 140, 30);
		    //---
		    e.Graphics.DrawString("Nº", FuenteA, Brushes.Black, MargenIzquierdo + 355, MargenSuperior + 87);
		    e.Graphics.DrawString("Nº", FuenteA, Brushes.Black, MargenIzquierdo + 885, MargenSuperior + 87);
		    //---
		    e.Graphics.DrawString("Cliente :", Fuente, Brushes.Black, MargenIzquierdo + 20, MargenSuperior + 120);
		    e.Graphics.DrawString("Localidad :", Fuente, Brushes.Black, MargenIzquierdo + 20, MargenSuperior + 135);
		    e.Graphics.DrawString("Domicilio :", Fuente, Brushes.Black, MargenIzquierdo + 20, MargenSuperior + 150);
		    e.Graphics.DrawString("I.V.A :", Fuente, Brushes.Black, MargenIzquierdo + 20, MargenSuperior + 165);
		    e.Graphics.DrawString("C.U.I.T Nº :", Fuente, Brushes.Black, MargenIzquierdo + 255, MargenSuperior + 165);
		    e.Graphics.DrawString("Cond. Venta :", Fuente, Brushes.Black, MargenIzquierdo + 20, MargenSuperior + 180);
		    e.Graphics.DrawString("Remito Nº :", Fuente, Brushes.Black, MargenIzquierdo + 255, MargenSuperior + 180);
		    e.Graphics.DrawString("Cliente :", Fuente, Brushes.Black, MargenIzquierdo + 550, MargenSuperior + 120);
		    e.Graphics.DrawString("Localidad :", Fuente, Brushes.Black, MargenIzquierdo + 550, MargenSuperior + 135);
		    e.Graphics.DrawString("Domicilio :", Fuente, Brushes.Black, MargenIzquierdo + 550, MargenSuperior + 150);
		    e.Graphics.DrawString("I.V.A :", Fuente, Brushes.Black, MargenIzquierdo + 550, MargenSuperior + 165);
		    e.Graphics.DrawString("C.U.I.T Nº :", Fuente, Brushes.Black, MargenIzquierdo + 785, MargenSuperior + 165);
		    e.Graphics.DrawString("Cond. Venta :", Fuente, Brushes.Black, MargenIzquierdo + 550, MargenSuperior + 180);
		    e.Graphics.DrawString("Remito Nº :", Fuente, Brushes.Black, MargenIzquierdo + 785, MargenSuperior + 180);
		    //--- Cuadros Detalle Factura
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 15, MargenSuperior + 200, 52, 460);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 69, MargenSuperior + 200, 257, 460);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 328, MargenSuperior + 200, 53, 460);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 383, MargenSuperior + 200, 58, 460);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 443, MargenSuperior + 200, 57, 460);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 545, MargenSuperior + 200, 52, 460);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 599, MargenSuperior + 200, 257, 460);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 858, MargenSuperior + 200, 53, 460);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 913, MargenSuperior + 200, 58, 460);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 973, MargenSuperior + 200, 57, 460);
		    //---Titulos Detalle
		    e.Graphics.DrawString("Código", Fuente, Brushes.Black, MargenIzquierdo + 22, MargenSuperior + 202);
		    e.Graphics.DrawString("Descripción", Fuente, Brushes.Black, MargenIzquierdo + 169, MargenSuperior + 202);
		    e.Graphics.DrawString("Precio", Fuente, Brushes.Black, MargenIzquierdo + 338, MargenSuperior + 202);
		    e.Graphics.DrawString("Cant.", Fuente, Brushes.Black, MargenIzquierdo + 397, MargenSuperior + 202);
		    e.Graphics.DrawString("Importe", Fuente, Brushes.Black, MargenIzquierdo + 450, MargenSuperior + 202);
		    e.Graphics.DrawString("Código", Fuente, Brushes.Black, MargenIzquierdo + 552, MargenSuperior + 202);
		    e.Graphics.DrawString("Descripción", Fuente, Brushes.Black, MargenIzquierdo + 699, MargenSuperior + 202);
		    e.Graphics.DrawString("Precio", Fuente, Brushes.Black, MargenIzquierdo + 868, MargenSuperior + 202);
		    e.Graphics.DrawString("Cant.", Fuente, Brushes.Black, MargenIzquierdo + 927, MargenSuperior + 202);
		    e.Graphics.DrawString("Importe", Fuente, Brushes.Black, MargenIzquierdo + 980, MargenSuperior + 202);
		    //--- Lineas Titulo
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 15, MargenSuperior + 217, MargenIzquierdo + 67, MargenSuperior + 217);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 69, MargenSuperior + 217, MargenIzquierdo + 326, MargenSuperior + 217);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 328, MargenSuperior + 217, MargenIzquierdo + 381, MargenSuperior + 217);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 383, MargenSuperior + 217, MargenIzquierdo + 441, MargenSuperior + 217);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 443, MargenSuperior + 217, MargenIzquierdo + 500, MargenSuperior + 217);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 545, MargenSuperior + 217, MargenIzquierdo + 597, MargenSuperior + 217);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 599, MargenSuperior + 217, MargenIzquierdo + 856, MargenSuperior + 217);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 858, MargenSuperior + 217, MargenIzquierdo + 911, MargenSuperior + 217);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 913, MargenSuperior + 217, MargenIzquierdo + 971, MargenSuperior + 217);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 973, MargenSuperior + 217, MargenIzquierdo + 1030, MargenSuperior + 217);
		    //---Borde Precios
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 15, MargenSuperior + 660, 485, 40);
		    e.Graphics.DrawRectangle(Pens.Black, MargenIzquierdo + 545, MargenSuperior + 660, 485, 40);
		    //---Division Precios
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 109, MargenSuperior + 660, MargenIzquierdo + 109, MargenSuperior + 700);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 203, MargenSuperior + 660, MargenIzquierdo + 203, MargenSuperior + 700);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 297, MargenSuperior + 660, MargenIzquierdo + 297, MargenSuperior + 700);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 391, MargenSuperior + 660, MargenIzquierdo + 391, MargenSuperior + 700);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 639, MargenSuperior + 660, MargenIzquierdo + 639, MargenSuperior + 700);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 733, MargenSuperior + 660, MargenIzquierdo + 733, MargenSuperior + 700);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 827, MargenSuperior + 660, MargenIzquierdo + 827, MargenSuperior + 700);
		    e.Graphics.DrawLine(Pens.Black, MargenIzquierdo + 921, MargenSuperior + 660, MargenIzquierdo + 921, MargenSuperior + 700);
		    //---Titulos Precios
		    e.Graphics.DrawString("Subtotal", Fuente, Brushes.Black, MargenIzquierdo + 40, MargenSuperior + 662);
		    e.Graphics.DrawString("Descuento", Fuente, Brushes.Black, MargenIzquierdo + 129, MargenSuperior + 662);
		    e.Graphics.DrawString("Imp. Neto", Fuente, Brushes.Black, MargenIzquierdo + 223, MargenSuperior + 662);
		    e.Graphics.DrawString("IVA Inscr. (%)", Fuente, Brushes.Black, MargenIzquierdo + 307, MargenSuperior + 662);
		    e.Graphics.DrawString("Imp. Total", Fuente, Brushes.Black, MargenIzquierdo + 421, MargenSuperior + 662);
		    e.Graphics.DrawString("Subtotal", Fuente, Brushes.Black, MargenIzquierdo + 570, MargenSuperior + 662);
		    e.Graphics.DrawString("Descuento", Fuente, Brushes.Black, MargenIzquierdo + 659, MargenSuperior + 662);
		    e.Graphics.DrawString("Imp. Neto", Fuente, Brushes.Black, MargenIzquierdo + 753, MargenSuperior + 662);
		    e.Graphics.DrawString("IVA Inscr. (%)", Fuente, Brushes.Black, MargenIzquierdo + 837, MargenSuperior + 662);
		    e.Graphics.DrawString("Imp. Total", Fuente, Brushes.Black, MargenIzquierdo + 951, MargenSuperior + 662);
	    }

	    private void CargarEncabezado(System.Drawing.Printing.PrintPageEventArgs e)
	    {
		    Font FuenteA = new Font("Tahoma", 16, FontStyle.Bold);
		    float MargenSuperior = e.MarginBounds.Top;
		    float MargenIzquierdo = e.MarginBounds.Left;
		    float MargenInferior = e.MarginBounds.Bottom;
		    //---
		    e.Graphics.DrawString(this.cmbFactura.Text, FuenteA, Brushes.Black, MargenIzquierdo + 245, MargenSuperior + 15);
		    e.Graphics.DrawString(this.cmbFactura.Text, FuenteA, Brushes.Black, MargenIzquierdo + 775, MargenSuperior + 15);
		    //---
		    DateTime FechaD = Convert.ToDateTime(this.txtFecha.Text);
		    e.Graphics.DrawString(FechaD.Day.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 362, MargenSuperior + 55);
		    e.Graphics.DrawString(FechaD.Month.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 412, MargenSuperior + 55);
		    e.Graphics.DrawString(FechaD.Year.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 462, MargenSuperior + 55);
		    e.Graphics.DrawString(FechaD.Day.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 892, MargenSuperior + 55);
		    e.Graphics.DrawString(FechaD.Month.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 942, MargenSuperior + 55);
		    e.Graphics.DrawString(FechaD.Year.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 992, MargenSuperior + 55);
		    //'---
		    e.Graphics.DrawString(this.txtFacturaN.Text, Fuente, Brushes.Black, MargenIzquierdo + 380, MargenSuperior + 90);
		    e.Graphics.DrawString(this.txtFacturaN.Text, Fuente, Brushes.Black, MargenIzquierdo + 910, MargenSuperior + 90);
		    //'---
		    e.Graphics.DrawString(this.cmbCliente.Text, Fuente, Brushes.Black, MargenIzquierdo + 95, MargenSuperior + 120);
		    e.Graphics.DrawString(this.txtLocCliente.Text, Fuente, Brushes.Black, MargenIzquierdo + 95, MargenSuperior + 135);
		    e.Graphics.DrawString(this.txtDirCliente.Text, Fuente, Brushes.Black, MargenIzquierdo + 95, MargenSuperior + 150);
		    e.Graphics.DrawString(this.cmbIVA.Text, Fuente, Brushes.Black, MargenIzquierdo + 95, MargenSuperior + 165);
		    if (this.cmbFactura.Text == "A") 
            {
			    e.Graphics.DrawString(this.txtCuitCliente.Text, Fuente, Brushes.Black, MargenIzquierdo + 340, MargenSuperior + 165);
		    }
		    e.Graphics.DrawString(this.cmbCondVenta.Text, Fuente, Brushes.Black, MargenIzquierdo + 95, MargenSuperior + 180);
		    decimal NRemito = 0;
		    if (this.txtRemitoN.Text != "") 
            {
			    NRemito = Convert.ToDecimal(this.txtRemitoN.Text);
			    //e.Graphics.DrawString(Strings.Format(NRemito, "0000-00000000"), Fuente, Brushes.Black, MargenIzquierdo + 340, MargenSuperior + 180);
		        e.Graphics.DrawString(NRemito.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 340, MargenSuperior + 180);
            }
		    e.Graphics.DrawString(this.cmbCliente.Text, Fuente, Brushes.Black, MargenIzquierdo + 635, MargenSuperior + 120);
		    e.Graphics.DrawString(this.txtLocCliente.Text, Fuente, Brushes.Black, MargenIzquierdo + 635, MargenSuperior + 135);
		    e.Graphics.DrawString(this.txtDirCliente.Text, Fuente, Brushes.Black, MargenIzquierdo + 635, MargenSuperior + 150);
		    e.Graphics.DrawString(this.cmbIVA.Text, Fuente, Brushes.Black, MargenIzquierdo + 635, MargenSuperior + 165);
		    if (this.cmbFactura.Text == "A")
            {
			    e.Graphics.DrawString(this.txtCuitCliente.Text, Fuente, Brushes.Black, MargenIzquierdo + 870, MargenSuperior + 165);
		    }
		    e.Graphics.DrawString(this.cmbCondVenta.Text, Fuente, Brushes.Black, MargenIzquierdo + 635, MargenSuperior + 180);
		    if (this.txtRemitoN.Text != "") 
            {
			    //e.Graphics.DrawString(Strings.Format(NRemito, "0000-00000000"), Fuente, Brushes.Black, MargenIzquierdo + 870, MargenSuperior + 180);
                e.Graphics.DrawString(NRemito.ToString(), Fuente, Brushes.Black, MargenIzquierdo + 870, MargenSuperior + 180);
		    }
		    //---
		    e.Graphics.DrawString(this.txtSubtotal.Text, Fuente, Brushes.Black, MargenIzquierdo + 45, MargenSuperior + 680);
		    e.Graphics.DrawString(this.txtDescuento.Text, Fuente, Brushes.Black, MargenIzquierdo + 139, MargenSuperior + 680);
		    e.Graphics.DrawString(this.txtNeto.Text, Fuente, Brushes.Black, MargenIzquierdo + 233, MargenSuperior + 680);
		    if (this.cmbFactura.Text == "A") 
            {
			    e.Graphics.DrawString(this.txtIVAInsc.Text, Fuente, Brushes.Black, MargenIzquierdo + 327, MargenSuperior + 680);
		    }
		    e.Graphics.DrawString(this.txtImporteT.Text, Fuente, Brushes.Black, MargenIzquierdo + 431, MargenSuperior + 680);
		    e.Graphics.DrawString(this.txtSubtotal.Text, Fuente, Brushes.Black, MargenIzquierdo + 575, MargenSuperior + 680);
		    e.Graphics.DrawString(this.txtDescuento.Text, Fuente, Brushes.Black, MargenIzquierdo + 669, MargenSuperior + 680);
		    e.Graphics.DrawString(this.txtNeto.Text, Fuente, Brushes.Black, MargenIzquierdo + 763, MargenSuperior + 680);
		    if (this.cmbFactura.Text == "A")
            {
			    e.Graphics.DrawString(this.txtIVAInsc.Text, Fuente, Brushes.Black, MargenIzquierdo + 857, MargenSuperior + 680);
		    }
		    e.Graphics.DrawString(this.txtImporteT.Text, Fuente, Brushes.Black, MargenIzquierdo + 961, MargenSuperior + 680);
	    }
	    //---
        private void btnCargarDR_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Carga el detalle del Remito especificado.";
        }

        private void btnCargarDR_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Imprime la Factura y guarda los datos en la Base de Datos.";
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cierra el formulario de emisión de Factura.";
        }

        private void ImprimirToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
             this.ToolStripStatusLabelInfo.Text = "Imprime la Factura activa.";
        }

        private void VistaPreliminarToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Muestra páginas completas.";
        }
    }
}
