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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        MarketManagementSystemEntities db = new MarketManagementSystemEntities();
        private void BtnMusteriBorcOdeme_Click(object sender, EventArgs e)
        {
            label3.Visible = true; TBOdemeMiktar.Visible = true; BtnOnayla.Visible = true;
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            DGVMusteriler.DataSource = db.Musteris.ToList();
            DGVMusteriler.Columns[4].Visible = false; DGVMusteriler.Columns[5].Visible = false;
            DGVMusteriler.Columns[0].HeaderText = "Müşteri No";
            DGVMusteriler.Columns[1].HeaderText = "Ad";
            DGVMusteriler.Columns[2].HeaderText = "Soyad";
            DGVMusteriler.Columns[3].HeaderText = "Borç";
        }

        private void TBMusteriArama_TextChanged(object sender, EventArgs e)
        {
            DGVMusteriler.DataSource = db.Musteris.Where(
                x => x.musteriAd.StartsWith(TBMusteriArama.Text)).ToList();
        }
    }
}
