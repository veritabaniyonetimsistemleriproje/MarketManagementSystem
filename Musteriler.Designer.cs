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
            this.TBMusteriAd = new System.Windows.Forms.TextBox();
            this.TBMusteriSoyad = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.TBMusteriId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusteriler)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVMusteriler
            // 
            this.DGVMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMusteriler.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMusteriler.Location = new System.Drawing.Point(9, 10);
            this.DGVMusteriler.Margin = new System.Windows.Forms.Padding(2);
            this.DGVMusteriler.Name = "DGVMusteriler";
            this.DGVMusteriler.RowHeadersWidth = 51;
            this.DGVMusteriler.RowTemplate.Height = 24;
            this.DGVMusteriler.Size = new System.Drawing.Size(394, 413);
            this.DGVMusteriler.TabIndex = 0;
            this.DGVMusteriler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMusteriler_CellEnter);
            // 
            // BtnYeniMusteri
            // 
            this.BtnYeniMusteri.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnYeniMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniMusteri.Location = new System.Drawing.Point(9, 152);
            this.BtnYeniMusteri.Margin = new System.Windows.Forms.Padding(2);
            this.BtnYeniMusteri.Name = "BtnYeniMusteri";
            this.BtnYeniMusteri.Size = new System.Drawing.Size(138, 26);
            this.BtnYeniMusteri.TabIndex = 1;
            this.BtnYeniMusteri.Text = "Müşteri Ekle";
            this.BtnYeniMusteri.UseVisualStyleBackColor = false;
            this.BtnYeniMusteri.Click += new System.EventHandler(this.BtnYeniMusteri_Click);
            // 
            // TBMusteriArama
            // 
            this.TBMusteriArama.Location = new System.Drawing.Point(14, 34);
            this.TBMusteriArama.Margin = new System.Windows.Forms.Padding(2);
            this.TBMusteriArama.Name = "TBMusteriArama";
            this.TBMusteriArama.Size = new System.Drawing.Size(133, 20);
            this.TBMusteriArama.TabIndex = 2;
            this.TBMusteriArama.TextChanged += new System.EventHandler(this.TBMusteriArama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Müşteri Arama ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteri Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Soyad:";
            // 
            // TBMusteriAd
            // 
            this.TBMusteriAd.Location = new System.Drawing.Point(78, 60);
            this.TBMusteriAd.Margin = new System.Windows.Forms.Padding(2);
            this.TBMusteriAd.Name = "TBMusteriAd";
            this.TBMusteriAd.Size = new System.Drawing.Size(69, 20);
            this.TBMusteriAd.TabIndex = 9;
            // 
            // TBMusteriSoyad
            // 
            this.TBMusteriSoyad.Location = new System.Drawing.Point(78, 93);
            this.TBMusteriSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.TBMusteriSoyad.Name = "TBMusteriSoyad";
            this.TBMusteriSoyad.Size = new System.Drawing.Size(69, 20);
            this.TBMusteriSoyad.TabIndex = 10;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(9, 122);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(65, 25);
            this.BtnGuncelle.TabIndex = 12;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Red;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(79, 122);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(68, 24);
            this.BtnSil.TabIndex = 13;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // TBMusteriId
            // 
            this.TBMusteriId.Location = new System.Drawing.Point(78, 31);
            this.TBMusteriId.Margin = new System.Windows.Forms.Padding(2);
            this.TBMusteriId.Name = "TBMusteriId";
            this.TBMusteriId.ReadOnly = true;
            this.TBMusteriId.Size = new System.Drawing.Size(69, 20);
            this.TBMusteriId.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(9, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
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
            this.panel1.Controls.Add(this.TBMusteriAd);
            this.panel1.Controls.Add(this.TBMusteriSoyad);
            this.panel1.Controls.Add(this.BtnSil);
            this.panel1.Controls.Add(this.BtnGuncelle);
            this.panel1.Location = new System.Drawing.Point(408, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 189);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TBMusteriArama);
            this.panel2.Location = new System.Drawing.Point(408, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 65);
            this.panel2.TabIndex = 21;
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 432);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGVMusteriler);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Musteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusteriler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox TBMusteriAd;
        private System.Windows.Forms.TextBox TBMusteriSoyad;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox TBMusteriId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}