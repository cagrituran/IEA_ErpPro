using IEA_ErpProject_CT.BilgiGirisIslemleri.Firmalar;
using IEA_ErpProject_CT.BilgiGirisIslemleri.Hastaneler;
using IEA_ErpProject_CT.BilgiGirisIslemleri.Urunler;
using IEA_ErpProject_CT.Doktorlar;
using IEA_ErpProject_CT.Firmalar;
using IEA_ErpProject_CT.Hastaneler;
using IEA_ErpProject_CT.Personeller;
using IEA_ErpProject_CT.Stok;
using IEA_ErpProject_CT.UrunGirisIslemleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject_CT.KonsinyeIslemleri.Gonderim;

namespace IEA_ErpProject_CT.Fonksiyonlar
{
    internal class Formlar
    {
       

        public int HastanelerListesiAc(bool secim = false)
        {
            HastanelerListesi frm = new HastanelerListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            return AnaSayfa.Aktarma;
        }
        public void HastaneGirisAc(int id)
        {
            HastaneGiris frm = new HastaneGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }

        public void HastaneDetayAc(string adi,int id)
        {
            HastaneDetay frm = new HastaneDetay();
            frm.lblHastaneAdi.Text = adi;
            frm.lblHastaneId.Text = id.ToString();
            frm.ShowDialog();
        }
        public int DoktorlarListesiAc(bool secim = false)
        {
            DoktorlarListesi frm = new DoktorlarListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            return AnaSayfa.Aktarma;
        }
        public void DoktorlarGirisAc(int id)
        {
            DoktorGiris frm = new DoktorGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }
        public int FirmalarListesiAc(bool secim = false)
        {
            FirmalarListesi frm = new FirmalarListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            return AnaSayfa.Aktarma;
        }
        public void FirmalarGirisAc(int id)
        {
            FirmaGiris frm = new FirmaGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }
        public void FirmaDetayAc(string adi, int id)
        {
            FirmaDetay firm = new FirmaDetay();
            firm.lblFirmaAdi.Text = adi;
            firm.lblFirmaId.Text = id.ToString();
            firm.ShowDialog();
        }
        public int PersonellerListesiAc(bool secim = false)
        {
            PersonellerListesi frm = new PersonellerListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            return AnaSayfa.Aktarma;
        }
        public void PersonellerGirisAc(int id)
        {
            PersonelGiris frm = new PersonelGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }
        public int UrunKayitListesiAc(bool secim = false)
        {
            UrunKayitListesi frm = new UrunKayitListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            return AnaSayfa.Aktarma;
        }
        public int UrunGirisListesiAc(bool secim = false)
        {
            UrunlerGirisListesi frm = new UrunlerGirisListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            return AnaSayfa.Aktarma;
        }
        public int StokDurumAc(bool secim = false)
        {
            StokDurum frm = new StokDurum();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            return AnaSayfa.Aktarma;
        }
        public int KonsinyeGonderimAc(bool secim = false)
        {
            KonsinyeGonderim frm = new KonsinyeGonderim();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            return AnaSayfa.Aktarma;
        }
    }
}
