namespace MarketManagementSystem
{
    partial class Satis
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
            this.DGVSepet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.RBtnVeresiye = new System.Windows.Forms.RadioButton();
            this.RBtnPesin = new System.Windows.Forms.RadioButton();
            this.BtnSatisOnayla = new System.Windows.Forms.Button();
            this.TBToplamTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVMusteriler = new System.Windows.Forms.DataGridView();
            this.TBMusteriID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBBarkodNo = new System.Windows.Forms.TextBox();
            this.BtnOnay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSepet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusteriler)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVSepet
            // 
            this.DGVSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSepet.Location = new System.Drawing.Point(18, 66);
            this.DGVSepet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVSepet.Name = "DGVSepet";
            this.DGVSepet.RowHeadersWidth = 62;
            this.DGVSepet.Size = new System.Drawing.Size(524, 608);
            this.DGVSepet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sepet:";
            // 
            // RBtnVeresiye
            // 
            this.RBtnVeresiye.AutoSize = true;
            this.RBtnVeresiye.Location = new System.Drawing.Point(576, 133);
            this.RBtnVeresiye.Name = "RBtnVeresiye";
            this.RBtnVeresiye.Size = new System.Drawing.Size(95, 24);
            this.RBtnVeresiye.TabIndex = 4;
            this.RBtnVeresiye.TabStop = true;
            this.RBtnVeresiye.Text = "Veresiye";
            this.RBtnVeresiye.UseVisualStyleBackColor = true;
            this.RBtnVeresiye.CheckedChanged += new System.EventHandler(this.RBtnVeresiye_CheckedChanged);
            // 
            // RBtnPesin
            // 
            this.RBtnPesin.AutoSize = true;
            this.RBtnPesin.Location = new System.Drawing.Point(717, 133);
            this.RBtnPesin.Name = "RBtnPesin";
            this.RBtnPesin.Size = new System.Drawing.Size(73, 24);
            this.RBtnPesin.TabIndex = 5;
            this.RBtnPesin.TabStop = true;
            this.RBtnPesin.Text = "Peşin";
            this.RBtnPesin.UseVisualStyleBackColor = true;
            this.RBtnPesin.CheckedChanged += new System.EventHandler(this.RBtnPesin_CheckedChanged);
            // 
            // BtnSatisOnayla
            // 
            this.BtnSatisOnayla.Location = new System.Drawing.Point(1013, 122);
            this.BtnSatisOnayla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSatisOnayla.Name = "BtnSatisOnayla";
            this.BtnSatisOnayla.Size = new System.Drawing.Size(170, 46);
            this.BtnSatisOnayla.TabIndex = 6;
            this.BtnSatisOnayla.Text = "Satışı Onayla";
            this.BtnSatisOnayla.UseVisualStyleBackColor = true;
            // 
            // TBToplamTutar
            // 
            this.TBToplamTutar.Location = new System.Drawing.Point(1013, 89);
            this.TBToplamTutar.Name = "TBToplamTutar";
            this.TBToplamTutar.Size = new System.Drawing.Size(155, 26);
            this.TBToplamTutar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1013, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Toplam Tutar:";
            // 
            // DGVMusteriler
            // 
            this.DGVMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMusteriler.Location = new System.Drawing.Point(18, 55);
            this.DGVMusteriler.Name = "DGVMusteriler";
            this.DGVMusteriler.RowHeadersWidth = 62;
            this.DGVMusteriler.RowTemplate.Height = 28;
            this.DGVMusteriler.Size = new System.Drawing.Size(575, 409);
            this.DGVMusteriler.TabIndex = 9;
            this.DGVMusteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMusteriler_CellContentClick);
            // 
            // TBMusteriID
            // 
            this.TBMusteriID.Location = new System.Drawing.Point(141, 14);
            this.TBMusteriID.Name = "TBMusteriID";
            this.TBMusteriID.Size = new System.Drawing.Size(155, 26);
            this.TBMusteriID.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DGVMusteriler);
            this.panel1.Controls.Add(this.TBMusteriID);
            this.panel1.Location = new System.Drawing.Point(576, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 481);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Müşteri ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Barkod No:";
            // 
            // TBBarkodNo
            // 
            this.TBBarkodNo.Location = new System.Drawing.Point(670, 63);
            this.TBBarkodNo.Name = "TBBarkodNo";
            this.TBBarkodNo.Size = new System.Drawing.Size(81, 26);
            this.TBBarkodNo.TabIndex = 13;
            // 
            // BtnOnay
            // 
            this.BtnOnay.Location = new System.Drawing.Point(777, 63);
            this.BtnOnay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOnay.Name = "BtnOnay";
            this.BtnOnay.Size = new System.Drawing.Size(125, 26);
            this.BtnOnay.TabIndex = 14;
            this.BtnOnay.Text = "Onayla";
            this.BtnOnay.UseVisualStyleBackColor = true;
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.BtnOnay);
            this.Controls.Add(this.TBBarkodNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBToplamTutar);
            this.Controls.Add(this.BtnSatisOnayla);
            this.Controls.Add(this.RBtnPesin);
            this.Controls.Add(this.RBtnVeresiye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVSepet);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Satis";
            this.Text = "Satis";
            this.Load += new System.EventHandler(this.Satis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSepet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusteriler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVSepet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBtnVeresiye;
        private System.Windows.Forms.RadioButton RBtnPesin;
        private System.Windows.Forms.Button BtnSatisOnayla;
        private System.Windows.Forms.TextBox TBToplamTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVMusteriler;
        private System.Windows.Forms.TextBox TBMusteriID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBBarkodNo;
        private System.Windows.Forms.Button BtnOnay;
    }
}