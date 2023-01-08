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
            this.DGVUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUrunler.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUrunler.Location = new System.Drawing.Point(16, 18);
            this.DGVUrunler.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DGVUrunler.Name = "DGVUrunler";
            this.DGVUrunler.RowHeadersWidth = 51;
            this.DGVUrunler.RowTemplate.Height = 24;
            this.DGVUrunler.Size = new System.Drawing.Size(688, 643);
            this.DGVUrunler.TabIndex = 1;
            // 
            // TBUrunAra
            // 
            this.TBUrunAra.Location = new System.Drawing.Point(780, 43);
            this.TBUrunAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBUrunAra.Name = "TBUrunAra";
            this.TBUrunAra.Size = new System.Drawing.Size(188, 26);
            this.TBUrunAra.TabIndex = 2;
            this.TBUrunAra.TextChanged += new System.EventHandler(this.TBUrunAra_TextChanged);
            // 
            // BtnStokEkle
            // 
            this.BtnStokEkle.Location = new System.Drawing.Point(780, 572);
            this.BtnStokEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnStokEkle.Name = "BtnStokEkle";
            this.BtnStokEkle.Size = new System.Drawing.Size(219, 77);
            this.BtnStokEkle.TabIndex = 3;
            this.BtnStokEkle.Text = "Stok Ekle";
            this.BtnStokEkle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(776, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(776, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(776, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Barkod No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(776, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(776, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stok:";
            // 
            // TBUrunAd
            // 
            this.TBUrunAd.Location = new System.Drawing.Point(892, 208);
            this.TBUrunAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBUrunAd.Name = "TBUrunAd";
            this.TBUrunAd.Size = new System.Drawing.Size(104, 26);
            this.TBUrunAd.TabIndex = 10;
            // 
            // TBUrunFiyat
            // 
            this.TBUrunFiyat.Location = new System.Drawing.Point(892, 248);
            this.TBUrunFiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBUrunFiyat.Name = "TBUrunFiyat";
            this.TBUrunFiyat.Size = new System.Drawing.Size(104, 26);
            this.TBUrunFiyat.TabIndex = 11;
            // 
            // TBUrunStok
            // 
            this.TBUrunStok.Location = new System.Drawing.Point(892, 328);
            this.TBUrunStok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBUrunStok.Name = "TBUrunStok";
            this.TBUrunStok.Size = new System.Drawing.Size(104, 26);
            this.TBUrunStok.TabIndex = 12;
            // 
            // TBUrunBarkod
            // 
            this.TBUrunBarkod.Location = new System.Drawing.Point(892, 288);
            this.TBUrunBarkod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBUrunBarkod.Name = "TBUrunBarkod";
            this.TBUrunBarkod.Size = new System.Drawing.Size(104, 26);
            this.TBUrunBarkod.TabIndex = 13;
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.Location = new System.Drawing.Point(752, 386);
            this.BtnUrunEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(94, 35);
            this.BtnUrunEkle.TabIndex = 14;
            this.BtnUrunEkle.Text = "Ekle";
            this.BtnUrunEkle.UseVisualStyleBackColor = true;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // BtnUrunSil
            // 
            this.BtnUrunSil.Location = new System.Drawing.Point(958, 386);
            this.BtnUrunSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUrunSil.Name = "BtnUrunSil";
            this.BtnUrunSil.Size = new System.Drawing.Size(94, 35);
            this.BtnUrunSil.TabIndex = 15;
            this.BtnUrunSil.Text = "Sil";
            this.BtnUrunSil.UseVisualStyleBackColor = true;
            // 
            // BtnUrunGuncelle
            // 
            this.BtnUrunGuncelle.Location = new System.Drawing.Point(855, 386);
            this.BtnUrunGuncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUrunGuncelle.Name = "BtnUrunGuncelle";
            this.BtnUrunGuncelle.Size = new System.Drawing.Size(94, 35);
            this.BtnUrunGuncelle.TabIndex = 16;
            this.BtnUrunGuncelle.Text = "Güncelle";
            this.BtnUrunGuncelle.UseVisualStyleBackColor = true;
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 680);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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