namespace MarketManagementSystem
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.KullaniciAd = new System.Windows.Forms.Label();
            this.Parola = new System.Windows.Forms.Label();
            this.KullaniciAdTB = new System.Windows.Forms.TextBox();
            this.ParolaTB = new System.Windows.Forms.TextBox();
            this.GirisBtn = new System.Windows.Forms.Button();
            this.CikisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KullaniciAd
            // 
            this.KullaniciAd.AutoSize = true;
            this.KullaniciAd.Location = new System.Drawing.Point(35, 55);
            this.KullaniciAd.Name = "KullaniciAd";
            this.KullaniciAd.Size = new System.Drawing.Size(97, 20);
            this.KullaniciAd.TabIndex = 0;
            this.KullaniciAd.Text = "Kullanıcı Adı:";
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.Location = new System.Drawing.Point(74, 98);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(58, 20);
            this.Parola.TabIndex = 1;
            this.Parola.Text = "Parola:";
            // 
            // KullaniciAdTB
            // 
            this.KullaniciAdTB.Location = new System.Drawing.Point(160, 55);
            this.KullaniciAdTB.Name = "KullaniciAdTB";
            this.KullaniciAdTB.Size = new System.Drawing.Size(181, 26);
            this.KullaniciAdTB.TabIndex = 2;
            // 
            // ParolaTB
            // 
            this.ParolaTB.Location = new System.Drawing.Point(160, 98);
            this.ParolaTB.Name = "ParolaTB";
            this.ParolaTB.PasswordChar = '*';
            this.ParolaTB.Size = new System.Drawing.Size(181, 26);
            this.ParolaTB.TabIndex = 3;
            // 
            // GirisBtn
            // 
            this.GirisBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.GirisBtn.Location = new System.Drawing.Point(39, 162);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(147, 40);
            this.GirisBtn.TabIndex = 4;
            this.GirisBtn.Text = "Giriş Yap";
            this.GirisBtn.UseVisualStyleBackColor = false;
            this.GirisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // CikisBtn
            // 
            this.CikisBtn.BackColor = System.Drawing.Color.Red;
            this.CikisBtn.Location = new System.Drawing.Point(212, 162);
            this.CikisBtn.Name = "CikisBtn";
            this.CikisBtn.Size = new System.Drawing.Size(129, 40);
            this.CikisBtn.TabIndex = 5;
            this.CikisBtn.Text = "Çıkış yap";
            this.CikisBtn.UseVisualStyleBackColor = false;
            this.CikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 258);
            this.Controls.Add(this.CikisBtn);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.ParolaTB);
            this.Controls.Add(this.KullaniciAdTB);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.KullaniciAd);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KullaniciAd;
        private System.Windows.Forms.Label Parola;
        private System.Windows.Forms.TextBox KullaniciAdTB;
        private System.Windows.Forms.TextBox ParolaTB;
        private System.Windows.Forms.Button GirisBtn;
        private System.Windows.Forms.Button CikisBtn;
    }
}

