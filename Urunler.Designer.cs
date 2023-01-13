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
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.DGVUrunler.Location = new System.Drawing.Point(14, 14);
            this.DGVUrunler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVUrunler.Name = "DGVUrunler";
            this.DGVUrunler.RowHeadersWidth = 51;
            this.DGVUrunler.RowTemplate.Height = 24;
            this.DGVUrunler.Size = new System.Drawing.Size(612, 514);
            this.DGVUrunler.TabIndex = 1;
            this.DGVUrunler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUrunler_CellEnter);
            // 
            // TBUrunAra
            // 
            this.TBUrunAra.Location = new System.Drawing.Point(19, 51);
            this.TBUrunAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBUrunAra.Name = "TBUrunAra";
            this.TBUrunAra.Size = new System.Drawing.Size(168, 22);
            this.TBUrunAra.TabIndex = 2;
            this.TBUrunAra.TextChanged += new System.EventHandler(this.TBUrunAra_TextChanged);
            // 
            // BtnStokEkle
            // 
            this.BtnStokEkle.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnStokEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStokEkle.Location = new System.Drawing.Point(645, 458);
            this.BtnStokEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnStokEkle.Name = "BtnStokEkle";
            this.BtnStokEkle.Size = new System.Drawing.Size(229, 62);
            this.BtnStokEkle.TabIndex = 3;
            this.BtnStokEkle.Text = "Stok Ekle";
            this.BtnStokEkle.UseVisualStyleBackColor = false;
            this.BtnStokEkle.Click += new System.EventHandler(this.BtnStokEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Barkod No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stok:";
            // 
            // TBUrunAd
            // 
            this.TBUrunAd.Location = new System.Drawing.Point(118, 53);
            this.TBUrunAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBUrunAd.Name = "TBUrunAd";
            this.TBUrunAd.Size = new System.Drawing.Size(93, 22);
            this.TBUrunAd.TabIndex = 10;
            // 
            // TBUrunFiyat
            // 
            this.TBUrunFiyat.Location = new System.Drawing.Point(118, 85);
            this.TBUrunFiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBUrunFiyat.Name = "TBUrunFiyat";
            this.TBUrunFiyat.Size = new System.Drawing.Size(93, 22);
            this.TBUrunFiyat.TabIndex = 11;
            // 
            // TBUrunStok
            // 
            this.TBUrunStok.Location = new System.Drawing.Point(118, 149);
            this.TBUrunStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBUrunStok.Name = "TBUrunStok";
            this.TBUrunStok.Size = new System.Drawing.Size(93, 22);
            this.TBUrunStok.TabIndex = 12;
            // 
            // TBUrunBarkod
            // 
            this.TBUrunBarkod.Location = new System.Drawing.Point(118, 117);
            this.TBUrunBarkod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBUrunBarkod.Name = "TBUrunBarkod";
            this.TBUrunBarkod.Size = new System.Drawing.Size(93, 22);
            this.TBUrunBarkod.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TBUrunBarkod);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBUrunStok);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TBUrunFiyat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TBUrunAd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(645, 129);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 183);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TBUrunAra);
            this.panel2.Location = new System.Drawing.Point(645, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 89);
            this.panel2.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnStokEkle);
            this.Controls.Add(this.DGVUrunler);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Urunler";
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
    }
}