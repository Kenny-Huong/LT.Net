using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_BTVN_Bai4.DomainClass
{
    [Table("tbCongTo")]
    public partial class TbCongTo
    {
        [Key]
        [Column("maCongTo")]
        [StringLength(10)]
        public string MaCongTo { get; set; }
        [Column("tenChuHo")]
        [StringLength(50)]
        public string TenChuHo { get; set; }
        [Column("soCu")]
        public int? SoCu { get; set; }
        [Column("soMoi")]
        public int? SoMoi { get; set; }
        [Column("donGia")]
        public int? DonGia { get; set; }
    }
}
