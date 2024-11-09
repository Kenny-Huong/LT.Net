using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NguyenVanHuong_DHTI15A5HN_05112024.DomainClass
{
    public partial class MatHang
    {
        public MatHang()
        {
            HopDongMatHang = new HashSet<HopDongMatHang>();
        }

        [Key]
        [Column("MaMH")]
        [StringLength(10)]
        public string MaMh { get; set; }
        [Required]
        [Column("TenMH")]
        [StringLength(100)]
        public string TenMh { get; set; }
        [Required]
        [StringLength(10)]
        public string DonViTinh { get; set; }
        public double DonGia { get; set; }

        [InverseProperty("MaMhNavigation")]
        public virtual ICollection<HopDongMatHang> HopDongMatHang { get; set; }
    }
}
