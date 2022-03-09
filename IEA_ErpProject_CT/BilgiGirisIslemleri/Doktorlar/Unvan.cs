using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject_CT.BilgiGirisIslemleri.Doktorlar
{
    public enum Unvan
    {
        [Display(Name = "Prof.Dr.")]
        ProfDr,
        [Display(Name = "Opt.Dr.")]
        OptDr,
        [Display(Name = "Doc.Dr.")]
        DocDr,
        [Display(Name = "Yrd.Doc.Dr.")]
        YrdDocDr,
        [Display(Name = "Uzman.Dr.")]
        UzmanDr,
        Dr,
        Asistan


    }
}
