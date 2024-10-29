using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab9_Bai1_vd.DomainClass
{
    [Table("tblBanHang")]
    public partial class TblBanHang
    {
        public TblBanHang()
        {
            TblChiTietBanHang = new HashSet<TblChiTietBanHang>();
        }

        [Key]
        [Column("SoHieuHD")]
        public int SoHieuHd { get; set; }
        [Column("MaKH")]
        [StringLength(50)]
        public string MaKh { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayMuaBan { get; set; }

        [ForeignKey(nameof(MaKh))]
        [InverseProperty(nameof(TblKhachHang.TblBanHang))]
        public virtual TblKhachHang MaKhNavigation { get; set; }
        [InverseProperty("SoHieuHdNavigation")]
        public virtual ICollection<TblChiTietBanHang> TblChiTietBanHang { get; set; }
    }
}
