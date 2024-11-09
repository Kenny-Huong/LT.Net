using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_QLThuVien_110824.DomainClass
{
    [Table("NHANVIEN")]
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Phieuthutien = new HashSet<Phieuthutien>();
        }

        [Key]
        public int MaNhanVien { get; set; }
        [StringLength(100)]
        public string HoTenNhanVien { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(255)]
        public string DiaChi { get; set; }
        [StringLength(20)]
        public string DienThoai { get; set; }
        public int? MaBangCap { get; set; }

        [ForeignKey(nameof(MaBangCap))]
        [InverseProperty(nameof(Bangcap.Nhanvien))]
        public virtual Bangcap MaBangCapNavigation { get; set; }
        [InverseProperty("MaNhanVienNavigation")]
        public virtual ICollection<Phieuthutien> Phieuthutien { get; set; }
    }
}
