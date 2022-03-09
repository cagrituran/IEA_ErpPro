namespace IEA_ErpProject_CT.KonsinyeIslemleri
{
    partial class LotBul
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotSeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uts = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.utarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sktarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Barkod,
            this.LotSeriNo,
            this.Adet,
            this.Uts,
            this.utarih,
            this.sktarih});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(515, 255);
            this.Liste.TabIndex = 1;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // Barkod
            // 
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.Name = "Barkod";
            // 
            // LotSeriNo
            // 
            this.LotSeriNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LotSeriNo.HeaderText = "Lot / Seri No";
            this.LotSeriNo.Name = "LotSeriNo";
            // 
            // Adet
            // 
            this.Adet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            this.Adet.Width = 54;
            // 
            // Uts
            // 
            this.Uts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Uts.HeaderText = "Uts";
            this.Uts.Name = "Uts";
            this.Uts.Width = 29;
            // 
            // utarih
            // 
            this.utarih.HeaderText = "utarih";
            this.utarih.Name = "utarih";
            this.utarih.Visible = false;
            // 
            // sktarih
            // 
            this.sktarih.HeaderText = "sktarih";
            this.sktarih.Name = "sktarih";
            this.sktarih.Visible = false;
            // 
            // LotBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 255);
            this.Controls.Add(this.Liste);
            this.Name = "LotBul";
            this.Text = "LotBul";
            this.Load += new System.EventHandler(this.LotBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotSeriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Uts;
        private System.Windows.Forms.DataGridViewTextBoxColumn utarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn sktarih;
    }
}