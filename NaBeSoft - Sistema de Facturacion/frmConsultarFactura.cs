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
    public partial class frmConsultarFactura : Form
    {
        private bool Bandera = false;
        private decimal CodCateg;

        public frmConsultarFactura()
        {
            InitializeComponent();
        }

        private void frmConsultarFactura_Load(object sender, EventArgs e)
        {
           
            this.btnBuscar.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.txtCuitCliente.Visible = false;
            this.txtIVAInsc.Visible = false;
            CargarTablas();
        }

        private void CargarTablas()
	    {
		    try 
            {
                this.localidadTableAdapter.Fill(this.sFDBDataSet.Localidad);
                this.lineaRemitoTableAdapter.Fill(this.sFDBDataSet.LineaRemito);
                this.facturaTableAdapter.Fill(this.sFDBDataSet.Factura);
                this.pagoTableAdapter.Fill(this.sFDBDataSet.Pago);
                this.remitoTableAdapter.Fill(this.sFDBDataSet.Remito);
                this.clienteTableAdapter.Fill(this.sFDBDataSet.Cliente);
                this.articuloCategoriaCTableAdapter.Fill(this.sFDBDataSet.ArticuloCategoriaC);
                this.articuloTableAdapter.Fill(this.sFDBDataSet.Articulo);
		    } 
            catch (Exception ex) 
            {
			    MessageBox.Show(ex.Message);
		    }
	    }
	    //---
	    private void cmbIngresoFactTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (this.cmbIngresoFactTipo.SelectedItem.ToString())
            {
			    case "A":
				    this.txtCuitCliente.Visible = true;
				    this.txtIVAInsc.Visible = true;
				    break;
			    case "B":
				    this.txtCuitCliente.Visible = false;
				    this.txtIVAInsc.Visible = false;
				    break;
			    case "C":
				    this.txtCuitCliente.Visible = false;
				    this.txtIVAInsc.Visible = false;
				    break;
		    }
        }

	    private void cmbIngresoFactTipo_KeyDown(object sender, KeyEventArgs e)
        {
            Bandera = false;
		    if (e.KeyCode < Keys.Left || e.KeyCode > Keys.Down) 
            {
			    Bandera = true;
		    }
        }

	    private void cmbIngresoFactTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Bandera == true) 
            {
			    e.Handled = true;
		    }
        }

	    private void cmbIngresoFactTipo_Leave(object sender, EventArgs e)
        {
            if (this.btnCancelar.Focused == false) 
            {
			    if (this.cmbIngresoFactTipo.Text == "") 
                {
				    MessageBox.Show("Seleccione el tipo de Factura que desea consultar antes de continuar.", "Sistema de Facturación",MessageBoxButtons.OK);
				    this.cmbIngresoFactTipo.Select();
			    }
		    }
        }
	    //---
	    private void txtIngresoFact_KeyDown(object sender, KeyEventArgs e)
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
        private void txtIngresoFact_Leave(object sender, EventArgs e)
        {
            if (this.txtIngresoFact.Text != "")
            {
                //decimal Numero = Convert.ToDecimal(this.txtIngresoFact.Text);
                //this.txtIngresoFact.Text = Strings.Format(Numero, "0000000000000000");
                this.btnBuscar.Enabled = true;
            }
            else
            {
                this.btnBuscar.Enabled = false;
            }
        }
	    
	    //---
	    private void btnBuscar_Click(object sender, EventArgs e)
        {
             bool Respuesta = false;
		    this.btnBuscar.Cursor = Cursors.WaitCursor;
		    Respuesta = ConsultarDatos();
		    if (Respuesta == true)
            {
			    this.cmbIngresoFactTipo.Enabled = false;
			    this.btnAceptar.Enabled = true;
			    this.btnAceptar.Select();
		    }
            else
            {
			    this.txtIngresoFact.Select();
		    }
		    this.btnBuscar.Cursor = Cursors.Hand;
        }

	    private bool ConsultarDatos()
	    {
		    int Factura = int.Parse(this.txtIngresoFact.Text);
		    string Tipo = this.cmbIngresoFactTipo.Text;
		    decimal NroFact = default(decimal);
		    decimal Neto = default(decimal);
		    decimal IVA = default(decimal);
		    decimal IT = default(decimal);
		    decimal CodCliente = default(decimal);
		    //decimal NLoc = default(decimal);
		    decimal CUIT = default(decimal);
		    decimal NroRto = default(decimal);
		    //DateTime FecRto; 
		    try 
            {
                this.facturaTableAdapter.FillByFactura(this.sFDBDataSet.Factura, Factura);
                foreach (DataRow Fila in this.sFDBDataSet.Factura)
                {
                    txtFactura.Text = Fila["TipoFactura"].ToString();
                    
                    NroFact = Convert.ToDecimal(Fila["IdFactura"].ToString());
                    txtFacturaN.Text = NroFact.ToString("0000-000000000000");

                    Neto = Convert.ToDecimal(Fila["ImporteNeto"].ToString());
                    txtNeto.Text = Neto.ToString("#,##0.00");

                    IVA = Convert.ToDecimal(Fila["IVA"].ToString());
                    txtIVAInsc.Text = IVA.ToString("#,##0.00");

                    IT = Convert.ToDecimal(Fila["ImporteBruto"].ToString());
                    txtImporteT.Text = IT.ToString("#,##0.00");

                    NroRto = Convert.ToDecimal(Fila["IdRemito"].ToString());
                    txtRemitoN.Text = NroRto.ToString("0000-00000000");
                    break;
                }
                
			    CodCliente = ObtenerCodCliente(Factura);
			    this.clienteTableAdapter.FillByCliente(this.sFDBDataSet.Cliente, int.Parse(CodCliente.ToString()));
			    foreach (DataRow Fila in this.sFDBDataSet.Cliente)
                {
				    if (CodCliente == Convert.ToDecimal(Fila["IdCliente"].ToString()))
                    {
					    this.txtCliente.Text = Fila["RazonSocial"].ToString();
					    this.txtDirCliente.Text = Fila["Domicilio"].ToString();
					    CUIT= Convert.ToDecimal(Fila["CUIT"].ToString());
                        this.txtCuitCliente.Text = CUIT.ToString("00-00000000-0");
                        this.txtLocCliente.Text = ObtenerLocalidad(Convert.ToDecimal(Fila["IdLocalidad"].ToString()));
                        CodCateg = Convert.ToDecimal(Fila["IdCategoriaC"].ToString());
					    break; 
				    }
			    }
			    if (Tipo == "A")
                {
				    this.txtIVA.Text = "Responsable Inscripto";
			    } 
                else
                {
				    this.txtIVA.Text = "Consumidor Final";
			    }
			    foreach (DataRow Fila in this.sFDBDataSet.Pago)
                {
				    if (CodCliente == Convert.ToDecimal(Fila["IdCliente"].ToString())) 
                    {
						if (Factura == Convert.ToDecimal(Fila["IdFactura"].ToString()))
                        {
					   	    this.txtCondVenta.Text = Fila["CondVenta"].ToString();
						    break; 
					    }
				    }
			    }
			    foreach(DataRow Fila in this.sFDBDataSet.Remito)
                {
                    if(NroRto==Convert.ToDecimal(Fila["IdRemito"].ToString()))
                    {
                        DateTime Fecha = Convert.ToDateTime(Fila["FechaRto"].ToString());
                        txtFecha.Text = Fecha.ToShortDateString();

                        Fecha=Convert.ToDateTime(Fila["FechaRto"].ToString());
                        txtFechaR.Text = Fecha.ToShortDateString();

                        decimal ST = Convert.ToDecimal(Fila["ImporteRto"].ToString()) + Convert.ToDecimal(Fila["Descuento"].ToString());
                        txtSubtotal.Text = ST.ToString("#,##0.00");

                        decimal Dto = Convert.ToDecimal(Fila["Descuento"].ToString());
                        txtDescuento.Text = Dto.ToString("#,##0.00");
                        break;
                    }
                }
			    ObtenerDetalleFactura(int.Parse(NroRto.ToString()));
			    return true;
		    } 
            catch (Exception)
            {
			    LimpiarCampos();
			    MessageBox.Show("La Factura no existe en la Base de Datos", "Sistema de Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			    return false;
		    }
	    }

        private decimal ObtenerCodCliente(decimal Factura)
	    {
		    decimal Codigo = 0;
		    foreach (DataRow Fila in this.sFDBDataSet.Pago)
            {
			    if (Convert.ToDecimal(Fila["IdFactura"].ToString()) == Factura)
                {
					Codigo = Convert.ToDecimal(Fila["IdCliente"].ToString());
					break; 
			    }
		    }
		    return Codigo;
	    }

	    private string ObtenerLocalidad(decimal NLoc)
	    {
		    string Localidad = "";
		    foreach (DataRow Fila in this.sFDBDataSet.Localidad) 
            {
			    if (Convert.ToDecimal(Fila["IdLocalidad"].ToString()) == NLoc) 
                {
				    Localidad = Fila["Nombre"].ToString();
				    break; 
			    }
		    }
		    return Localidad;
	    }

	    private void ObtenerDetalleFactura(int NroRto)
	    {
		    string Descrip = null;
		    decimal Precio = 0;
		    this.lvFactura.Items.Clear();
            this.lineaRemitoTableAdapter.FillByRemito(this.sFDBDataSet.LineaRemito, NroRto);
            for (int i = 0; i <= this.sFDBDataSet.LineaRemito.Count - 1; i++)
            {
			    this.lvFactura.Items.Add(this.sFDBDataSet.LineaRemito.Rows[i]["IdArticulo"].ToString());
                
                Descrip = ObtenerDescArticulo(Convert.ToDecimal(this.sFDBDataSet.LineaRemito.Rows[i]["IdArticulo"].ToString()));
			    this.lvFactura.Items[i].SubItems.Add(Descrip);
			    
                Precio = ObtenerPrecioArticulo(Convert.ToDecimal(this.sFDBDataSet.LineaRemito.Rows[i]["IdArticulo"].ToString()), CodCateg);
			    this.lvFactura.Items[i].SubItems.Add(Precio.ToString("#,##0.00"));
			    
			    this.lvFactura.Items[i].SubItems.Add(this.sFDBDataSet.LineaRemito.Rows[i]["Cantidad"].ToString());

                Precio = Convert.ToDecimal(this.sFDBDataSet.LineaRemito.Rows[i]["ImporteLinea"].ToString());
                this.lvFactura.Items[i].SubItems.Add(Precio.ToString("#,##0.00"));
		    }
	    }

	    private string ObtenerDescArticulo(decimal CodA)
	    {
		    string Cadena = null;
		    foreach (DataRow Fila in this.sFDBDataSet.Articulo)
            {
			    if (Convert.ToDecimal(Fila["IdArticulo"].ToString()) == CodA)
                {
				    Cadena = Fila["Descripcion"].ToString();
				    break; 
			    }
		    }
		    return Cadena;
	    }

	    private decimal ObtenerPrecioArticulo(decimal CodA, decimal CodC)
	    {
		    decimal Precio = 0;
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

	    private void LimpiarCampos()
	    {
		    foreach (Control c in this.gbFactura.Controls)
            {
			    if (c is TextBox) 
                {
				    c.Text = null;
			    }
		    }
		    this.lvFactura.Items.Clear();
		    this.btnAceptar.Enabled = false;
	    }
	    //---
	    private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	    //---
	   private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
		    this.Dispose();
        }
	    //---
	    private void frmConsultarFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea consultar los datos de otra Factura?", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
			    e.Cancel = true;
			    LimpiarCampos();
                this.cmbIngresoFactTipo.Enabled = true;
                this.cmbIngresoFactTipo.Refresh();
			    this.txtIngresoFact.Text="";
                this.btnBuscar.Enabled = false;
                this.cmbIngresoFactTipo.Select();
		    }
        }
	    //---
	    //Estos procedimientos muestran informacion acerca de los controles
	    //Botones
	    private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Busca la Factura especificada en la Base de Datos.";
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = null;
        }

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Termina la consulta de la Factura.";
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            this.ToolStripStatusLabelInfo.Text = "Cierra el Formulario de consulta de Factura.";
        }
    }
}
