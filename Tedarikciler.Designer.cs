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
            this.BtnYeniTedarikci = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTedarikciler)).BeginInit();
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
            this.DGVTedarikciler.Location = new System.Drawing.Point(10, 11);
            this.DGVTedarikciler.Margin = new System.Windows.Forms.Padding(2);
            this.DGVTedarikciler.Name = "DGVTedarikciler";
            this.DGVTedarikciler.ReadOnly = true;
            this.DGVTedarikciler.RowHeadersWidth = 51;
            this.DGVTedarikciler.RowTemplate.Height = 24;
            this.DGVTedarikciler.Size = new System.Drawing.Size(411, 429);
            this.DGVTedarikciler.TabIndex = 0;
            this.DGVTedarikciler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTedarikciler_CellEnter);
            // 
            // TBTedarikciArama
            // 
            this.TBTedarikciArama.Location = new System.Drawing.Point(12, 31);
            this.TBTedarikciArama.Margin = new System.Windows.Forms.Padding(2);
            this.TBTedarikciArama.Name = "TBTedarikciArama";
            this.TBTedarikciArama.Size = new System.Drawing.Size(181, 20);
            this.TBTedarikciArama.TabIndex = 1;
            this.TBTedarikciArama.TextChanged += new System.EventHandler(this.TBTedarikciArama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tedarikçi Arama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tedarikçi Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tedarikçi No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tedarikçi Ad:";
            // 
            // TBTedarikciNo
            // 
            this.TBTedarikciNo.Location = new System.Drawing.Point(116, 37);
            this.TBTedarikciNo.Margin = new System.Windows.Forms.Padding(2);
            this.TBTedarikciNo.Name = "TBTedarikciNo";
            this.TBTedarikciNo.ReadOnly = true;
            this.TBTedarikciNo.Size = new System.Drawing.Size(76, 20);
            this.TBTedarikciNo.TabIndex = 6;
            // 
            // TBTedarikciAd
            // 
            this.TBTedarikciAd.Location = new System.Drawing.Point(116, 68);
            this.TBTedarikciAd.Margin = new System.Windows.Forms.Padding(2);
            this.TBTedarikciAd.Name = "TBTedarikciAd";
            this.TBTedarikciAd.Size = new System.Drawing.Size(76, 20);
            this.TBTedarikciAd.TabIndex = 7;
            // 
            // BtnTedarikciGuncelle
            // 
            this.BtnTedarikciGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.BtnTedarikciGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTedarikciGuncelle.Location = new System.Drawing.Point(11, 95);
            this.BtnTedarikciGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTedarikciGuncelle.Name = "BtnTedarikciGuncelle";
            this.BtnTedarikciGuncelle.Size = new System.Drawing.Size(83, 25);
            this.BtnTedarikciGuncelle.TabIndex = 8;
            this.BtnTedarikciGuncelle.Text = "Güncelle";
            this.BtnTedarikciGuncelle.UseVisualStyleBackColor = false;
            this.BtnTedarikciGuncelle.Click += new System.EventHandler(this.BtnTedarikciGuncelle_Click);
            // 
            // BtnTedarikciSil
            // 
            this.BtnTedarikciSil.BackColor = System.Drawing.Color.Red;
            this.BtnTedarikciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTedarikciSil.Location = new System.Drawing.Point(109, 95);
            this.BtnTedarikciSil.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTedarikciSil.Name = "BtnTedarikciSil";
            this.BtnTedarikciSil.Size = new System.Drawing.Size(81, 25);
            this.BtnTedarikciSil.TabIndex = 9;
            this.BtnTedarikciSil.Text = "Sil";
            this.BtnTedarikciSil.UseVisualStyleBackColor = false;
            this.BtnTedarikciSil.Click += new System.EventHandler(this.BtnTedarikciSil_Click);
            // 
            // BtnYeniTedarikci
            // 
            this.BtnYeniTedarikci.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnYeniTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniTedarikci.Location = new System.Drawing.Point(12, 126);
            this.BtnYeniTedarikci.Margin = new System.Windows.Forms.Padding(2);
            this.BtnYeniTedarikci.Name = "BtnYeniTedarikci";
            this.BtnYeniTedarikci.Size = new System.Drawing.Size(178, 24);
            this.BtnYeniTedarikci.TabIndex = 14;
            this.BtnYeniTedarikci.Text = "Tedarikçi Ekle";
            this.BtnYeniTedarikci.UseVisualStyleBackColor = false;
            this.BtnYeniTedarikci.Click += new System.EventHandler(this.BtnYeniTedarikci_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TBTedarikciArama);
            this.panel2.Location = new System.Drawing.Point(424, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 60);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TBTedarikciNo);
            this.panel3.Controls.Add(this.TBTedarikciAd);
            this.panel3.Controls.Add(this.BtnYeniTedarikci);
            this.panel3.Controls.Add(this.BtnTedarikciGuncelle);
            this.panel3.Controls.Add(this.BtnTedarikciSil);
            this.panel3.Location = new System.Drawing.Point(424, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 168);
            this.panel3.TabIndex = 19;
            // 
            // Tedarikciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 447);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGVTedarikciler);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tedarikciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikciler";
            this.Load += new System.EventHandler(this.Tedarikciler_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTedarikciler)).EndInit();
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
        private System.Windows.Forms.Button BtnYeniTedarikci;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}