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
    public partial class MusteriBazliRapor : Form
    {
        MarketManagementSystemEntities1 db = new MarketManagementSystemEntities1();

        public MusteriBazliRapor()
        {
            InitializeComponent();
        }

        private void MusteriBazliRapor_Load(object sender, EventArgs e)
        {
            DGVMusteriler.DataSource = db.Musteris.ToList();
            DGVMusteriler.Columns[3].Visible = false; DGVMusteriler.Columns[4].Visible = false; DGVMusteriler.Columns[5].Visible = false;
            DGVMusteriler.Columns[0].HeaderText = "Müşteri Numarası";
            DGVMusteriler.Columns[1].HeaderText = "Ad";
            DGVMusteriler.Columns[2].HeaderText = "Soyad";
        }

        private void TbMusteriAra_TextChanged(object sender, EventArgs e)
        {
            DGVMusteriler.DataSource = db.Musteris.Where(
                x => x.musteriAd.StartsWith(TbMusteriAra.Text)).ToList();
        }

        private void DGVMusteriler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TbMusteriNo.Text = DGVMusteriler.CurrentRow.Cells[0].Value.ToString();
        }

        private void BtnMusteriRapor_Click(object sender, EventArgs e)
        { 

            int musteriNo = Convert.ToInt32(TbMusteriNo.Text);
            var musteri = db.Musteris.Find(musteriNo);

            var query = from sepeturun in db.SepetUruns
                        join veresiye in db.SatisVeresiyes
                        on sepeturun.sepetId equals veresiye.sepetId
                        where veresiye.musteriNo == musteriNo
                        group sepeturun by sepeturun.urunBarkod into s
                        select new
                        {
                            //Ad = musteri.musteriAd + " " + musteri.musteriSoyad,
                            ÜrünAd = db.Uruns.Where(x => x.urunBarkod == s.Key).Select(x => x.urunAd).FirstOrDefault(),
                            ToplamSatış = s.Sum(x => x.satisMiktar),
                            ToplamMiktar = s.Sum(x => x.satisMiktar * x.urunAnlikFiyat),

                        };
            DGVMusteriRapor.DataSource = query.ToList();

            var sorgu = from sepetUrun in db.SepetUruns
                        group sepetUrun by sepetUrun.urunBarkod into s
                        select new
                        {
                            Ad = db.Uruns.Where(x => x.urunBarkod == s.Key).Select(x => x.urunAd).FirstOrDefault(),
                            Barkod = s.Key,
                            ToplamSatış = s.Sum(x => x.satisMiktar),
                        };
        }
    }
}
