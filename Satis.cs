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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }

        MarketManagementSystemEntities db = new MarketManagementSystemEntities();
        private void Satis_Load(object sender, EventArgs e)
        {
            DGVMusteriler.DataSource = db.Musteris.ToList();
            panel1.Visible = false;
            DGVMusteriler.Columns[4].Visible = false; DGVMusteriler.Columns[5].Visible = false;
            DGVMusteriler.Columns[0].HeaderText = "Müşteri No";
            DGVMusteriler.Columns[1].HeaderText = "Ad";
            DGVMusteriler.Columns[2].HeaderText = "Soyad";
            DGVMusteriler.Columns[3].HeaderText = "Borç";

            //DGVSepet.DataSource = db.Uruns.ToList();
            
        }

        private void DGVMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TBMusteriID.Text = DGVMusteriler.CurrentRow.Cells[0].Value.ToString();
        }

        private void RBtnVeresiye_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void RBtnPesin_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void BtnOnay_Click(object sender, EventArgs e)
        {

            /*int number = Convert.ToInt32(TBBarkodNo.Text);
            var urun = db.Uruns.Where(r => r.urunKod == number).FirstOrDefault();
            if (urun != null)
            {
                DGVSepet.DataSource = db.Uruns.Where(
                    x => x.urunAd.StartsWith(TBBarkodNo.Text)).ToList();
            }
            */
            DGVSepet.DataSource = db.Uruns.Where(
                    x => x.urunAd.StartsWith(TBBarkodNo.Text)).ToList();



        }

        private void DGVSepet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
