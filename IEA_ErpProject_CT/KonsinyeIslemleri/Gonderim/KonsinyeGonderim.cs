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

namespace IEA_ErpProject_CT.KonsinyeIslemleri.Gonderim
{
    public partial class KonsinyeGonderim : Form
    {
        private readonly Entity.Erp102EvEntities _db = new Entity.Erp102EvEntities();
        private readonly ErpProContext _code = new ErpProContext();

        public bool Secim = false;
        public string[] MyArray { get; set; }
        public KonsinyeGonderim()
        {
            InitializeComponent();
        }

        private void KonsinyeGonderim_Load(object sender, EventArgs e)
        {
            MyArray = _db.tblUrunKayitUst.Select(x => x.UrunKodu).Distinct().ToArray();
        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            try
            {
                TextBox txt = e.Control as TextBox;
                if (Liste.CurrentCell.ColumnIndex == 3 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource.AddRange(MyArray);
                }
                else if (Liste.CurrentCell.ColumnIndex != 3 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.None;
                }
                //if (Liste.CurrentCell.ColumnIndex == 4)
                //{
                //    LotBul bul = new LotBul();
                //    bul.ShowDialog();

                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        private void Liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Liste.CurrentCell.ColumnIndex == 4)
            {
                LotBul bul = new LotBul();
                if (Liste.CurrentRow.Cells[3].Value != null)
                {
                    bul.ukod = Liste.CurrentRow.Cells[3].Value.ToString();
                }
                bul.ShowDialog();

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            Liste.AllowUserToAddRows = false;
            tblKonsinyeGonderim[] Kon = new tblKonsinyeGonderim[Liste.RowCount];
            for (int i = 0; i < Liste.RowCount; i++)
            {
                Kon[i] = new tblKonsinyeGonderim();
                Kon[i].CariAdi = TxtKonCariAdi.Text;
                Kon[i].Aciklama = TxtKonAciklama.Text;
                Kon[i].Adet = Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                Kon[i].CariTur = TxtKonCariTur.Text;
                Kon[i].GonderimTarih = TxtKonGirisTarih.Value;
                var brk = Liste.Rows[i].Cells[2].Value;
                Kon[i].UrunId = _db.tblStokDurum.FirstOrDefault(s => s.Barkod == brk).Id;
                Kon[i].CreatedDate = DateTime.Now;
                Kon[i].UpdatedDate = DateTime.Now;
                Kon[i].CreatedUser = -1;
                Kon[i].UpdatedUser = -1;
                Kon[i].isDeleted = false;
                Kon[i].CariId = 1;

            }
            _code.TblKonsinyeGonderimler.AddRange(Kon);
            _code.SaveChanges();
        }
    }
}
