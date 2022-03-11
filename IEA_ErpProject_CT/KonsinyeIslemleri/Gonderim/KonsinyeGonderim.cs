using IEA_ErpProject_CT.Entity.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject_CT.Fonksiyonlar;
using IEA_ErpProject_CT.Properties;

namespace IEA_ErpProject_CT.KonsinyeIslemleri.Gonderim
{
    public partial class KonsinyeGonderim : Form
    {
        private readonly Entity.Erp102EvEntities _db = new Entity.Erp102EvEntities();
        private readonly ErpProContext _code = new ErpProContext();
        private Numaralar _n = new Numaralar();
        private Formlar _f = new Formlar();

        public bool Secim = false;
        public string[] MyArray { get; set; }
        public KonsinyeGonderim()
        {
            InitializeComponent();
        }

        private void KonsinyeGonderim_Load(object sender, EventArgs e)
        {
            TxtKonGonderimNo.Text = _n.KonGonderimNo();
            MyArray = _db.tblUrunKayitUst.Select(x => x.UrunKodu).Distinct().ToArray();
        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            try
            {
                TextBox txt = e.Control as TextBox;
                if (Liste.CurrentCell.ColumnIndex == 3 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource.AddRange(MyArray);
                }
                else if (Liste.CurrentCell.ColumnIndex != 3 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.None;
                }
                //if (Liste.CurrentCell.ColumnIndex == 4)
                //{
                //    LotBul bul = new LotBul();
                //    bul.ShowDialog();

                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        private void Liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Liste.CurrentCell.ColumnIndex == 4)
            {
                LotBul bul = new LotBul();
                if (Liste.CurrentRow.Cells[3].Value != null)
                {
                    bul.ukod = Liste.CurrentRow.Cells[3].Value.ToString();
                }
                bul.ShowDialog();

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            Liste.AllowUserToAddRows = false;
            tblKonsinyeGonderim[] Kon = new tblKonsinyeGonderim[Liste.RowCount];
            for (int i = 0; i < Liste.RowCount; i++)
            {
                Kon[i] = new tblKonsinyeGonderim();
                Kon[i].CariAdi = TxtKonCariAdi.Text;
                Kon[i].Aciklama = TxtKonAciklama.Text;
                Kon[i].Adet = Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                Kon[i].CariTur = TxtKonCariTur.Text;
                Kon[i].GonderimTarih = TxtKonGirisTarih.Value;
                var brk = Liste.Rows[i].Cells[2].Value;
                Kon[i].UrunId = _db.tblStokDurum.FirstOrDefault(s => s.Barkod == brk).Id;
                //Kon[i].CreatedDate = DateTime.Now;
                //Kon[i].UpdatedDate = DateTime.Now;
                //Kon[i].CreatedUser = -1;
                //Kon[i].UpdatedUser = -1;
                //Kon[i].isDeleted = false;
                Kon[i].CariId = 1;

            }
            _code.TblKonsinyeGonderimler.AddRange(Kon);
            _code.SaveChanges();
            MessageBox.Show(@"Kayit İslemi Basarili");
        }

        protected override void OnLoad(EventArgs e)
        {
            var btnGonderim = new Button();
            btnGonderim.Size = new Size(22, TxtKonGonderimNo.ClientSize.Height);
            btnGonderim.Location = new Point(TxtKonGonderimNo.ClientSize.Width - btnGonderim.Width - 1);
            btnGonderim.Cursor = Cursors.Default;
            btnGonderim.BackgroundImage = Resources.Ara32x32;
            btnGonderim.BackgroundImageLayout = ImageLayout.Stretch;
            btnGonderim.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtKonGonderimNo.Controls.Add(btnGonderim);
            base.OnLoad(e);
            btnGonderim.Click += btnGonderim_Click;

            var btn = new Button();
            btn.Size = new Size(22, TxtKonCariAdi.ClientSize.Height);
            btn.Location = new Point(TxtKonCariAdi.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtKonCariAdi.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += btn_Click;

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int CariId = -1;
            switch (TxtKonCariTur.Text)
            {
                case "Hastane":
                    CariId = _f.HastanelerListesiAc(true);
                    if (CariId > 0)
                    {
                        HastaneAc(CariId);
                    }
                    break;
                case "Doktor":
                    CariId = _f.DoktorlarListesiAc(true);
                    if (CariId > 0)
                    {
                        DoktorAc(CariId);
                    }
                    break;
                case "Personel":
                    //CariId = f.PersonellerListesiAc(true);
                    //if (CariId > 0)
                    //{
                    //    DoktorAc(CariId);
                    //}
                    CariId = _f.PersonellerListesiAc(true);
                    if (CariId > 0)
                    {
                        PersonelAc(CariId);
                    }
                    break;
                case "Firma":
                    CariId = _f.FirmalarListesiAc(true);
                    if (CariId > 0)
                    {
                        FirmaAc(CariId);
                    }
                    break;
                case "Diger":
                    TxtKonCariAdi.Text = "Bilinmiyor";
                    break;
            }
            AnaSayfa.Aktarma = -1;
        }

        private void FirmaAc(int cariId)
        {
            TxtKonCariAdi.Text = _db.tblFirmalar.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void PersonelAc(int cariId)
        {
            TxtKonCariAdi.Text = _db.tblPersoneller.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void DoktorAc(int cariId)
        {
            TxtKonCariAdi.Text = _db.tblDoktorlar.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void HastaneAc(int cariId)
        {
            TxtKonCariAdi.Text = _db.tblHastaneler.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void btnGonderim_Click(object sender, EventArgs e)
        {
            int id = _f.KonGirisListesiAc(true);
            if (id > 0)
            {
                KonGonderimAc(id);
            }
            AnaSayfa.Aktarma = -1;
        }

        public void  KonGonderimAc(int id)
        {
            Liste.Rows.Clear();
            var srg = _code.TblKonsinyeGonderimler.Where(s => s.GonderimId == id).ToList();
            var srgStok = _db.tblStokDurum.ToList();
            
            if (srg.Count > 0)
            {
                
                for (int i = 0; i < srg.Count; i++)
                {
                    
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = srg[i].Id;
                    Liste.Rows[i].Cells[1].Value = i+1;
                    Liste.Rows[i].Cells[2].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.Barkod;
                    Liste.Rows[i].Cells[3].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.UrunKodu;
                    Liste.Rows[i].Cells[4].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.LotSeriNo;
                    Liste.Rows[i].Cells[5].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.RafAdet;
                    Liste.Rows[i].Cells[6].Value = srg[i].Adet;
                    Liste.Rows[i].Cells[7].Value = srg[i].Aciklama;
                    Liste.Rows[i].Cells[8].Value = srg[i].UrunId;
                    Liste.Rows[i].Cells[9].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.Uts;
                    Liste.Rows[i].Cells[10].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.UTarih; 
                    Liste.Rows[i].Cells[11].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.SKTarih;
                    TxtKonGonderimNo.Text = srg[i].GonderimId.ToString();
                    TxtKonCariTur.Text = srg[i].CariTur;
                    TxtKonCariAdi.Text = srg[i].CariAdi;
                    TxtKonGirisTarih.Text = srg[i].GonderimTarih.ToShortDateString();
                    TxtKonAciklama.Text = "";
                    //TxtKonGonderimTuru.Text ---> db ekle
                    //Liste.Rows[i].Cells[12].Value = false;
                }
            }
        }
    }
}
