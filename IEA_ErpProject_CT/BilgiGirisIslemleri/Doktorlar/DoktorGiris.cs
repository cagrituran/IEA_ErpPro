using IEA_ErpProject_CT.BilgiGirisIslemleri.Doktorlar;
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

namespace IEA_ErpProject_CT.Doktorlar
{
    public partial class DoktorGiris : Form
    {
        private int secimId;
        tblDoktorlar kayitBul;
        private readonly Entity.Erp102EvEntities _db = new Entity.Erp102EvEntities();
        Formlar f = new Formlar();
        public DoktorGiris()
        {
            InitializeComponent();
        }

        private void DoktorGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }
        List<tblDoktorlar> dktList;
        private void Listele()
        {

            Liste.Rows.Clear();
            int i = 0;
            dktList = (from s in _db.tblDoktorlar select s).ToList();
            foreach (var item in dktList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.Tel1;
                Liste.Rows[i].Cells[4].Value = item.Tel2;
                Liste.Rows[i].Cells[5].Value = item.Gsm;
                Liste.Rows[i].Cells[6].Value = item.Email;
                if (item.Sehirler != null)
                {
                    Liste.Rows[i].Cells[7].Value = item.Sehirler.name; 
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
            TxtUnvan.DataSource = Enum.GetValues(typeof(Unvan));
            TxtUnvan.SelectedIndex = -1;
            var srg = _db.tblHastaneler;

            TxtHastane1.DataSource = srg.ToList();
            TxtHastane1.ValueMember = "Id";
            TxtHastane1.DisplayMember = "Adi";
            TxtHastane1.SelectedIndex = -1;

            TxtHastane2.DataSource = srg.ToList();
            TxtHastane2.ValueMember = "Id";
            TxtHastane2.DisplayMember = "Adi";
            TxtHastane2.SelectedIndex = -1;

            TxtHastane3.DataSource = srg.ToList();
            TxtHastane3.ValueMember = "Id";
            TxtHastane3.DisplayMember = "Adi";
            TxtHastane3.SelectedIndex = -1;

            TxtSehir.DataSource = _db.Sehirler.ToList();
            TxtSehir.ValueMember = "Id";
            TxtSehir.DisplayMember = "name";
            TxtSehir.SelectedIndex = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if(TxtDadi.Text == "")
            {
                MessageBox.Show("Doktor Adı Bos Olamaz...");
                return;
            }
            try
            {
                tblDoktorlar dkt = new tblDoktorlar
                {
                    Adi = TxtDadi.Text,
                    DTarih = TxtDTarih.Value,
                    Email = TxtEmail.Text,
                    Gsm = TxtGsm.Text,
                    Muayenehane = TxtMuayenehane.Text,
                    Tel1 = TxtTel1.Text,
                    Tel2 = TxtTel2.Text,
                    Unvan = TxtUnvan.Text,
                    VergiDairesi = TxtVergiDairesi.Text,
                    VergiNo = TxtVergiNo.Text


                };
                if (TxtHastane1.SelectedValue != null) dkt.Hastane1Id = Convert.ToInt32(TxtHastane1.SelectedValue);
                if (TxtHastane2.SelectedValue != null) dkt.Hastane2Id = Convert.ToInt32(TxtHastane2.SelectedValue);
                if (TxtHastane3.SelectedValue != null) dkt.Hastane3Id = Convert.ToInt32(TxtHastane3.SelectedValue);
                if (TxtSehir.SelectedValue != null) dkt.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);

                _db.tblDoktorlar.Add(dkt);
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

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control k in ScDoktor.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";


                }
                TxtHastane1.SelectedIndex = -1;
                TxtHastane2.SelectedIndex = -1;
                TxtHastane3.SelectedIndex = -1;
                TxtSehir.SelectedIndex = -1;
                TxtUnvan.SelectedIndex = -1;

            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, txtDoktorBul.ClientSize.Height);
            btn.Location = new Point(txtDoktorBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            txtDoktorBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += Btn_Click;
        }
        private void Btn_Click(object sender, EventArgs e)
        {

            int id = f.DoktorlarListesiAc(true);
            if (id > 0)
            {
                Ac(id);
            }
            AnaSayfa.Aktarma = -1;
        }

        public void Ac(int secimId)
        {
            if (secimId < 0)
            {
                MessageBox.Show("Kayit id bulunamamıstır");
                return;

            }
            btnDetayEkle.Visible = true;
            btnDetayGoster.Visible = true;
            //tblHastaneler kayitBul = _db.tblHastaneler.Find(secimId);//dbden çektik.
            kayitBul = dktList.FirstOrDefault(x => x.Id == secimId);//Lambda expression,listeyi dbden çekmiştik o listeden bilgiyi çektik.
            try
            {
                if (kayitBul != null)
                {
                    TxtVergiNo.Text = kayitBul.VergiNo;
                    TxtTel1.Text = kayitBul.Tel1;
                    if (kayitBul.Sehirler != null) TxtSehir.Text = kayitBul.Sehirler.name;
                    TxtMuayenehane.Text = kayitBul.Muayenehane;
                    TxtUnvan.Text = kayitBul.Unvan;
                    TxtDadi.Text = kayitBul.Adi;
                    TxtTel2.Text = kayitBul.Tel2;
                    TxtVergiDairesi.Text = kayitBul.VergiDairesi;
                    txtDoktorBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');//toplamı 5 e tamamlar
                    if (kayitBul.tblHastaneler != null) TxtHastane1.Text = kayitBul.tblHastaneler.Adi;
                    if (kayitBul.tblHastaneler1 != null) TxtHastane2.Text = kayitBul.tblHastaneler1.Adi;
                    if (kayitBul.tblHastaneler2 != null) TxtHastane3.Text = kayitBul.tblHastaneler2.Adi;

                    TxtEmail.Text = kayitBul.Email;
                    TxtDTarih.Text = kayitBul.DTarih.ToString();
                    TxtGsm.Text = kayitBul.Gsm;

                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "Hata Kodu : HGListe101");
            }

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Temizle();
            if (Liste.CurrentRow != null)
            {
                secimId = (int)Liste.CurrentRow.Cells[1].Value;
                Ac(secimId);
            }
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
            if (kayitBul != null)
            {
                kayitBul.VergiNo = TxtVergiNo.Text;
                kayitBul.Tel1 = TxtTel1.Text;
                if (TxtSehir.SelectedValue != null)
                    kayitBul.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);
                kayitBul.Muayenehane = TxtMuayenehane.Text;
                kayitBul.Unvan = TxtUnvan.Text;
                kayitBul.Adi = TxtDadi.Text;
                kayitBul.Tel2 = TxtTel2.Text;
                kayitBul.VergiDairesi = TxtVergiDairesi.Text;
                if (TxtHastane1.SelectedValue != null)
                {
                    kayitBul.Hastane1Id = Convert.ToInt32(TxtHastane1.SelectedValue);
                }
                if (TxtHastane2.SelectedValue != null)
                {
                    kayitBul.Hastane2Id = Convert.ToInt32(TxtHastane2.SelectedValue);
                }
                if (TxtHastane3.SelectedValue != null)
                {
                    kayitBul.Hastane3Id = Convert.ToInt32(TxtHastane3.SelectedValue);
                }
                kayitBul.Email = TxtEmail.Text;
                kayitBul.DTarih = TxtDTarih.Value;
                kayitBul.Gsm = TxtGsm.Text;




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

                _db.tblDoktorlar.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydiniz Silindi...");
                Temizle();
                Listele();
            }
        }
    }
}
