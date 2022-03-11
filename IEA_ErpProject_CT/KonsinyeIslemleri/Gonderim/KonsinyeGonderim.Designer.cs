namespace IEA_ErpProject_CT.KonsinyeIslemleri.Gonderim
{
    partial class KonsinyeGonderim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.etiketId = new System.Windows.Forms.Label();
            this.TxtKonAciklama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtKonGirisTarih = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtKonGirisTuru = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtKonCariAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtKonGonderimNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKonCariTur = new System.Windows.Forms.ComboBox();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.spcUrunGiris = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotSeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SevkAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Not = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uts = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddListeRow = new System.Windows.Forms.Button();
            this.btnRowsDelete = new System.Windows.Forms.Button();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcUrunGiris)).BeginInit();
            this.spcUrunGiris.Panel1.SuspendLayout();
            this.spcUrunGiris.Panel2.SuspendLayout();
            this.spcUrunGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // etiketId
            // 
            this.etiketId.BackColor = System.Drawing.Color.SteelBlue;
            this.etiketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etiketId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.etiketId.Location = new System.Drawing.Point(378, 10);
            this.etiketId.Name = "etiketId";
            this.etiketId.Size = new System.Drawing.Size(180, 23);
            this.etiketId.TabIndex = 3;
            this.etiketId.Text = "***";
            this.etiketId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtKonAciklama
            // 
            this.TxtKonAciklama.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtKonAciklama.Location = new System.Drawing.Point(0, 243);
            this.TxtKonAciklama.Multiline = true;
            this.TxtKonAciklama.Name = "TxtKonAciklama";
            this.TxtKonAciklama.Size = new System.Drawing.Size(281, 71);
            this.TxtKonAciklama.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(0, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Aciklama";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtKonGirisTarih
            // 
            this.TxtKonGirisTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKonGirisTarih.CalendarMonthBackground = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtKonGirisTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtKonGirisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtKonGirisTarih.Location = new System.Drawing.Point(0, 203);
            this.TxtKonGirisTarih.Name = "TxtKonGirisTarih";
            this.TxtKonGirisTarih.Size = new System.Drawing.Size(281, 20);
            this.TxtKonGirisTarih.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(0, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Giris Tarihi";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtKonGirisTuru
            // 
            this.TxtKonGirisTuru.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtKonGirisTuru.FormattingEnabled = true;
            this.TxtKonGirisTuru.Items.AddRange(new object[] {
            "Normal Giris",
            "Muhtelif Giris"});
            this.TxtKonGirisTuru.Location = new System.Drawing.Point(0, 162);
            this.TxtKonGirisTuru.Name = "TxtKonGirisTuru";
            this.TxtKonGirisTuru.Size = new System.Drawing.Size(281, 21);
            this.TxtKonGirisTuru.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(0, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Konsinye Gonderim Turu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtKonCariAdi
            // 
            this.TxtKonCariAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtKonCariAdi.Location = new System.Drawing.Point(0, 106);
            this.TxtKonCariAdi.Multiline = true;
            this.TxtKonCariAdi.Name = "TxtKonCariAdi";
            this.TxtKonCariAdi.Size = new System.Drawing.Size(281, 36);
            this.TxtKonCariAdi.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(0, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Cari Adi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(0, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cari Turu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtKonGonderimNo
            // 
            this.TxtKonGonderimNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtKonGonderimNo.Location = new System.Drawing.Point(0, 25);
            this.TxtKonGonderimNo.Name = "TxtKonGonderimNo";
            this.TxtKonGonderimNo.ReadOnly = true;
            this.TxtKonGonderimNo.Size = new System.Drawing.Size(281, 20);
            this.TxtKonGonderimNo.TabIndex = 24;
            this.TxtKonGonderimNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Konsinye Gonderim No";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtKonCariTur
            // 
            this.TxtKonCariTur.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtKonCariTur.FormattingEnabled = true;
            this.TxtKonCariTur.Items.AddRange(new object[] {
            "Doktor",
            "Firma",
            "Hastane",
            "Personel",
            "Diger"});
            this.TxtKonCariTur.Location = new System.Drawing.Point(0, 65);
            this.TxtKonCariTur.Name = "TxtKonCariTur";
            this.TxtKonCariTur.Size = new System.Drawing.Size(281, 21);
            this.TxtKonCariTur.TabIndex = 26;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlUst.Controls.Add(this.btnPrint);
            this.pnlUst.Controls.Add(this.label1);
            this.pnlUst.Controls.Add(this.button5);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.button3);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnKaydet);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1369, 47);
            this.pnlUst.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.print;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Location = new System.Drawing.Point(293, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(50, 31);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(655, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Konsinye Gonderim";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.exit_64;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(1312, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 30);
            this.button5.TabIndex = 15;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.clean;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(223, 11);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(50, 31);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.cop24x24;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(156, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 31);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(91, 11);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(50, 31);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.Save_icon64x64;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(27, 11);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(50, 31);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // spcUrunGiris
            // 
            this.spcUrunGiris.BackColor = System.Drawing.Color.Teal;
            this.spcUrunGiris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcUrunGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcUrunGiris.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcUrunGiris.Location = new System.Drawing.Point(0, 47);
            this.spcUrunGiris.Name = "spcUrunGiris";
            // 
            // spcUrunGiris.Panel1
            // 
            this.spcUrunGiris.Panel1.Controls.Add(this.Liste);
            this.spcUrunGiris.Panel1.Controls.Add(this.panel1);
            // 
            // spcUrunGiris.Panel2
            // 
            this.spcUrunGiris.Panel2.Controls.Add(this.TxtKonAciklama);
            this.spcUrunGiris.Panel2.Controls.Add(this.label11);
            this.spcUrunGiris.Panel2.Controls.Add(this.TxtKonGirisTarih);
            this.spcUrunGiris.Panel2.Controls.Add(this.label10);
            this.spcUrunGiris.Panel2.Controls.Add(this.TxtKonGirisTuru);
            this.spcUrunGiris.Panel2.Controls.Add(this.label8);
            this.spcUrunGiris.Panel2.Controls.Add(this.TxtKonCariAdi);
            this.spcUrunGiris.Panel2.Controls.Add(this.label7);
            this.spcUrunGiris.Panel2.Controls.Add(this.TxtKonCariTur);
            this.spcUrunGiris.Panel2.Controls.Add(this.label6);
            this.spcUrunGiris.Panel2.Controls.Add(this.TxtKonGonderimNo);
            this.spcUrunGiris.Panel2.Controls.Add(this.label2);
            this.spcUrunGiris.Size = new System.Drawing.Size(1369, 573);
            this.spcUrunGiris.SplitterDistance = 1080;
            this.spcUrunGiris.TabIndex = 7;
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sira,
            this.Barkod,
            this.UrunKodu,
            this.LotSeri,
            this.RAdet,
            this.SevkAdet,
            this.Not,
            this.UrunId,
            this.Uts,
            this.UTarih,
            this.SKTarihi,
            this.Durum});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 42);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersVisible = false;
            this.Liste.Size = new System.Drawing.Size(1076, 527);
            this.Liste.TabIndex = 1;
            this.Liste.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellEnter);
            this.Liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Liste_EditingControlShowing);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.Name = "Sira";
            this.Sira.Visible = false;
            // 
            // Barkod
            // 
            this.Barkod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.Name = "Barkod";
            this.Barkod.Width = 66;
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunKodu.HeaderText = "Urun Kodu";
            this.UrunKodu.Name = "UrunKodu";
            // 
            // LotSeri
            // 
            this.LotSeri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LotSeri.HeaderText = "Lot Seri No";
            this.LotSeri.Name = "LotSeri";
            this.LotSeri.Width = 79;
            // 
            // RAdet
            // 
            this.RAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RAdet.HeaderText = "Raf Adet";
            this.RAdet.Name = "RAdet";
            this.RAdet.ReadOnly = true;
            this.RAdet.Width = 69;
            // 
            // SevkAdet
            // 
            this.SevkAdet.HeaderText = "Sevk Adet";
            this.SevkAdet.Name = "SevkAdet";
            // 
            // Not
            // 
            this.Not.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Not.HeaderText = "Not";
            this.Not.Name = "Not";
            this.Not.Width = 49;
            // 
            // UrunId
            // 
            this.UrunId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UrunId.HeaderText = "UrunId";
            this.UrunId.Name = "UrunId";
            this.UrunId.Visible = false;
            // 
            // Uts
            // 
            this.Uts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Uts.FalseValue = "false";
            this.Uts.HeaderText = "Uts";
            this.Uts.Name = "Uts";
            this.Uts.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Uts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Uts.TrueValue = "true";
            this.Uts.Width = 48;
            // 
            // UTarih
            // 
            this.UTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.UTarih.DefaultCellStyle = dataGridViewCellStyle3;
            this.UTarih.HeaderText = "Uretim T.";
            this.UTarih.Name = "UTarih";
            this.UTarih.Width = 70;
            // 
            // SKTarihi
            // 
            this.SKTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.SKTarihi.DefaultCellStyle = dataGridViewCellStyle4;
            this.SKTarihi.HeaderText = "Son Kullanma T.";
            this.SKTarihi.Name = "SKTarihi";
            this.SKTarihi.Width = 92;
            // 
            // Durum
            // 
            this.Durum.FalseValue = "";
            this.Durum.HeaderText = "Durum";
            this.Durum.Name = "Durum";
            this.Durum.TrueValue = "";
            this.Durum.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.etiketId);
            this.panel1.Controls.Add(this.btnAddListeRow);
            this.panel1.Controls.Add(this.btnRowsDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 42);
            this.panel1.TabIndex = 5;
            // 
            // btnAddListeRow
            // 
            this.btnAddListeRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddListeRow.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.plus;
            this.btnAddListeRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddListeRow.Location = new System.Drawing.Point(1048, 10);
            this.btnAddListeRow.Name = "btnAddListeRow";
            this.btnAddListeRow.Size = new System.Drawing.Size(25, 22);
            this.btnAddListeRow.TabIndex = 2;
            this.btnAddListeRow.UseVisualStyleBackColor = true;
            // 
            // btnRowsDelete
            // 
            this.btnRowsDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRowsDelete.Location = new System.Drawing.Point(985, 10);
            this.btnRowsDelete.Name = "btnRowsDelete";
            this.btnRowsDelete.Size = new System.Drawing.Size(57, 22);
            this.btnRowsDelete.TabIndex = 4;
            this.btnRowsDelete.Text = "Satir Sil";
            this.btnRowsDelete.UseVisualStyleBackColor = true;
            // 
            // KonsinyeGonderim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 620);
            this.Controls.Add(this.spcUrunGiris);
            this.Controls.Add(this.pnlUst);
            this.Name = "KonsinyeGonderim";
            this.Text = "KonsinyeGonderim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KonsinyeGonderim_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.spcUrunGiris.Panel1.ResumeLayout(false);
            this.spcUrunGiris.Panel2.ResumeLayout(false);
            this.spcUrunGiris.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcUrunGiris)).EndInit();
            this.spcUrunGiris.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label etiketId;
        private System.Windows.Forms.TextBox TxtKonAciklama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker TxtKonGirisTarih;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TxtKonGirisTuru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtKonCariAdi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtKonGonderimNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox TxtKonCariTur;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAddListeRow;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer spcUrunGiris;
        public System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotSeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn SevkAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Not;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Uts;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKTarihi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Durum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRowsDelete;
    }
}