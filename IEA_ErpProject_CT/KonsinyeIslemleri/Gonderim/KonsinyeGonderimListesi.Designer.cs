namespace IEA_ErpProject_CT.KonsinyeIslemleri.Gonderim
{
    partial class KonsinyeGonderimListesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GonderimTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcikTr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GonderimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGirisAra = new System.Windows.Forms.TextBox();
            this.btnGonderimBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUst = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.CariTur,
            this.Cari,
            this.GonderimTarih,
            this.AcikTr,
            this.GonderimId});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 41);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(800, 409);
            this.Liste.TabIndex = 7;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // CariTur
            // 
            this.CariTur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTur.HeaderText = "Cari Tur";
            this.CariTur.Name = "CariTur";
            this.CariTur.Width = 50;
            // 
            // Cari
            // 
            this.Cari.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cari.HeaderText = "Cari Adi";
            this.Cari.Name = "Cari";
            // 
            // GonderimTarih
            // 
            this.GonderimTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.GonderimTarih.DefaultCellStyle = dataGridViewCellStyle1;
            this.GonderimTarih.HeaderText = "Gonderim Tarih";
            this.GonderimTarih.Name = "GonderimTarih";
            this.GonderimTarih.Width = 96;
            // 
            // AcikTr
            // 
            this.AcikTr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AcikTr.HeaderText = "Aciklama";
            this.AcikTr.Name = "AcikTr";
            // 
            // GonderimId
            // 
            this.GonderimId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GonderimId.HeaderText = "Gonderim Id";
            this.GonderimId.Name = "GonderimId";
            this.GonderimId.Visible = false;
            // 
            // txtGirisAra
            // 
            this.txtGirisAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGirisAra.Location = new System.Drawing.Point(595, 8);
            this.txtGirisAra.Name = "txtGirisAra";
            this.txtGirisAra.Size = new System.Drawing.Size(193, 20);
            this.txtGirisAra.TabIndex = 3;
            // 
            // btnGonderimBul
            // 
            this.btnGonderimBul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGonderimBul.Location = new System.Drawing.Point(504, 6);
            this.btnGonderimBul.Name = "btnGonderimBul";
            this.btnGonderimBul.Size = new System.Drawing.Size(85, 25);
            this.btnGonderimBul.TabIndex = 2;
            this.btnGonderimBul.Text = "Gonderim Bul";
            this.btnGonderimBul.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Konsinye Gonderim Listesi";
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlUst.Controls.Add(this.txtGirisAra);
            this.pnlUst.Controls.Add(this.btnGonderimBul);
            this.pnlUst.Controls.Add(this.label1);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(800, 41);
            this.pnlUst.TabIndex = 6;
            // 
            // KonsinyeGonderimListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlUst);
            this.Name = "KonsinyeGonderimListesi";
            this.Text = "KonsinyeGonderimListesi";
            this.Load += new System.EventHandler(this.KonsinyeGonderimListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.TextBox txtGirisAra;
        private System.Windows.Forms.Button btnGonderimBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cari;
        private System.Windows.Forms.DataGridViewTextBoxColumn GonderimTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcikTr;
        private System.Windows.Forms.DataGridViewTextBoxColumn GonderimId;
    }
}