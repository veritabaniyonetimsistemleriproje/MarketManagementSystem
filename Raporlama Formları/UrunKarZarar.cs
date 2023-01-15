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
    public partial class UrunKarZarar : Form
    {
        MarketManagementSystemEntities1 db = new MarketManagementSystemEntities1();
        DataTable dt = new DataTable();
        public UrunKarZarar()
        {
            InitializeComponent();
        }

        private void UrunKarZarar_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Ürün Barkod");
            dt.Columns.Add("Ürün Ad");
            dt.Columns.Add("Toplam satış");
            dt.Columns.Add("Toplam alış");
            dt.Columns.Add("Toplam Kar Zarar");
            
            foreach (var item in db.Uruns)
            {
                DataRow dr = dt.NewRow();

                var sorgu = db.SepetUruns.Where(x => x.urunBarkod == item.urunBarkod).Sum(x => x.urunAnlikFiyat * x.satisMiktar);
                var deneme = db.Irsaliyes.Where(x => x.urunBarkod == item.urunBarkod).Sum(x => (double?)(x.birimGirdiFiyat * x.miktar)) ?? 0;
                             
                if (sorgu.HasValue)
                {
                    dr["Ürün Barkod"] = item.urunBarkod;
                    dr["Ürün Ad"] = item.urunAd;
                    dr["Toplam satış"] = sorgu.Value;
                    dr["Toplam alış"] = Convert.ToDouble(deneme.ToString());
                    dr["Toplam Kar Zarar"] = sorgu.Value - Convert.ToDouble(deneme.ToString());

                    dt.Rows.Add(dr);
                }
                else
                {
                    dr["Ürün Barkod"] = item.urunBarkod;
                    dr["Ürün Ad"] = item.urunAd;
                    dr["Toplam satış"] = "0";
                    dr["Toplam alış"] = Convert.ToDouble(deneme.ToString());
                    dr["Toplam Kar Zarar"] = 0 - Convert.ToDouble(deneme.ToString());

                    dt.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt;

            }
            
        }
    }
}
