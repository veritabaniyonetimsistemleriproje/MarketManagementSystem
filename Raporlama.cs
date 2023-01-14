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
    
    public partial class Raporlama : Form
    {
        
        public Raporlama()
        {
            InitializeComponent();
        }

        public void formAc(Form frm)
        {
            bool onsiteopen = false;
            foreach (Form S in Application.OpenForms)
            {
                if (S is TopluMusteriBorc || S is UrunKarZarar || S is MusteriBazliRapor || S is MarketKarZarar || S is TarihArasiTrend || S is UrunListCoktanAza)
                {
                    onsiteopen = true;
                }
            }
            if (onsiteopen == true)
            {
                MessageBox.Show("Bir form zaten şu an açık.");
                frm.Activate();
            }
            else
            {
                frm.Show();
            }
        }
       
        private void BtnKarZararUrun_Click(object sender, EventArgs e)
        {
            UrunKarZarar urunKarZarar = new UrunKarZarar();
            formAc(urunKarZarar);
            
        }

        private void BtnTopluMusBorc_Click(object sender, EventArgs e)
        {
            TopluMusteriBorc topluMusteriBorc = new TopluMusteriBorc();
            formAc(topluMusteriBorc);
        }

        private void BtnMusBazlıRapor_Click(object sender, EventArgs e)
        {
            MusteriBazliRapor musteriBazliRapor = new MusteriBazliRapor();
            formAc(musteriBazliRapor);
        }

        private void BtnKarZarar_Click(object sender, EventArgs e)
        {
            MarketKarZarar marketKarZarar = new MarketKarZarar();
            formAc(marketKarZarar);
        }

        private void BtnSatısTrendi_Click(object sender, EventArgs e)
        {
            TarihArasiTrend tarihArasiTrend = new TarihArasiTrend();
            formAc(tarihArasiTrend);
        }

        private void BtnCokSatandanAza_Click(object sender, EventArgs e)
        {
            UrunListCoktanAza urunListCoktanAza = new UrunListCoktanAza();
            formAc(urunListCoktanAza);
        }
    }
}
