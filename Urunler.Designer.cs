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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnUrunGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUrunler)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVUrunler
            // 
            this.DGVUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUrunler.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUrunler.Location = new System.Drawing.Point(10, 11);
            this.DGVUrunler.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGVUrunler.Name = "DGVUrunler";
            this.DGVUrunler.RowHeadersWidth = 51;
            this.DGVUrunler.RowTemplate.Height = 24;
            this.DGVUrunler.Size = new System.Drawing.Size(459, 418);
            this.DGVUrunler.TabIndex = 1;
            this.DGVUrunler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUrunler_CellEnter);
            // 
            // TBUrunAra
            // 
            this.TBUrunAra.Location = new System.Drawing.Point(14, 41);
            this.TBUrunAra.Name = "TBUrunAra";
            this.TBUrunAra.Size = new System.Drawing.Size(127, 20);
            this.TBUrunAra.TabIndex = 2;
            this.TBUrunAra.TextChanged += new System.EventHandler(this.TBUrunAra_TextChanged);
            // 
            // BtnStokEkle
            // 
            this.BtnStokEkle.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnStokEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStokEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStokEkle.Location = new System.Drawing.Point(484, 372);
            this.BtnStokEkle.Name = "BtnStokEkle";
            this.BtnStokEkle.Size = new System.Drawing.Size(172, 50);
            this.BtnStokEkle.TabIndex = 3;
            this.BtnStokEkle.Text = "Stok Ekle";
            this.BtnStokEkle.UseVisualStyleBackColor = false;
            this.BtnStokEkle.Click += new System.EventHandler(this.BtnStokEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Barkod No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stok:";
            // 
            // TBUrunAd
            // 
            this.TBUrunAd.Location = new System.Drawing.Point(88, 69);
            this.TBUrunAd.Name = "TBUrunAd";
            this.TBUrunAd.Size = new System.Drawing.Size(71, 20);
            this.TBUrunAd.TabIndex = 10;
            // 
            // TBUrunFiyat
            // 
            this.TBUrunFiyat.Location = new System.Drawing.Point(88, 121);
            this.TBUrunFiyat.Name = "TBUrunFiyat";
            this.TBUrunFiyat.Size = new System.Drawing.Size(71, 20);
            this.TBUrunFiyat.TabIndex = 11;
            // 
            // TBUrunStok
            // 
            this.TBUrunStok.Location = new System.Drawing.Point(88, 95);
            this.TBUrunStok.Name = "TBUrunStok";
            this.TBUrunStok.ReadOnly = true;
            this.TBUrunStok.Size = new System.Drawing.Size(71, 20);
            this.TBUrunStok.TabIndex = 12;
            // 
            // TBUrunBarkod
            // 
            this.TBUrunBarkod.Location = new System.Drawing.Point(88, 41);
            this.TBUrunBarkod.Name = "TBUrunBarkod";
            this.TBUrunBarkod.ReadOnly = true;
            this.TBUrunBarkod.Size = new System.Drawing.Size(71, 20);
            this.TBUrunBarkod.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TBUrunBarkod);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBUrunFiyat);
            this.panel1.Controls.Add(this.TBUrunStok);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TBUrunAd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(484, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 149);
            this.panel1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fiyat:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TBUrunAra);
            this.panel2.Location = new System.Drawing.Point(484, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 73);
            this.panel2.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnUrunGuncelle
            // 
            this.BtnUrunGuncelle.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnUrunGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUrunGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunGuncelle.Location = new System.Drawing.Point(484, 259);
            this.BtnUrunGuncelle.Name = "BtnUrunGuncelle";
            this.BtnUrunGuncelle.Size = new System.Drawing.Size(173, 49);
            this.BtnUrunGuncelle.TabIndex = 16;
            this.BtnUrunGuncelle.Text = "Ürün Bilgilerini Güncelle";
            this.BtnUrunGuncelle.UseVisualStyleBackColor = false;
            this.BtnUrunGuncelle.Click += new System.EventHandler(this.BtnUrunGuncelle_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 442);
            this.Controls.Add(this.BtnUrunGuncelle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnStokEkle);
            this.Controls.Add(this.DGVUrunler);
            this.Name = "Urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUrunler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnUrunGuncelle;
    }
}