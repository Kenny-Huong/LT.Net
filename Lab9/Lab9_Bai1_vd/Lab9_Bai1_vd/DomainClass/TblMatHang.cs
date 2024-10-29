using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab9_Bai1_vd.DomainClass
{
    [Table("tblMatHang")]
    public partial class TblMatHang
    {
        public TblMatHang()
        {
            TblChiTietBanHang = new HashSet<TblChiTietBanHang>();
        }

        [Key]
        [Column("MaMH")]
        [StringLength(50)]
        public string MaMh { get; set; }
        [Column("TenMH")]
        [StringLength(100)]
        public string TenMh { get; set; }
        [Column("DVT")]
        [StringLength(20)]
        public string Dvt { get; set; }

        [InverseProperty("MaMhNavigation")]
        public virtual ICollection<TblChiTietBanHang> TblChiTietBanHang { get; set; }
    }
}
