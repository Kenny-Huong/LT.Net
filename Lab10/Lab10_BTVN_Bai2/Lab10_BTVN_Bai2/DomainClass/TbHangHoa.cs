using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_BTVN_Bai2.DomainClass
{
    [Table("tbHangHoa")]
    public partial class TbHangHoa
    {
        [Key]
        [Column("maHang")]
        [StringLength(10)]
        public string MaHang { get; set; }
        [Column("tenHang")]
        [StringLength(50)]
        public string TenHang { get; set; }
        [Column("donVi")]
        [StringLength(10)]
        public string DonVi { get; set; }
        [Column("donGia", TypeName = "decimal(18, 2)")]
        public decimal? DonGia { get; set; }
        [Column("soLuong")]
        public int? SoLuong { get; set; }
    }
}
