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

namespace IEA_ErpProject_CT.Personeller
{
    public partial class PersonellerListesi : Form
    {
        private readonly Entity.Erp102EvEntities _db = new Entity.Erp102EvEntities();
        public bool Secim = false;
        List<tblPersoneller> PersList;
        Formlar f = new Formlar();
        private int secimId = -1;
        public PersonellerListesi()
        {
            InitializeComponent();
        }

        private void PersonellerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            PersList = (from s in _db.tblPersoneller where s.Adi.Contains(txtPersonelAra.Text) select s).ToList();
            foreach (var item in PersList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.Unvan;
                if (item.tblDepartmanlar != null)
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

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[1].Value ?? -1; // null gelirse -1 yaz , normal gelirse int değerine çevir
            if (secimId > 0 && Secim && Application.OpenForms["PersonelGiris"] == null)
            {
                AnaSayfa.Aktarma = secimId;
                Close();//Hastaneler listesi kapatıldı.
                // f.FirmalarGirisAc(secimId);
            }
            else if (secimId > 0 && Secim && Application.OpenForms["PersonelGiris"] != null)
            {
                // AnaSayfa.Aktarma = secimId;
                PersonelGiris frm = Application.OpenForms["PersonelGiris"] as PersonelGiris;
                frm.Ac(secimId);
                Close();//Hastaneler listesi kapatıldı.
                // f.FirmalarGirisAc(secimId);
            }
            else if (!Secim)
            {
                f.PersonellerGirisAc(secimId);
                Close();
            }

        }

        private void btnPersonelAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
