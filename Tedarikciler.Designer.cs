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
            this.DGVTedarikciler.Location = new System.Drawing.Point(13, 13);
            this.DGVTedarikciler.Name = "DGVTedarikciler";
            this.DGVTedarikciler.ReadOnly = true;
            this.DGVTedarikciler.RowHeadersWidth = 51;
            this.DGVTedarikciler.RowTemplate.Height = 24;
            this.DGVTedarikciler.Size = new System.Drawing.Size(548, 528);
            this.DGVTedarikciler.TabIndex = 0;
            this.DGVTedarikciler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTedarikciler_CellEnter);
            // 
            // TBTedarikciArama
            // 
            this.TBTedarikciArama.Location = new System.Drawing.Point(16, 38);
            this.TBTedarikciArama.Name = "TBTedarikciArama";
            this.TBTedarikciArama.Size = new System.Drawing.Size(240, 22);
            this.TBTedarikciArama.TabIndex = 1;
            this.TBTedarikciArama.TextChanged += new System.EventHandler(this.TBTedarikciArama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tedarikçi Arama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tedarikçi Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tedarikçi No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tedarikçi Ad:";
            // 
            // TBTedarikciNo
            // 
            this.TBTedarikciNo.Location = new System.Drawing.Point(155, 46);
            this.TBTedarikciNo.Name = "TBTedarikciNo";
            this.TBTedarikciNo.Size = new System.Drawing.Size(100, 22);
            this.TBTedarikciNo.TabIndex = 6;
            // 
            // TBTedarikciAd
            // 
            this.TBTedarikciAd.Location = new System.Drawing.Point(155, 84);
            this.TBTedarikciAd.Name = "TBTedarikciAd";
            this.TBTedarikciAd.Size = new System.Drawing.Size(100, 22);
            this.TBTedarikciAd.TabIndex = 7;
            // 
            // BtnTedarikciGuncelle
            // 
            this.BtnTedarikciGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.BtnTedarikciGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTedarikciGuncelle.Location = new System.Drawing.Point(16, 156);
            this.BtnTedarikciGuncelle.Name = "BtnTedarikciGuncelle";
            this.BtnTedarikciGuncelle.Size = new System.Drawing.Size(111, 31);
            this.BtnTedarikciGuncelle.TabIndex = 8;
            this.BtnTedarikciGuncelle.Text = "Güncelle";
            this.BtnTedarikciGuncelle.UseVisualStyleBackColor = false;
            this.BtnTedarikciGuncelle.Click += new System.EventHandler(this.BtnTedarikciGuncelle_Click);
            // 
            // BtnTedarikciSil
            // 
            this.BtnTedarikciSil.BackColor = System.Drawing.Color.Red;
            this.BtnTedarikciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTedarikciSil.Location = new System.Drawing.Point(147, 156);
            this.BtnTedarikciSil.Name = "BtnTedarikciSil";
            this.BtnTedarikciSil.Size = new System.Drawing.Size(108, 31);
            this.BtnTedarikciSil.TabIndex = 9;
            this.BtnTedarikciSil.Text = "Sil";
            this.BtnTedarikciSil.UseVisualStyleBackColor = false;
            this.BtnTedarikciSil.Click += new System.EventHandler(this.BtnTedarikciSil_Click);
            // 
            // BtnTedarikciBorcOdeme
            // 
            this.BtnTedarikciBorcOdeme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnTedarikciBorcOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTedarikciBorcOdeme.Location = new System.Drawing.Point(18, 14);
            this.BtnTedarikciBorcOdeme.Name = "BtnTedarikciBorcOdeme";
            this.BtnTedarikciBorcOdeme.Size = new System.Drawing.Size(237, 38);
            this.BtnTedarikciBorcOdeme.TabIndex = 10;
            this.BtnTedarikciBorcOdeme.Text = "Tedarikçi Borç Ödeme";
            this.BtnTedarikciBorcOdeme.UseVisualStyleBackColor = false;
            this.BtnTedarikciBorcOdeme.Click += new System.EventHandler(this.BtnTedarikciBorcOdeme_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ödeme Miktari Giriniz:";
            this.label5.Visible = false;
            // 
            // TBTedarikciOdemeMiktar
            // 
            this.TBTedarikciOdemeMiktar.Location = new System.Drawing.Point(20, 94);
            this.TBTedarikciOdemeMiktar.Name = "TBTedarikciOdemeMiktar";
            this.TBTedarikciOdemeMiktar.Size = new System.Drawing.Size(235, 22);
            this.TBTedarikciOdemeMiktar.TabIndex = 12;
            this.TBTedarikciOdemeMiktar.Visible = false;
            // 
            // BtnTedarikciOnayla
            // 
            this.BtnTedarikciOnayla.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnTedarikciOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTedarikciOnayla.Location = new System.Drawing.Point(18, 129);
            this.BtnTedarikciOnayla.Name = "BtnTedarikciOnayla";
            this.BtnTedarikciOnayla.Size = new System.Drawing.Size(237, 36);
            this.BtnTedarikciOnayla.TabIndex = 13;
            this.BtnTedarikciOnayla.Text = "Onayla";
            this.BtnTedarikciOnayla.UseVisualStyleBackColor = false;
            this.BtnTedarikciOnayla.Visible = false;
            // 
            // BtnYeniTedarikci
            // 
            this.BtnYeniTedarikci.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnYeniTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniTedarikci.Location = new System.Drawing.Point(17, 194);
            this.BtnYeniTedarikci.Name = "BtnYeniTedarikci";
            this.BtnYeniTedarikci.Size = new System.Drawing.Size(237, 30);
            this.BtnYeniTedarikci.TabIndex = 14;
            this.BtnYeniTedarikci.Text = "Tedarikçi Ekle";
            this.BtnYeniTedarikci.UseVisualStyleBackColor = false;
            this.BtnYeniTedarikci.Click += new System.EventHandler(this.BtnYeniTedarikci_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tedarikçiye Borç:";
            // 
            // TBTedarikciBorc
            // 
            this.TBTedarikciBorc.Location = new System.Drawing.Point(155, 120);
            this.TBTedarikciBorc.Name = "TBTedarikciBorc";
            this.TBTedarikciBorc.Size = new System.Drawing.Size(100, 22);
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
            this.panel1.Location = new System.Drawing.Point(566, 359);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 182);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TBTedarikciArama);
            this.panel2.Location = new System.Drawing.Point(566, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 74);
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
            this.panel3.Location = new System.Drawing.Point(566, 91);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 263);
            this.panel3.TabIndex = 19;
            // 
            // Tedarikciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGVTedarikciler);
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