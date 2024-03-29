﻿using MarketManagementSystem.Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketManagementSystem
{
    public partial class BorcOdeme : Form
    {
        MarketManagementSystemEntities1 db = new MarketManagementSystemEntities1();
        public BorcOdeme()
        {
            InitializeComponent();
        }

        private void RBMusteriBorc_CheckedChanged(object sender, EventArgs e)
        {
            PanelMusteriBorc.Visible = true;
            PanelTedarikciBorc.Visible = false;
        }

        private void RBTedarikciBorc_CheckedChanged(object sender, EventArgs e)
        {
            PanelTedarikciBorc.Visible = true;
            PanelMusteriBorc.Visible = false;
        }

        private void BorcOdeme_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnMusteriAra_Click(object sender, EventArgs e)
        {
            try
            {
                int mNo = Convert.ToInt32(TBMusteriNo.Text);
                var sorgu = from sepeturun in db.SepetUruns
                            join veresiye in db.SatisVeresiyes
                            on sepeturun.sepetId equals veresiye.sepetId
                            join sepet in db.Sepets
                            on veresiye.sepetId equals sepet.sepetId
                            join urun in db.Uruns
                            on sepeturun.urunBarkod equals urun.urunBarkod
                            where veresiye.musteriNo == mNo
                            select new
                            {
                                SepetID = sepet.sepetId,
                                Barkod = urun.urunBarkod,
                                Ad = urun.urunAd,
                                Fiyat = sepeturun.urunAnlikFiyat,
                                Miktar = sepeturun.satisMiktar,
                                Tarih = sepet.tarih,
                            };
                DGVMusteri_Borc.DataSource = sorgu.ToList();

                var musteri = db.Musteris.Find(mNo);
                if(musteri == null)
                {
                    MessageBox.Show("Böyle bir müşteri bulunmamaktadır.");
                }
                else
                {
                    musteri_bilgi.Text = musteri.musteriAd + " " + musteri.musteriSoyad + " Toplam Borç: " + musteri.borcMiktar.ToString();
                    musteri_bilgi.Visible = true; musteri_bilgi.ForeColor = Color.Red;
                }
                
            }
            catch
            {
                MessageBox.Show("Böyle bir müşteri bulunmamaktadır.");
            }
            
        }

        private void BtnTedarikciAra_Click(object sender, EventArgs e)
        {
            try
            {
                int tNo = Convert.ToInt32(TBTedarikciNo.Text);
                var sorgu = from tedarikci in db.Tedarikcis
                            join irsaliye in db.Irsaliyes
                            on tedarikci.tedarikciNo equals irsaliye.tedarikciNo
                            join urun in db.Uruns
                            on irsaliye.urunKod equals urun.urunKod
                            where tedarikci.tedarikciNo == tNo
                            select new
                            {
                                İrsaliyeNo = irsaliye.irsaliyeNo,
                                Tedarikçi = tedarikci.tedarikciAd,
                                ÜrünAd = urun.urunAd,
                                Miktar = irsaliye.miktar,
                                Fiyat = irsaliye.birimGirdiFiyat,
                                Toplam = irsaliye.miktar * irsaliye.birimGirdiFiyat,
                                Tarih = irsaliye.tarih,
                            };

                DGVTedarikBorc.DataSource = sorgu.ToList();

                var tedarik = db.Tedarikcis.Find(tNo);
                if (tedarik == null)
                {
                    MessageBox.Show("Böyle bir tedarikçi bulunmamaktadır.");
                }
                else
                {
                    tedarikci_bilgi.Text = tedarik.tedarikciAd + " Toplam Borç: " + tedarik.tedarikciBorc.ToString();
                    tedarikci_bilgi.Visible = true; tedarikci_bilgi.ForeColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Böyle bir tedarikçi bulunmamaktadır.");
            }
            
            
        }

        private void BtnMusteriBorcOde_Click(object sender, EventArgs e)
        {
            try
            {
                var musteri = db.Musteris.Find(Convert.ToInt32(TBMusteriNo.Text));
                musteri.borcMiktar -= Convert.ToDouble(TBMusteriTutar.Text);

                MusteriBorcOdeme musteriBorcOdeme = new MusteriBorcOdeme();
                musteriBorcOdeme.musteriNo = Convert.ToInt32(TBMusteriNo.Text);
                musteriBorcOdeme.odenenMiktar = Convert.ToDouble(TBMusteriTutar.Text);
                musteriBorcOdeme.tarih = DateTime.Now;
                db.MusteriBorcOdemes.Add(musteriBorcOdeme);

                db.SaveChanges();

                musteri_bilgi.Text = musteri.musteriAd + " " + musteri.musteriSoyad + " Toplam Borç: " + musteri.borcMiktar.ToString();
                MessageBox.Show("Ödeme Başarıyla Tamamlandı.");
            }
            catch
            {
                MessageBox.Show("Lütfen müşteri numarası ve ödenen miktarı doğru giriniz.");
            }
            

        }

        private void BtnTedarikciBorcOde_Click(object sender, EventArgs e)
        {
            try
            {
                var tedarikci = db.Tedarikcis.Find(Convert.ToInt32(TBTedarikciNo.Text));
                tedarikci.tedarikciBorc -= Convert.ToDouble(TBTedarikciTutar.Text);

                TedarikciBorcOdeme tedarikciBorcOdeme = new TedarikciBorcOdeme();
                tedarikciBorcOdeme.saticiId = 1;
                tedarikciBorcOdeme.tedarikciNo = Convert.ToInt32(TBTedarikciNo.Text);
                tedarikciBorcOdeme.odenenMiktar = Convert.ToDouble(TBTedarikciTutar.Text);
                tedarikciBorcOdeme.tarih = DateTime.Now;
                db.TedarikciBorcOdemes.Add(tedarikciBorcOdeme);

                db.SaveChanges();

                tedarikci_bilgi.Text = tedarikci.tedarikciAd + " Toplam Borç: " + tedarikci.tedarikciBorc.ToString();
                MessageBox.Show("Ödeme Başarıyla Tamamlandı.");
            }
            catch
            {
                MessageBox.Show("Lütfen tedarikçi numarası ve ödenen miktarı doğru giriniz.");
            }
            
        }

        private void BtnUrunSatisSil_Click(object sender, EventArgs e)
        {
            string sifre = Interaction.InputBox("Şifre girin:", "Satış Silme");
            if(sifre == "özelşifre")
            {
                int musteriNo = Convert.ToInt32(TBMusteriNo.Text);
                foreach (DataGridViewRow item in this.DGVMusteri_Borc.SelectedRows)
                {
                    int sepetId = Convert.ToInt32(item.Cells[0].Value.ToString());
                    int barkodNo = Convert.ToInt32(item.Cells[1].Value.ToString());
                    double fiyat = Convert.ToDouble(item.Cells[3].Value.ToString());
                    int satismiktar = Convert.ToInt32(item.Cells[4].Value.ToString());
                    double toplamTutar = satismiktar * fiyat;

                    var sepetTutarGuncelle = db.Sepets.First(s => s.sepetId == sepetId);
                    sepetTutarGuncelle.toplamTutar -= toplamTutar;

                    if(sepetTutarGuncelle.toplamTutar == 0)
                    {
                        SatisVeresiye satisVeresiye = db.SatisVeresiyes.FirstOrDefault(s => s.sepetId == sepetId);
                        db.SatisVeresiyes.Remove(satisVeresiye);
                        db.Sepets.Remove(sepetTutarGuncelle);
                    }

                    var urunStokGuncelle = db.Uruns.First(s => s.urunBarkod == barkodNo);
                    urunStokGuncelle.urunStok += satismiktar;

                    var musteriBorcGuncelle = db.Musteris.First(s => s.musteriNo == musteriNo);
                    musteriBorcGuncelle.borcMiktar -= toplamTutar;

                    SepetUrun urunsatis = db.SepetUruns.FirstOrDefault(s => s.sepetId == sepetId & s.urunBarkod == barkodNo);
                    db.SepetUruns.Remove(urunsatis);

                    db.SaveChanges();

                    BtnMusteriAra_Click(sender, e);
                    MessageBox.Show("Ürün Satışı Başarıyla Silindi.");

                }
            }
            else
            {
                MessageBox.Show("Hatalı Şifre.");
            }
            
        }

        private void BtnMusteriBorcList_Click(object sender, EventArgs e)
        {
            try
            {
                int mNo = Convert.ToInt32(TBMusteriNo.Text);
                var sorgu = from musteris in db.Musteris
                            join borc in db.MusteriBorcOdemes
                            on musteris.musteriNo equals borc.musteriNo
                            where musteris.musteriNo == mNo
                            select new
                            {
                                AdSoyad = musteris.musteriAd + " " + musteris.musteriSoyad,
                                OdenenMiktar = borc.odenenMiktar,
                                Tarih = borc.tarih,
                            };
                DGVMusteri_Borc.DataSource = sorgu.ToList();

                var musteri = db.Musteris.Find(mNo);
                if (musteri == null)
                {
                    MessageBox.Show("Böyle bir müşteri bulunmamaktadır.");
                }
                else
                {
                    musteri_bilgi.Text = musteri.musteriAd + " " + musteri.musteriSoyad + " Toplam Borç: " + musteri.borcMiktar.ToString();
                    musteri_bilgi.Visible = true; musteri_bilgi.ForeColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Böyle bir müşteri bulunmamaktadır.");
            }

        }

        private void BtnTedarikciBorcList_Click(object sender, EventArgs e)
        {

            try
            {
                int tNo = Convert.ToInt32(TBTedarikciNo.Text);
                var sorgu = from tedarikcis in db.Tedarikcis
                            join borc in db.TedarikciBorcOdemes
                            on tedarikcis.tedarikciNo equals borc.tedarikciNo
                            where tedarikcis.tedarikciNo == tNo
                            select new
                            {
                                Ad = tedarikcis.tedarikciAd, 
                                OdenenMiktar = borc.odenenMiktar,
                                Tarih = borc.tarih,
                            };
                DGVTedarikBorc.DataSource = sorgu.ToList();

                var tedarikci = db.Tedarikcis.Find(tNo);
                if (tedarikci == null)
                {
                    MessageBox.Show("Böyle bir tedarikçi bulunmamaktadır.");
                }
                else
                {
                    tedarikci_bilgi.Text = tedarikci.tedarikciAd + " " + tedarikci.tedarikciNo + " Toplam Borç: " + tedarikci.tedarikciBorc.ToString();
                    tedarikci_bilgi.Visible = true; tedarikci_bilgi.ForeColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Böyle bir müşteri bulunmamaktadır.");
            }
        }
    }
}
