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
            this.PanelButon = new System.Windows.Forms.Panel();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.PanelButon.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnUrunler
            // 
            this.BtnUrunler.Location = new System.Drawing.Point(29, 35);
            this.BtnUrunler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUrunler.Name = "BtnUrunler";
            this.BtnUrunler.Size = new System.Drawing.Size(143, 69);
            this.BtnUrunler.TabIndex = 1;
            this.BtnUrunler.Text = "Ürünler";
            this.BtnUrunler.UseVisualStyleBackColor = true;
            this.BtnUrunler.Click += new System.EventHandler(this.BtnUrunler_Click);
            // 
            // BtnSatis
            // 
            this.BtnSatis.Location = new System.Drawing.Point(276, 35);
            this.BtnSatis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSatis.Name = "BtnSatis";
            this.BtnSatis.Size = new System.Drawing.Size(143, 69);
            this.BtnSatis.TabIndex = 2;
            this.BtnSatis.Text = "Satış";
            this.BtnSatis.UseVisualStyleBackColor = true;
            this.BtnSatis.Click += new System.EventHandler(this.BtnSatis_Click);
            // 
            // BtnMusteri
            // 
            this.BtnMusteri.Location = new System.Drawing.Point(542, 35);
            this.BtnMusteri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnMusteri.Name = "BtnMusteri";
            this.BtnMusteri.Size = new System.Drawing.Size(143, 69);
            this.BtnMusteri.TabIndex = 3;
            this.BtnMusteri.Text = "Müşteriler";
            this.BtnMusteri.UseVisualStyleBackColor = true;
            this.BtnMusteri.Click += new System.EventHandler(this.BtnMusteri_Click);
            // 
            // BtnTedarikci
            // 
            this.BtnTedarikci.Location = new System.Drawing.Point(790, 35);
            this.BtnTedarikci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTedarikci.Name = "BtnTedarikci";
            this.BtnTedarikci.Size = new System.Drawing.Size(143, 69);
            this.BtnTedarikci.TabIndex = 4;
            this.BtnTedarikci.Text = "Tedarikçi";
            this.BtnTedarikci.UseVisualStyleBackColor = true;
            this.BtnTedarikci.Click += new System.EventHandler(this.BtnTedarikci_Click);
            // 
            // BtnRaporlama
            // 
            this.BtnRaporlama.Location = new System.Drawing.Point(1045, 35);
            this.BtnRaporlama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRaporlama.Name = "BtnRaporlama";
            this.BtnRaporlama.Size = new System.Drawing.Size(143, 69);
            this.BtnRaporlama.TabIndex = 5;
            this.BtnRaporlama.Text = "Raporlama";
            this.BtnRaporlama.UseVisualStyleBackColor = true;
            this.BtnRaporlama.Click += new System.EventHandler(this.BtnRaporlama_Click);
            // 
            // PanelButon
            // 
            this.PanelButon.Controls.Add(this.BtnUrunler);
            this.PanelButon.Controls.Add(this.BtnRaporlama);
            this.PanelButon.Controls.Add(this.BtnSatis);
            this.PanelButon.Controls.Add(this.BtnTedarikci);
            this.PanelButon.Controls.Add(this.BtnMusteri);
            this.PanelButon.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelButon.Location = new System.Drawing.Point(0, 0);
            this.PanelButon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelButon.Name = "PanelButon";
            this.PanelButon.Size = new System.Drawing.Size(1444, 134);
            this.PanelButon.TabIndex = 6;
            // 
            // PanelForm
            // 
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(0, 134);
            this.PanelForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(1444, 725);
            this.PanelForm.TabIndex = 7;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 859);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.PanelButon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.PanelButon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUrunler;
        private System.Windows.Forms.Button BtnSatis;
        private System.Windows.Forms.Button BtnMusteri;
        private System.Windows.Forms.Button BtnTedarikci;
        private System.Windows.Forms.Button BtnRaporlama;
        private System.Windows.Forms.Panel PanelButon;
        private System.Windows.Forms.Panel PanelForm;
    }
}