namespace MarketManagementSystem
{
    partial class Urunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVUrunler = new System.Windows.Forms.DataGridView();
            this.TBUrunAra = new System.Windows.Forms.TextBox();
            this.BtnStokEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBUrunAd = new System.Windows.Forms.TextBox();
            this.TBUrunFiyat = new System.Windows.Forms.TextBox();
            this.TBUrunStok = new System.Windows.Forms.TextBox();
            this.TBUrunBarkod = new System.Windows.Forms.TextBox();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.BtnUrunSil = new System.Windows.Forms.Button();
            this.BtnUrunGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVUrunler
            // 
            this.DGVUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUrunler.Location = new System.Drawing.Point(11, 12);
            this.DGVUrunler.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGVUrunler.Name = "DGVUrunler";
            this.DGVUrunler.RowHeadersWidth = 51;
            this.DGVUrunler.RowTemplate.Height = 24;
            this.DGVUrunler.Size = new System.Drawing.Size(459, 418);
            this.DGVUrunler.TabIndex = 1;
            // 
            // TBUrunAra
            // 
            this.TBUrunAra.Location = new System.Drawing.Point(520, 28);
            this.TBUrunAra.Name = "TBUrunAra";
            this.TBUrunAra.Size = new System.Drawing.Size(127, 20);
            this.TBUrunAra.TabIndex = 2;
            this.TBUrunAra.TextChanged += new System.EventHandler(this.TBUrunAra_TextChanged);
            // 
            // BtnStokEkle
            // 
            this.BtnStokEkle.Location = new System.Drawing.Point(520, 372);
            this.BtnStokEkle.Name = "BtnStokEkle";
            this.BtnStokEkle.Size = new System.Drawing.Size(146, 50);
            this.BtnStokEkle.TabIndex = 3;
            this.BtnStokEkle.Text = "Stok Ekle";
            this.BtnStokEkle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Barkod No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stok:";
            // 
            // TBUrunAd
            // 
            this.TBUrunAd.Location = new System.Drawing.Point(595, 135);
            this.TBUrunAd.Name = "TBUrunAd";
            this.TBUrunAd.Size = new System.Drawing.Size(71, 20);
            this.TBUrunAd.TabIndex = 10;
            // 
            // TBUrunFiyat
            // 
            this.TBUrunFiyat.Location = new System.Drawing.Point(595, 161);
            this.TBUrunFiyat.Name = "TBUrunFiyat";
            this.TBUrunFiyat.Size = new System.Drawing.Size(71, 20);
            this.TBUrunFiyat.TabIndex = 11;
            // 
            // TBUrunStok
            // 
            this.TBUrunStok.Location = new System.Drawing.Point(595, 213);
            this.TBUrunStok.Name = "TBUrunStok";
            this.TBUrunStok.Size = new System.Drawing.Size(71, 20);
            this.TBUrunStok.TabIndex = 12;
            // 
            // TBUrunBarkod
            // 
            this.TBUrunBarkod.Location = new System.Drawing.Point(595, 187);
            this.TBUrunBarkod.Name = "TBUrunBarkod";
            this.TBUrunBarkod.Size = new System.Drawing.Size(71, 20);
            this.TBUrunBarkod.TabIndex = 13;
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.Location = new System.Drawing.Point(501, 251);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(63, 23);
            this.BtnUrunEkle.TabIndex = 14;
            this.BtnUrunEkle.Text = "Ekle";
            this.BtnUrunEkle.UseVisualStyleBackColor = true;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // BtnUrunSil
            // 
            this.BtnUrunSil.Location = new System.Drawing.Point(639, 251);
            this.BtnUrunSil.Name = "BtnUrunSil";
            this.BtnUrunSil.Size = new System.Drawing.Size(63, 23);
            this.BtnUrunSil.TabIndex = 15;
            this.BtnUrunSil.Text = "Sil";
            this.BtnUrunSil.UseVisualStyleBackColor = true;
            // 
            // BtnUrunGuncelle
            // 
            this.BtnUrunGuncelle.Location = new System.Drawing.Point(570, 251);
            this.BtnUrunGuncelle.Name = "BtnUrunGuncelle";
            this.BtnUrunGuncelle.Size = new System.Drawing.Size(63, 23);
            this.BtnUrunGuncelle.TabIndex = 16;
            this.BtnUrunGuncelle.Text = "Güncelle";
            this.BtnUrunGuncelle.UseVisualStyleBackColor = true;
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 442);
            this.Controls.Add(this.BtnUrunGuncelle);
            this.Controls.Add(this.BtnUrunSil);
            this.Controls.Add(this.BtnUrunEkle);
            this.Controls.Add(this.TBUrunBarkod);
            this.Controls.Add(this.TBUrunStok);
            this.Controls.Add(this.TBUrunFiyat);
            this.Controls.Add(this.TBUrunAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStokEkle);
            this.Controls.Add(this.TBUrunAra);
            this.Controls.Add(this.DGVUrunler);
            this.Name = "Urunler";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVUrunler;
        private System.Windows.Forms.TextBox TBUrunAra;
        private System.Windows.Forms.Button BtnStokEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBUrunAd;
        private System.Windows.Forms.TextBox TBUrunFiyat;
        private System.Windows.Forms.TextBox TBUrunStok;
        private System.Windows.Forms.TextBox TBUrunBarkod;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.Button BtnUrunSil;
        private System.Windows.Forms.Button BtnUrunGuncelle;
    }
}