using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject_CT.BilgiGirisIslemleri.Hastaneler
{
    public partial class HastaneDetayGoster : Form
    {
        public readonly Entity.Erp102EvEntities _db = new Entity.Erp102EvEntities();
        public string Hadi = "";
        public HastaneDetayGoster()
        {
            InitializeComponent();
        }

        private void HastaneDetayGoster_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var hstDetayList = (from s in _db.tblHastaneDetaylar  where s.tblHastaneler.Adi == Hadi select s).ToList(); //Linq sorgu

            foreach (var item in hstDetayList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[3].Value = item.YetkiliAdi; //visible false yaptıgımız için 3den başlattık
                Liste.Rows[i].Cells[4].Value = item.tblDepartmanlar.Adi;
                Liste.Rows[i].Cells[5].Value = item.Tel;
                Liste.Rows[i].Cells[6].Value = item.Gsm;
                Liste.Rows[i].Cells[7].Value = item.Email;
                i++;

            }
            Liste.AllowUserToAddRows = false; // altta bi satır boş kalmasın diye
            Liste.AllowUserToDeleteRows = false; // satır silmeye izin vermez
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }
    }
}
