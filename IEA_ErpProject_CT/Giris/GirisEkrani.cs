using IEA_ErpProject_CT.Entity.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject_CT.Giris
{
    public partial class GirisEkrani : Form
    {
        private readonly ErpProContext code = new ErpProContext();
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnGir_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text != "" && TxtSifre.Text != "")
            {
                var srg = code.TblUsers.FirstOrDefault(s => s.UserName == TxtKullaniciAdi.Text && s.Password == TxtSifre.Text);
                if (srg != null)
                {
                    AnaSayfa ana = new AnaSayfa();
                    ana.Show();
                    ana.lblName.Text = srg.Name;
                    ana.lblUserName.Text = srg.UserName;
                    Hide();
                }
                else
                {
                    MessageBox.Show(@"Kullanici adi veya sifre hatali");
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
