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
    public partial class UrunListCoktanAza : Form
    {
        MarketManagementSystemEntities1 db = new MarketManagementSystemEntities1();
        public UrunListCoktanAza()
        {
            InitializeComponent();
        }

        private void UrunListCoktanAza_Load(object sender, EventArgs e)
        {


            try
            {
                var sorgu = from sepetUrun in db.SepetUruns
                            group sepetUrun by sepetUrun.urunBarkod into s
                            select new
                            {
                                Ad = db.Uruns.Where(x => x.urunBarkod == s.Key).Select(x => x.urunAd).FirstOrDefault(),
                                Barkod = s.Key,
                                ToplamSatış = s.Sum(x => x.satisMiktar),
                            };
                DGVListelemeUrun.DataSource = sorgu.OrderByDescending(x => x.ToplamSatış).ToList();
            }
            catch
            {
                MessageBox.Show("Lütfen kontrol edin");
            }
        }
    }
}