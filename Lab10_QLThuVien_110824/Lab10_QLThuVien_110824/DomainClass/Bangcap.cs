using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_QLThuVien_110824.DomainClass
{
    [Table("BANGCAP")]
    public partial class Bangcap
    {
        public Bangcap()
        {
            Nhanvien = new HashSet<Nhanvien>();
        }

        [Key]
        public int MaBangCap { get; set; }
        [StringLength(100)]
        public string TenBangCap { get; set; }

        [InverseProperty("MaBangCapNavigation")]
        public virtual ICollection<Nhanvien> Nhanvien { get; set; }
    }
}
