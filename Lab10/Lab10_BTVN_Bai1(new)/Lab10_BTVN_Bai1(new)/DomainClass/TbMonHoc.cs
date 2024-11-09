using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_BTVN_Bai1_new_.DomainClass
{
    [Table("tbMonHoc")]
    public partial class TbMonHoc
    {
        public TbMonHoc()
        {
            TbDiem = new HashSet<TbDiem>();
        }

        [Key]
        [Column("MaMH")]
        public int MaMh { get; set; }
        [Column("TenMH")]
        [StringLength(100)]
        public string TenMh { get; set; }
        public int? SoTiet { get; set; }
        [Column("MaGV")]
        public int? MaGv { get; set; }

        [ForeignKey(nameof(MaGv))]
        [InverseProperty(nameof(TbGiaoVien.TbMonHoc))]
        public virtual TbGiaoVien MaGvNavigation { get; set; }
        [InverseProperty("MaMhNavigation")]
        public virtual ICollection<TbDiem> TbDiem { get; set; }
    }
}
