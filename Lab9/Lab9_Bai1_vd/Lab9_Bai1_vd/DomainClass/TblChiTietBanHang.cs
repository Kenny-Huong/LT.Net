using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab9_Bai1_vd.DomainClass
{
    [Table("tblChiTietBanHang")]
    public partial class TblChiTietBanHang
    {
        [Key]
        [Column("SoHieuHD")]
        public int SoHieuHd { get; set; }
        [Key]
        [Column("MaMH")]
        [StringLength(50)]
        public string MaMh { get; set; }
        public int? SoLuong { get; set; }
        public double? DonGia { get; set; }

       

        [ForeignKey(nameof(MaMh))]
        [InverseProperty(nameof(TblMatHang.TblChiTietBanHang))]
        public virtual TblMatHang MaMhNavigation { get; set; }// nó cũng rỗng --> include
        [ForeignKey(nameof(SoHieuHd))]
        [InverseProperty(nameof(TblBanHang.TblChiTietBanHang))]
        public virtual TblBanHang SoHieuHdNavigation { get; set; }
    }
}
