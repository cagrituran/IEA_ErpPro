using IEA_ErpProject_CT.BilgiGirisIslemleri.Hastaneler;
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

namespace IEA_ErpProject_CT.Hastaneler
{
    public partial class HastaneGiris : Form
    {
        private readonly Entity.Erp102EvEntities _db = new Entity.Erp102EvEntities();
        private tblHastaneler kayitbul;
        private int secimId=-1;
        Formlar f = new Formlar();
        public HastaneGiris()
        {
            InitializeComponent();
        }

        private void HastaneGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void ComboDoldur()
        {
            txtTipAdi.DataSource = _db.tblHastanetip.ToList();
            txtTipAdi.ValueMember = "Id";
            txtTipAdi.DisplayMember = "TipAdi";
            txtTipAdi.SelectedIndex = -1;

            txtSehirAdi.DataSource = _db.Sehirler.ToList();
            txtSehirAdi.ValueMember="Id";
            txtSehirAdi.DisplayMember = "name";
            txtSehirAdi.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if(TxtHadi.Text=="")
            {
                return;
            }
            try
            {

                tblHastaneler hst = new tblHastaneler();
                hst.Adi = TxtHadi.Text;
                hst.Adres = TxtAdres.Text;
                hst.Tel = TxtTelefon.Text;
                hst.CariAdi = TxtCari.Text;
                hst.VergiNo = TxtVergiNo.Text;
                hst.VergiDairesi = TxtVergiDairesi.Text;
                hst.SehirId = (int)txtSehirAdi.SelectedValue;
                hst.TipID = (int)txtTipAdi.SelectedValue;

                _db.tblHastaneler.Add(hst);
                _db.SaveChanges();
                MessageBox.Show("Kayıt İslemi Gerceklestirildi...");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "HataKodu : HGKex100");
            }
            Listele();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control item in ScMenu.Panel1.Controls)
            {
                if(item is ComboBox || item is TextBox || item is RichTextBox || item is MaskedTextBox)
                {
                    item.Text = "";
                }
                txtSehirAdi.SelectedIndex = -1;
                txtTipAdi.SelectedIndex = -1;
                secimId = -1;
                kayitbul = null;
                btnDetayEkle.Visible = false;
                btnDetayGoster.Visible = false;

            }
        }
        List<tblHastaneler> hstList;
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            hstList = (from s in _db.tblHastaneler select s).ToList();
            foreach (var item in hstList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i+1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.tblHastanetip.TipAdi;
                Liste.Rows[i].Cells[4].Value = item.Tel;
                Liste.Rows[i].Cells[5].Value = item.Sehirler.name;
                i++;
                
            }
            Liste.AllowUserToAddRows = false; // altta bi satır boş kalmasın diye
            Liste.AllowUserToDeleteRows = false; // satır silmeye izin vermez
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null)
            {
                secimId = (int)Liste.CurrentRow.Cells[1].Value;
                Ac(secimId);

            }
          
        }
        
        public void Ac(int secimId)

        {
            
            if (secimId<0)
            {
                MessageBox.Show("Kayit Bulunamamistir...");
                return;
            }
            btnDetayEkle.Visible = true;
            btnDetayGoster.Visible = true;
            kayitbul = hstList.FirstOrDefault(x=>x.Id == secimId);
            try
            {
                if (kayitbul != null)
                {
                    TxtHadi.Text = kayitbul.Adi;
                    TxtCari.Text = kayitbul.CariAdi;
                    TxtAdres.Text = kayitbul.Adres;
                    TxtTelefon.Text = kayitbul.Tel;
                    TxtVergiDairesi.Text = kayitbul.VergiDairesi;
                    TxtVergiNo.Text = kayitbul.VergiNo;
                    txtSehirAdi.Text = kayitbul.Sehirler.name;
                    txtTipAdi.Text = kayitbul.tblHastanetip.TipAdi;
                    TxtHastaneBul.Text = kayitbul.Id.ToString().PadLeft(5, '0');
                }
                
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "Hata Kodu : HGLST101");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            if (AnaSayfa.Aktarma < 0)
            {
                MessageBox.Show("Degistirilecek kayit bulunamadi");
                return;
            }
            if (kayitbul != null)
            {
                kayitbul.Adi = TxtHadi.Text;
                kayitbul.Adres = TxtAdres.Text;
                kayitbul.Tel = TxtTelefon.Text;
                kayitbul.CariAdi = TxtCari.Text;
                kayitbul.VergiDairesi = TxtVergiDairesi.Text;
                kayitbul.SehirId = (int?)txtSehirAdi.SelectedValue;
                kayitbul.TipID = (int?)txtTipAdi.SelectedValue;
                kayitbul.VergiNo = TxtVergiNo.Text;
            }
            _db.SaveChanges();
            MessageBox.Show("Guncelleme Yapildi");
            Temizle();
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AnaSayfa.Aktarma < 0)
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
            if (AnaSayfa.Aktarma > 0)
            {

                _db.tblHastaneler.Remove(kayitbul);
                _db.SaveChanges();
                MessageBox.Show("Kaydiniz Silindi...");
                Temizle();
                Listele();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(22, TxtHastaneBul.ClientSize.Height);
            btn.Location = new Point(TxtHastaneBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtHastaneBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = f.HastanelerListesiAc(true);
            if (id > 0)
            {
                Ac(id);
            }
            AnaSayfa.Aktarma = -1;
        }

        private void btnDetayEkle_Click(object sender, EventArgs e)
        {
            string adi = "";
            int id = -1;
            if (secimId>0)

            {
                adi = TxtHadi.Text;
                id = int.Parse(TxtHastaneBul.Text);
                f.HastaneDetayAc(adi, id);
            }
            else
            {
                MessageBox.Show("Once bir kayit secin!!!");
                return;
            }
        }

        private void btnDetayGoster_Click(object sender, EventArgs e)
        {
            HastaneDetayGoster goster = new HastaneDetayGoster();
            goster.Hadi = TxtHadi.Text;
            goster.ShowDialog();

        }

        
    }
}
