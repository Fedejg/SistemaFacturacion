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
    public partial class frmConsultaRemito : Form
    {
        private decimal CodCateg;
        private string DescR;
        private string ImpTR;

        public frmConsultaRemito()
        {
            InitializeComponent();
        }

        private void frmConsultaRemito_Load(object sender, EventArgs e)
        {
            
            this.lineaRemitoTableAdapter.Fill(this.sFBDDataSet.LineaRemito);
            CargarTablas();
            CargarListaRemito();
        }

        private void CargarTablas()
	    {
		    try 
            {
                this.remitoTableAdapter.Fill(this.sFBDDataSet.Remito);
                this.clienteTableAdapter.Fill(this.sFBDDataSet.Cliente);
                this.articuloTableAdapter.Fill(this.sFBDDataSet.Articulo);
                this.articuloCategoriaCTableAdapter.Fill(this.sFBDDataSet.ArticuloCategoriaC);
		    } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
		    }
	    }

	    private void CargarListaRemito()
	    {
		    for (int i = 0; i <= this.sFBDDataSet.Remito.Rows.Count - 1; i++)
            {
			    decimal IdRem=Convert.ToDecimal(this.sFBDDataSet.Remito.Rows[i]["IdRemito"].ToString());
                this.lvRemito.Items.Add(IdRem.ToString("000000000000"));
                this.lvRemito.Items[i].SubItems.Add(this.sFBDDataSet.Remito.Rows[i]["FechaRto"].ToString());
                decimal Dto=Convert.ToDecimal(this.sFBDDataSet.Remito.Rows[i]["Descuento"].ToString());
                this.lvRemito.Items[i].SubItems.Add(Dto.ToString("#,##0.00"));
                //this.lvRemito.Items[i].SubItems.Add(Strings.Format(this.SCDataBaseDataSet.Remito.Rows[i]("Importe"), "#,##0.00"));
                decimal Importe=Convert.ToDecimal(this.sFBDDataSet.Remito.Rows[i]["ImporteRto"].ToString());
                this.lvRemito.Items[i].SubItems.Add(Importe.ToString("#,##0.00"));
            }
	    }
	    //---
	    private void lvRemito_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Si el usuario cambia de fila seleccionando los datos de otro Remito, se deben limpiar los datos del Cliente y el Detalle del Remito.
            this.txtCodC.Text = null;
            this.txtApNom.Text = null;
            this.txtRSocial.Text = null;
            this.lvDetalleRemito.Items.Clear();
            this.txtDescuento.Text = null;
            this.txtImporteT.Text = null;
        }

        private void lvRemito_DoubleClick(object sender, EventArgs e)
        {
            //Si el usuario hace doble click en una linea de lvRemito (es decir, selecciona un Remito), se deben mostrar los datos relacionados al mismo.
            ListView.SelectedListViewItemCollection FilaSel = default(ListView.SelectedListViewItemCollection);
            Decimal NroRto;
            string Fecha;
            //Asigno a FilaSel la coleccion de items de la fila seleccionada, a NroRto el numero de Remito, y a Fecha la Fecha del Remito.
            FilaSel = this.lvRemito.SelectedItems;
            NroRto = Convert.ToDecimal(FilaSel[0].Text);
            Fecha = FilaSel[0].SubItems[1].Text;
            DescR = FilaSel[0].SubItems[2].Text;
            ImpTR = FilaSel[0].SubItems[3].Text;
            //Carga los datos del Cliente relacionados al remito seleccionado.
            CargarDatosCliente(NroRto.ToString(), Fecha);
            //Carga las filas del lvDetalleRemito desde la Base de Datos, relacionadas al Remito seleccionado.
            CargarListaDetalleR(NroRto.ToString());
        }

	    private void CargarDatosCliente(string NumRemito, string FecR)
	    {
		    //Con este procedimiento se cargan los datos del Cliente dentro del grbCliente (Informacion de Cliente)
            string Codigo;
		    //este procedimiento sirve para buscar el codigo del Cliente del cual se quiere mostrar los datos, y que esta relacionado con el Remito.
		    Codigo = ObtenerCodCliente(NumRemito);
		    //Recorro la tabla Cliente para asignar los valores buscados
		    foreach (DataRow Fila in this.sFBDDataSet.Cliente)
            {
			    if (Fila["IdCliente"].ToString() == Codigo)
                {
				    //this.txtCodC.Text = Strings.Format(Fila("CodCliente"), "0000");
                    this.txtCodC.Text = int.Parse(Fila["IdCliente"].ToString()).ToString("0000");
                    this.txtApNom.Text = Fila["Apellido"].ToString()+" "+ Fila["Nombre"].ToString();
				    this.txtRSocial.Text = Fila["RazonSocial"].ToString();
				    CodCateg = Convert.ToDecimal(Fila["IdCategoriaC"].ToString());
				    break; // 
			    }
		    }
	    }

        private string ObtenerCodCliente(string NumRemito)
	    {
		    //Con este procedimiento se obtiene el codigo de Cliente en cuestion.
            string Codigo1="";
		    //Recorro la tabla ClienteRemito para buscar el codigo de Cliente.
		    foreach (DataRow Fila in this.sFBDDataSet.Remito)
            {
			    if (Fila["IdRemito"].ToString() == NumRemito)
                {
					Codigo1 = Fila["IdCliente"].ToString();
					break; 
			    }
		    }
		    return Codigo1;
	    }

	    private void CargarListaDetalleR(string NumRemito)
	    {
		    //Con este procedimiento se cargan los datos del detalle del Remito seleccionado.
		    string Descrip = null;
            decimal Precio = 0;
		    //Lleno la tabla ArticuloRemito en memoria unicamente con los datos del remito seleccionado.
		    this.lineaRemitoTableAdapter.FillByRemito(this.sFBDDataSet.LineaRemito, int.Parse(NumRemito));
		    //Adiciono cada fila de la tabla a lvDetalleRemito.
		    for (int i = 0; i <= this.sFBDDataSet.LineaRemito.Count - 1; i++) 
            {
                this.lvDetalleRemito.Items.Add(Convert.ToDecimal(this.sFBDDataSet.LineaRemito.Rows[i]["IdArticulo"].ToString()).ToString("0000"));
                Descrip = ObtenerDescArticulo(this.sFBDDataSet.LineaRemito.Rows[i]["IdArticulo"].ToString());
			    this.lvDetalleRemito.Items[i].SubItems.Add(Descrip);
			    Precio = ObtenerPrecioArticulo(this.sFBDDataSet.LineaRemito.Rows[i]["IdArticulo"].ToString(), CodCateg);
                this.lvDetalleRemito.Items[i].SubItems.Add(Precio.ToString("#,##0.00"));
                this.lvDetalleRemito.Items[i].SubItems.Add(this.sFBDDataSet.LineaRemito.Rows[i]["Cantidad"].ToString());
			    //this.lvDetalleRemito.Items(i).SubItems.Add(Strings.Format(this.SCDataBaseDataSet.RemitoArticulo.Rows(i)("ImporteP"), "#,##0.00"));
                this.lvDetalleRemito.Items[i].SubItems.Add((Convert.ToDecimal(this.sFBDDataSet.LineaRemito.Rows[i]["ImporteLinea"].ToString()).ToString("#,##0.00")));		    
            }
		    this.txtDescuento.Text = DescR;
		    this.txtImporteT.Text = ImpTR;
	    }

	    private string ObtenerDescArticulo(string CodA)
	    {
		    //Con este procedimiento se obtiene la descripcion del articulo desde la Base de Datos.
		    string Cadena = null;
		    foreach (DataRow Fila in this.sFBDDataSet.Articulo)
            {
			    if (Fila["IdArticulo"].ToString() == CodA)
                {
                    Cadena = Fila["Descripcion"].ToString();
				    break; 
			    }
		    }
		    return Cadena;
	    }

	    private decimal ObtenerPrecioArticulo(string CodA, decimal CodC)
	    {
		    //Con este procedimiento se obtiene el precio del Articulo desde la Base de Datos.
		    decimal Precio = 0;
		    foreach (DataRow Fila in this.sFBDDataSet.ArticuloCategoriaC)
            {
			    if (Convert.ToDecimal(Fila["IdCategoriaC"].ToString()) == CodC)
                {
				    if (Fila["IdArticulo"].ToString() == CodA)
                    {
					    Precio = Convert.ToDecimal(Fila["Precio"].ToString());
					    break; 
				    }
			    }
		    }
		    return Precio;
	    }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
               
    }
}
