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
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void BtnUrunler_Click(object sender, EventArgs e)
        {

        }

        private void BtnRaporlama_Click(object sender, EventArgs e)
        {

        }

        private void BtnSatis_Click(object sender, EventArgs e)
        {

        }

        private void BtnMusteri_Click(object sender, EventArgs e)
        {

        }

        private void BtnTedarikci_Click(object sender, EventArgs e)
        {

        }
    }
}
