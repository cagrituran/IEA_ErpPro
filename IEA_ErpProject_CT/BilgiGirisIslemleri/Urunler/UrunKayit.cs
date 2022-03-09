using IEA_ErpProject_CT.Entity;
using IEA_ErpProject_CT.Firmalar;
using IEA_ErpProject_CT.Fonksiyonlar;
using IEA_ErpProject_CT.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject_CT.BilgiGirisIslemleri.Urunler
{
    public partial class UrunKayit : Form
    {
        private readonly Entity.Erp102EvEntities _db = new Entity.Erp102EvEntities();
        private Numaralar n= new Numaralar();
        private Resimler r=new Resimler();
        private bool _resim = false;
        private int secimId = -1;
        OpenFileDialog _dosya = new OpenFileDialog();
        private Formlar f = new Formlar();
        public UrunKayit()
        {
            InitializeComponent();
        }

        private void UrunKayit_Load(object sender, EventArgs e)
        {
           TxtUrunId.Text = n.UidNo();
        }

        private void btnUrunResim_Click(object sender, EventArgs e)
        {

            ResimSec();
        }

        private void ResimSec()
        {
            _dosya.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if (_dosya.ShowDialog()==DialogResult.OK)
            {
                pbResim.ImageLocation = _dosya.FileName;
                _resim = true;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, TxtUrunId.ClientSize.Height);
            btn.Location = new Point(TxtUrunId.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtUrunId.Controls.Add(btn);

            var btnFirma = new Button();
            btnFirma.Size = new Size(25, TxtFirmaKodu.ClientSize.Height);
            btnFirma.Location = new Point(TxtFirmaKodu.ClientSize.Width - btnFirma.Width - 1);
            btnFirma.Cursor = Cursors.Default;
            btnFirma.BackgroundImage = Resources.Ara32x32;
            btnFirma.BackgroundImageLayout = ImageLayout.Stretch;
            btnFirma.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtFirmaKodu.Controls.Add(btnFirma);


            base.OnLoad(e);
            btn.Click += BtnUrun_Click;
            btnFirma.Click += BtnFirma_Click;
        }

        private void BtnFirma_Click(object sender, EventArgs e)
        {
            
            int id = f.FirmalarListesiAc(true);
            if (id > 0)
            {
                FirmaAc(id);
            }
            AnaSayfa.Aktarma = -1;
        }

        private void FirmaAc(int id)
        {
            int cariId = id;
            tblFirmalar frm = _db.tblFirmalar.First(s => s.Id==cariId);
            TxtFirmaKodu.Text = frm.Id.ToString().PadLeft(7,'0');
            TxtFirmaAdi.Text = frm.Adi;
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {

            int id = f.UrunKayitListesiAc(true);
            if (id > 0)
            {
                UrunAc(id);
            }
            AnaSayfa.Aktarma = -1;
        }

        public void UrunAc(int uid)
        {
            Temizle();
            secimId = uid;
            Liste.AllowUserToAddRows = false;
            tblUrunKayitUst lst = _db.tblUrunKayitUst.FirstOrDefault(s => s.Uid==uid);//Lambda expression nesne örneğini ref alınır
            TxtAciklamaEng.Text=lst.AciklamaEng;
            TxtAciklamaTr.Text=lst.AciklamaTr;
            TxtGirisTarih.Text=lst.GirisTarih.ToString();
            
            if (lst.FirmaId != null) {
                TxtFirmaKodu.Text=lst.FirmaId.ToString();
                TxtFirmaAdi.Text=lst.tblFirmalar.Adi;
            }
            TxtKullanimSure.Text=lst.KullanimSuresi.ToString();
            TxtUrunId.Text = lst.Uid.ToString().PadLeft(7,'0');
            TxtUrunKodu.Text=lst.UrunKodu;
            etiketId.Text = lst.Id.ToString().PadLeft(7, '0');
            if (lst.Resim !=null) pbResim.Image = r.ResimGetirme(lst.Resim);

            var Urunalt = _db.tblUrunKayitAlt.Where(x=>x.Uid==uid).ToList();
            var UrunaltTek = _db.tblUrunKayitAlt.FirstOrDefault(s=>s.Uid==uid);
            
            int i = 0;
            foreach (var  alt in Urunalt)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = alt.GMDMKodu;
                Liste.Rows[i].Cells[1].Value = alt.UNSPCKodu;
                Liste.Rows[i].Cells[2].Value = alt.SB;
                Liste.Rows[i].Cells[3].Value = alt.KullanimDisi;
                Liste.Rows[i].Cells[4].Value = alt.Ubb;
                Liste.Rows[i].Cells[5].Value = alt.Sut;
                Liste.Rows[i].Cells[6].Value = alt.SutFiyat;
                Liste.Rows[i].Cells[7].Value = alt.SutAciklama;
                Liste.Rows[i].Cells[8].Value = alt.UTS;
                Liste.Rows[i].Cells[9].Value = false;
                Liste.Rows[i].Cells[10].Value = alt.Id;

                i++;

            }
            if (UrunaltTek != null)
            {
                TxtFirmaSinif.Text = UrunaltTek.Sinif;
                TxtParaBirim.Text = UrunaltTek.ParaBirimi;
                TxtMinFiyat.Text = UrunaltTek.MinFiyat.ToString();
                TxtBirimFiyat.Text = UrunaltTek.BirimFiyat.ToString(); 
            }



            //Liste.AllowUserToAddRows = false;
            //Liste.AllowUserToDeleteRows = false;
            //Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Liste.ReadOnly = true;

            
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void YeniKaydet()
        {
            Liste.AllowUserToAddRows = false;
            if (TxtUrunId.Text=="" || TxtUrunKodu.Text=="" || TxtFirmaKodu.Text =="")
            {
                MessageBox.Show("Ilgili Alanlari Doldur");
                Liste.AllowUserToAddRows = true;
                return;
            }
            tblUrunKayitUst ust = new tblUrunKayitUst();
            ust.AciklamaEng=TxtAciklamaEng.Text;
            ust.AciklamaTr=TxtAciklamaTr.Text;
            ust.GirisTarih=TxtGirisTarih.Value;
            ust.FirmaId=int.Parse(TxtFirmaKodu.Text);
           if(pbResim.Image!=null) ust.Resim=new System.Data.Linq.Binary(r.ResimYukle(pbResim.Image)).ToArray();
            ust.Uid=int.Parse(TxtUrunId.Text);
            ust.UrunKodu=TxtUrunKodu.Text;
            ust.KullanimSuresi=int.Parse(TxtKullanimSure.Text);
            
            _db.tblUrunKayitUst.Add(ust);
            tblUrunKayitAlt[] alt = new tblUrunKayitAlt[Liste.RowCount];
            for(int i=0; i<Liste.RowCount; i++)
            {
                alt[i]=new tblUrunKayitAlt();
                alt[i].Aciklama = TxtAciklamaTr.Text;
                alt[i].BirimFiyat = Convert.ToDecimal(TxtBirimFiyat.Text);
                alt[i].BransAdi = "";
                alt[i].GMDMKodu=Liste.Rows[i].Cells[0].Value.ToString();
                alt[i].UNSPCKodu=Liste.Rows[i].Cells[1].Value.ToString();
                alt[i].KullanimDisi=Convert.ToBoolean(Liste.Rows[i].Cells[3].Value); 
                alt[i].SB=Convert.ToBoolean(Liste.Rows[i].Cells[2].Value);
                alt[i].MinFiyat = Convert.ToDecimal (TxtMinFiyat.Text);
                alt[i].ParaBirimi = TxtParaBirim.Text;
                alt[i].Sinif = TxtFirmaSinif.Text;
                alt[i].Sut =Liste.Rows[i].Cells[5].Value.ToString();
                alt[i].SutFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);
                alt[i].SutAciklama = Liste.Rows[i].Cells[7].Value.ToString();
                alt[i].Ubb = Liste.Rows[i].Cells[4].Value.ToString();
                alt[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                alt[i].Uid = int.Parse(TxtUrunId.Text);
                alt[i].UIKodu = TxtUrunKodu.Text;

                _db.tblUrunKayitAlt.Add(alt[i]);
            }

            _db.SaveChanges();
            MessageBox.Show("Kayit yaptin cikabilirsin.");
            Temizle();
        }
        private void Temizle()
        {
            foreach (Control item in spcUrunKayit.Panel1.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    if (item.Name!=TxtUrunId.Name)
                    {
                        item.Text = "";
                    }
                    
                }
                pbResim.Image = null;
                
            }
            Liste.Rows.Clear();
            //Liste.Rows.Add();
            TxtUrunId.Text = n.UidNo();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
           
            int a= Convert.ToInt32(TxtUrunId.Text);
            Liste.AllowUserToAddRows = false;
            tblUrunKayitUst ust = _db.tblUrunKayitUst.FirstOrDefault(x => x.Uid==a);
            ust.AciklamaEng=TxtAciklamaEng.Text;
            ust.AciklamaTr=TxtAciklamaTr.Text;
            ust.GirisTarih=TxtGirisTarih.Value;
            ust.FirmaId=int.Parse(TxtFirmaKodu.Text);
           // if (pbResim.Image!=null) ust.Resim=new System.Data.Linq.Binary(r.ResimYukle(pbResim.Image)).ToArray();
            ust.Uid=int.Parse(TxtUrunId.Text);
            ust.UrunKodu=TxtUrunKodu.Text;
            ust.KullanimSuresi=int.Parse(TxtKullanimSure.Text);
            _db.SaveChanges();

            List<tblUrunKayitAlt> alt = _db.tblUrunKayitAlt.Where(s => s.Uid == a).ToList();

            for (int i = 0; i < Liste.RowCount; i++)
            {
                if ((bool)Liste.Rows[i].Cells[9].Value != true) 
                {
                    int indexId = alt[i].Id;
                    alt[i] = _db.tblUrunKayitAlt.FirstOrDefault(s => s.Id == indexId);
                    alt[i].Aciklama = TxtAciklamaTr.Text;
                    alt[i].BirimFiyat = Convert.ToDecimal(TxtBirimFiyat.Text);
                    alt[i].BransAdi = "";
                    alt[i].GMDMKodu=Liste.Rows[i].Cells[0].Value.ToString();
                    alt[i].UNSPCKodu=Liste.Rows[i].Cells[1].Value.ToString();
                    alt[i].KullanimDisi=Convert.ToBoolean(Liste.Rows[i].Cells[3].Value);
                    alt[i].SB=Convert.ToBoolean(Liste.Rows[i].Cells[2].Value);
                    alt[i].MinFiyat = Convert.ToDecimal(TxtMinFiyat.Text);
                    alt[i].ParaBirimi = TxtParaBirim.Text;
                    alt[i].Sinif = TxtFirmaSinif.Text;
                    alt[i].Sut =Liste.Rows[i].Cells[5].Value.ToString();
                    alt[i].SutFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);
                    alt[i].SutAciklama = Liste.Rows[i].Cells[7].Value.ToString();
                    alt[i].Ubb = Liste.Rows[i].Cells[4].Value.ToString();
                    alt[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                    alt[i].Uid = int.Parse(TxtUrunId.Text);
                    alt[i].UIKodu = TxtUrunKodu.Text;

                    
                }
                else if ((bool)Liste.Rows[i].Cells[9].Value == true)
                {
                    alt.Add(null);
                    alt[i] = new tblUrunKayitAlt();
                    alt[i].Aciklama = TxtAciklamaTr.Text;
                    alt[i].BirimFiyat = Convert.ToDecimal(TxtBirimFiyat.Text);
                    alt[i].BransAdi = "";
                    alt[i].GMDMKodu=Liste.Rows[i].Cells[0].Value.ToString();
                    alt[i].UNSPCKodu=Liste.Rows[i].Cells[1].Value.ToString();
                    alt[i].KullanimDisi=Convert.ToBoolean(Liste.Rows[i].Cells[3].Value);
                    alt[i].SB=Convert.ToBoolean(Liste.Rows[i].Cells[2].Value);
                    alt[i].MinFiyat = Convert.ToDecimal(TxtMinFiyat.Text);
                    alt[i].ParaBirimi = TxtParaBirim.Text;
                    alt[i].Sinif = TxtFirmaSinif.Text;
                    alt[i].Sut =Liste.Rows[i].Cells[5].Value.ToString();
                    alt[i].SutFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);
                    alt[i].SutAciklama = Liste.Rows[i].Cells[7].Value.ToString();
                    alt[i].Ubb = Liste.Rows[i].Cells[4].Value.ToString();
                    alt[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                    alt[i].Uid = int.Parse(TxtUrunId.Text);
                    alt[i].UIKodu = TxtUrunKodu.Text;
                    _db.tblUrunKayitAlt.Add(alt[i]);
                }
                _db.SaveChanges();


            }
        }

        private void btnAddListeRow_Click(object sender, EventArgs e)
        {
            if (Liste.AllowUserToAddRows == true)
            {
                Liste.AllowUserToAddRows = false; 
            }
            else
            {
                Liste.AllowUserToAddRows = true;
            }
            var srg = Liste.RowCount;
            if (Liste.CurrentRow != null) Liste.Rows[srg - 1].Cells[9].Value = true;
        }

        private void btnRowsDelete_Click(object sender, EventArgs e)
        {
            if (secimId < 0)
            {
                MessageBox.Show("Once kayit secin");
            }
            int say = 0;
            tblUrunKayitAlt[] alt = new tblUrunKayitAlt[Liste.RowCount];
            for (int i = 0; i < Liste.RowCount; i++)
            {

                if ((bool)Liste.Rows[i].Cells[9].Value == true)
                {
                    var srg = _db.tblUrunKayitAlt.Find(Liste.Rows[i].Cells[10].Value);
                    _db.tblUrunKayitAlt.Remove(srg);
                    say++;
                }

            }
            if (say == 0)
            {
                MessageBox.Show("Silinecek Satir Bulunamadi,Silmek İstediğiniz Satırın Durum Hücresini İşaretleyin");
                return;
            }
            if (_db.SaveChanges() > 0)
            {
                MessageBox.Show("Satir silme islemi basarili");
                UrunAc(int.Parse(TxtUrunId.Text));
            }
            else
            {
                MessageBox.Show("Silme Basarisiz");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var srg = _db.tblUrunKayitUst.Find(int.Parse(etiketId.Text));
            var uid = _db.tblUrunKayitAlt.Where(s => s.Uid == srg.Uid);
            _db.tblUrunKayitUst.Remove(srg);
            _db.tblUrunKayitAlt.RemoveRange(uid);
            try
            {
                if (_db.SaveChanges() > 0)
                {
                    MessageBox.Show("Kayit Silme İslemi Yapildi");
                    Close();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
