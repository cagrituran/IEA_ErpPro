using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject_CT.Fonksiyonlar
{
    public class Numaralar
    {
        private readonly Entity.Erp102EvEntities _db = new Entity.Erp102EvEntities();   
        public string UidNo()
        {
            try
            {
                var numara = (from s in _db.tblUrunKayitUst orderby s.Id descending select s).First().Uid;
                numara++;
                string num=numara.ToString().PadLeft(7,'0');
                return num;
                    
            }
            catch (Exception)
            {

                return "0000001";//ilk başta kayıt olmadıgı için ilk 1 i vermek için kullanılıyor
            }
        }

        public string UGirisNo()
        {
            try
            {
                var numara = (from s in _db.tblUrunGirisUst orderby s.Id descending select s).First().GirisId;
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception e)
            {
                return "0000001";
            }
        }
    }
}
