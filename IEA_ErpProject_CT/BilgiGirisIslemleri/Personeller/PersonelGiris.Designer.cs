namespace IEA_ErpProject_CT.Personeller
{
    partial class PersonelGiris
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
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScPersonel = new System.Windows.Forms.SplitContainer();
            this.btnDetayGoster = new System.Windows.Forms.Button();
            this.btnDetayEkle = new System.Windows.Forms.Button();
            this.TxtPersonelBul = new System.Windows.Forms.TextBox();
            this.TxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtSehir = new System.Windows.Forms.ComboBox();
            this.TxtDepartman = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtAdres = new System.Windows.Forms.RichTextBox();
            this.TxtUnvan = new System.Windows.Forms.TextBox();
            this.TxtPadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtGsm = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtIsBas = new System.Windows.Forms.DateTimePicker();
            this.TxtIsBit = new System.Windows.Forms.DateTimePicker();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScPersonel)).BeginInit();
            this.ScPersonel.Panel1.SuspendLayout();
            this.ScPersonel.Panel2.SuspendLayout();
            this.ScPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Adi,
            this.Unvan,
            this.Departman,
            this.Tel,
            this.Email,
            this.Sehir});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1339, 272);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.cop24x24;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(217, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 30);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.exit_64;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(1286, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 30);
            this.button5.TabIndex = 18;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.clean;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(312, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(45, 30);
            this.btnTemizle.TabIndex = 17;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Location = new System.Drawing.Point(537, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sehir:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(47, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personel Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScPersonel
            // 
            this.ScPersonel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScPersonel.Location = new System.Drawing.Point(0, 56);
            this.ScPersonel.Name = "ScPersonel";
            this.ScPersonel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScPersonel.Panel1
            // 
            this.ScPersonel.Panel1.Controls.Add(this.TxtIsBit);
            this.ScPersonel.Panel1.Controls.Add(this.TxtIsBas);
            this.ScPersonel.Panel1.Controls.Add(this.btnDetayGoster);
            this.ScPersonel.Panel1.Controls.Add(this.btnDetayEkle);
            this.ScPersonel.Panel1.Controls.Add(this.TxtPersonelBul);
            this.ScPersonel.Panel1.Controls.Add(this.TxtGsm);
            this.ScPersonel.Panel1.Controls.Add(this.TxtTelefon);
            this.ScPersonel.Panel1.Controls.Add(this.TxtSehir);
            this.ScPersonel.Panel1.Controls.Add(this.TxtDepartman);
            this.ScPersonel.Panel1.Controls.Add(this.TxtEmail);
            this.ScPersonel.Panel1.Controls.Add(this.TxtAdres);
            this.ScPersonel.Panel1.Controls.Add(this.TxtUnvan);
            this.ScPersonel.Panel1.Controls.Add(this.TxtPadi);
            this.ScPersonel.Panel1.Controls.Add(this.label5);
            this.ScPersonel.Panel1.Controls.Add(this.label4);
            this.ScPersonel.Panel1.Controls.Add(this.label9);
            this.ScPersonel.Panel1.Controls.Add(this.label11);
            this.ScPersonel.Panel1.Controls.Add(this.label8);
            this.ScPersonel.Panel1.Controls.Add(this.label7);
            this.ScPersonel.Panel1.Controls.Add(this.label6);
            this.ScPersonel.Panel1.Controls.Add(this.label10);
            this.ScPersonel.Panel1.Controls.Add(this.label3);
            this.ScPersonel.Panel1.Controls.Add(this.label2);
            // 
            // ScPersonel.Panel2
            // 
            this.ScPersonel.Panel2.Controls.Add(this.Liste);
            this.ScPersonel.Size = new System.Drawing.Size(1343, 559);
            this.ScPersonel.SplitterDistance = 279;
            this.ScPersonel.TabIndex = 19;
            // 
            // btnDetayGoster
            // 
            this.btnDetayGoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetayGoster.Location = new System.Drawing.Point(1224, 178);
            this.btnDetayGoster.Name = "btnDetayGoster";
            this.btnDetayGoster.Size = new System.Drawing.Size(96, 40);
            this.btnDetayGoster.TabIndex = 11;
            this.btnDetayGoster.Text = "Detay Goster";
            this.btnDetayGoster.UseVisualStyleBackColor = true;
            this.btnDetayGoster.Visible = false;
            // 
            // btnDetayEkle
            // 
            this.btnDetayEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetayEkle.Location = new System.Drawing.Point(1224, 224);
            this.btnDetayEkle.Name = "btnDetayEkle";
            this.btnDetayEkle.Size = new System.Drawing.Size(96, 36);
            this.btnDetayEkle.TabIndex = 10;
            this.btnDetayEkle.Text = "Detay Ekle";
            this.btnDetayEkle.UseVisualStyleBackColor = true;
            this.btnDetayEkle.Visible = false;
            // 
            // TxtPersonelBul
            // 
            this.TxtPersonelBul.Location = new System.Drawing.Point(1095, 26);
            this.TxtPersonelBul.Name = "TxtPersonelBul";
            this.TxtPersonelBul.Size = new System.Drawing.Size(234, 20);
            this.TxtPersonelBul.TabIndex = 9;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(656, 62);
            this.TxtTelefon.Mask = "(999) 000-0000";
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(163, 20);
            this.TxtTelefon.TabIndex = 8;
            // 
            // TxtSehir
            // 
            this.TxtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtSehir.FormattingEnabled = true;
            this.TxtSehir.Location = new System.Drawing.Point(656, 28);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(200, 21);
            this.TxtSehir.TabIndex = 7;
            // 
            // TxtDepartman
            // 
            this.TxtDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtDepartman.FormattingEnabled = true;
            this.TxtDepartman.Location = new System.Drawing.Point(194, 95);
            this.TxtDepartman.Name = "TxtDepartman";
            this.TxtDepartman.Size = new System.Drawing.Size(283, 21);
            this.TxtDepartman.TabIndex = 7;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(656, 136);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(163, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(194, 154);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(283, 82);
            this.TxtAdres.TabIndex = 4;
            this.TxtAdres.Text = "";
            // 
            // TxtUnvan
            // 
            this.TxtUnvan.Location = new System.Drawing.Point(194, 62);
            this.TxtUnvan.Name = "TxtUnvan";
            this.TxtUnvan.Size = new System.Drawing.Size(283, 20);
            this.TxtUnvan.TabIndex = 1;
            // 
            // TxtPadi
            // 
            this.TxtPadi.Location = new System.Drawing.Point(194, 26);
            this.TxtPadi.Name = "TxtPadi";
            this.TxtPadi.Size = new System.Drawing.Size(283, 20);
            this.TxtPadi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Location = new System.Drawing.Point(47, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adres:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(537, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gsm:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.Location = new System.Drawing.Point(537, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Telefon:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label11.Location = new System.Drawing.Point(47, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Departman:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label10.Location = new System.Drawing.Point(537, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "E-Mail:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(47, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Unvan:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.Save_icon64x64;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(30, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(45, 30);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(122, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(45, 30);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1343, 56);
            this.label1.TabIndex = 20;
            this.label1.Text = "Personel Giriş";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtGsm
            // 
            this.TxtGsm.Location = new System.Drawing.Point(656, 99);
            this.TxtGsm.Mask = "(999) 000-0000";
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(163, 20);
            this.TxtGsm.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Location = new System.Drawing.Point(537, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "İş Başlangıç Tarihi:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Location = new System.Drawing.Point(537, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "İş BitişTarihi:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtIsBas
            // 
            this.TxtIsBas.Location = new System.Drawing.Point(656, 177);
            this.TxtIsBas.Name = "TxtIsBas";
            this.TxtIsBas.Size = new System.Drawing.Size(200, 20);
            this.TxtIsBas.TabIndex = 12;
            // 
            // TxtIsBit
            // 
            this.TxtIsBit.Location = new System.Drawing.Point(656, 216);
            this.TxtIsBit.Name = "TxtIsBit";
            this.TxtIsBit.Size = new System.Drawing.Size(200, 20);
            this.TxtIsBit.TabIndex = 12;
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
            // Adi
            // 
            this.Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adi.HeaderText = "Personel Adi";
            this.Adi.Name = "Adi";
            // 
            // Unvan
            // 
            this.Unvan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Unvan.HeaderText = "Unvan";
            this.Unvan.Name = "Unvan";
            this.Unvan.Width = 64;
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
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.HeaderText = "E-Mail";
            this.Email.Name = "Email";
            this.Email.Width = 61;
            // 
            // Sehir
            // 
            this.Sehir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sehir.HeaderText = "Sehir";
            this.Sehir.Name = "Sehir";
            this.Sehir.Width = 56;
            // 
            // PersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 615);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.ScPersonel);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label1);
            this.Name = "PersonelGiris";
            this.Text = "PersonelGiris";
            this.Load += new System.EventHandler(this.PersonelGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ScPersonel.Panel1.ResumeLayout(false);
            this.ScPersonel.Panel1.PerformLayout();
            this.ScPersonel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScPersonel)).EndInit();
            this.ScPersonel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer ScPersonel;
        private System.Windows.Forms.Button btnDetayGoster;
        private System.Windows.Forms.Button btnDetayEkle;
        private System.Windows.Forms.TextBox TxtPersonelBul;
        private System.Windows.Forms.MaskedTextBox TxtTelefon;
        private System.Windows.Forms.ComboBox TxtSehir;
        private System.Windows.Forms.ComboBox TxtDepartman;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.RichTextBox TxtAdres;
        private System.Windows.Forms.TextBox TxtUnvan;
        private System.Windows.Forms.TextBox TxtPadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtGsm;
        private System.Windows.Forms.DateTimePicker TxtIsBit;
        private System.Windows.Forms.DateTimePicker TxtIsBas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
    }
}