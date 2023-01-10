using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class Satis : Form
    {
        static DataTable dt  = new DataTable();
        MarketManagementSystemEntities1 db = new MarketManagementSystemEntities1();





        public Satis()
        {
            InitializeComponent();
        }

        public void tutarHesapla()
        {
            double sum = 0;
            for (int i = 0; i < DGVSepet.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(DGVSepet.Rows[i].Cells[2].Value);
            }
            TBToplamTutar.Text = sum.ToString();
        }


        private void Satis_Load(object sender, EventArgs e)
        {
            DGVMusteriler.DataSource = db.Musteris.ToList();
            panel1.Visible = false;
            DGVMusteriler.Columns[4].Visible = false; DGVMusteriler.Columns[5].Visible = false;
            DGVMusteriler.Columns[0].HeaderText = "Müşteri No";
            DGVMusteriler.Columns[1].HeaderText = "Ad";
            DGVMusteriler.Columns[2].HeaderText = "Soyad";
            DGVMusteriler.Columns[3].HeaderText = "Borç";
            
            dt.Columns.Clear();
            dt.Columns.Add("Barkod No");
            dt.Columns.Add("Urun Ad");
            dt.Columns.Add("Urun Fiyat");
            dt.Columns.Add("Urun Stok");

        }

        private void DGVMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TBMusteriID.Text = DGVMusteriler.CurrentRow.Cells[0].Value.ToString();
        }

        private void RBtnVeresiye_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void RBtnPesin_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }   

        public void sepettekiUrunlereEkle(int sptid)
        {
            SepetUrun sepettekiUrun = new SepetUrun();

            for(int i = 0; i < DGVSepet.Rows.Count - 1; i++)
            {
                int barkodNo = Convert.ToInt32(DGVSepet.Rows[i].Cells[0].Value);
                double anlikFiyat = Convert.ToDouble(DGVSepet.Rows[i].Cells[2].Value);
                var query = (from s in db.SepetUruns
                             where s.urunBarkod == barkodNo & s.sepetId == sptid
                             select s);
                var deneme = query.FirstOrDefault();
                if(deneme != null)
                {
                    deneme.satisMiktar += 1;
                    db.SaveChanges();
                }
                else if(deneme == null)
                {
                    sepettekiUrun.sepetId = sptid;
                    sepettekiUrun.urunBarkod = barkodNo;
                    sepettekiUrun.urunAnlikFiyat = anlikFiyat;
                    sepettekiUrun.satisMiktar = 1;
                    db.SepetUruns.Add(sepettekiUrun);
                    db.SaveChanges();
                }             
            }
        }
        private void BtnOnay_Click(object sender, EventArgs e)
        {
            int bNo = Convert.ToInt32(TBBarkodNo.Text);
            try
            {
                var query = (from s in db.Uruns
                            where s.urunBarkod == bNo
                            select s).First();
                DataRow dr = dt.NewRow();
                dr["Barkod No"] = query.urunBarkod;
                dr["Urun Ad"] = query.urunAd;
                dr["Urun Fiyat"] = query.urunFiyat;
                dr["Urun Stok"] = query.urunStok;

                dt.Rows.Add(dr);
                DGVSepet.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Böyle bir ürün bulunmamaktadır.");
            };
            tutarHesapla();

        }

        private void DGVSepet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TBUrunSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.DGVSepet.SelectedRows)
            {
                DGVSepet.Rows.RemoveAt(item.Index);
            }
            tutarHesapla();
        }

        private void BtnSatisOnayla_Click(object sender, EventArgs e)
        {
            

            Sepet spt = new Sepet();
            spt.toplamTutar = Convert.ToDouble(TBToplamTutar.Text);
            spt.tarih = DateTime.Now;            
            db.Sepets.Add(spt);
            db.SaveChanges();
            

            if(RBtnVeresiye.Checked)
            {
                spt.satisId = 1;

                int mNo = Convert.ToInt32(TBMusteriID.Text);
                var x = db.Musteris.Find(mNo);
                x.borcMiktar += Convert.ToDouble(TBToplamTutar.Text);
                db.SaveChanges();
                DGVMusteriler.Refresh();



                int sptid = spt.sepetId;
                SatisVeresiye vrsySatis = new SatisVeresiye();
                vrsySatis.musteriNo = Convert.ToInt32(TBMusteriID.Text);
                vrsySatis.sepetId = sptid;
                vrsySatis.satisId = 1;
                db.SatisVeresiyes.Add(vrsySatis);
                db.SaveChanges();
                sepettekiUrunlereEkle(sptid);
                MessageBox.Show("Veresiye satış başarıyla gerçekleşti.");

            }
            else if (RBtnPesin.Checked)
            {
                spt.satisId = 2;

                int sptid = spt.sepetId;
                SatisPesin psnSatis = new SatisPesin();
                psnSatis.sepetId = sptid;
                psnSatis.satisId = 2;
                db.SatisPesins.Add(psnSatis);
                db.SaveChanges();
                sepettekiUrunlereEkle(sptid);
                MessageBox.Show("Peşin satış başarıyla gerçekleşti.");
            }
            else
            {
                MessageBox.Show("Lütfen Ödeme Yöntemi Giriniz.");
            }
            

            

        }
    }
}
