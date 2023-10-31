using MarketManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MarketManagementSystem
{
    public partial class TopluMusteriBorc : Form
    {
        static DataTable dt = new DataTable();
        MarketManagementSystemEntities1 db = new MarketManagementSystemEntities1();
        public TopluMusteriBorc()
        {
            InitializeComponent();
        }

        private void TopluMusteriBorc_Load(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.Columns.Add("Ad Soyad");
            dt.Columns.Add("Toplam Satış");
            dt.Columns.Add("Toplam Ödenen");
            dt.Columns.Add("Toplam Borç");

            int toplamSatis = 0;
            int mNo = 0;

            List<SatisVeresiye> sorgu = db.SatisVeresiyes.OrderBy(p => p.musteriNo).ToList();
            dataGridView1.DataSource = sorgu;

            List<MusteriBorcOdeme> musterisorgu = db.MusteriBorcOdemes.OrderBy(p => p.musteriNo).ToList();

            foreach (var veresiye in sorgu)
            {
                
                if (veresiye.musteriNo == mNo)
                {
                    toplamSatis += 1;
                    var query = db.Musteris.Find(mNo);
                    string isim = query.musteriAd + " " + query.musteriSoyad;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(isim))
                        {
                            row.Cells[1].Value = toplamSatis;
                            break;
                        }
                    }
                }
                else
                {
                    toplamSatis = 0;
                    mNo = veresiye.musteriNo;
                    toplamSatis += 1;


                    DataRow dr = dt.NewRow();
                    var query = db.Musteris.Find(mNo);
                    dr["Ad Soyad"] = query.musteriAd + " " + query.musteriSoyad;
                    dr["Toplam Satış"] = toplamSatis;
                    dr["Toplam Ödenen"] = musterisorgu.Where(x => x.musteriNo == mNo).Sum(x => x.odenenMiktar);
                    dr["Toplam Borç"] = query.borcMiktar;

                    dt.Rows.Add(dr);
                    dataGridView1.DataSource = dt;
                }
            }
    
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excellApp = new Excel.Application();
            excellApp.Workbooks.Add();
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                excellApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    excellApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            excellApp.Visible = true;
        }
    }
}
