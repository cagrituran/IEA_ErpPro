using IEA_ErpProject_CT.Entity;
using IEA_ErpProject_CT.Fonksiyonlar;
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
    public partial class HastanelerListesi : Form
    {
        private readonly Entity.Erp102EvEntities _db = new Entity.Erp102EvEntities();
        private List<tblHastaneler> hstList;
        private int secimId = -1;
        public bool Secim = false;
        Formlar f = new Formlar();

        public HastanelerListesi()
        {
            InitializeComponent();
        }

        private void HastanelerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            hstList = (from s in _db.tblHastaneler where s.Adi.Contains(txtHastaneAra.Text) select s).ToList();

            foreach (var item in hstList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.tblHastanetip.TipAdi;
                Liste.Rows[i].Cells[4].Value = item.Tel;
                Liste.Rows[i].Cells[5].Value = item.Sehirler.name;
                i++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[1].Value ?? -1; // null gelirse -1 yaz , normal gelirse int değerine çevir
            if (secimId > 0 && Secim && Application.OpenForms["HastaneGiris"] == null)
            {
                AnaSayfa.Aktarma = secimId;
                Close();//Hastaneler listesi kapatıldı.
                // f.FirmalarGirisAc(secimId);
            }
            else if (secimId > 0 && Secim && Application.OpenForms["HastaneGiris"] != null)
            {
                // AnaSayfa.Aktarma = secimId;
                HastaneGiris frm = Application.OpenForms["HastaneGiris"] as HastaneGiris;
                frm.Ac(secimId);
                Close();//Hastaneler listesi kapatıldı.
                // f.FirmalarGirisAc(secimId);
            }
            else if (!Secim)
            {
                f.HastaneGirisAc(secimId);
                Close();
            }
        }

        private void btnHastaneAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtHastaneAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void txtHastaneAra_TextChanged(object sender, EventArgs e)
        //{ //her karakterde bulmak için
        //    Listele();
        //}
    }
}
