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
    public partial class frmRanking : Form
    {
        string FechaDesde;
        string FechaHasta;
        int i = 0;
        ListView Lista = new ListView();
        public frmRanking()
        {
            InitializeComponent();
        }

        private void frmRanking_Load(object sender, EventArgs e)
        {
            this.lvRank.Items.Clear();
            CargarTablas();
        }  

        private void CargarTablas()
        {
             this.lineaRemitoTableAdapter.Fill(this.sFDBDataSet.LineaRemito);
            this.articuloTableAdapter.Fill(this.sFDBDataSet.Articulo);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FechaDesde = dtpFecDesde.Text;
            FechaHasta = dtpFecHasta.Text;
            foreach(DataRow Fila in this.sFDBDataSet.Articulo)
            {
                int IdArt=Convert.ToInt32(Fila["IdArticulo"].ToString());
                
                var CantArt = this.lineaRemitoTableAdapter.CantidadTotalPorFechas(IdArt, FechaDesde, FechaHasta);
                if(CantArt!=null)
                {
                    Lista.Items.Add(IdArt.ToString("0000"));
                    Lista.Items[i].SubItems.Add(Fila["Descripcion"].ToString());
                    Lista.Items[i].SubItems.Add(CantArt.ToString());
                    i += 1;
                }
            }
            OrdenarLista();
            CargarListViewRank();
        }
        private void OrdenarLista()
        {
            for (int i = 0; i < Lista.Items.Count-1; i++)
            {
                for (int j = i+1; j < Lista.Items.Count; j++)
                {
                    int Elementoi=int.Parse(Lista.Items[i].SubItems[2].Text);
                    int Elementoj=int.Parse(Lista.Items[j].SubItems[2].Text);
                    if(Elementoj > Elementoi)
                    {
                        var Aux1=Lista.Items[i].SubItems[0].Text;
                        var Aux2=Lista.Items[i].SubItems[1].Text;
                        var Aux3=Lista.Items[i].SubItems[2].Text;

                        Lista.Items[i].SubItems[0].Text = Lista.Items[j].SubItems[0].Text;
                        Lista.Items[i].SubItems[1].Text = Lista.Items[j].SubItems[1].Text;
                        Lista.Items[i].SubItems[2].Text = Lista.Items[j].SubItems[2].Text;

                        Lista.Items[j].SubItems[0].Text = Aux1;
                        Lista.Items[j].SubItems[1].Text = Aux2;
                        Lista.Items[j].SubItems[2].Text = Aux3;
                    }
                }
            }
        }

        private void CargarListViewRank()
        {
            this.lvRank.Items.Clear();
            int j = 0;
            for (int i = 0; i < Lista.Items.Count; i++)
            {
                decimal Codigo=Convert.ToDecimal(Lista.Items[i].Text);
                this.lvRank.Items.Add(Codigo.ToString("0000"));
                this.lvRank.Items[j].SubItems.Add(Lista.Items[i].SubItems[1].Text.ToString());
                this.lvRank.Items[j].SubItems.Add(Lista.Items[i].SubItems[2].Text.ToString());
                j += 1;
            }
        }
    }
}
