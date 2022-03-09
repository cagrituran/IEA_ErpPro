namespace IEA_ErpProject_CT.BilgiGirisIslemleri.Hastaneler
{
    partial class HastaneDetay
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
            this.lblHastaneAdi = new System.Windows.Forms.Label();
            this.lblHastaneId = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.TxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtGsm = new System.Windows.Forms.MaskedTextBox();
            this.TxtDepartman = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtYetkili = new System.Windows.Forms.TextBox();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.btnKayit = new System.Windows.Forms.Button();
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
            // lblHastaneAdi
            // 
            this.lblHastaneAdi.BackColor = System.Drawing.Color.SteelBlue;
            this.lblHastaneAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaneAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHastaneAdi.Location = new System.Drawing.Point(350, 37);
            this.lblHastaneAdi.Name = "lblHastaneAdi";
            this.lblHastaneAdi.Size = new System.Drawing.Size(176, 23);
            this.lblHastaneAdi.TabIndex = 4;
            this.lblHastaneAdi.Text = "****";
            this.lblHastaneAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHastaneId
            // 
            this.lblHastaneId.BackColor = System.Drawing.Color.SteelBlue;
            this.lblHastaneId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaneId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHastaneId.Location = new System.Drawing.Point(121, 37);
            this.lblHastaneId.Name = "lblHastaneId";
            this.lblHastaneId.Size = new System.Drawing.Size(176, 23);
            this.lblHastaneId.TabIndex = 5;
            this.lblHastaneId.Text = "****";
            this.lblHastaneId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(670, 75);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(292, 77);
            this.TxtTel.Mask = "(999) 000-0000";
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(100, 20);
            this.TxtTel.TabIndex = 10;
            // 
            // TxtGsm
            // 
            this.TxtGsm.Location = new System.Drawing.Point(398, 77);
            this.TxtGsm.Mask = "(999) 000-0000";
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(100, 20);
            this.TxtGsm.TabIndex = 11;
            // 
            // TxtDepartman
            // 
            this.TxtDepartman.FormattingEnabled = true;
            this.TxtDepartman.Location = new System.Drawing.Point(134, 77);
            this.TxtDepartman.Name = "TxtDepartman";
            this.TxtDepartman.Size = new System.Drawing.Size(152, 21);
            this.TxtDepartman.TabIndex = 9;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(504, 77);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(142, 20);
            this.TxtEmail.TabIndex = 7;
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.Location = new System.Drawing.Point(12, 77);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Size = new System.Drawing.Size(116, 20);
            this.TxtYetkili.TabIndex = 8;
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
            this.Liste.Location = new System.Drawing.Point(48, 271);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(708, 150);
            this.Liste.TabIndex = 13;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(670, 233);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 23);
            this.btnKayit.TabIndex = 14;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
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
            // HastaneDetay
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
            this.Controls.Add(this.lblHastaneId);
            this.Controls.Add(this.lblHastaneAdi);
            this.Name = "HastaneDetay";
            this.Text = "HastaneDetay";
            this.Load += new System.EventHandler(this.HastaneDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblHastaneAdi;
        public System.Windows.Forms.Label lblHastaneId;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.MaskedTextBox TxtTel;
        private System.Windows.Forms.MaskedTextBox TxtGsm;
        private System.Windows.Forms.ComboBox TxtDepartman;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtYetkili;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetkili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}