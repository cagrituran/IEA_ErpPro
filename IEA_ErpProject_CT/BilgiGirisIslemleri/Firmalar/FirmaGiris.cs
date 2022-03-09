using IEA_ErpProject_CT.BilgiGirisIslemleri.Firmalar;
using IEA_ErpProject_CT.Entity;
using IEA_ErpProject_CT.Fonksiyonlar;
using IEA_ErpProject_CT.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject_CT.Firmalar
{
    public partial class FirmaGiris : Form
    {
        private readonly Entity.Erp102EvEntities _db = new Entity.Erp102EvEntities();
        List<tblFirmalar> FirmList;
        private int secimId = -1;
        tblFirmalar kayitBul;
        Formlar f = new Formlar();
        public FirmaGiris()
        {
            InitializeComponent();
        }

        private void FirmaGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            FirmList = (from s in _db.tblFirmalar select s).ToList();
            foreach (var item in FirmList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.FirmaTip;
                Liste.Rows[i].Cells[4].Value = item.Tel;
                Liste.Rows[i].Cells[5].Value = item.Email;
               
                if (item.Sehirler != null)
                {
                    Liste.Rows[i].Cells[6].Value = item.Sehirler.name;
                }
                i++;

            }
            Liste.AllowUserToAddRows = false; // altta bi satır boş kalmasın diye
            Liste.AllowUserToDeleteRows = false; // satır silmeye izin vermez
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void ComboDoldur()
        {
            TxtFirmaTip.DataSource = Enum.GetValues(typeof(FirmaTip));
            TxtFirmaTip.SelectedIndex = 6;
          

        

            TxtSehir.DataSource = _db.Sehirler.ToList();
            TxtSehir.ValueMember = "Id";
            TxtSehir.DisplayMember = "name";
            TxtSehir.SelectedIndex = 81;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control k in ScFirma.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";


                }
                
                

            }
            TxtFirmaTip.SelectedIndex = -1;

            btnKaydet.Enabled=true;
            TxtSehir.SelectedIndex = -1;
            btnDetayEkle.Visible = false;
            btnDetayGoster.Visible = false;
            secimId = -1;
            kayitBul = null;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if (TxtFadi.Text== "")
            {
                MessageBox.Show("Firma Adı Boş Geçilemez...");
                return;
            }
            try
            {
                tblFirmalar Firm = new tblFirmalar
                {
                    Adi = TxtFadi.Text,
                    Tel = TxtTelefon.Text,


                    Email = TxtEmail.Text,
                    FirmaTip = TxtFirmaTip.Text,
                    Adres = TxtAdres.Text,

                    VergiDairesi = TxtVergiDairesi.Text,
                    VergiNo = TxtVergiNo.Text


                };

                if (TxtSehir.SelectedValue != null) Firm.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);


                _db.tblFirmalar.Add(Firm);
                _db.SaveChanges();
                MessageBox.Show("Kayıt gerceklesti...");
                Temizle();
                Listele();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Temizle();
            if (Liste.CurrentRow != null)
            {
                secimId = (int)Liste.CurrentRow.Cells[1].Value;
                
            }
            Ac(secimId);
            btnKaydet.Enabled=false;
        }
        
        public void Ac(int id)
        {
            //Temizle();
            secimId=id;

            if (secimId < 0)
            {
                MessageBox.Show("Kayit id bulunamamıstır");
                return;

            }
            btnDetayEkle.Visible = true;
            btnDetayGoster.Visible = true;
            kayitBul = FirmList.FirstOrDefault(x => x.Id == secimId);

            try
            {
                TxtVergiNo.Text = kayitBul.VergiNo;
               if(kayitBul.Sehirler != null) TxtSehir.Text = kayitBul.Sehirler.name;
                TxtFirmaTip.Text = kayitBul.FirmaTip;
                TxtVergiDairesi.Text = kayitBul.VergiDairesi;
                TxtEmail.Text = kayitBul.Email;
                TxtAdres.Text = kayitBul.Adres;
                TxtFadi.Text = kayitBul.Adi;
                TxtTelefon.Text = kayitBul.Tel;
                TxtFirmaBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, TxtFirmaBul.ClientSize.Height);
            btn.Location = new Point(TxtFirmaBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtFirmaBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += Btn_Click;
        }
        private void Btn_Click(object sender, EventArgs e)
        {

            int id = f.FirmalarListesiAc(true);
            if (id > 0)
            {
                Ac(id);
            }
            AnaSayfa.Aktarma = -1;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            if (secimId < 0)
            {
                MessageBox.Show("Degistirilecek kayit bulunamadi");
                return;
            }
            if(kayitBul != null)
            {
                kayitBul.VergiNo = TxtVergiNo.Text;
                kayitBul.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);
                kayitBul.FirmaTip = TxtFirmaTip.Text;
                kayitBul.VergiDairesi = TxtVergiDairesi.Text;
                kayitBul.Email = TxtEmail.Text;
                kayitBul.Tel = TxtTelefon.Text;
                kayitBul.Adres = TxtAdres.Text;
                kayitBul.Adi = TxtFadi.Text;
                
               
            }
            _db.SaveChanges();
            MessageBox.Show("Guncelleme Yapildi");
            Temizle();
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (secimId < 0)
            {
                MessageBox.Show("Silinecek kaydi seciniz");
                return;
            }

            DialogResult dr = MessageBox.Show("Kayit kalici olarak silinecektir!!", "Silme İslemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dr == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void Sil()
        {
            if (secimId > 0)
            {

                _db.tblFirmalar.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydiniz Silindi...");
                Temizle();
                Listele();
            }
        }

        private void btnDetayEkle_Click(object sender, EventArgs e)
        {
            FirmaDetay frmDetay = new FirmaDetay();
            frmDetay.lblFirmaAdi.Text = kayitBul.Adi;
            frmDetay.lblFirmaId.Text = kayitBul.Id.ToString();
            frmDetay.ShowDialog();
            Close();
        }

        private void btnDetayGoster_Click(object sender, EventArgs e)
        {
            FirmaDetayGoster goster = new FirmaDetayGoster();
            goster.Fadi = TxtFadi.Text;
            goster.ShowDialog();
        }
    }
}
