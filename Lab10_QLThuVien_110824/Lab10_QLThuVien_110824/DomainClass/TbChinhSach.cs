using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_QLThuVien_110824.DomainClass
{
    [Table("tbChinhSach")]
    public partial class TbChinhSach
    {
        public TbChinhSach()
        {
            TbSinhVien = new HashSet<TbSinhVien>();
        }

        [Key]
        [Column("MaCS")]
        public int MaCs { get; set; }
        [Column("TenCS")]
        [StringLength(100)]
        public string TenCs { get; set; }
        [Column(TypeName = "text")]
        public string CheDo { get; set; }

        [InverseProperty("MaCsNavigation")]
        public virtual ICollection<TbSinhVien> TbSinhVien { get; set; }
    }
}
