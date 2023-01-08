namespace MarketManagementSystem
{
    partial class Musteriler
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
            this.DGVMusteriler = new System.Windows.Forms.DataGridView();
            this.BtnYeniMusteri = new System.Windows.Forms.Button();
            this.TBMusteriArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBMusteriAd = new System.Windows.Forms.TextBox();
            this.TBMusteriSoyad = new System.Windows.Forms.TextBox();
            this.TBMusteriBorc = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnMusteriBorcOdeme = new System.Windows.Forms.Button();
            this.TBOdemeMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnOnayla = new System.Windows.Forms.Button();
            this.TBMusteriId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusteriler)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVMusteriler
            // 
            this.DGVMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMusteriler.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMusteriler.Location = new System.Drawing.Point(14, 15);
            this.DGVMusteriler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVMusteriler.Name = "DGVMusteriler";
            this.DGVMusteriler.RowHeadersWidth = 51;
            this.DGVMusteriler.RowTemplate.Height = 24;
            this.DGVMusteriler.Size = new System.Drawing.Size(592, 635);
            this.DGVMusteriler.TabIndex = 0;
            this.DGVMusteriler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMusteriler_CellEnter);
            // 
            // BtnYeniMusteri
            // 
            this.BtnYeniMusteri.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnYeniMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniMusteri.Location = new System.Drawing.Point(12, 284);
            this.BtnYeniMusteri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnYeniMusteri.Name = "BtnYeniMusteri";
            this.BtnYeniMusteri.Size = new System.Drawing.Size(207, 40);
            this.BtnYeniMusteri.TabIndex = 1;
            this.BtnYeniMusteri.Text = "Müşteri Ekle";
            this.BtnYeniMusteri.UseVisualStyleBackColor = false;
            this.BtnYeniMusteri.Click += new System.EventHandler(this.BtnYeniMusteri_Click);
            // 
            // TBMusteriArama
            // 
            this.TBMusteriArama.Location = new System.Drawing.Point(20, 52);
            this.TBMusteriArama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBMusteriArama.Name = "TBMusteriArama";
            this.TBMusteriArama.Size = new System.Drawing.Size(198, 26);
            this.TBMusteriArama.TabIndex = 2;
            this.TBMusteriArama.TextChanged += new System.EventHandler(this.TBMusteriArama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Müşteri Arama ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteri Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Borç Bilgisi: ";
            // 
            // TBMusteriAd
            // 
            this.TBMusteriAd.Location = new System.Drawing.Point(117, 93);
            this.TBMusteriAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBMusteriAd.Name = "TBMusteriAd";
            this.TBMusteriAd.Size = new System.Drawing.Size(102, 26);
            this.TBMusteriAd.TabIndex = 9;
            // 
            // TBMusteriSoyad
            // 
            this.TBMusteriSoyad.Location = new System.Drawing.Point(117, 142);
            this.TBMusteriSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBMusteriSoyad.Name = "TBMusteriSoyad";
            this.TBMusteriSoyad.Size = new System.Drawing.Size(102, 26);
            this.TBMusteriSoyad.TabIndex = 10;
            // 
            // TBMusteriBorc
            // 
            this.TBMusteriBorc.Location = new System.Drawing.Point(117, 189);
            this.TBMusteriBorc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBMusteriBorc.Name = "TBMusteriBorc";
            this.TBMusteriBorc.Size = new System.Drawing.Size(102, 26);
            this.TBMusteriBorc.TabIndex = 11;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(12, 238);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(98, 39);
            this.BtnGuncelle.TabIndex = 12;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Red;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(117, 238);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(102, 38);
            this.BtnSil.TabIndex = 13;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnMusteriBorcOdeme
            // 
            this.BtnMusteriBorcOdeme.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnMusteriBorcOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriBorcOdeme.Location = new System.Drawing.Point(14, 4);
            this.BtnMusteriBorcOdeme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnMusteriBorcOdeme.Name = "BtnMusteriBorcOdeme";
            this.BtnMusteriBorcOdeme.Size = new System.Drawing.Size(205, 36);
            this.BtnMusteriBorcOdeme.TabIndex = 14;
            this.BtnMusteriBorcOdeme.Text = "Müşteri Borç Ödeme ";
            this.BtnMusteriBorcOdeme.UseVisualStyleBackColor = false;
            this.BtnMusteriBorcOdeme.Click += new System.EventHandler(this.BtnMusteriBorcOdeme_Click);
            // 
            // TBOdemeMiktar
            // 
            this.TBOdemeMiktar.Location = new System.Drawing.Point(17, 89);
            this.TBOdemeMiktar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBOdemeMiktar.Name = "TBOdemeMiktar";
            this.TBOdemeMiktar.Size = new System.Drawing.Size(202, 26);
            this.TBOdemeMiktar.TabIndex = 15;
            this.TBOdemeMiktar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ödeme miktarı giriniz:";
            this.label3.Visible = false;
            // 
            // BtnOnayla
            // 
            this.BtnOnayla.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOnayla.Location = new System.Drawing.Point(14, 133);
            this.BtnOnayla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOnayla.Name = "BtnOnayla";
            this.BtnOnayla.Size = new System.Drawing.Size(205, 36);
            this.BtnOnayla.TabIndex = 17;
            this.BtnOnayla.Text = "Onayla";
            this.BtnOnayla.UseVisualStyleBackColor = false;
            this.BtnOnayla.Visible = false;
            // 
            // TBMusteriId
            // 
            this.TBMusteriId.Location = new System.Drawing.Point(117, 48);
            this.TBMusteriId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBMusteriId.Name = "TBMusteriId";
            this.TBMusteriId.Size = new System.Drawing.Size(102, 26);
            this.TBMusteriId.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(13, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TBMusteriId);
            this.panel1.Controls.Add(this.BtnYeniMusteri);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TBMusteriAd);
            this.panel1.Controls.Add(this.TBMusteriSoyad);
            this.panel1.Controls.Add(this.BtnSil);
            this.panel1.Controls.Add(this.TBMusteriBorc);
            this.panel1.Controls.Add(this.BtnGuncelle);
            this.panel1.Location = new System.Drawing.Point(612, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 336);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TBMusteriArama);
            this.panel2.Location = new System.Drawing.Point(612, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 100);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BtnMusteriBorcOdeme);
            this.panel3.Controls.Add(this.TBOdemeMiktar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.BtnOnayla);
            this.panel3.Location = new System.Drawing.Point(612, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 188);
            this.panel3.TabIndex = 22;
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 665);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGVMusteriler);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Musteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusteriler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMusteriler;
        private System.Windows.Forms.Button BtnYeniMusteri;
        private System.Windows.Forms.TextBox TBMusteriArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBMusteriAd;
        private System.Windows.Forms.TextBox TBMusteriSoyad;
        private System.Windows.Forms.TextBox TBMusteriBorc;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnMusteriBorcOdeme;
        private System.Windows.Forms.TextBox TBOdemeMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnOnayla;
        private System.Windows.Forms.TextBox TBMusteriId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}