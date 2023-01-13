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
        MarketManagementSystemEntities1 db = new MarketManagementSystemEntities1();

        public void TextBoxTemizle()
        {
            TBMusteriId.Text = ""; TBMusteriBorc.Text = ""; TBMusteriAd.Text = ""; TBMusteriSoyad.Text = "";
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

        private void DGVMusteriler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TBMusteriId.Text = DGVMusteriler.CurrentRow.Cells[0].Value.ToString();
            TBMusteriAd.Text = DGVMusteriler.CurrentRow.Cells[1].Value.ToString();
            TBMusteriSoyad.Text = DGVMusteriler.CurrentRow.Cells[2].Value.ToString();
            TBMusteriBorc.Text = DGVMusteriler.CurrentRow.Cells[3].Value.ToString();
          
        }

        private void BtnYeniMusteri_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.musteriAd = TBMusteriAd.Text;
            musteri.musteriSoyad = TBMusteriSoyad.Text;
            musteri.borcMiktar = Convert.ToDouble(TBMusteriBorc.Text);
            db.Musteris.Add(musteri);
            db.SaveChanges();
            MessageBox.Show("Müşteri başarı ile kayıt edildi.");
            DGVMusteriler.DataSource = db.Musteris.ToList();
            TextBoxTemizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Müşteri Silinsin Mi?", "Uyarı", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                int id = Convert.ToInt32(TBMusteriId.Text);
                var x = db.Musteris.Find(id);
                db.Musteris.Remove(x);
                db.SaveChanges();
                MessageBox.Show("Müşteri başarı ile silindi.");
                DGVMusteriler.DataSource = db.Musteris.ToList();
                TextBoxTemizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBMusteriId.Text);
            var x = db.Musteris.Find(id);
            x.musteriAd = TBMusteriAd.Text;
            x.musteriSoyad = TBMusteriSoyad.Text;
            x.borcMiktar = Convert.ToDouble(TBMusteriBorc.Text);
            db.SaveChanges();
            DGVMusteriler.DataSource = db.Musteris.ToList();
            TextBoxTemizle();
        }
    }
}
