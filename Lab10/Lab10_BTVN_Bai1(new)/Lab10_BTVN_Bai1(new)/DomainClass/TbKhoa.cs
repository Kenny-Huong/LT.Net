using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_BTVN_Bai1_new_.DomainClass
{
    [Table("tbKhoa")]
    public partial class TbKhoa
    {
        public TbKhoa()
        {
            TbLop = new HashSet<TbLop>();
        }

        [Key]
        public int MaKhoa { get; set; }
        [StringLength(100)]
        public string TenKhoa { get; set; }

        [InverseProperty("MaKhoaNavigation")]
        public virtual ICollection<TbLop> TbLop { get; set; }
    }
}
