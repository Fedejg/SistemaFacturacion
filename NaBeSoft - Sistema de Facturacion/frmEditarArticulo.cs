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
    public partial class frmEditarArticulo : Form
    {
        private bool Bandera = false;
        private decimal Codigo;
        private int NroDepos;
        private int Rubro;
        private int IdStock;
        private int Stock=0;
        private string Cadena;
        ListView Listado = new ListView();
        TextBox Actual;
        public frmEditarArticulo()
        {
            InitializeComponent();
        }

        private void frmEditarArticulo_Load(object sender, EventArgs e)
        {
            BloquearComponentes();
            CargarTablas();
            CargarComboRubro();
            CargarComboDeposito();
            Listado.Items.Clear();
            CargarLista();
            LimpiarVentana();
        }

        private void BloquearComponentes()
        {
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.grbArticulo.Enabled = false;
            this.gbDepositos.Enabled = false;
            this.grbPrecios.Enabled = false;
        }

        private void CargarTablas()
	    {
		    try
            {
                this.rubroTableAdapter.Fill(this.sFBDDataSet.Rubro);
                this.depositoTableAdapter.Fill(this.sFBDDataSet.Deposito);
		    } 
            catch (Exception ex) 
            {
			        MessageBox.Show(ex.Message);
		    }
	    }

        private void CargarComboRubro()
        { 
            foreach(DataRow Fila in this.sFBDDataSet.Rubro)
            {
                this.cmbRubro.Items.Add(Fila["Descripcion"].ToString());
            }
        }

        private void CargarComboDeposito()
	    {
		    foreach (DataRow Fila in this.sFBDDataSet.Deposito) 
            {
			    this.cmbDeposito.Items.Add(Fila["Nombre"].ToString());
		    }
	    }

	    private void CargarLista()
	    {
            
            int j=0;
            this.lvArticulos.Items.Clear();
            try 
            {
                this.articuloTableAdapter.Fill(this.sFBDDataSet.Articulo);
			    for (int i = 0; i <= this.sFBDDataSet.Articulo.Rows.Count - 1; i++) 
                {
                    if(this.sFBDDataSet.Articulo.Rows[i]["Borrado"].ToString()=="N")
                    {
                        decimal CodCli=Convert.ToDecimal(this.sFBDDataSet.Articulo.Rows[i]["IdArticulo"].ToString());
                        Listado.Items.Add(CodCli.ToString("0000"));
                        Listado.Items[j].SubItems.Add(this.sFBDDataSet.Articulo.Rows[i]["Descripcion"].ToString());
                        j+=1;    
                    }
                }
                for (int i = 0; i < Listado.Items.Count; i++)
			    {
			        this.lvArticulos.Items.Add(Listado.Items[i].Text);
                    this.lvArticulos.Items[i].SubItems.Add(Listado.Items[i].SubItems[1].Text);
                    string Cadena = this.lvArticulos.Items[i].SubItems[1].Text;
			    }
                //this.lvArticulos.Items.Add(Strings.Format(this.SCDataBaseDataSet.Articulo.Rows(i)("CodArticulo"), "0000"));
                //this.lvArticulos.Items.Add(this.sFBDDataSet.Articulo.Rows[i-1]["IdArticulo"].ToString());
		    }
            catch (Exception ex) 
            {
			    MessageBox.Show("No existe ningín Artículo en la Base de Datos: Error "+ ex.Message, "Sistema de Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
		    }
		    LimpiarVentana();
	    }

	    private void LimpiarVentana()
	    {
		    foreach (Control c in this.grbArticulo.Controls)
            {
			    if (c is TextBox)
                {
				    c.Text = null;
			    }
			    if (c is ComboBox)
                {
				    c.Text = "Seleccione uno...";
			    }
		    }
		    foreach (Control c in this.gbDepositos.Controls)
            {
			    if (c is TextBox)
                {
				    c.Text = null;
			    }
			    if (c is ComboBox)
                {
				    c.Text = "Seleccione uno...";
			    }
		    }
		    this.cmbUStock.Text = "Seleccione una...";
	    	this.txtNroDeposito.Text = null;
		    foreach (Control c in this.grbPrecios.Controls)
            {
			    if (c is TextBox)
                {
				    c.Text = null;
			    }
		    }
            BloquearComponentes();
	    }
	    //---
	    private void lvArticulos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            LimpiarVentana();
        }

        private void lvArticulos_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection FilaSelect = default(ListView.SelectedListViewItemCollection);
		    FilaSelect = this.lvArticulos.SelectedItems;
		    int CodArticulo = int.Parse(FilaSelect[0].Text);
		    ConsultarDatos(CodArticulo);
		    this.txtDesc.Select();
            this.btnModificar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.grbArticulo.Enabled = true;
            this.gbDepositos.Enabled = true;
            this.grbPrecios.Enabled = true;
        }
	
	    private void ConsultarDatos(int CodArticulo)
	    {
		    int cod = 0;
            int Rub = 0;
            this.articuloTableAdapter.FillByArticulo(this.sFBDDataSet.Articulo, CodArticulo);
            this.stockTableAdapter.Fill(this.sFBDDataSet.Stock);
		    
            foreach(DataRow Fila in this.sFBDDataSet.Articulo)
            {
                cod = int.Parse(Fila["IdArticulo"].ToString());
                this.txtCodArt.Text = cod.ToString("0000");
                txtDesc.Text = Fila["Descripcion"].ToString();
                Rub = int.Parse(Fila["IdRubro"].ToString());
                break;
            }

            foreach (DataRow Fila in this.sFBDDataSet.Rubro)
            {
                if (Rub==int.Parse(Fila["IdRubro"].ToString()))
                {
                    cmbRubro.Text=Fila["Descripcion"].ToString();
                    break;
                }
            }
            foreach (DataRow Fila in this.sFBDDataSet.Stock)
            {
			    if (CodArticulo == int.Parse(Fila["IdArticulo"].ToString()))
                {
                    IdStock = int.Parse(Fila["IdStock"].ToString());
                    this.cmbUStock.Text = Fila["UnidadStock"].ToString();
                    Stock = int.Parse(Fila["CantStock"].ToString());
                    this.txtStockSeguridad.Text = Fila["StockSeguridad"].ToString();
				    NroDepos = int.Parse(Fila["IdDeposito"].ToString());
                    break;
			    }
		    }
		    foreach (DataRow Fila in this.sFBDDataSet.Deposito)
            {
			    if (NroDepos == int.Parse(Fila["IdDeposito"].ToString()))
                {
				    this.cmbDeposito.Text = Fila["Nombre"].ToString();
				    int Iddep=int.Parse(Fila["IdDeposito"].ToString());
                    this.txtNroDeposito.Text = Iddep.ToString("00");
                    break;
			    }
		    }
		    this.articuloCategoriaCTableAdapter.FillByArticulo(this.sFBDDataSet.ArticuloCategoriaC, CodArticulo);
		    foreach (DataRow Fila in this.sFBDDataSet.ArticuloCategoriaC)
            {
			    switch (Fila["IdCategoriaC"].ToString())
                {
				    case "1":
					        this.txtPrecioEsp.Text = Fila["Precio"].ToString();
                            //this.txtPrecioEsp.Text = Strings.Format(Fila("Precio"), "#,##0.00");
					        break;
				    case "2":
					        this.txtPrecioFra.Text = Fila["Precio"].ToString();
                            //this.txtPrecioEst.Text = Strings.Format(Fila("Precio"), "#,##0.00");
					        break;
				    case "3":
					        this.txtPrecioMay.Text= Fila["Precio"].ToString();
                            //this.txtPrecioFra.Text = Strings.Format(Fila("Precio"), "#,##0.00");
					        break;
				    case "4":
					        this.txtPrecioMin.Text = Fila["Precio"].ToString();
                            //this.txtPrecioMay.Text = Strings.Format(Fila("Precio"), "#,##0.00");
					        break;
			    }
		    }
	    }
	    //---
	    private void cmbRubro_KeyDown(object sender, KeyEventArgs e)
        {
             //Este procedimiento valida y no permite el ingreso de algun caracter en el combo
		    if (e.KeyCode < Keys.Left || e.KeyCode > Keys.Down) 
            {
			    Bandera = true;
		    }
        } 

        private void cmbRubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Este procedimiento cancela el ingreso del caracter validado en el proceso keydown
		    if (Bandera == true) 
            {
		    	e.Handled = true;
		    }
        }
	    //---
        private void cmbRubro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cmbRubro.Text == null)
            {
            }
        }

        private void cmbRubro_TextChanged(object sender, EventArgs e)
        {
            foreach (DataRow Fila in this.sFBDDataSet.Rubro)
            {
                if (Fila["Descripcion"].ToString() == this.cmbRubro.Text)
                {
                    Rubro = int.Parse(Fila["IdRubro"].ToString());
                    break;
                }
            }
        }
        private void cmbDeposito_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cmbDeposito.Text == null)
            {
			    this.txtNroDeposito.Text = null;
		    }
        }

        private void cmbDeposito_TextChanged(object sender, EventArgs e)
        {
            foreach (DataRow Fila in this.sFBDDataSet.Deposito) 
            {
			    if (Fila["Nombre"].ToString() == this.cmbDeposito.SelectedItem.ToString())
                {
				    this.txtNroDeposito.Text=Fila["IdDeposito"].ToString();
                    //this.txtNroDeposito.Text = Strings.Format(Fila("NroDeposito"), "00");
				    NroDepos = int.Parse(Fila["IdDeposito"].ToString());
				    break; 
			    }
		    }
        }
	    //---
	    private void txtStockSeguridad_KeyDown(object sender, KeyEventArgs e)
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
					    if (e.KeyCode != Keys.Decimal)
                        {
						    Bandera = true;
					    }
				    }
			    }
		    }
        }

        private void txtPrecioEsp_Leave(object sender, EventArgs e)
        {
            //Este procedimiento le da un formato al precio ingresado en el campo, y genera la validacion del campo.
		    Actual=(TextBox)sender;
            if (this.btnCancelar.Focused == false)
            {
			    if (Actual.Text != null) 
                {
				    Cadena = Actual.Text;
				    Actual.Text = Cadena.Replace('.', ',');
				    Codigo = Convert.ToDecimal(Actual.Text);
				    //this.txtPrecioEsp.Text = Strings.Format(Codigo, "#,##0.00");
			    }
            }
		}
	    //---
	    private void btnModificar_Click(object sender, EventArgs e)
        {
            bool Respuesta = false;
	    	Respuesta = ValidarDatosArticulo();
		    if (Respuesta == true)
            {
		    	return;
		    }
		    this.btnModificar.Cursor = Cursors.WaitCursor;
		    if (MessageBox.Show("Se modificarán los datos del Artículo, seguro desea continuar?", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
			    ModificarDatos();
			    MessageBox.Show("El Artículo fue modificado con Exito!!", "Sistema de Facturación", MessageBoxButtons.OK);
		    } 
            else 
            {
			    this.btnCancelar.Select();
		    }
		    this.btnModificar.Cursor = Cursors.Hand;
		    this.lvArticulos.Items.Clear();
		    CargarLista();
        }

	    private bool ValidarDatosArticulo()
	    {
		    bool functionReturnValue = false;
		    if (this.txtDesc.Text=="")
            {
			    MessageBox.Show("Debe Ingresar la descripción del Artículo antes de continuar.", "Sistema de Facturación",MessageBoxButtons.OK);
			    this.txtDesc.Select();
				return functionReturnValue=true;
		    }
		    if (this.cmbRubro.Text == null || this.cmbRubro.Text == "Seleccione uno...")
            {
			    MessageBox.Show("Debe Seleccionar el Rubro del Artículo antes de continuar.", "Sistema de Facturación",MessageBoxButtons.OK);
			    this.cmbRubro.Select();
			    return functionReturnValue=true;
		    }
		    if (this.cmbDeposito.Text == null || this.cmbDeposito.Text == "Seleccione uno...") 
            {
			    MessageBox.Show("Debe Seleccionar el Deposito donde se almacenará el Artículo antes de continuar.", "Sistema de Facturación",MessageBoxButtons.OK);
			    this.cmbDeposito.Select();
			    return functionReturnValue=true;
		    }
		    if (this.cmbUStock.Text == null || this.cmbUStock.Text == "Seleccione una...")
            {
			    MessageBox.Show("Debe Seleccionar la Unidad de Stock del Artículo antes de continuar.", "Sistema de Facturación",MessageBoxButtons.OK);
			    this.cmbUStock.Select();
			    return functionReturnValue=true;
		    }
		    if (this.txtStockSeguridad.Text=="")
            {
			    MessageBox.Show("Debe Ingresar el Stock de Seguridad que tendrá el Artículo antes de continuar.", "Sistema de Facturación",MessageBoxButtons.OK);
			    this.txtStockSeguridad.Select();
			    return functionReturnValue=true;
		    }
		    if (this.txtPrecioEsp.Text=="")
            {
			    MessageBox.Show("Debe ingresar el Precio para Clientes Especiales, antes de continuar", "Sistema de Facturación",MessageBoxButtons.OK);
			    this.txtPrecioEsp.Select();
			    return functionReturnValue=true;
		    }
		    if (this.txtPrecioMin.Text=="")
            {
			    MessageBox.Show("Debe ingresar el Precio para Clientes Minoristas, antes de continuar", "Sistema de Facturación",MessageBoxButtons.OK);	    
    			this.txtPrecioMin.Select();
		    	return functionReturnValue=true;
		    }
		    if (this.txtPrecioFra.Text=="") 
            {
			    MessageBox.Show("Debe ingresar el Precio para Clientes Franquiciados, antes de continuar", "Sistema de Facturación",MessageBoxButtons.OK);	    	
    			this.txtPrecioFra.Select();
	    		return functionReturnValue=true;
		    }
		    if (this.txtPrecioMay.Text=="")
            {
			    MessageBox.Show("Debe ingresar el Precio para Clientes Mayoristas, antes de continuar", "Sistema de Facturación",MessageBoxButtons.OK); 		
    			this.txtPrecioMay.Select();
	    		return functionReturnValue=true;
		    }
		    return functionReturnValue;
	    }
	    private void ModificarDatos()
	    {
		    //int StockSeguridad = int.Parse(this.txtStockSeguridad.Text);
		    int CodA = int.Parse(this.txtCodArt.Text);
		    this.articuloTableAdapter.ModificarArticulo(txtDesc.Text, Rubro, CodA);
            this.stockTableAdapter.ModificarStockArticulo(cmbUStock.Text, Stock, int.Parse(txtStockSeguridad.Text), NroDepos, CodA, IdStock);
            this.articuloCategoriaCTableAdapter.FillByArticulo(this.sFBDDataSet.ArticuloCategoriaC, CodA);
            foreach(DataRow Fila in this.sFBDDataSet.ArticuloCategoriaC)
            {
                string Codigo = Fila["IdCategoriaC"].ToString();
                int IdPA=int.Parse(Fila["IdArtCat"].ToString());
                switch(Codigo)
                {
                    case "1":   this.articuloCategoriaCTableAdapter.ModificarPrecioArticulo(txtPrecioEsp.Text, int.Parse(Codigo), CodA, IdPA);
                                break;
                    case "2":   this.articuloCategoriaCTableAdapter.ModificarPrecioArticulo(txtPrecioFra.Text, int.Parse(Codigo), CodA, IdPA);
                                break;
                    case "3":   this.articuloCategoriaCTableAdapter.ModificarPrecioArticulo(txtPrecioMay.Text, int.Parse(Codigo), CodA, IdPA);
                                break;
                    case "4":   this.articuloCategoriaCTableAdapter.ModificarPrecioArticulo(txtPrecioMin.Text, int.Parse(Codigo), CodA, IdPA);
                                break;
                }
            }
	    }
	    //---
	    private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.btnEliminar.Cursor = Cursors.WaitCursor;
		    if (MessageBox.Show("Seguro desea eliminar el Artículo?, Si continua se perderan permanetemente los datos del mismo y no podra recuperarlos.", "Sistema de Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
			    EliminarDatos();
			    MessageBox.Show("El Artículo fue eliminado de la Base de Datos.", "Sistema de Facturación",MessageBoxButtons.OK);
		    }
		    this.btnEliminar.Cursor = Cursors.Hand;
		    this.lvArticulos.Items.Clear();
		    CargarLista();
        }

    	private void EliminarDatos()
	    {
            int CodA=0;
            int CodArticulo = int.Parse(this.txtCodArt.Text);
            this.articuloTableAdapter.Fill(this.sFBDDataSet.Articulo);
            foreach(DataRow Fila in this.sFBDDataSet.Articulo)
            {
                if(CodArticulo==int.Parse(Fila["IdArticulo"].ToString()))
                {
                    CodA = int.Parse(Fila["IdArticulo"].ToString());
                    break;
                }
            }
            this.articuloTableAdapter.BorrarArticulo("S", CodA);
            /*this.articuloCategoriaCTableAdapter.FillByArticulo(this.sFBDDataSet.ArticuloCategoriaC, CodArticulo);
            foreach(DataRow Fila in this.sFBDDataSet.ArticuloCategoriaC)
            {
                int CodAC = int.Parse(Fila["IdArtCat"].ToString());
                string CodC = Fila["IdCategoriaC"].ToString();
                switch(CodC)
                {
                    case "1":   this.articuloCategoriaCTableAdapter.EliminarPrecioArticulo(CodAC);
                                break;
                    case "2":   this.articuloCategoriaCTableAdapter.EliminarPrecioArticulo(CodAC);
                                break;
                    case "3":   this.articuloCategoriaCTableAdapter.EliminarPrecioArticulo(CodAC);
                                break;
                    case "4":   this.articuloCategoriaCTableAdapter.EliminarPrecioArticulo(CodAC);
                                break;
                }
            }
            this.stockTableAdapter.EliminarStockArticulo(IdStock);
            this.articuloTableAdapter.EliminarArticulo(CodArticulo);*/
	    }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabelInfo.Text="Modifica los datos de un Artículo en la Base de datos.";
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            this.toolStripStatusLabelInfo.Text = null;
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabelInfo.Text = "Elimina los datos de un Artículo en la Base de datos.";
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            this.toolStripStatusLabelInfo.Text = "Cierra el formulario de Edición/Eliminación de Articulos.";
        }

        
    }
}
