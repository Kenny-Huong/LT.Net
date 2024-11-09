using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_QLThuVien_110824.DomainClass
{
    [Table("tbLop")]
    public partial class TbLop
    {
        public TbLop()
        {
            TbSinhVien = new HashSet<TbSinhVien>();
        }

        [Key]
        public int MaLop { get; set; }
        [StringLength(100)]
        public string TenLop { get; set; }
        public int? MaKhoa { get; set; }

        [ForeignKey(nameof(MaKhoa))]
        [InverseProperty(nameof(TbKhoa.TbLop))]
        public virtual TbKhoa MaKhoaNavigation { get; set; }
        [InverseProperty("MaLopNavigation")]
        public virtual ICollection<TbSinhVien> TbSinhVien { get; set; }
    }
}
