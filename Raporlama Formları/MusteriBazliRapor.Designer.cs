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
            this.DGVMusteriRapor = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbMusteriAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbMusteriNo = new System.Windows.Forms.TextBox();
            this.DGVMusteriler = new System.Windows.Forms.DataGridView();
            this.BtnMusteriRapor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusteriRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMusteriRapor
            // 
            this.DGVMusteriRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMusteriRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMusteriRapor.Location = new System.Drawing.Point(8, 163);
            this.DGVMusteriRapor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVMusteriRapor.Name = "DGVMusteriRapor";
            this.DGVMusteriRapor.RowTemplate.Height = 28;
            this.DGVMusteriRapor.Size = new System.Drawing.Size(595, 251);
            this.DGVMusteriRapor.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(380, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Müşteri Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(380, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Müşteri Ara:";
            // 
            // TbMusteriAra
            // 
            this.TbMusteriAra.Location = new System.Drawing.Point(512, 21);
            this.TbMusteriAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbMusteriAra.Name = "TbMusteriAra";
            this.TbMusteriAra.Size = new System.Drawing.Size(91, 20);
            this.TbMusteriAra.TabIndex = 10;
            this.TbMusteriAra.TextChanged += new System.EventHandler(this.TbMusteriAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(380, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lütfen Müşteri Seçiniz";
            // 
            // TbMusteriNo
            // 
            this.TbMusteriNo.Location = new System.Drawing.Point(512, 45);
            this.TbMusteriNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbMusteriNo.Name = "TbMusteriNo";
            this.TbMusteriNo.Size = new System.Drawing.Size(91, 20);
            this.TbMusteriNo.TabIndex = 8;
            // 
            // DGVMusteriler
            // 
            this.DGVMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMusteriler.Location = new System.Drawing.Point(8, 8);
            this.DGVMusteriler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVMusteriler.Name = "DGVMusteriler";
            this.DGVMusteriler.RowTemplate.Height = 28;
            this.DGVMusteriler.Size = new System.Drawing.Size(370, 117);
            this.DGVMusteriler.TabIndex = 7;
            this.DGVMusteriler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMusteriler_CellEnter);
            // 
            // BtnMusteriRapor
            // 
            this.BtnMusteriRapor.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnMusteriRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMusteriRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriRapor.Location = new System.Drawing.Point(383, 80);
            this.BtnMusteriRapor.Name = "BtnMusteriRapor";
            this.BtnMusteriRapor.Size = new System.Drawing.Size(220, 44);
            this.BtnMusteriRapor.TabIndex = 14;
            this.BtnMusteriRapor.Text = "Müşteri Raporu Getir";
            this.BtnMusteriRapor.UseVisualStyleBackColor = false;
            this.BtnMusteriRapor.Click += new System.EventHandler(this.BtnMusteriRapor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(218, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Müşteri Satış Raporu";
            // 
            // MusteriBazliRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 422);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnMusteriRapor);
            this.Controls.Add(this.DGVMusteriRapor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbMusteriAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbMusteriNo);
            this.Controls.Add(this.DGVMusteriler);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MusteriBazliRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriBazliRapor";
            this.Load += new System.EventHandler(this.MusteriBazliRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusteriRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMusteriRapor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbMusteriAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbMusteriNo;
        private System.Windows.Forms.DataGridView DGVMusteriler;
        private System.Windows.Forms.Button BtnMusteriRapor;
        private System.Windows.Forms.Label label4;
    }
}