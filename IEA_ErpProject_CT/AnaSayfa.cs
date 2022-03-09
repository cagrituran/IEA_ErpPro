using IEA_ErpProject_CT.BilgiGirisIslemleri.Urunler;
using IEA_ErpProject_CT.Doktorlar;
using IEA_ErpProject_CT.Firmalar;
using IEA_ErpProject_CT.Fonksiyonlar;
using IEA_ErpProject_CT.Hastaneler;
using IEA_ErpProject_CT.Personeller;
using IEA_ErpProject_CT.UrunGirisIslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject_CT
{
    public partial class AnaSayfa : Form
    {
        public static int Aktarma = -1;
        Formlar f = new Formlar();
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void blgGiris_Click(object sender, EventArgs e)
        {
            lblMenu.Text = blgGiris.Text;
            MenuOlustur("bilgi");
        }
        private void MenuOlustur(string gelen)
        {
            tvMenu.Nodes.Clear();

            if (gelen == "bilgi")
            {
                tvMenu.Nodes.Add("Hastaneler");
                tvMenu.Nodes[0].Nodes.Add("Hastane Listesi");
                tvMenu.Nodes[0].Nodes.Add("Hastane Giriş");

                tvMenu.Nodes.Add("Doktorlar");
                tvMenu.Nodes[1].Nodes.Add("Doktor Listesi");
                tvMenu.Nodes[1].Nodes.Add("Doktor Giriş");

                tvMenu.Nodes.Add("Firmalar");
                tvMenu.Nodes[2].Nodes.Add("Firma Listesi");
                tvMenu.Nodes[2].Nodes.Add("Firma Giriş");

                tvMenu.Nodes.Add("Personeller");
                tvMenu.Nodes[3].Nodes.Add("Personel Listesi");
                tvMenu.Nodes[3].Nodes.Add("Personel Giriş");

                tvMenu.Nodes.Add("Urunler");
                tvMenu.Nodes[4].Nodes.Add("Urun Kayit Listesi");
                tvMenu.Nodes[4].Nodes.Add("Urun Kayit");
            }

            else if (gelen == "urun")
            {
                tvMenu.Nodes.Add("Urunler Giris");
                tvMenu.Nodes[0].Nodes.Add("Urunler Listesi");
                tvMenu.Nodes[0].Nodes.Add("Urun Giris");

            }
            else if (gelen == "stok")
            {
                tvMenu.Nodes.Add("Stok");
                tvMenu.Nodes[0].Nodes.Add("Stok Durum");

            }
            else if (gelen == "konsinye")
            {
                tvMenu.Nodes.Add("Konsinye");
                tvMenu.Nodes[0].Nodes.Add("Gonderim");
                tvMenu.Nodes[0].Nodes[0].Nodes.Add("Konsinye Gonderim");
                tvMenu.Nodes[0].Nodes[0].Nodes.Add("Konsinye Gonderim Listesi");

                tvMenu.Nodes[0].Nodes.Add("Cikis");
                tvMenu.Nodes[0].Nodes[1].Nodes.Add("Konsinye Cikis");
                tvMenu.Nodes[0].Nodes[1].Nodes.Add("Konsinye Cikis Listesi");

            }

        }

        private void tvMenu_DoubleClick(object sender, EventArgs e)
        {
            string isim = "";
            if (tvMenu.SelectedNode != null)
            {
                isim = tvMenu.SelectedNode.Text;
            }

            if (isim == "Hastane Listesi" && Application.OpenForms["HastanelerListesi"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa;
                f.HastanelerListesiAc();
            }
            else if (isim == "Hastane Giriş" && Application.OpenForms["HastaneGiris"] == null)
            {
                HastaneGiris frm = new HastaneGiris();
                frm.MdiParent = ActiveForm;
                frm.Show();
            }
            if (isim == "Doktor Listesi" && Application.OpenForms["DoktorlarListesi"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa;
                f.DoktorlarListesiAc();
            }
            else if (isim == "Doktor Giriş" && Application.OpenForms["DoktorGiris"] == null)
            {
                DoktorGiris frm = new DoktorGiris();
                frm.MdiParent = ActiveForm;
                frm.Show();
            }
            if (isim == "Firma Listesi" && Application.OpenForms["FirmalarListesi"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa;
                f.FirmalarListesiAc();
            }
            else if (isim == "Firma Giriş" && Application.OpenForms["FirmaGiris"] == null)
            {
                FirmaGiris frm = new FirmaGiris();
                frm.MdiParent = ActiveForm;
                frm.Show();
            }
            if (isim == "Personel Listesi" && Application.OpenForms["PersonellerListesi"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa;
                f.PersonellerListesiAc();
            }
            else if (isim == "Personel Giriş" && Application.OpenForms["PersonelGiris"] == null)
            {
                PersonelGiris frm = new PersonelGiris();
                frm.MdiParent = ActiveForm;
                frm.Show();
            }

            if (isim == "Urun Kayit Listesi" && Application.OpenForms["UrunKayitListesi"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa;
                f.UrunKayitListesiAc();
            }
            else if (isim == "Urun Kayit" && Application.OpenForms["UrunKayit"] == null)
            {
                UrunKayit frm = new UrunKayit();
                frm.MdiParent = ActiveForm;
                frm.Show();
            }
            if (isim == "Urunler Listesi" && Application.OpenForms["UrunlerGirisListesi"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa;
                f.UrunGirisListesiAc();
            }
            else if (isim == "Urun Giris" && Application.OpenForms["UrunGiris"] == null)
            {
                UrunGiris frm = new UrunGiris();
                frm.MdiParent = ActiveForm;
                frm.Show();
            }
            else if (isim == "Urun Giris" && Application.OpenForms["UrunGiris"] == null)
            {
                UrunGiris frm = new UrunGiris();
                frm.MdiParent = ActiveForm;
                frm.Show();
            }
            if (isim == "Stok Durum" && Application.OpenForms["StokDurum"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa;

                f.StokDurumAc();
            }
            if (isim == "Konsinye Gonderim" && Application.OpenForms["KonsinyeGonderim"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa;

                f.KonsinyeGonderimAc();
            }
        }

        private void btnUrungiris_Click(object sender, EventArgs e)
        {
            lblMenu.Text = btnUrungiris.Text;
            MenuOlustur("urun");
        }

        private void btnStokIslemleri_Click(object sender, EventArgs e)
        {
            lblMenu.Text = btnStokIslemleri.Text;
            MenuOlustur("stok");
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cikis(e);
        }

        private void Cikis(FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Programdan cikis yapmak istediginize emin misiniz ?", "Cikis Islemi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Programdan cikis yapmak istediginize emin misiniz ?", "Cikis Islemi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }
           
        }

        private void btnSolUstCollapse_Click(object sender, EventArgs e)
        {
            if (panel1.Width > 130)
            {
                panel1.Width = 100;
            }
            else
            {
                panel1.Width = 200;
            }
        }

        private void btnKonsinye_Click(object sender, EventArgs e)
        {
            lblMenu.Text = btnKonsinye.Text;
            MenuOlustur("konsinye");

        }
    }
}
