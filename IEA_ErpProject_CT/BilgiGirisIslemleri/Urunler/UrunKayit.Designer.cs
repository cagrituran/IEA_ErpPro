namespace IEA_ErpProject_CT.BilgiGirisIslemleri.Urunler
{
    partial class UrunKayit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.spcUrunKayit = new System.Windows.Forms.SplitContainer();
            this.TxtParaBirim = new System.Windows.Forms.ComboBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnUrunResim = new System.Windows.Forms.Button();
            this.TxtGirisTarih = new System.Windows.Forms.DateTimePicker();
            this.TxtFirmaSinif = new System.Windows.Forms.TextBox();
            this.TxtMinFiyat = new System.Windows.Forms.TextBox();
            this.TxtBirimFiyat = new System.Windows.Forms.TextBox();
            this.TxtKullanimSure = new System.Windows.Forms.TextBox();
            this.TxtAciklamaTr = new System.Windows.Forms.TextBox();
            this.TxtAciklamaEng = new System.Windows.Forms.TextBox();
            this.TxtUrunKodu = new System.Windows.Forms.TextBox();
            this.TxtFirmaAdi = new System.Windows.Forms.TextBox();
            this.TxtFirmaKodu = new System.Windows.Forms.TextBox();
            this.TxtUrunId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.pnlListe = new System.Windows.Forms.Panel();
            this.btnAddListeRow = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnRowsDelete = new System.Windows.Forms.Button();
            this.GMDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNSPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.KulDisi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UBB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUTFIYAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUTACIKLAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UTS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etiketId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spcUrunKayit)).BeginInit();
            this.spcUrunKayit.Panel1.SuspendLayout();
            this.spcUrunKayit.Panel2.SuspendLayout();
            this.spcUrunKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlListe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1022, 56);
            this.label1.TabIndex = 14;
            this.label1.Text = "Urun Kayit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spcUrunKayit
            // 
            this.spcUrunKayit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcUrunKayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcUrunKayit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcUrunKayit.Location = new System.Drawing.Point(0, 56);
            this.spcUrunKayit.Name = "spcUrunKayit";
            this.spcUrunKayit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcUrunKayit.Panel1
            // 
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtParaBirim);
            this.spcUrunKayit.Panel1.Controls.Add(this.pbResim);
            this.spcUrunKayit.Panel1.Controls.Add(this.btnUrunResim);
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtGirisTarih);
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtFirmaSinif);
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtMinFiyat);
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtBirimFiyat);
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtKullanimSure);
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtAciklamaTr);
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtAciklamaEng);
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtUrunKodu);
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtFirmaAdi);
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtFirmaKodu);
            this.spcUrunKayit.Panel1.Controls.Add(this.TxtUrunId);
            this.spcUrunKayit.Panel1.Controls.Add(this.label6);
            this.spcUrunKayit.Panel1.Controls.Add(this.label5);
            this.spcUrunKayit.Panel1.Controls.Add(this.label10);
            this.spcUrunKayit.Panel1.Controls.Add(this.label9);
            this.spcUrunKayit.Panel1.Controls.Add(this.label8);
            this.spcUrunKayit.Panel1.Controls.Add(this.label4);
            this.spcUrunKayit.Panel1.Controls.Add(this.label2);
            this.spcUrunKayit.Panel1.Controls.Add(this.label11);
            this.spcUrunKayit.Panel1.Controls.Add(this.label13);
            this.spcUrunKayit.Panel1.Controls.Add(this.label12);
            this.spcUrunKayit.Panel1.Controls.Add(this.label3);
            // 
            // spcUrunKayit.Panel2
            // 
            this.spcUrunKayit.Panel2.Controls.Add(this.Liste);
            this.spcUrunKayit.Panel2.Controls.Add(this.pnlListe);
            this.spcUrunKayit.Size = new System.Drawing.Size(1022, 444);
            this.spcUrunKayit.SplitterDistance = 257;
            this.spcUrunKayit.TabIndex = 20;
            // 
            // TxtParaBirim
            // 
            this.TxtParaBirim.FormattingEnabled = true;
            this.TxtParaBirim.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "TRY",
            "GBP",
            "RUB",
            "JPY",
            "CNY"});
            this.TxtParaBirim.Location = new System.Drawing.Point(328, 202);
            this.TxtParaBirim.Name = "TxtParaBirim";
            this.TxtParaBirim.Size = new System.Drawing.Size(121, 21);
            this.TxtParaBirim.TabIndex = 5;
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(824, 15);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(133, 180);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 4;
            this.pbResim.TabStop = false;
            // 
            // btnUrunResim
            // 
            this.btnUrunResim.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUrunResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunResim.Location = new System.Drawing.Point(824, 211);
            this.btnUrunResim.Name = "btnUrunResim";
            this.btnUrunResim.Size = new System.Drawing.Size(133, 36);
            this.btnUrunResim.TabIndex = 3;
            this.btnUrunResim.Text = "Ürün Resim Ekle";
            this.btnUrunResim.UseVisualStyleBackColor = false;
            this.btnUrunResim.Click += new System.EventHandler(this.btnUrunResim_Click);
            // 
            // TxtGirisTarih
            // 
            this.TxtGirisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtGirisTarih.Location = new System.Drawing.Point(146, 134);
            this.TxtGirisTarih.Name = "TxtGirisTarih";
            this.TxtGirisTarih.Size = new System.Drawing.Size(176, 20);
            this.TxtGirisTarih.TabIndex = 2;
            // 
            // TxtFirmaSinif
            // 
            this.TxtFirmaSinif.Location = new System.Drawing.Point(464, 138);
            this.TxtFirmaSinif.Name = "TxtFirmaSinif";
            this.TxtFirmaSinif.Size = new System.Drawing.Size(176, 20);
            this.TxtFirmaSinif.TabIndex = 1;
            // 
            // TxtMinFiyat
            // 
            this.TxtMinFiyat.Location = new System.Drawing.Point(146, 227);
            this.TxtMinFiyat.Name = "TxtMinFiyat";
            this.TxtMinFiyat.Size = new System.Drawing.Size(176, 20);
            this.TxtMinFiyat.TabIndex = 1;
            // 
            // TxtBirimFiyat
            // 
            this.TxtBirimFiyat.Location = new System.Drawing.Point(146, 203);
            this.TxtBirimFiyat.Name = "TxtBirimFiyat";
            this.TxtBirimFiyat.Size = new System.Drawing.Size(176, 20);
            this.TxtBirimFiyat.TabIndex = 1;
            // 
            // TxtKullanimSure
            // 
            this.TxtKullanimSure.Location = new System.Drawing.Point(146, 173);
            this.TxtKullanimSure.Name = "TxtKullanimSure";
            this.TxtKullanimSure.Size = new System.Drawing.Size(176, 20);
            this.TxtKullanimSure.TabIndex = 1;
            // 
            // TxtAciklamaTr
            // 
            this.TxtAciklamaTr.Location = new System.Drawing.Point(146, 99);
            this.TxtAciklamaTr.Name = "TxtAciklamaTr";
            this.TxtAciklamaTr.Size = new System.Drawing.Size(494, 20);
            this.TxtAciklamaTr.TabIndex = 1;
            // 
            // TxtAciklamaEng
            // 
            this.TxtAciklamaEng.Location = new System.Drawing.Point(146, 68);
            this.TxtAciklamaEng.Name = "TxtAciklamaEng";
            this.TxtAciklamaEng.Size = new System.Drawing.Size(494, 20);
            this.TxtAciklamaEng.TabIndex = 1;
            // 
            // TxtUrunKodu
            // 
            this.TxtUrunKodu.Location = new System.Drawing.Point(146, 43);
            this.TxtUrunKodu.Name = "TxtUrunKodu";
            this.TxtUrunKodu.Size = new System.Drawing.Size(176, 20);
            this.TxtUrunKodu.TabIndex = 1;
            // 
            // TxtFirmaAdi
            // 
            this.TxtFirmaAdi.Location = new System.Drawing.Point(464, 41);
            this.TxtFirmaAdi.Name = "TxtFirmaAdi";
            this.TxtFirmaAdi.Size = new System.Drawing.Size(176, 20);
            this.TxtFirmaAdi.TabIndex = 1;
            // 
            // TxtFirmaKodu
            // 
            this.TxtFirmaKodu.Location = new System.Drawing.Point(464, 13);
            this.TxtFirmaKodu.Name = "TxtFirmaKodu";
            this.TxtFirmaKodu.Size = new System.Drawing.Size(176, 20);
            this.TxtFirmaKodu.TabIndex = 1;
            // 
            // TxtUrunId
            // 
            this.TxtUrunId.Location = new System.Drawing.Point(146, 13);
            this.TxtUrunId.Name = "TxtUrunId";
            this.TxtUrunId.ReadOnly = true;
            this.TxtUrunId.Size = new System.Drawing.Size(176, 20);
            this.TxtUrunId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(7, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Min Fiyat:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(7, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Birim Fiyat:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.SteelBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(7, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kullanim Süresi";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.SteelBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(7, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giriş Tarih:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(10, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Açıklama Tr:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(10, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Açıklama Eng:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Kodu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.SteelBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(345, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Firma Kodu:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.SteelBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(345, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Sınıfı:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.SteelBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(345, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Firma Adı:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GMDN,
            this.UNSPC,
            this.SB,
            this.KulDisi,
            this.UBB,
            this.SUT,
            this.SUTFIYAT,
            this.SUTACIKLAMA,
            this.UTS,
            this.Durum,
            this.id});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 24);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1018, 155);
            this.Liste.TabIndex = 0;
            // 
            // pnlListe
            // 
            this.pnlListe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlListe.Controls.Add(this.btnRowsDelete);
            this.pnlListe.Controls.Add(this.btnAddListeRow);
            this.pnlListe.Controls.Add(this.etiketId);
            this.pnlListe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListe.Location = new System.Drawing.Point(0, 0);
            this.pnlListe.Name = "pnlListe";
            this.pnlListe.Size = new System.Drawing.Size(1018, 24);
            this.pnlListe.TabIndex = 1;
            // 
            // btnAddListeRow
            // 
            this.btnAddListeRow.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.plus;
            this.btnAddListeRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddListeRow.Location = new System.Drawing.Point(973, 3);
            this.btnAddListeRow.Name = "btnAddListeRow";
            this.btnAddListeRow.Size = new System.Drawing.Size(23, 18);
            this.btnAddListeRow.TabIndex = 0;
            this.btnAddListeRow.UseVisualStyleBackColor = true;
            this.btnAddListeRow.Click += new System.EventHandler(this.btnAddListeRow_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.exit_64;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(953, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 30);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.clean;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(316, 14);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(45, 30);
            this.btnTemizle.TabIndex = 18;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.cop24x24;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(209, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 30);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.Save_icon64x64;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(12, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(45, 30);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject_CT.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(114, 14);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(45, 30);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnRowsDelete
            // 
            this.btnRowsDelete.Location = new System.Drawing.Point(906, 2);
            this.btnRowsDelete.Name = "btnRowsDelete";
            this.btnRowsDelete.Size = new System.Drawing.Size(51, 21);
            this.btnRowsDelete.TabIndex = 1;
            this.btnRowsDelete.Text = "Satir Sil";
            this.btnRowsDelete.UseVisualStyleBackColor = true;
            this.btnRowsDelete.Click += new System.EventHandler(this.btnRowsDelete_Click);
            // 
            // GMDN
            // 
            this.GMDN.HeaderText = "GMDN";
            this.GMDN.Name = "GMDN";
            // 
            // UNSPC
            // 
            this.UNSPC.HeaderText = "UNSPC";
            this.UNSPC.Name = "UNSPC";
            // 
            // SB
            // 
            this.SB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SB.HeaderText = "SB";
            this.SB.Name = "SB";
            this.SB.Width = 27;
            // 
            // KulDisi
            // 
            this.KulDisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.KulDisi.HeaderText = "Kul Disi";
            this.KulDisi.Name = "KulDisi";
            this.KulDisi.Width = 48;
            // 
            // UBB
            // 
            this.UBB.HeaderText = "UBB";
            this.UBB.Name = "UBB";
            // 
            // SUT
            // 
            this.SUT.HeaderText = "SUT";
            this.SUT.Name = "SUT";
            // 
            // SUTFIYAT
            // 
            dataGridViewCellStyle1.Format = "C4";
            dataGridViewCellStyle1.NullValue = null;
            this.SUTFIYAT.DefaultCellStyle = dataGridViewCellStyle1;
            this.SUTFIYAT.HeaderText = "SUTFIYAT";
            this.SUTFIYAT.Name = "SUTFIYAT";
            // 
            // SUTACIKLAMA
            // 
            this.SUTACIKLAMA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUTACIKLAMA.HeaderText = "SUTACIKLAMA";
            this.SUTACIKLAMA.Name = "SUTACIKLAMA";
            // 
            // UTS
            // 
            this.UTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UTS.HeaderText = "UTS";
            this.UTS.Name = "UTS";
            this.UTS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UTS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UTS.Width = 54;
            // 
            // Durum
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.NullValue = false;
            this.Durum.DefaultCellStyle = dataGridViewCellStyle2;
            this.Durum.HeaderText = "Durum";
            this.Durum.Name = "Durum";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // etiketId
            // 
            this.etiketId.BackColor = System.Drawing.Color.SteelBlue;
            this.etiketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etiketId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.etiketId.Location = new System.Drawing.Point(460, 0);
            this.etiketId.Name = "etiketId";
            this.etiketId.Size = new System.Drawing.Size(180, 24);
            this.etiketId.TabIndex = 0;
            this.etiketId.Text = "***";
            this.etiketId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UrunKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 500);
            this.Controls.Add(this.spcUrunKayit);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label1);
            this.Name = "UrunKayit";
            this.Text = "UrunKayit";
            this.Load += new System.EventHandler(this.UrunKayit_Load);
            this.spcUrunKayit.Panel1.ResumeLayout(false);
            this.spcUrunKayit.Panel1.PerformLayout();
            this.spcUrunKayit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcUrunKayit)).EndInit();
            this.spcUrunKayit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlListe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.SplitContainer spcUrunKayit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Button btnUrunResim;
        private System.Windows.Forms.DateTimePicker TxtGirisTarih;
        private System.Windows.Forms.TextBox TxtFirmaSinif;
        private System.Windows.Forms.TextBox TxtKullanimSure;
        private System.Windows.Forms.TextBox TxtAciklamaTr;
        private System.Windows.Forms.TextBox TxtAciklamaEng;
        private System.Windows.Forms.TextBox TxtUrunKodu;
        private System.Windows.Forms.TextBox TxtFirmaAdi;
        private System.Windows.Forms.TextBox TxtFirmaKodu;
        private System.Windows.Forms.TextBox TxtUrunId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox TxtParaBirim;
        private System.Windows.Forms.TextBox TxtMinFiyat;
        private System.Windows.Forms.TextBox TxtBirimFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlListe;
        private System.Windows.Forms.Button btnAddListeRow;
        private System.Windows.Forms.Button btnRowsDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn GMDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNSPC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn KulDisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUTFIYAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUTACIKLAMA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UTS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label etiketId;
    }
}