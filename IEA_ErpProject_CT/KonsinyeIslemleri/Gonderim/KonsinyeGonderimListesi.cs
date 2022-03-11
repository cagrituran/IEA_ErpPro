using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject_CT.Entity;
using IEA_ErpProject_CT.Entity.Code;
using IEA_ErpProject_CT.Migrations;

namespace IEA_ErpProject_CT.KonsinyeIslemleri.Gonderim
{
    public partial class KonsinyeGonderimListesi : Form
    {
        private readonly ErpProContext _code = new ErpProContext();
        public bool Secim = false;
        private int gonderimId = -1;
        public KonsinyeGonderimListesi()
        {
            InitializeComponent();
        }

        private void KonsinyeGonderimListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = _code.TblKonsinyeGonderimler.ToList();
            foreach (var item in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.CariTur;
                Liste.Rows[i].Cells[3].Value = item.CariAdi;
                Liste.Rows[i].Cells[4].Value = item.GonderimTarih;
                Liste.Rows[i].Cells[5].Value = item.Aciklama;
                Liste.Rows[i].Cells[6].Value = item.GonderimId;
                i++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && gonderimId > 0)
            {
                AnaSayfa.Aktarma = gonderimId;
                
            }
            else if (!Secim && gonderimId > 0)
            {
                KonsinyeGonderim urn = new KonsinyeGonderim();
                urn.MdiParent = Form.ActiveForm;
                urn.StartPosition = FormStartPosition.CenterParent;
                urn.Show();
                urn.KonGonderimAc(gonderimId);
                
            }

            Close();
        }

        private void Sec()
        {
            gonderimId = Convert.ToInt32(Liste.CurrentRow.Cells[6].Value);
        }
    }
}
