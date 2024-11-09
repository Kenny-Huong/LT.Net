using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_QLThuVien_110824.DomainClass
{
    [Table("PHIEUMUONSACH")]
    public partial class Phieumuonsach
    {
        public Phieumuonsach()
        {
            Chitietphieumuon = new HashSet<Chitietphieumuon>();
        }

        [Key]
        public int MaPhieuMuon { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayMuon { get; set; }
        public int? MaDocGia { get; set; }

        [ForeignKey(nameof(MaDocGia))]
        [InverseProperty(nameof(Docgia.Phieumuonsach))]
        public virtual Docgia MaDocGiaNavigation { get; set; }
        [InverseProperty("MaPhieuMuonNavigation")]
        public virtual ICollection<Chitietphieumuon> Chitietphieumuon { get; set; }
    }
}
