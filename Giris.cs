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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        MarketManagementSystemEntities db = new MarketManagementSystemEntities();

        private void girisBtn_Click(object sender, EventArgs e)
        {

            if (db.Saticis.Where(r => r.kullaniciAdi == kullaniciAdTB.Text
                && r.parola == parolaTB.Text).Count() > 0)
            {
                MessageBox.Show("Giriş Başarılı.");
                Menu anamenu = new Menu();
                this.Hide();
                anamenu.Show();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız.");
            }




        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
