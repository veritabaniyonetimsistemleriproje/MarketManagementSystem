namespace MarketManagementSystem
{
    partial class UrunListCoktanAza
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
            this.DGVListelemeUrun = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListelemeUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVListelemeUrun
            // 
            this.DGVListelemeUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListelemeUrun.Location = new System.Drawing.Point(13, 13);
            this.DGVListelemeUrun.Name = "DGVListelemeUrun";
            this.DGVListelemeUrun.RowHeadersWidth = 51;
            this.DGVListelemeUrun.RowTemplate.Height = 24;
            this.DGVListelemeUrun.Size = new System.Drawing.Size(775, 415);
            this.DGVListelemeUrun.TabIndex = 0;
            // 
            // UrunListCoktanAza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVListelemeUrun);
            this.Name = "UrunListCoktanAza";
            this.Text = "UrunListCoktanAza";
            this.Load += new System.EventHandler(this.UrunListCoktanAza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListelemeUrun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListelemeUrun;
    }
}