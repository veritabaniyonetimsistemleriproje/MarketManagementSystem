using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        MarketManagementSystemEntities1 db = new MarketManagementSystemEntities1();
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


        private void BtnStokEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt dosyaları|*.txt";
            DialogResult result = openFileDialog1.ShowDialog(); 
            if (result == DialogResult.OK) 
            {

                string file = openFileDialog1.FileName;

                try
                {
                    string[] text = File.ReadAllLines(file);

                    int urunID = Convert.ToInt32(text[0]);
                    int urunBarkod = Convert.ToInt32(text[1]);
                    int urunStok = Convert.ToInt32(text[3]);
                    double urunFiyat = Convert.ToDouble(text[2]);
                    int tedarikciNo = Convert.ToInt32(text[4]);


                    var urun = db.Uruns.Find(urunID);
                    urun.urunStok += urunStok;
                    urun.urunFiyat = urunFiyat;

                    var tedarikci = db.Tedarikcis.Find(tedarikciNo);
                    tedarikci.tedarikciBorc += urunStok * urunFiyat;

                    Irsaliye irsaliye = new Irsaliye();
                    irsaliye.urunKod = urunID;
                    irsaliye.urunBarkod = urunBarkod;
                    irsaliye.tedarikciNo = tedarikciNo;
                    irsaliye.birimGirdiFiyat = urunFiyat;
                    irsaliye.miktar = urunStok;
                    irsaliye.tarih = DateTime.Now;
                    db.Irsaliyes.Add(irsaliye);
                    db.SaveChanges();
                    MessageBox.Show("Ürün stoğa işlendi.");
                }
                catch 
                {
                    MessageBox.Show("Lütfen doğru txt dosyasını seçtiğinizden emin olunuz.");
                }
            }
        }

        private void DGVUrunler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TBUrunBarkod.Text = DGVUrunler.CurrentRow.Cells[1].Value.ToString();
            TBUrunAd.Text = DGVUrunler.CurrentRow.Cells[2].Value.ToString();
            TBUrunFiyat.Text = DGVUrunler.CurrentRow.Cells[3].Value.ToString();
            TBUrunStok.Text = DGVUrunler.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
