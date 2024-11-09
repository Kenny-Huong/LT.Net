using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_QLThuVien_110824.DomainClass
{
    [Table("DOCGIA")]
    public partial class Docgia
    {
        public Docgia()
        {
            Phieumuonsach = new HashSet<Phieumuonsach>();
            Phieuthutien = new HashSet<Phieuthutien>();
        }

        [Key]
        public int MaDocGia { get; set; }
        [StringLength(100)]
        public string HoTenDocGia { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(255)]
        public string DiaChi { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayLapThe { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TienNo { get; set; }

        [InverseProperty("MaDocGiaNavigation")]
        public virtual ICollection<Phieumuonsach> Phieumuonsach { get; set; }
        [InverseProperty("MaDocGiaNavigation")]
        public virtual ICollection<Phieuthutien> Phieuthutien { get; set; }
    }
}
