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
    public partial class MarketKarZarar : Form
    {
        public MarketKarZarar()
        {
            InitializeComponent();
        }
        MarketManagementSystemEntities1 db = new MarketManagementSystemEntities1();
        private void MarketKarZarar_Load(object sender, EventArgs e)
        {
            try
            {
                var toplamsatıs = db.Sepets.ToList().Sum(x => x.toplamTutar);
                label6.Text = toplamsatıs + " ₺";
                label6.ForeColor = Color.Green;

                var tedarikcitoplam = db.Tedarikcis.ToList().Sum(t => t.tedarikciBorc);
                label7.Text = tedarikcitoplam + " ₺";
                label7.ForeColor = Color.Blue;

                var gorekar = toplamsatıs - tedarikcitoplam; 
                label8.Text =  gorekar + " ₺";

                if(gorekar > 0) label8.ForeColor = Color.Green;
                else label8.ForeColor = Color.Red;

                var musteriBorc = db.Musteris.ToList().Sum(m => m.borcMiktar);
                label9.Text =  musteriBorc + " ₺";
                label9.ForeColor = Color.Blue;

                var sonuc = toplamsatıs - musteriBorc - tedarikcitoplam;
                label10.Text =  sonuc + " ₺";

                if (sonuc > 0) label10.ForeColor = Color.Green;
                else label10.ForeColor = Color.Red;

            }
            catch
            {
                MessageBox.Show("Lütfen kontrol edin");
            }

        }
    }
}
