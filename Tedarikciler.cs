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
    public partial class Tedarikciler : Form
    {
        public Tedarikciler()
        {
            InitializeComponent();
        }
        MarketManagementSystemEntities1 db = new MarketManagementSystemEntities1();

        private void BtnTedarikciBorcOdeme_Click(object sender, EventArgs e)
        {
            label5.Visible = true; TBTedarikciOdemeMiktar.Visible = true; BtnTedarikciOnayla.Visible = true;
        }
   
        private void TBTedarikciArama_TextChanged(object sender, EventArgs e)
        {
            DGVTedarikciler.DataSource = db.Tedarikcis.Where(
                x => x.tedarikciAd.StartsWith(TBTedarikciArama.Text)).ToList();
        }

        private void Tedarikciler_Load_1(object sender, EventArgs e)
        {
            DGVTedarikciler.DataSource = db.Tedarikcis.ToList();
            DGVTedarikciler.Columns[3].Visible = false; DGVTedarikciler.Columns[4].Visible = false;
            DGVTedarikciler.Columns[0].HeaderText = "Tedarikci No";
            DGVTedarikciler.Columns[1].HeaderText = "Tedarikci Ad";
            DGVTedarikciler.Columns[2].HeaderText = "Tedarikçi Borç";
        }

        private void DGVTedarikciler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TBTedarikciNo.Text = DGVTedarikciler.CurrentRow.Cells[0].Value.ToString();
            TBTedarikciAd.Text = DGVTedarikciler.CurrentRow.Cells[1].Value.ToString();
            TBTedarikciBorc.Text = DGVTedarikciler.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnYeniTedarikci_Click(object sender, EventArgs e)
        {
            Tedarikci t = new Tedarikci();
            t.tedarikciAd = TBTedarikciAd.Text;
            t.tedarikciBorc = Convert.ToDouble(TBTedarikciBorc.Text);
            db.Tedarikcis.Add(t);
            db.SaveChanges();
            MessageBox.Show("Tedarikçi başarı ile eklenmiştir");
            DGVTedarikciler.DataSource = db.Tedarikcis.ToList();
        }

        private void BtnTedarikciSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Tedarikçi Silinsin Mi?", "Uyarı", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                int id = Convert.ToInt32(TBTedarikciNo.Text);
                var x = db.Tedarikcis.Find(id);
                db.Tedarikcis.Remove(x);
                db.SaveChanges();
                MessageBox.Show("Tedarikçi başarı ile silindi.");
                DGVTedarikciler.DataSource = db.Tedarikcis.ToList();
            }
           
        }

        private void BtnTedarikciGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBTedarikciNo.Text);
            var x = db.Tedarikcis.Find(id);
            x.tedarikciAd = TBTedarikciAd.Text;
            x.tedarikciBorc = Convert.ToDouble(TBTedarikciBorc.Text);
            db.SaveChanges();
            DGVTedarikciler.DataSource = db.Tedarikcis.ToList();
            MessageBox.Show("Tedarikçi bilgileri başarı ile güncellendi.");
        }
    }
}
