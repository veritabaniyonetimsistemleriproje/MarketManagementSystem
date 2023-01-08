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
            this.kullaniciAd = new System.Windows.Forms.Label();
            this.parola = new System.Windows.Forms.Label();
            this.kullaniciAdTB = new System.Windows.Forms.TextBox();
            this.parolaTB = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciAd
            // 
            this.kullaniciAd.AutoSize = true;
            this.kullaniciAd.Location = new System.Drawing.Point(35, 55);
            this.kullaniciAd.Name = "kullaniciAd";
            this.kullaniciAd.Size = new System.Drawing.Size(97, 20);
            this.kullaniciAd.TabIndex = 0;
            this.kullaniciAd.Text = "Kullanıcı Adı:";
            // 
            // parola
            // 
            this.parola.AutoSize = true;
            this.parola.Location = new System.Drawing.Point(74, 98);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(58, 20);
            this.parola.TabIndex = 1;
            this.parola.Text = "Parola:";
            // 
            // kullaniciAdTB
            // 
            this.kullaniciAdTB.Location = new System.Drawing.Point(160, 55);
            this.kullaniciAdTB.Name = "kullaniciAdTB";
            this.kullaniciAdTB.Size = new System.Drawing.Size(181, 26);
            this.kullaniciAdTB.TabIndex = 2;
            // 
            // parolaTB
            // 
            this.parolaTB.Location = new System.Drawing.Point(160, 98);
            this.parolaTB.Name = "parolaTB";
            this.parolaTB.PasswordChar = '*';
            this.parolaTB.Size = new System.Drawing.Size(181, 26);
            this.parolaTB.TabIndex = 3;
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.girisBtn.Location = new System.Drawing.Point(39, 162);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(147, 40);
            this.girisBtn.TabIndex = 4;
            this.girisBtn.Text = "Giriş Yap";
            this.girisBtn.UseVisualStyleBackColor = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.Red;
            this.cikisBtn.Location = new System.Drawing.Point(212, 162);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(129, 40);
            this.cikisBtn.TabIndex = 5;
            this.cikisBtn.Text = "Çıkış yap";
            this.cikisBtn.UseVisualStyleBackColor = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 258);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.parolaTB);
            this.Controls.Add(this.kullaniciAdTB);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.kullaniciAd);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciAd;
        private System.Windows.Forms.Label parola;
        private System.Windows.Forms.TextBox kullaniciAdTB;
        private System.Windows.Forms.TextBox parolaTB;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Button cikisBtn;
    }
}

