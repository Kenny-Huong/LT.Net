using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_QLThuVien_110824.DomainClass
{
    [Table("SACH")]
    public partial class Sach
    {
        public Sach()
        {
            Chitietphieumuon = new HashSet<Chitietphieumuon>();
        }

        [Key]
        public int MaSach { get; set; }
        [StringLength(255)]
        public string TenSach { get; set; }
        [StringLength(100)]
        public string TacGia { get; set; }
        public int? NamXuatBan { get; set; }
        [StringLength(100)]
        public string NhaXuatBan { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TriGia { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayNhap { get; set; }

        [InverseProperty("MaSachNavigation")]
        public virtual ICollection<Chitietphieumuon> Chitietphieumuon { get; set; }
    }
}
