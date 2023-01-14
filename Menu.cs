using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class Menu : Form
    {
        MarketManagementSystemEntities1 db = new MarketManagementSystemEntities1();
        public Menu()
        {
            InitializeComponent();
        }
        private void FormGetir(Form frm)
        {
            PanelForm.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            PanelForm.Controls.Add(frm);
            frm.Show();
        }

        private void BtnUrunler_Click(object sender, EventArgs e)
        {
            Urunler urunlerfrm = new Urunler();
            FormGetir(urunlerfrm);
        }

        private void BtnRaporlama_Click(object sender, EventArgs e)
        {
            Raporlama raporlamafrm = new Raporlama();
            FormGetir(raporlamafrm);
        }

        private void BtnSatis_Click(object sender, EventArgs e)
        {
           
            string Ad = Interaction.InputBox("Kullanıcı Adınızı Girin:", "Kullanıcı Adı");
            string sifre = Interaction.InputBox("Şifre girin:", "Şifre");
            
            var query = db.Saticis.Where(x => x.kullaniciAdi == Ad && x.parola == sifre).FirstOrDefault();
            if (query != null)
            {
                Satis satisfrm = new Satis();
                FormGetir(satisfrm);
            }
            else
            {
                MessageBox.Show("Giriş Başarısız.");
            }

        }

        private void BtnMusteri_Click(object sender, EventArgs e)
        {
            Musteriler musterilerfrm = new Musteriler();
            FormGetir(musterilerfrm);
        }

        private void BtnTedarikci_Click(object sender, EventArgs e)
        {
            Tedarikciler tedarikcilerfrm = new Tedarikciler();
            FormGetir(tedarikcilerfrm);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void BtnBorcOdeme_Click(object sender, EventArgs e)
        {
            BorcOdeme borcOdemefrm = new BorcOdeme();
            FormGetir(borcOdemefrm);
        }
    }
}
