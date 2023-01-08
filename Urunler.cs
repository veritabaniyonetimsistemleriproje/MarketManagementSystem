using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        MarketManagementSystemEntities db = new MarketManagementSystemEntities();
        private void Urunler_Load(object sender, EventArgs e)
        {
            DGVUrunler.DataSource = db.Uruns.ToList();
            DGVUrunler.Columns[5].Visible = false;
            DGVUrunler.Columns[0].HeaderText = "Urun Kod";
            DGVUrunler.Columns[1].HeaderText = "Urun Barkod";
            DGVUrunler.Columns[2].HeaderText = "Ad";
            DGVUrunler.Columns[3].HeaderText = "Fiyat";
            DGVUrunler.Columns[4].HeaderText = "Stok";
        }

        private void TBUrunAra_TextChanged(object sender, EventArgs e)
        {
            DGVUrunler.DataSource = db.Uruns.Where(
                    x => x.urunAd.StartsWith(TBUrunAra.Text)).ToList();
        }
    }
}
