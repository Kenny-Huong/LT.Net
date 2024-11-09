using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lad10_BTVN_Bai3.DomainClass
{
    [Table("tbDiemHocSinh")]
    public partial class TbDiemHocSinh
    {
        [Key]
        [Column("maHocSinh")]
        [StringLength(10)]
        public string MaHocSinh { get; set; }
        [Column("hoTen")]
        [StringLength(50)]
        public string HoTen { get; set; }
        [Column("diemToan")]
        public double? DiemToan { get; set; }
        [Column("diemViet")]
        public double? DiemViet { get; set; }
    }
}
