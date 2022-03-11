using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject_CT.Entity.Code
{
    public class ErpProContext:DbContext // DbContext ErpProContext sınıfının Base'sidir
    {
        AnaSayfa ana = Application.OpenForms["AnaSayfa"] as AnaSayfa;
        public ErpProContext() : base("name=Erp102EvCode")
        {

            Database.SetInitializer(new MyInitializer());
        }
        public DbSet<tblUser> TblUsers { get; set; }

        public DbSet<tblKonsinyeGonderim> TblKonsinyeGonderimler { get; set; }

        public override int SaveChanges()//override yaparak ezdik
        {//ChangeTracker : Entityler üzerinde yapılan degisikliklerin yada yeni eklenen verinin yakalanmasını saglayan propertydir
          var datas=ChangeTracker.Entries<BaseEntity>();
          foreach (var data in datas)
          {
              if (data.State==EntityState.Added)
              {
                  data.Entity.CreatedDate=DateTime.Now;
                  
                  data.Entity.CreatedUser=ana.lblUserName.Text;
                  data.Entity.isDeleted = false;

              }
              else if (data.State==EntityState.Modified)
              {
                  data.Entity.UpdatedDate=DateTime.Now;
                  data.Entity.UpdatedUser= ana.lblUserName.Text;
              }
          }

          return base.SaveChanges();
        }
    }
}
