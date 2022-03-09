using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject_CT.Entity.Code
{
    [Table("tblUsers")] //db tarafında olusmasını istedigimiz ismin ne olmasını istedigimizi belirttik
    public class tblUser
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] //bir alttaki satırın primarykey oldugu ve birbir arttırması  bu kod ile saglandı
        public int Id { get; set; }
        [DisplayName("Ad"), StringLength(50, ErrorMessage = "{0} alani max {1} karakterdir")]// C# tarafında Ad olarak gözükmesi saglandı
        [Required(ErrorMessage = "{0} alani girilmesi zorunludur")]
        public string Name { get; set; }
        [DisplayName("Sifre"), StringLength(maximumLength: 10, MinimumLength = 5, ErrorMessage = "{0} alani max {1} min {2} karakter olmalıdır")]// C# tarafında Ad olarak gözükmesi saglandı
        [Required(ErrorMessage = "{0} alani girilmesi zorunludur")]
        public string Password { get; set; }
        [DisplayName("Kullanici Adi"), StringLength(maximumLength: 10, MinimumLength = 5, ErrorMessage = "{0} alani max {1} min {2} karakter olmalıdır")]// C# tarafında Ad olarak gözükmesi saglandı
        [Required(ErrorMessage = "{0} alani girilmesi zorunludur")]
        public string UserName { get; set; }
    }
}
