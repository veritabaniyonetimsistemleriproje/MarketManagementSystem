﻿namespace MarketManagementSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.PanelButon.SuspendLayout();
            this.PanelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnUrunler
            // 
            this.BtnUrunler.Location = new System.Drawing.Point(19, 23);
            this.BtnUrunler.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnUrunler.Name = "BtnUrunler";
            this.BtnUrunler.Size = new System.Drawing.Size(95, 45);
            this.BtnUrunler.TabIndex = 1;
            this.BtnUrunler.Text = "Ürünler";
            this.BtnUrunler.UseVisualStyleBackColor = true;
            this.BtnUrunler.Click += new System.EventHandler(this.BtnUrunler_Click);
            // 
            // BtnSatis
            // 
            this.BtnSatis.Location = new System.Drawing.Point(184, 23);
            this.BtnSatis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSatis.Name = "BtnSatis";
            this.BtnSatis.Size = new System.Drawing.Size(95, 45);
            this.BtnSatis.TabIndex = 2;
            this.BtnSatis.Text = "Satış";
            this.BtnSatis.UseVisualStyleBackColor = true;
            this.BtnSatis.Click += new System.EventHandler(this.BtnSatis_Click);
            // 
            // BtnMusteri
            // 
            this.BtnMusteri.Location = new System.Drawing.Point(361, 23);
            this.BtnMusteri.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnMusteri.Name = "BtnMusteri";
            this.BtnMusteri.Size = new System.Drawing.Size(95, 45);
            this.BtnMusteri.TabIndex = 3;
            this.BtnMusteri.Text = "Müşteriler";
            this.BtnMusteri.UseVisualStyleBackColor = true;
            this.BtnMusteri.Click += new System.EventHandler(this.BtnMusteri_Click);
            // 
            // BtnTedarikci
            // 
            this.BtnTedarikci.Location = new System.Drawing.Point(527, 23);
            this.BtnTedarikci.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnTedarikci.Name = "BtnTedarikci";
            this.BtnTedarikci.Size = new System.Drawing.Size(95, 45);
            this.BtnTedarikci.TabIndex = 4;
            this.BtnTedarikci.Text = "Tedarikçi";
            this.BtnTedarikci.UseVisualStyleBackColor = true;
            this.BtnTedarikci.Click += new System.EventHandler(this.BtnTedarikci_Click);
            // 
            // BtnRaporlama
            // 
            this.BtnRaporlama.Location = new System.Drawing.Point(697, 23);
            this.BtnRaporlama.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnRaporlama.Name = "BtnRaporlama";
            this.BtnRaporlama.Size = new System.Drawing.Size(95, 45);
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
            this.PanelButon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PanelButon.Name = "PanelButon";
            this.PanelButon.Size = new System.Drawing.Size(963, 87);
            this.PanelButon.TabIndex = 6;
            // 
            // PanelForm
            // 
            this.PanelForm.Controls.Add(this.label1);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(0, 87);
            this.PanelForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(963, 471);
            this.PanelForm.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOŞGELDİNİZ VS";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 558);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.PanelButon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.PanelButon.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            this.PanelForm.PerformLayout();
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
        private System.Windows.Forms.Label label1;
    }
}