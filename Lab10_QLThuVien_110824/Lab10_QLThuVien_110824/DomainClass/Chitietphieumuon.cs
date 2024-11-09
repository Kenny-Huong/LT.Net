using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_QLThuVien_110824.DomainClass
{
    [Table("CHITIETPHIEUMUON")]
    public partial class Chitietphieumuon
    {
        [Key]
        public int MaSach { get; set; }
        [Key]
        public int MaPhieuMuon { get; set; }

        [ForeignKey(nameof(MaPhieuMuon))]
        [InverseProperty(nameof(Phieumuonsach.Chitietphieumuon))]
        public virtual Phieumuonsach MaPhieuMuonNavigation { get; set; }
        [ForeignKey(nameof(MaSach))]
        [InverseProperty(nameof(Sach.Chitietphieumuon))]
        public virtual Sach MaSachNavigation { get; set; }
    }
}
