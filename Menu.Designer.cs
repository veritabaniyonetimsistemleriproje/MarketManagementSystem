namespace MarketManagementSystem
{
    partial class Menu
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
            this.BtnUrunler = new System.Windows.Forms.Button();
            this.BtnSatis = new System.Windows.Forms.Button();
            this.BtnMusteri = new System.Windows.Forms.Button();
            this.BtnTedarikci = new System.Windows.Forms.Button();
            this.BtnRaporlama = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnUrunler
            // 
            this.BtnUrunler.Location = new System.Drawing.Point(26, 28);
            this.BtnUrunler.Name = "BtnUrunler";
            this.BtnUrunler.Size = new System.Drawing.Size(127, 55);
            this.BtnUrunler.TabIndex = 1;
            this.BtnUrunler.Text = "Ürünler";
            this.BtnUrunler.UseVisualStyleBackColor = true;
            this.BtnUrunler.Click += new System.EventHandler(this.BtnUrunler_Click);
            // 
            // BtnSatis
            // 
            this.BtnSatis.Location = new System.Drawing.Point(245, 28);
            this.BtnSatis.Name = "BtnSatis";
            this.BtnSatis.Size = new System.Drawing.Size(127, 55);
            this.BtnSatis.TabIndex = 2;
            this.BtnSatis.Text = "Satış";
            this.BtnSatis.UseVisualStyleBackColor = true;
            this.BtnSatis.Click += new System.EventHandler(this.BtnSatis_Click);
            // 
            // BtnMusteri
            // 
            this.BtnMusteri.Location = new System.Drawing.Point(482, 28);
            this.BtnMusteri.Name = "BtnMusteri";
            this.BtnMusteri.Size = new System.Drawing.Size(127, 55);
            this.BtnMusteri.TabIndex = 3;
            this.BtnMusteri.Text = "Müşteriler";
            this.BtnMusteri.UseVisualStyleBackColor = true;
            this.BtnMusteri.Click += new System.EventHandler(this.BtnMusteri_Click);
            // 
            // BtnTedarikci
            // 
            this.BtnTedarikci.Location = new System.Drawing.Point(702, 28);
            this.BtnTedarikci.Name = "BtnTedarikci";
            this.BtnTedarikci.Size = new System.Drawing.Size(127, 55);
            this.BtnTedarikci.TabIndex = 4;
            this.BtnTedarikci.Text = "Tedarikçi";
            this.BtnTedarikci.UseVisualStyleBackColor = true;
            this.BtnTedarikci.Click += new System.EventHandler(this.BtnTedarikci_Click);
            // 
            // BtnRaporlama
            // 
            this.BtnRaporlama.Location = new System.Drawing.Point(929, 28);
            this.BtnRaporlama.Name = "BtnRaporlama";
            this.BtnRaporlama.Size = new System.Drawing.Size(127, 55);
            this.BtnRaporlama.TabIndex = 5;
            this.BtnRaporlama.Text = "Raporlama";
            this.BtnRaporlama.UseVisualStyleBackColor = true;
            this.BtnRaporlama.Click += new System.EventHandler(this.BtnRaporlama_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnUrunler);
            this.panel1.Controls.Add(this.BtnRaporlama);
            this.panel1.Controls.Add(this.BtnSatis);
            this.panel1.Controls.Add(this.BtnTedarikci);
            this.panel1.Controls.Add(this.BtnMusteri);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 107);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 456);
            this.panel2.TabIndex = 7;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 563);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUrunler;
        private System.Windows.Forms.Button BtnSatis;
        private System.Windows.Forms.Button BtnMusteri;
        private System.Windows.Forms.Button BtnTedarikci;
        private System.Windows.Forms.Button BtnRaporlama;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}