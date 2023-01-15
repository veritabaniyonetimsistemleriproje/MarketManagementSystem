using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class UrunListCoktanAza : Form
    {
        public UrunListCoktanAza()
        {
            InitializeComponent();
        }
        MarketManagementSystemEntities1 db = new MarketManagementSystemEntities1();
        DataTable dt = new DataTable();

        private void UrunListCoktanAza_Load(object sender, EventArgs e)
        {
     
            try
            {
                
                    var sorgu = from sepetUrun in db.SepetUruns
                                group sepetUrun by sepetUrun.urunBarkod into s
                                select new
                                {
                                    barkod = s.Key,
                                    miktar = s.Sum(x => x.satisMiktar),
                                };
                    var deneme = from urun in db.Uruns
                                 select new
                                 {
                                   
                                     barkod = urun.urunBarkod,
                                     ad = urun.urunAd,
                                 };

                var q = from sor in sorgu
                        from dene in deneme
                        where sor.barkod == dene.barkod
                        select new
                        {
                            Ad = dene.ad,
                            Barkod = dene.barkod,
                            ToplamSatış = sor.miktar,
                        };
                DGVListelemeUrun.DataSource = q.OrderByDescending(x => x.ToplamSatış).ToList();

            }
            catch
            {
                MessageBox.Show("Lütfen kontrol edin");
            }
        }
    }
}
