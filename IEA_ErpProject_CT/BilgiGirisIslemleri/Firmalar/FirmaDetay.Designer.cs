namespace IEA_ErpProject_CT.BilgiGirisIslemleri.Firmalar
{
    partial class FirmaDetay
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
            this.btnKayit = new System.Windows.Forms.Button();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.TxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtGsm = new System.Windows.Forms.MaskedTextBox();
            this.TxtDepartman = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtYetkili = new System.Windows.Forms.TextBox();
            this.lblFirmaId = new System.Windows.Forms.Label();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(686, 229);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 23);
            this.btnKayit.TabIndex = 24;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.GirisId,
            this.Yetkili,
            this.Departman,
            this.Tel,
            this.Gsm,
            this.Email});
            this.Liste.Location = new System.Drawing.Point(28, 267);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(744, 150);
            this.Liste.TabIndex = 23;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(686, 71);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(308, 73);
            this.TxtTel.Mask = "(999) 000-0000";
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(100, 20);
            this.TxtTel.TabIndex = 20;
            // 
            // TxtGsm
            // 
            this.TxtGsm.Location = new System.Drawing.Point(414, 73);
            this.TxtGsm.Mask = "(999) 000-0000";
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(100, 20);
            this.TxtGsm.TabIndex = 21;
            // 
            // TxtDepartman
            // 
            this.TxtDepartman.FormattingEnabled = true;
            this.TxtDepartman.Location = new System.Drawing.Point(150, 73);
            this.TxtDepartman.Name = "TxtDepartman";
            this.TxtDepartman.Size = new System.Drawing.Size(152, 21);
            this.TxtDepartman.TabIndex = 19;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(520, 73);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(142, 20);
            this.TxtEmail.TabIndex = 17;
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.Location = new System.Drawing.Point(28, 73);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Size = new System.Drawing.Size(116, 20);
            this.TxtYetkili.TabIndex = 18;
            // 
            // lblFirmaId
            // 
            this.lblFirmaId.BackColor = System.Drawing.Color.SteelBlue;
            this.lblFirmaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFirmaId.Location = new System.Drawing.Point(137, 33);
            this.lblFirmaId.Name = "lblFirmaId";
            this.lblFirmaId.Size = new System.Drawing.Size(176, 23);
            this.lblFirmaId.TabIndex = 16;
            this.lblFirmaId.Text = "****";
            this.lblFirmaId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.BackColor = System.Drawing.Color.SteelBlue;
            this.lblFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFirmaAdi.Location = new System.Drawing.Point(366, 33);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(176, 23);
            this.lblFirmaAdi.TabIndex = 15;
            this.lblFirmaAdi.Text = "****";
            this.lblFirmaAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // GirisId
            // 
            this.GirisId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisId.HeaderText = "GirisId";
            this.GirisId.Name = "GirisId";
            this.GirisId.Width = 61;
            // 
            // Yetkili
            // 
            this.Yetkili.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Yetkili.HeaderText = "Yetkili";
            this.Yetkili.Name = "Yetkili";
            // 
            // Departman
            // 
            this.Departman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Departman.HeaderText = "Departman";
            this.Departman.Name = "Departman";
            this.Departman.Width = 84;
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel.HeaderText = "Telefon";
            this.Tel.Name = "Tel";
            this.Tel.Width = 68;
            // 
            // Gsm
            // 
            this.Gsm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Gsm.HeaderText = "Gsm";
            this.Gsm.Name = "Gsm";
            this.Gsm.Width = 53;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 57;
            // 
            // FirmaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtGsm);
            this.Controls.Add(this.TxtDepartman);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtYetkili);
            this.Controls.Add(this.lblFirmaId);
            this.Controls.Add(this.lblFirmaAdi);
            this.Name = "FirmaDetay";
            this.Text = "FirmaDetay";
            this.Load += new System.EventHandler(this.FirmaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.MaskedTextBox TxtTel;
        private System.Windows.Forms.MaskedTextBox TxtGsm;
        private System.Windows.Forms.ComboBox TxtDepartman;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtYetkili;
        public System.Windows.Forms.Label lblFirmaId;
        public System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetkili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}