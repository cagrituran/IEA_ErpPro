using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject_CT.Entity.Code
{
    public class MyInitializer:CreateDatabaseIfNotExists<ErpProContext>
    {
        protected override void Seed(ErpProContext context)
        {
            tblUser admin = new tblUser();
            admin.Name = "Cagri";
            admin.Password = "12345";
            admin.UserName = "CagriT";
            context.TblUsers.Add(admin);

            base.Seed(context); 
        }
    }
}
