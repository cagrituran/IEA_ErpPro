namespace IEA_ErpProject_CT.Stok
{
    partial class StokDurum
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
            this.spcStok = new System.Windows.Forms.SplitContainer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlSol = new System.Windows.Forms.Panel();
            this.ListeSube = new System.Windows.Forms.DataGridView();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.ListeKonsinye = new System.Windows.Forms.DataGridView();
            this.ListeUrunHareket = new System.Windows.Forms.DataGridView();
            this.tclStokDurum = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ListeStok = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sStokAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sRafAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKonsinyeAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSubeAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUrunHareket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uts = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListeStok1 = new System.Windows.Forms.DataGridView();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotSeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RafAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spcStok)).BeginInit();
            this.spcStok.Panel1.SuspendLayout();
            this.spcStok.Panel2.SuspendLayout();
            this.spcStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeSube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeKonsinye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeUrunHareket)).BeginInit();
            this.tclStokDurum.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok1)).BeginInit();
            this.SuspendLayout();
            // 
            // spcStok
            // 
            this.spcStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcStok.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcStok.Location = new System.Drawing.Point(0, 0);
            this.spcStok.Name = "spcStok";
            this.spcStok.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcStok.Panel1
            // 
            this.spcStok.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.spcStok.Panel1.Controls.Add(this.tclStokDurum);
            this.spcStok.Panel1.Controls.Add(this.splitter1);
            this.spcStok.Panel1.Controls.Add(this.pnlSol);
            // 
            // spcStok.Panel2
            // 
            this.spcStok.Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.spcStok.Panel2.Controls.Add(this.ListeSube);
            this.spcStok.Panel2.Controls.Add(this.splitter3);
            this.spcStok.Panel2.Controls.Add(this.splitter2);
            this.spcStok.Panel2.Controls.Add(this.ListeKonsinye);
            this.spcStok.Panel2.Controls.Add(this.ListeUrunHareket);
            this.spcStok.Size = new System.Drawing.Size(1220, 602);
            this.spcStok.SplitterDistance = 418;
            this.spcStok.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.InfoText;
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 414);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlSol
            // 
            this.pnlSol.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 0);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(200, 414);
            this.pnlSol.TabIndex = 0;
            // 
            // ListeSube
            // 
            this.ListeSube.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListeSube.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeSube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeSube.Location = new System.Drawing.Point(250, 0);
            this.ListeSube.Name = "ListeSube";
            this.ListeSube.Size = new System.Drawing.Size(716, 176);
            this.ListeSube.TabIndex = 4;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter3.Location = new System.Drawing.Point(966, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(10, 176);
            this.splitter3.TabIndex = 3;
            this.splitter3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ControlText;
            this.splitter2.Location = new System.Drawing.Point(240, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 176);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // ListeKonsinye
            // 
            this.ListeKonsinye.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListeKonsinye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeKonsinye.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListeKonsinye.Location = new System.Drawing.Point(976, 0);
            this.ListeKonsinye.Name = "ListeKonsinye";
            this.ListeKonsinye.Size = new System.Drawing.Size(240, 176);
            this.ListeKonsinye.TabIndex = 1;
            // 
            // ListeUrunHareket
            // 
            this.ListeUrunHareket.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListeUrunHareket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeUrunHareket.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListeUrunHareket.Location = new System.Drawing.Point(0, 0);
            this.ListeUrunHareket.Name = "ListeUrunHareket";
            this.ListeUrunHareket.Size = new System.Drawing.Size(240, 176);
            this.ListeUrunHareket.TabIndex = 0;
            // 
            // tclStokDurum
            // 
            this.tclStokDurum.Controls.Add(this.tabPage1);
            this.tclStokDurum.Controls.Add(this.tabPage2);
            this.tclStokDurum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclStokDurum.Location = new System.Drawing.Point(210, 0);
            this.tclStokDurum.Name = "tclStokDurum";
            this.tclStokDurum.SelectedIndex = 0;
            this.tclStokDurum.Size = new System.Drawing.Size(1006, 414);
            this.tclStokDurum.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tclStokDurum.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ListeStok);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "StokDurum-1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ListeStok
            // 
            this.ListeStok.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListeStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.sBarkod,
            this.sUrunKodu,
            this.sLot,
            this.sStokAdet,
            this.sRafAdet,
            this.sKonsinyeAdet,
            this.sSubeAdet,
            this.sUrunHareket,
            this.Uts,
            this.UTarih,
            this.SKTarih});
            this.ListeStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeStok.Location = new System.Drawing.Point(3, 3);
            this.ListeStok.Name = "ListeStok";
            this.ListeStok.Size = new System.Drawing.Size(992, 382);
            this.ListeStok.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // sBarkod
            // 
            this.sBarkod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sBarkod.HeaderText = "Barkod";
            this.sBarkod.Name = "sBarkod";
            this.sBarkod.Visible = false;
            // 
            // sUrunKodu
            // 
            this.sUrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sUrunKodu.HeaderText = "Urun Kodu";
            this.sUrunKodu.Name = "sUrunKodu";
            // 
            // sLot
            // 
            this.sLot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sLot.HeaderText = "Lot Seri No";
            this.sLot.Name = "sLot";
            this.sLot.Width = 79;
            // 
            // sStokAdet
            // 
            this.sStokAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sStokAdet.HeaderText = "Stok Adet";
            this.sStokAdet.Name = "sStokAdet";
            this.sStokAdet.Width = 73;
            // 
            // sRafAdet
            // 
            this.sRafAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sRafAdet.HeaderText = "Raf Adet";
            this.sRafAdet.Name = "sRafAdet";
            this.sRafAdet.Width = 69;
            // 
            // sKonsinyeAdet
            // 
            this.sKonsinyeAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sKonsinyeAdet.HeaderText = "Konsinye Adet";
            this.sKonsinyeAdet.Name = "sKonsinyeAdet";
            this.sKonsinyeAdet.Width = 92;
            // 
            // sSubeAdet
            // 
            this.sSubeAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sSubeAdet.HeaderText = "Sube Adet";
            this.sSubeAdet.Name = "sSubeAdet";
            this.sSubeAdet.Width = 76;
            // 
            // sUrunHareket
            // 
            this.sUrunHareket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sUrunHareket.HeaderText = "Urun Hareket Adet";
            this.sUrunHareket.Name = "sUrunHareket";
            this.sUrunHareket.Width = 111;
            // 
            // Uts
            // 
            this.Uts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Uts.HeaderText = "Uts";
            this.Uts.Name = "Uts";
            this.Uts.Width = 29;
            // 
            // UTarih
            // 
            this.UTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UTarih.HeaderText = "Uretim Tarihi";
            this.UTarih.Name = "UTarih";
            this.UTarih.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UTarih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UTarih.Visible = false;
            // 
            // SKTarih
            // 
            this.SKTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SKTarih.HeaderText = "Son Kullanma Tarih";
            this.SKTarih.Name = "SKTarih";
            this.SKTarih.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SKTarih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SKTarih.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ListeStok1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "StokDurum-2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListeStok1
            // 
            this.ListeStok1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeStok1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barkod,
            this.UrunKodu,
            this.LotSeri,
            this.StokAdet,
            this.RafAdet});
            this.ListeStok1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeStok1.Location = new System.Drawing.Point(3, 3);
            this.ListeStok1.Name = "ListeStok1";
            this.ListeStok1.Size = new System.Drawing.Size(757, 233);
            this.ListeStok1.TabIndex = 3;
            // 
            // Barkod
            // 
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.Name = "Barkod";
            // 
            // UrunKodu
            // 
            this.UrunKodu.HeaderText = "Urun Kodu";
            this.UrunKodu.Name = "UrunKodu";
            // 
            // LotSeri
            // 
            this.LotSeri.HeaderText = "Lot Seri No";
            this.LotSeri.Name = "LotSeri";
            // 
            // StokAdet
            // 
            this.StokAdet.HeaderText = "Stok Adet";
            this.StokAdet.Name = "StokAdet";
            // 
            // RafAdet
            // 
            this.RafAdet.HeaderText = "Raf Adet";
            this.RafAdet.Name = "RafAdet";
            // 
            // StokDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 602);
            this.Controls.Add(this.spcStok);
            this.Name = "StokDurum";
            this.Text = "StokDurum";
            this.Load += new System.EventHandler(this.StokDurum_Load);
            this.spcStok.Panel1.ResumeLayout(false);
            this.spcStok.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcStok)).EndInit();
            this.spcStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeSube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeKonsinye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeUrunHareket)).EndInit();
            this.tclStokDurum.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer spcStok;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.DataGridView ListeSube;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView ListeKonsinye;
        private System.Windows.Forms.DataGridView ListeUrunHareket;
        private System.Windows.Forms.TabControl tclStokDurum;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView ListeStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn sStokAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sRafAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKonsinyeAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSubeAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUrunHareket;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Uts;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKTarih;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ListeStok1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotSeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn RafAdet;
    }
}