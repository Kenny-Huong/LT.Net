using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_QLThuVien_110824.DomainClass
{
    [Table("tbDiem")]
    public partial class TbDiem
    {
        [Key]
        public int Id { get; set; }
        [Column("MaSV")]
        public int? MaSv { get; set; }
        [Column("MaMH")]
        public int? MaMh { get; set; }
        public double? Diem { get; set; }

        [ForeignKey(nameof(MaMh))]
        [InverseProperty(nameof(TbMonHoc.TbDiem))]
        public virtual TbMonHoc MaMhNavigation { get; set; }
        [ForeignKey(nameof(MaSv))]
        [InverseProperty(nameof(TbSinhVien.TbDiem))]
        public virtual TbSinhVien MaSvNavigation { get; set; }
    }
}
