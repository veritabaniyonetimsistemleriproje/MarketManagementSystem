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
            this.KullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAd.Location = new System.Drawing.Point(6, 34);
            this.KullaniciAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KullaniciAd.Name = "KullaniciAd";
            this.KullaniciAd.Size = new System.Drawing.Size(97, 20);
            this.KullaniciAd.TabIndex = 0;
            this.KullaniciAd.Text = "Kullanıcı Adı:";
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Parola.Location = new System.Drawing.Point(45, 62);
            this.Parola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(58, 20);
            this.Parola.TabIndex = 1;
            this.Parola.Text = "Parola:";
            // 
            // KullaniciAdTB
            // 
            this.KullaniciAdTB.Location = new System.Drawing.Point(107, 36);
            this.KullaniciAdTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KullaniciAdTB.Name = "KullaniciAdTB";
            this.KullaniciAdTB.Size = new System.Drawing.Size(122, 20);
            this.KullaniciAdTB.TabIndex = 2;
            // 
            // ParolaTB
            // 
            this.ParolaTB.Location = new System.Drawing.Point(107, 64);
            this.ParolaTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParolaTB.Name = "ParolaTB";
            this.ParolaTB.PasswordChar = '*';
            this.ParolaTB.Size = new System.Drawing.Size(122, 20);
            this.ParolaTB.TabIndex = 3;
            // 
            // GirisBtn
            // 
            this.GirisBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.GirisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GirisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisBtn.Location = new System.Drawing.Point(21, 105);
            this.GirisBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(105, 34);
            this.GirisBtn.TabIndex = 4;
            this.GirisBtn.Text = "Giriş Yap";
            this.GirisBtn.UseVisualStyleBackColor = false;
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // CikisBtn
            // 
            this.CikisBtn.BackColor = System.Drawing.Color.Red;
            this.CikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CikisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CikisBtn.Location = new System.Drawing.Point(130, 105);
            this.CikisBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CikisBtn.Name = "CikisBtn";
            this.CikisBtn.Size = new System.Drawing.Size(97, 34);
            this.CikisBtn.TabIndex = 5;
            this.CikisBtn.Text = "Çıkış yap";
            this.CikisBtn.UseVisualStyleBackColor = false;
            this.CikisBtn.Click += new System.EventHandler(this.CikisBtn_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 168);
            this.Controls.Add(this.CikisBtn);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.ParolaTB);
            this.Controls.Add(this.KullaniciAdTB);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.KullaniciAd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

