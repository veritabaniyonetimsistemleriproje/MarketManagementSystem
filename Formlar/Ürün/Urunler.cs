using MarketManagementSystem.Model;
using Microsoft.VisualBasic;
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


                    var query = (from s in db.Uruns
                                 where s.urunKod == urunID
                                 select s);
                    var deneme = query.FirstOrDefault();

                    if (deneme != null)
                    {
                        var urun = db.Uruns.Find(urunID);
                        urun.urunStok += urunStok;
                    }
                    else if (deneme == null)
                    {
                        int x = this.Left + (this.Width / 2);
                        int y = this.Top + (this.Height / 2);
                        string isimGirisi = Interaction.InputBox("Bu ürün ilk defa ekleniyor. Lütfen ürün ismini giriniz:", "Ürün İsmi", "Örn: Süt 1L", x, y);
                        Urun urun = new Urun();
                        urun.urunKod = urunID;
                        urun.urunBarkod = urunBarkod;
                        urun.urunAd = isimGirisi;
                        double fiyatGiris = Convert.ToDouble(Interaction.InputBox("Lütfen ürün satış fiyatını giriniz:", "Ürün Fiyat", "Örn: 100", x, y));
                        urun.urunFiyat = fiyatGiris;
                        urun.urunStok = urunStok;
                        db.Uruns.Add(urun);
                    }

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
                    DGVUrunler.DataSource = db.Uruns.ToList();
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

        private void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            double barkod = Convert.ToInt32(TBUrunBarkod.Text);
            var urun = db.Uruns.First(s => s.urunBarkod == barkod);
            urun.urunFiyat = Convert.ToDouble(TBUrunFiyat.Text);
            urun.urunAd = TBUrunAd.Text;
            db.SaveChanges();
            DGVUrunler.DataSource = db.Uruns.ToList();
        }
    }
}
