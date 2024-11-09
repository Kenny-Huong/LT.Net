using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NguyenVanHuong_DHTI15A5HN_05112024.DomainClass
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HopDong = new HashSet<HopDong>();
        }

        [Key]
        [Column("MaKH")]
        [StringLength(15)]
        public string MaKh { get; set; }
        [Required]
        [Column("TenKH")]
        [StringLength(30)]
        public string TenKh { get; set; }
        [Required]
        [StringLength(5)]
        public string GioiTinh { get; set; }
        [Required]
        [StringLength(80)]
        public string DiaChi { get; set; }
        [Column(TypeName = "text")]
        public string DienThoai { get; set; }

        [InverseProperty("MaKhNavigation")]
        public virtual ICollection<HopDong> HopDong { get; set; }
    }
}
