using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_QLThuVien_110824.DomainClass
{
    [Table("tbGiaoVien")]
    public partial class TbGiaoVien
    {
        public TbGiaoVien()
        {
            TbMonHoc = new HashSet<TbMonHoc>();
        }

        [Key]
        [Column("MaGV")]
        public int MaGv { get; set; }
        [Column("TenGV")]
        [StringLength(100)]
        public string TenGv { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(10)]
        public string GioiTinh { get; set; }
        [StringLength(200)]
        public string DiaChi { get; set; }

        [InverseProperty("MaGvNavigation")]
        public virtual ICollection<TbMonHoc> TbMonHoc { get; set; }
    }
}
