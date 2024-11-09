using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab9_Bai1_vd.DomainClass
{
    [Table("tblKhachHang")]
    public partial class TblKhachHang
    {
        public TblKhachHang()
        {
            TblBanHang = new HashSet<TblBanHang>();
        }

        [Key]
        [Column("MaKH")]
        [StringLength(50)]
        public string MaKh { get; set; }
        [StringLength(100)]
        public string Hoten { get; set; }
        [StringLength(10)]
        public string Gioitinh { get; set; }
        [StringLength(200)]
        public string Diachi { get; set; }
        [StringLength(15)]
        public string DienThoai { get; set; }

        [InverseProperty("MaKhNavigation")]
        public virtual ICollection<TblBanHang> TblBanHang { get; set; } // nó đang rỗng
    }
}
