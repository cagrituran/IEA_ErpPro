namespace IEA_ErpProject_CT.Firmalar
{
    partial class FirmaGiris
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
            this.btnDetayGoster = new System.Windows.Forms.Button();
            this.btnDetayEkle = new System.Windows.Forms.Button();
            this.TxtFirmaBul = new System.Windows.Forms.TextBox();
            this.TxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtSehir = new System.Windows.Forms.ComboBox();
            this.TxtVergiNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtVergiDairesi = new System.Windows.Forms.TextBox();
            this.TxtAdres = new System.Windows.Forms.RichTextBox();
            this.TxtFirmaTip = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.TxtFadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScFirma = new System.Windows.Forms.SplitContainer();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScFirma)).BeginInit();
            this.ScFirma.Panel1.SuspendLayout();
            this.ScFirma.Panel2.SuspendLayout();
            this.ScFirma.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetayGoster
            // 
            this.btnDetayGoster.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDetayGoster.Location = new System.Drawing.Point(1006, 0);
            this.btnDetayGoster.Name = "btnDetayGoster";
            this.btnDetayGoster.Size = new System.Drawing.Size(55, 391);
            this.btnDetayGoster.TabIndex = 11;
            this.btnDetayGoster.Text = "Detay Goster";
            this.btnDetayGoster.UseVisualStyleBackColor = true;
            this.btnDetayGoster.Visible = false;
            this.btnDetayGoster.Click += new System.EventHandler(this.btnDetayGoster_Click);
            // 
            // btnDetayEkle
            // 
            this.btnDetayEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDetayEkle.Location = new System.Drawing.Point(0, 0);
            this.btnDetayEkle.Name = "btnDetayEkle";
            this.btnDetayEkle.Size = new System.Drawing.Size(41, 391);
            this.btnDetayEkle.TabIndex = 10;
            this.btnDetayEkle.Text = "Detay Ekle";
            this.btnDetayEkle.UseVisualStyleBackColor = true;
            this.btnDetayEkle.Visible = false;
            this.btnDetayEkle.Click += new System.EventHandler(this.btnDetayEkle_Click);
            // 
            // TxtFirmaBul
            // 
            this.TxtFirmaBul.Location = new System.Drawing.Point(868, 26);
            this.TxtFirmaBul.Name = "TxtFirmaBul";
            this.TxtFirmaBul.Size = new System.Drawing.Size(132, 20);
            this.TxtFirmaBul.TabIndex = 9;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(678, 160);
            this.TxtTelefon.Mask = "(999) 000-0000";
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(163, 20);
            this.TxtTelefon.TabIndex = 8;
            // 
            // TxtSehir
            // 
            this.TxtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtSehir.FormattingEnabled = true;
            this.TxtSehir.Location = new System.Drawing.Point(194, 63);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(273, 21);
            this.TxtSehir.TabIndex = 7;
            // 
            // TxtVergiNo
            // 
            this.TxtVergiNo.Location = new System.Drawing.Point(678, 65);
            this.TxtVergiNo.Mask = "00000000000";
            this.TxtVergiNo.Name = "TxtVergiNo";
            this.TxtVergiNo.Size = new System.Drawing.Size(163, 20);
            this.TxtVergiNo.TabIndex = 6;
            // 
            // TxtVergiDairesi
            // 
            this.TxtVergiDairesi.Location = new System.Drawing.Point(678, 26);
            this.TxtVergiDairesi.Name = "TxtVergiDairesi";
            this.TxtVergiDairesi.Size = new System.Drawing.Size(163, 20);
            this.TxtVergiDairesi.TabIndex = 5;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(194, 157);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(273, 82);
            this.TxtAdres.TabIndex = 4;
            this.TxtAdres.Text = "";
            // 
            // TxtFirmaTip
            // 
            this.TxtFirmaTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtFirmaTip.FormattingEnabled = true;
            this.TxtFirmaTip.Location = new System.Drawing.Point(194, 110);
            this.TxtFirmaTip.Name = "TxtFirmaTip";
            this.TxtFirmaTip.Size = new System.Drawing.Size(273, 21);
            this.TxtFirmaTip.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.exit_64;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(1008, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 30);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.clean;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(334, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(45, 30);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // TxtFadi
            // 
            this.TxtFadi.Location = new System.Drawing.Point(194, 26);
            this.TxtFadi.Name = "TxtFadi";
            this.TxtFadi.Size = new System.Drawing.Size(273, 20);
            this.TxtFadi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Location = new System.Drawing.Point(47, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adres:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(47, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Firma Tipi:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.cop24x24;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(239, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 30);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.Save_icon64x64;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(52, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(45, 30);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.Location = new System.Drawing.Point(537, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Telefon:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Adi,
            this.Tip,
            this.Tel,
            this.Email,
            this.Sehir});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1061, 168);
            this.Liste.TabIndex = 0;
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
            // Adi
            // 
            this.Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adi.HeaderText = "Firma Adi";
            this.Adi.Name = "Adi";
            // 
            // Tip
            // 
            this.Tip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tip.HeaderText = "Firma Tipi";
            this.Tip.Name = "Tip";
            this.Tip.Width = 77;
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
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Location = new System.Drawing.Point(47, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sehir:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Location = new System.Drawing.Point(537, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vergi Dairesi:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Location = new System.Drawing.Point(537, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vergi No:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(47, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firma Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScFirma
            // 
            this.ScFirma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScFirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScFirma.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.ScFirma.Location = new System.Drawing.Point(0, 42);
            this.ScFirma.Name = "ScFirma";
            this.ScFirma.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScFirma.Panel1
            // 
            this.ScFirma.Panel1.Controls.Add(this.btnDetayGoster);
            this.ScFirma.Panel1.Controls.Add(this.btnDetayEkle);
            this.ScFirma.Panel1.Controls.Add(this.TxtFirmaBul);
            this.ScFirma.Panel1.Controls.Add(this.TxtTelefon);
            this.ScFirma.Panel1.Controls.Add(this.TxtSehir);
            this.ScFirma.Panel1.Controls.Add(this.TxtVergiNo);
            this.ScFirma.Panel1.Controls.Add(this.TxtEmail);
            this.ScFirma.Panel1.Controls.Add(this.TxtVergiDairesi);
            this.ScFirma.Panel1.Controls.Add(this.TxtAdres);
            this.ScFirma.Panel1.Controls.Add(this.TxtFirmaTip);
            this.ScFirma.Panel1.Controls.Add(this.TxtFadi);
            this.ScFirma.Panel1.Controls.Add(this.label5);
            this.ScFirma.Panel1.Controls.Add(this.label4);
            this.ScFirma.Panel1.Controls.Add(this.label9);
            this.ScFirma.Panel1.Controls.Add(this.label8);
            this.ScFirma.Panel1.Controls.Add(this.label10);
            this.ScFirma.Panel1.Controls.Add(this.label7);
            this.ScFirma.Panel1.Controls.Add(this.label6);
            this.ScFirma.Panel1.Controls.Add(this.label2);
            // 
            // ScFirma.Panel2
            // 
            this.ScFirma.Panel2.Controls.Add(this.Liste);
            this.ScFirma.Size = new System.Drawing.Size(1065, 571);
            this.ScFirma.SplitterDistance = 395;
            this.ScFirma.TabIndex = 12;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(678, 198);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(163, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label10.Location = new System.Drawing.Point(537, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "E-Mail:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(144, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(45, 30);
            this.btnGuncelle.TabIndex = 8;
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
            this.label1.Size = new System.Drawing.Size(1065, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Firma Giriş";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirmaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 613);
            this.Controls.Add(this.ScFirma);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label1);
            this.Name = "FirmaGiris";
            this.Text = "FirmaGiris";
            this.Load += new System.EventHandler(this.FirmaGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ScFirma.Panel1.ResumeLayout(false);
            this.ScFirma.Panel1.PerformLayout();
            this.ScFirma.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScFirma)).EndInit();
            this.ScFirma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDetayGoster;
        private System.Windows.Forms.Button btnDetayEkle;
        private System.Windows.Forms.TextBox TxtFirmaBul;
        private System.Windows.Forms.MaskedTextBox TxtTelefon;
        private System.Windows.Forms.ComboBox TxtSehir;
        private System.Windows.Forms.MaskedTextBox TxtVergiNo;
        private System.Windows.Forms.TextBox TxtVergiDairesi;
        private System.Windows.Forms.RichTextBox TxtAdres;
        private System.Windows.Forms.ComboBox TxtFirmaTip;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox TxtFadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer ScFirma;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
    }
}