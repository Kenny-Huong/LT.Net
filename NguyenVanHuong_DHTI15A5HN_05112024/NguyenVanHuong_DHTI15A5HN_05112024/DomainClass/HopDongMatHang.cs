using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NguyenVanHuong_DHTI15A5HN_05112024.DomainClass
{
    [Table("HopDong_MatHang")]
    public partial class HopDongMatHang
    {
        [Key]
        [Column("SoHieuHD")]
        [StringLength(15)]
        public string SoHieuHd { get; set; }
        [Key]
        [Column("MaMH")]
        [StringLength(10)]
        public string MaMh { get; set; }
        public int SoLuong { get; set; }

        [ForeignKey(nameof(MaMh))]
        [InverseProperty(nameof(MatHang.HopDongMatHang))]
        public virtual MatHang MaMhNavigation { get; set; }
        [ForeignKey(nameof(SoHieuHd))]
        [InverseProperty(nameof(HopDong.HopDongMatHang))]
        public virtual HopDong SoHieuHdNavigation { get; set; }
    }
}
