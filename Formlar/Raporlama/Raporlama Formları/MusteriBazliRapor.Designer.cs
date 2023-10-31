namespace MarketManagementSystem
{
    partial class MusteriBazliRapor
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
            this.DGVMusteriRapor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBMusteriAra = new System.Windows.Forms.TextBox();
            this.TBMusteriNo = new System.Windows.Forms.TextBox();
            this.BtnMusteriRapor = new System.Windows.Forms.Button();
            this.musteriLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusteriRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMusteriler
            // 
            this.DGVMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMusteriler.Location = new System.Drawing.Point(13, 13);
            this.DGVMusteriler.Name = "DGVMusteriler";
            this.DGVMusteriler.Size = new System.Drawing.Size(292, 119);
            this.DGVMusteriler.TabIndex = 0;
            this.DGVMusteriler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMusteriler_CellEnter);
            // 
            // DGVMusteriRapor
            // 
            this.DGVMusteriRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMusteriRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMusteriRapor.Location = new System.Drawing.Point(13, 169);
            this.DGVMusteriRapor.Name = "DGVMusteriRapor";
            this.DGVMusteriRapor.Size = new System.Drawing.Size(511, 269);
            this.DGVMusteriRapor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(311, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lütfen Müşteri Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(311, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteri Ara:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(311, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Müşteri Numarası:";
            // 
            // TBMusteriAra
            // 
            this.TBMusteriAra.Location = new System.Drawing.Point(424, 41);
            this.TBMusteriAra.Name = "TBMusteriAra";
            this.TBMusteriAra.Size = new System.Drawing.Size(100, 20);
            this.TBMusteriAra.TabIndex = 5;
            this.TBMusteriAra.TextChanged += new System.EventHandler(this.TBMusteriAra_TextChanged);
            // 
            // TBMusteriNo
            // 
            this.TBMusteriNo.Location = new System.Drawing.Point(424, 71);
            this.TBMusteriNo.Name = "TBMusteriNo";
            this.TBMusteriNo.Size = new System.Drawing.Size(100, 20);
            this.TBMusteriNo.TabIndex = 6;
            // 
            // BtnMusteriRapor
            // 
            this.BtnMusteriRapor.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnMusteriRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMusteriRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriRapor.Location = new System.Drawing.Point(314, 97);
            this.BtnMusteriRapor.Name = "BtnMusteriRapor";
            this.BtnMusteriRapor.Size = new System.Drawing.Size(210, 35);
            this.BtnMusteriRapor.TabIndex = 7;
            this.BtnMusteriRapor.Text = "Müşteri Raporunu Getir";
            this.BtnMusteriRapor.UseVisualStyleBackColor = false;
            this.BtnMusteriRapor.Click += new System.EventHandler(this.BtnMusteriRapor_Click);
            // 
            // musteriLabel
            // 
            this.musteriLabel.AutoSize = true;
            this.musteriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriLabel.Location = new System.Drawing.Point(140, 141);
            this.musteriLabel.Name = "musteriLabel";
            this.musteriLabel.Size = new System.Drawing.Size(233, 25);
            this.musteriLabel.TabIndex = 8;
            this.musteriLabel.Text = "Müşteri Satış Raporu";
            // 
            // MusteriBazliRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.musteriLabel);
            this.Controls.Add(this.BtnMusteriRapor);
            this.Controls.Add(this.TBMusteriNo);
            this.Controls.Add(this.TBMusteriAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVMusteriRapor);
            this.Controls.Add(this.DGVMusteriler);
            this.Name = "MusteriBazliRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Satış Raporu";
            this.Load += new System.EventHandler(this.MusteriBazliRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusteriRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMusteriler;
        private System.Windows.Forms.DataGridView DGVMusteriRapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBMusteriAra;
        private System.Windows.Forms.TextBox TBMusteriNo;
        private System.Windows.Forms.Button BtnMusteriRapor;
        private System.Windows.Forms.Label musteriLabel;
    }
}