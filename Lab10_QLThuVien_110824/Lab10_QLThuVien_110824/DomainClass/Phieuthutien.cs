using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_QLThuVien_110824.DomainClass
{
    [Table("PHIEUTHUTIEN")]
    public partial class Phieuthutien
    {
        [Key]
        public int MaPhieuThuTien { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? SoTienThu { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayThuTien { get; set; }
        public int? MaDocGia { get; set; }
        public int? MaNhanVien { get; set; }

        [ForeignKey(nameof(MaDocGia))]
        [InverseProperty(nameof(Docgia.Phieuthutien))]
        public virtual Docgia MaDocGiaNavigation { get; set; }
        [ForeignKey(nameof(MaNhanVien))]
        [InverseProperty(nameof(Nhanvien.Phieuthutien))]
        public virtual Nhanvien MaNhanVienNavigation { get; set; }
    }
}
