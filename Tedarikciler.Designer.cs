namespace MarketManagementSystem
{
    partial class Tedarikciler
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
            this.DGVTedarikciler = new System.Windows.Forms.DataGridView();
            this.TBTedarikciArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBTedarikciNo = new System.Windows.Forms.TextBox();
            this.TBTedarikciAd = new System.Windows.Forms.TextBox();
            this.BtnTedarikciGuncelle = new System.Windows.Forms.Button();
            this.BtnTedarikciSil = new System.Windows.Forms.Button();
            this.BtnTedarikciBorcOdeme = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TBTedarikciOdemeMiktar = new System.Windows.Forms.TextBox();
            this.BtnTedarikciOnayla = new System.Windows.Forms.Button();
            this.BtnYeniTedarikci = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TBTedarikciBorc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTedarikciler)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVTedarikciler
            // 
            this.DGVTedarikciler.AllowUserToAddRows = false;
            this.DGVTedarikciler.AllowUserToDeleteRows = false;
            this.DGVTedarikciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTedarikciler.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVTedarikciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTedarikciler.Location = new System.Drawing.Point(15, 16);
            this.DGVTedarikciler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVTedarikciler.Name = "DGVTedarikciler";
            this.DGVTedarikciler.ReadOnly = true;
            this.DGVTedarikciler.RowHeadersWidth = 51;
            this.DGVTedarikciler.RowTemplate.Height = 24;
            this.DGVTedarikciler.Size = new System.Drawing.Size(616, 660);
            this.DGVTedarikciler.TabIndex = 0;
            this.DGVTedarikciler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTedarikciler_CellEnter);
            // 
            // TBTedarikciArama
            // 
            this.TBTedarikciArama.Location = new System.Drawing.Point(18, 48);
            this.TBTedarikciArama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBTedarikciArama.Name = "TBTedarikciArama";
            this.TBTedarikciArama.Size = new System.Drawing.Size(269, 26);
            this.TBTedarikciArama.TabIndex = 1;
            this.TBTedarikciArama.TextChanged += new System.EventHandler(this.TBTedarikciArama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tedarikçi Arama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tedarikçi Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tedarikçi No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tedarikçi Ad:";
            // 
            // TBTedarikciNo
            // 
            this.TBTedarikciNo.Location = new System.Drawing.Point(174, 58);
            this.TBTedarikciNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBTedarikciNo.Name = "TBTedarikciNo";
            this.TBTedarikciNo.Size = new System.Drawing.Size(112, 26);
            this.TBTedarikciNo.TabIndex = 6;
            // 
            // TBTedarikciAd
            // 
            this.TBTedarikciAd.Location = new System.Drawing.Point(174, 105);
            this.TBTedarikciAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBTedarikciAd.Name = "TBTedarikciAd";
            this.TBTedarikciAd.Size = new System.Drawing.Size(112, 26);
            this.TBTedarikciAd.TabIndex = 7;
            // 
            // BtnTedarikciGuncelle
            // 
            this.BtnTedarikciGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.BtnTedarikciGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTedarikciGuncelle.Location = new System.Drawing.Point(18, 195);
            this.BtnTedarikciGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTedarikciGuncelle.Name = "BtnTedarikciGuncelle";
            this.BtnTedarikciGuncelle.Size = new System.Drawing.Size(125, 39);
            this.BtnTedarikciGuncelle.TabIndex = 8;
            this.BtnTedarikciGuncelle.Text = "Güncelle";
            this.BtnTedarikciGuncelle.UseVisualStyleBackColor = false;
            this.BtnTedarikciGuncelle.Click += new System.EventHandler(this.BtnTedarikciGuncelle_Click);
            // 
            // BtnTedarikciSil
            // 
            this.BtnTedarikciSil.BackColor = System.Drawing.Color.Red;
            this.BtnTedarikciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTedarikciSil.Location = new System.Drawing.Point(165, 195);
            this.BtnTedarikciSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTedarikciSil.Name = "BtnTedarikciSil";
            this.BtnTedarikciSil.Size = new System.Drawing.Size(121, 39);
            this.BtnTedarikciSil.TabIndex = 9;
            this.BtnTedarikciSil.Text = "Sil";
            this.BtnTedarikciSil.UseVisualStyleBackColor = false;
            this.BtnTedarikciSil.Click += new System.EventHandler(this.BtnTedarikciSil_Click);
            // 
            // BtnTedarikciBorcOdeme
            // 
            this.BtnTedarikciBorcOdeme.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnTedarikciBorcOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTedarikciBorcOdeme.Location = new System.Drawing.Point(20, 17);
            this.BtnTedarikciBorcOdeme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTedarikciBorcOdeme.Name = "BtnTedarikciBorcOdeme";
            this.BtnTedarikciBorcOdeme.Size = new System.Drawing.Size(267, 47);
            this.BtnTedarikciBorcOdeme.TabIndex = 10;
            this.BtnTedarikciBorcOdeme.Text = "Tedarikçi Borç Ödeme";
            this.BtnTedarikciBorcOdeme.UseVisualStyleBackColor = false;
            this.BtnTedarikciBorcOdeme.Click += new System.EventHandler(this.BtnTedarikciBorcOdeme_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ödeme Miktari Giriniz:";
            this.label5.Visible = false;
            // 
            // TBTedarikciOdemeMiktar
            // 
            this.TBTedarikciOdemeMiktar.Location = new System.Drawing.Point(23, 117);
            this.TBTedarikciOdemeMiktar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBTedarikciOdemeMiktar.Name = "TBTedarikciOdemeMiktar";
            this.TBTedarikciOdemeMiktar.Size = new System.Drawing.Size(264, 26);
            this.TBTedarikciOdemeMiktar.TabIndex = 12;
            this.TBTedarikciOdemeMiktar.Visible = false;
            // 
            // BtnTedarikciOnayla
            // 
            this.BtnTedarikciOnayla.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnTedarikciOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTedarikciOnayla.Location = new System.Drawing.Point(20, 161);
            this.BtnTedarikciOnayla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTedarikciOnayla.Name = "BtnTedarikciOnayla";
            this.BtnTedarikciOnayla.Size = new System.Drawing.Size(267, 45);
            this.BtnTedarikciOnayla.TabIndex = 13;
            this.BtnTedarikciOnayla.Text = "Onayla";
            this.BtnTedarikciOnayla.UseVisualStyleBackColor = false;
            this.BtnTedarikciOnayla.Visible = false;
            // 
            // BtnYeniTedarikci
            // 
            this.BtnYeniTedarikci.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnYeniTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniTedarikci.Location = new System.Drawing.Point(19, 242);
            this.BtnYeniTedarikci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnYeniTedarikci.Name = "BtnYeniTedarikci";
            this.BtnYeniTedarikci.Size = new System.Drawing.Size(267, 38);
            this.BtnYeniTedarikci.TabIndex = 14;
            this.BtnYeniTedarikci.Text = "Tedarikçi Ekle";
            this.BtnYeniTedarikci.UseVisualStyleBackColor = false;
            this.BtnYeniTedarikci.Click += new System.EventHandler(this.BtnYeniTedarikci_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(18, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tedarikçiye Borç:";
            // 
            // TBTedarikciBorc
            // 
            this.TBTedarikciBorc.Location = new System.Drawing.Point(174, 150);
            this.TBTedarikciBorc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBTedarikciBorc.Name = "TBTedarikciBorc";
            this.TBTedarikciBorc.Size = new System.Drawing.Size(112, 26);
            this.TBTedarikciBorc.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnTedarikciBorcOdeme);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TBTedarikciOdemeMiktar);
            this.panel1.Controls.Add(this.BtnTedarikciOnayla);
            this.panel1.Location = new System.Drawing.Point(637, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 227);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TBTedarikciArama);
            this.panel2.Location = new System.Drawing.Point(637, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 92);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TBTedarikciBorc);
            this.panel3.Controls.Add(this.TBTedarikciNo);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TBTedarikciAd);
            this.panel3.Controls.Add(this.BtnYeniTedarikci);
            this.panel3.Controls.Add(this.BtnTedarikciGuncelle);
            this.panel3.Controls.Add(this.BtnTedarikciSil);
            this.panel3.Location = new System.Drawing.Point(637, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 328);
            this.panel3.TabIndex = 19;
            // 
            // Tedarikciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 688);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGVTedarikciler);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Tedarikciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikciler";
            this.Load += new System.EventHandler(this.Tedarikciler_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTedarikciler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVTedarikciler;
        private System.Windows.Forms.TextBox TBTedarikciArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBTedarikciNo;
        private System.Windows.Forms.TextBox TBTedarikciAd;
        private System.Windows.Forms.Button BtnTedarikciGuncelle;
        private System.Windows.Forms.Button BtnTedarikciSil;
        private System.Windows.Forms.Button BtnTedarikciBorcOdeme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBTedarikciOdemeMiktar;
        private System.Windows.Forms.Button BtnTedarikciOnayla;
        private System.Windows.Forms.Button BtnYeniTedarikci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBTedarikciBorc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}