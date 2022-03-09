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

namespace IEA_ErpProject_CT.Personeller
{
    public partial class PersonelGiris : Form
    {
        private readonly Entity.Erp102EvEntities _db = new Entity.Erp102EvEntities();
        List<tblPersoneller> PersList;
        private int secimId;
        tblPersoneller kayitBul;
        Formlar f = new Formlar();
        public PersonelGiris()
        {
            InitializeComponent();
        }

        private void PersonelGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            PersList = (from s in _db.tblPersoneller select s).ToList();
            foreach (var item in PersList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.Unvan;
                if (item.tblDepartmanlar !=null)
                {
                    Liste.Rows[i].Cells[4].Value = item.tblDepartmanlar.Adi; 
                }
                Liste.Rows[i].Cells[5].Value = item.Tel;
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
            TxtDepartman.DataSource = _db.tblDepartmanlar.ToList();
            TxtDepartman.ValueMember = "Id";
            TxtDepartman.DisplayMember = "Adi";
            TxtDepartman.SelectedIndex = -1;

            TxtSehir.DataSource = _db.Sehirler.ToList();
            TxtSehir.ValueMember = "Id";
            TxtSehir.DisplayMember = "name";
            TxtSehir.SelectedIndex = 81;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if (TxtPadi.Text == "")
            {
                MessageBox.Show("Personel Adı Boş Geçilemez...");
                return;
            }
            try
            {
                tblPersoneller Pers = new tblPersoneller
                {
                    Adi = TxtPadi.Text,
                    Unvan = TxtUnvan.Text,
                    Adres = TxtAdres.Text,
                    Tel = TxtTelefon.Text,
                    Gsm = TxtGsm.Text, 
                    Email = TxtEmail.Text,
                    IsBaslangicTarih = TxtIsBas.Value,
                    IsBitisTarih = TxtIsBit.Value,
                   
                    

                    


                };

                if (TxtSehir.SelectedValue != null) Pers.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);
                if (TxtDepartman.SelectedValue != null) Pers.DepartmanId = Convert.ToInt32(TxtSehir.SelectedValue);



                _db.tblPersoneller.Add(Pers);
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

        private void Temizle()
        {
            foreach (Control k in ScPersonel.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";


                }



            }
            TxtDepartman.SelectedIndex = -1;
            TxtSehir.SelectedIndex = 81;
            btnDetayEkle.Visible = false;
            btnDetayGoster.Visible = false;
            secimId = -1;
            kayitBul = null;
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

        public void Ac(int secimId)
        {
           

            if (secimId < 0)
            {
                MessageBox.Show("Kayit id bulunamamıstır");
                return;

            }
            btnDetayEkle.Visible = true;
            btnDetayGoster.Visible = true;
            kayitBul = PersList.FirstOrDefault(x => x.Id == secimId);

            try
            {
                TxtPadi.Text = kayitBul.Adi;
                TxtUnvan.Text = kayitBul.Unvan;
                if (kayitBul.Sehirler != null) TxtSehir.Text = kayitBul.Sehirler.name;
                if (kayitBul.tblDepartmanlar != null) TxtDepartman.Text = kayitBul.tblDepartmanlar.Adi;
                TxtGsm.Text = kayitBul.Gsm;
                TxtIsBas.Text =kayitBul.IsBaslangicTarih.ToString();
                TxtIsBit.Text = kayitBul.IsBitisTarih.ToString();
                TxtPersonelBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');


                TxtEmail.Text = kayitBul.Email;
                TxtAdres.Text = kayitBul.Adres;
                
                TxtTelefon.Text = kayitBul.Tel;
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

        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, TxtPersonelBul.ClientSize.Height);
            btn.Location = new Point(TxtPersonelBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtPersonelBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += Btn_Click;
        }
        private void Btn_Click(object sender, EventArgs e)
        {

            int id = f.PersonellerListesiAc(true);
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
            if (kayitBul != null)
            {
                
                kayitBul.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);   
                kayitBul.DepartmanId = Convert.ToInt32(TxtDepartman.SelectedValue);   
                kayitBul.Email = TxtEmail.Text;
                kayitBul.Tel = TxtTelefon.Text;
                kayitBul.Adres = TxtAdres.Text;
                kayitBul.Adi = TxtPadi.Text;
                kayitBul.Unvan=TxtUnvan.Text;
                kayitBul.Gsm = TxtGsm.Text;
                kayitBul.IsBaslangicTarih = TxtIsBas.Value;
                kayitBul.IsBitisTarih = TxtIsBit.Value;
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

                _db.tblPersoneller.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydiniz Silindi...");
                Temizle();
                Listele();
            }
        }
    }
}
