using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NguyenVanHuong_DHTI15A5HN_05112024.DomainClass
{
    public partial class HopDong
    {
        public HopDong()
        {
            HopDongMatHang = new HashSet<HopDongMatHang>();
        }

        [Key]
        [Column("SoHieuHD")]
        [StringLength(15)]
        public string SoHieuHd { get; set; }
        [Required]
        [Column("MaKH")]
        [StringLength(15)]
        public string MaKh { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NgayLap { get; set; }

        [ForeignKey(nameof(MaKh))]
        [InverseProperty(nameof(KhachHang.HopDong))]
        public virtual KhachHang MaKhNavigation { get; set; }
        [InverseProperty("SoHieuHdNavigation")]
        public virtual ICollection<HopDongMatHang> HopDongMatHang { get; set; }
    }
}
