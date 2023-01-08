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
    public partial class Menu : Form
    {
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
            Satis satisfrm = new Satis();
            FormGetir(satisfrm);
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
    }
}
